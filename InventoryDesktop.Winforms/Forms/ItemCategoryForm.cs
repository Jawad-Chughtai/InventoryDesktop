using InventoryDesktop.Applications.ItemCategories;
using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.ItemTypes;
using InventoryDesktop.Winforms.Enums;
using InventoryDesktop.Winforms.Models;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class ItemCategoryForm : Form
    {
        private readonly IItemCategoryService _itemCategoryService;

        private ItemCategory? _itemCategory = null;
        bool isLoading = true;

        public ItemCategoryForm(
            IItemCategoryService itemCategoryService)
        {
            _itemCategoryService = itemCategoryService;
            InitializeComponent();
        }

        private async void ItemCategoryForm_Load(object sender, EventArgs e)
        {
            nameTextbox.Select();
            await GetListAsync();
            await GetItemTypeLookup();
        }

        private void InitDataGridView()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns.Clear();

            datagrid.Columns.Add("id", "Id");
            datagrid.Columns.Add("name", "Name");
            datagrid.Columns.Add("code", "Code");
            datagrid.Columns.Add("typename", "Item Type");
            datagrid.Columns.Add("typeid", "Type Id");

            datagrid.Columns["id"].DataPropertyName = "Id";
            datagrid.Columns["name"].DataPropertyName = "Name";
            datagrid.Columns["code"].DataPropertyName = "Code";
            datagrid.Columns["typename"].DataPropertyName = "TypeName";
            datagrid.Columns["typeid"].DataPropertyName = "TypeId";

            datagrid.Columns["typeid"].Visible = false;
            datagrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns[0].Width = 100;
            datagrid.CurrentCell = null;
        }

        /* CRUD Functions */
        #region

        private async Task GetListAsync(string? searchText = null, int? typeId = null)
        {
            var data = await _itemCategoryService.GetListAsync(searchText, typeId);
            datagrid.DataSource = data.ToItemCategoryModel();

            InitDataGridView();
        }

        private async Task GetItemTypeLookup()
        {
            var itemTypes = await _itemCategoryService.GetItemTypeLookup();
            typeCombobox.DataSource = new List<ItemType>(itemTypes);
            typeCombobox.DisplayMember = "Name";
            typeCombobox.ValueMember = "Id";
            typeCombobox.SelectedItem = null;

            itemTypes.Insert(0, new ItemType());
            typeFilter.DataSource = new List<ItemType>(itemTypes);
            typeFilter.DisplayMember = "Name";
            typeFilter.ValueMember = "Id";
            typeFilter.SelectedItem = null;
            isLoading = false;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidSaveForm())
                {
                    if (saveButton.Text == SaveButtonText.Save)
                    {
                        _itemCategory = new ItemCategory
                        {
                            Name = nameTextbox.Text,
                            Code = codeTextbox.Text,
                            ItemTypeId = (int)typeCombobox.SelectedValue
                        };

                        await _itemCategoryService.CreateAsync(_itemCategory);
                    }
                    else
                    {
                        _itemCategory.Name = nameTextbox.Text;
                        _itemCategory.Code = codeTextbox.Text;
                        _itemCategory.ItemTypeId = (int)typeCombobox.SelectedValue;

                        await _itemCategoryService.UpdateAsync(_itemCategory);
                    }

                    ResetForm();

                    var typeId = (int?)typeFilter.SelectedValue == 0 ? null : (int?)typeFilter.SelectedValue;
                    await GetListAsync(searchTextbox.Text, typeId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedCells.Count > 0)
            {
                SetSelectedItemCategory();
                nameTextbox.Text = _itemCategory.Name;
                codeTextbox.Text = _itemCategory.Code;
                typeCombobox.SelectedValue = _itemCategory.ItemTypeId;

                saveButton.Text = SaveButtonText.Update;
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagrid.SelectedCells.Count > 0)
                {
                    SetSelectedItemCategory();
                    if (MessageBox.Show($"Are you sure you want to delete {_itemCategory.Name}", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        await _itemCategoryService.DeleteAsync(_itemCategory.Id);
                        await GetListAsync(searchTextbox.Text);
                        _itemCategory = null;
                    }
                    else
                    {
                        _itemCategory = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void ResetForm()
        {
            _itemCategory = null;
            saveButton.Text = SaveButtonText.Save;

            nameTextbox.Text = null;
            codeTextbox.Text = null;
            typeCombobox.SelectedItem = null;
            typeCombobox.Text = null;

            ResetErrorLabels();
        }

        private void ResetErrorLabels()
        {
            nameErrorLabel.Visible = false;
            codeErrorLabel.Visible = false;
            typeErrorLabel.Visible = false;
        }

        private void SetSelectedItemCategory()
        {
            int rowIndex = datagrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = datagrid.Rows[rowIndex];
            datagrid.CurrentCell = null;

            _itemCategory = new ItemCategory
            {
                Id = (int)selectedRow.Cells["Id"].Value,
                Name = selectedRow.Cells["Name"].Value.ToString(),
                Code = selectedRow.Cells["Code"].Value.ToString(),
                ItemTypeId = (int)selectedRow.Cells["TypeId"].Value
            };
        }

        /* Validators Start Here */
        #region Validators

        private bool IsValidSaveForm()
        {
            ResetErrorLabels();

            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                nameErrorLabel.Visible = true;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(codeTextbox.Text))
            {
                codeErrorLabel.Visible = true;
                return false;
            }
            else if (typeCombobox.SelectedValue == null)
            {
                typeErrorLabel.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        /* Event Handling Starts Here */
        #region Event Handling

        private void SaveForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SaveButton_Click(sender, e);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            saveButton.Text = SaveButtonText.Save;
            ResetForm();
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            var typeId = (int?)typeFilter.SelectedValue == 0 ? null : (int?)typeFilter.SelectedValue;
            await GetListAsync(searchTextbox.Text, typeId);
        }

        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                SearchButton_Click(sender, e);
            }
        }

        private async void TypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoading)
            {
                int? typeId = Convert.ToInt32(typeFilter.SelectedValue);
                if (typeId == 0)
                {
                    typeId = null;
                }
                await GetListAsync(searchTextbox.Text, typeId);
            }
        }

        #endregion

    }
}
