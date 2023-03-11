using InventoryDesktop.Applications.ItemTypes;
using InventoryDesktop.EntityFramework.ItemTypes;
using InventoryDesktop.Winforms.Enums;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class ItemTypeForm : Form
    {
        private readonly ItemTypeService _itemTypeService = new();
        private ItemType? _itemType = null;

        public ItemTypeForm()
        {
            InitializeComponent();
        }

        private async void CategoryForm_Load(object sender, EventArgs e)
        {
            await GetListAsync(searchTextbox.Text);
        }

        public async Task GetListAsync(string? searchText = null)
        {
            var types = await _itemTypeService.GetListAsync(searchText);
            datagrid.DataSource = types;

            InitDataGridView();
        }

        private void InitDataGridView()
        {
            datagrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns[0].Width = 100;
            datagrid.CurrentCell = null;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidSaveForm())
                {
                    if (_itemType == null)
                    {
                        _itemType = new ItemType()
                        {
                            Name = nameTextbox.Text,
                            Code = codeTextbox.Text
                        };
                        await _itemTypeService.CreateAsync(_itemType);
                    }
                    else
                    {
                        _itemType.Name = nameTextbox.Text;
                        _itemType.Code = codeTextbox.Text;
                        await _itemTypeService.UpdateAsync(_itemType);
                    }

                    ResetForm();
                    await GetListAsync(searchTextbox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagrid.SelectedCells.Count > 0)
                {
                    SetSelectedItemType();
                    if (MessageBox.Show($"Are you sure you want to delete {_itemType.Name}", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        await _itemTypeService.DeleteAsync(_itemType.Id);
                        await GetListAsync(searchTextbox.Text);
                    }
                    else
                    {
                        _itemType = null;
                    }
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
                SetSelectedItemType();
                nameTextbox.Text = _itemType.Name;
                codeTextbox.Text = _itemType.Code;

                saveButton.Text = SaveButtonText.Update.ToString();
            }
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
            else
            {
                return true;
            }
        }
        #endregion

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
            saveButton.Text = SaveButtonText.Save.ToString();
            ResetForm();
        }

        private void ResetForm()
        {
            _itemType = null;
            saveButton.Text = SaveButtonText.Save.ToString();

            nameTextbox.Text = null;
            codeTextbox.Text = null;

            ResetErrorLabels();
        }

        private void ResetErrorLabels()
        {
            nameErrorLabel.Visible = false;
            codeErrorLabel.Visible = false;
        }

        private void SetSelectedItemType()
        {
            int rowIndex = datagrid.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = datagrid.Rows[rowIndex];
            datagrid.CurrentCell = null;

            _itemType = new ItemType
            {
                Id = (int)selectedRow.Cells["Id"].Value,
                Name = selectedRow.Cells["Name"].Value.ToString(),
                Code = selectedRow.Cells["Code"].Value.ToString()
            };
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await GetListAsync(searchTextbox.Text);
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
    }

}
