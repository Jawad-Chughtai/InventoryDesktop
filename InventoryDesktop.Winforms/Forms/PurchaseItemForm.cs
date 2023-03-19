using InventoryDesktop.Applications.ItemCategories;
using InventoryDesktop.Applications.PurchaseItems;
using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.PurchaseItems;
using InventoryDesktop.Winforms.Enums;
using System.ComponentModel;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class PurchaseItemForm : Form
    {
        private readonly PurchaseItemAppService _purchaseItemAppService = new();
        private PurchaseItem? _purchaseItem { get; set; } = null;

        public PurchaseItemForm()
        {
            InitializeComponent();
        }

        private void PurchaseItemForm_Shown(object sender, EventArgs e)
        {
            FetchDataBackgroundWorker_DoWork(sender, new DoWorkEventArgs(e));
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidForm())
                {
                    if (_purchaseItem == null)
                    {
                        _purchaseItem = new PurchaseItem
                        {
                            Name = nameTextbox.Text,
                            Description = descriptionTextbox.Text,
                            MinimumQuantity = Convert.ToInt32(quantityTextbox.Text),
                            ItemCategoryId = Convert.ToInt32(categoryCombobox.SelectedValue),
                            CompanyId = ((Company)companyCombobox.SelectedItem)?.Id ?? null,
                            DistributorId = ((Distributor)distributorCombobox.SelectedItem)?.Id ?? null,
                        };

                        await _purchaseItemAppService.CreateAsync(_purchaseItem);
                    }
                    else
                    {
                        var id = _purchaseItem.Id;
                        _purchaseItem = new PurchaseItem
                        {
                            Id = id,
                            Name = nameTextbox.Text,
                            Description = descriptionTextbox.Text,
                            MinimumQuantity = Convert.ToInt32(quantityTextbox.Text),
                            ItemCategoryId = Convert.ToInt32(categoryCombobox.SelectedValue),
                            CompanyId = ((Company)companyCombobox.SelectedItem)?.Id ?? null,
                            DistributorId = ((Distributor)distributorCombobox.SelectedItem)?.Id ?? null,
                        };

                        await _purchaseItemAppService.UpdateAsync(_purchaseItem);
                    }

                    ResetForm();
                    GetListBackgroundWorker_DoWork(new object(), new DoWorkEventArgs(e));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetForm();
            }
        }

        private async void FetchDataBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            await GetItemCategoryLookupAsync();
            await GetCompanyLookupAsync();
            await GetDistributorLookupAsync();
            await GetListAsync();
        }

        private async void GetListBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            await GetListAsync(searchTextbox.Text);
        }

        private async Task GetListAsync(string? searchText = null)
        {
            var data = await _purchaseItemAppService.GetListAsync(searchText: searchText, includeDetails: true);
            datagrid.DataSource = data;
            InitDataGridView();
        }

        private void InitDataGridView()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns.Clear();

            datagrid.Columns.Add("id", "Id");
            datagrid.Columns.Add("code", "Code");
            datagrid.Columns.Add("name", "Name");
            datagrid.Columns.Add("minimumQuantity", "Min-Qty");
            datagrid.Columns.Add("description", "Description");
            datagrid.Columns.Add("categoryName", "Item Category");
            datagrid.Columns.Add("companyName", "Company");
            datagrid.Columns.Add("distributorName", "Distributor");

            datagrid.Columns["id"].DataPropertyName = "Id";
            datagrid.Columns["code"].DataPropertyName = "Code";
            datagrid.Columns["name"].DataPropertyName = "Name";
            datagrid.Columns["minimumQuantity"].DataPropertyName = "MinimumQuantity";
            datagrid.Columns["description"].DataPropertyName = "Description";
            datagrid.Columns["categoryName"].DataPropertyName = "ItemCategoryName";
            datagrid.Columns["companyName"].DataPropertyName = "CompanyName";
            datagrid.Columns["distributorName"].DataPropertyName = "DistributorName";

            datagrid.Columns.Add("itemCategoryId", "");
            datagrid.Columns.Add("companyId", "");
            datagrid.Columns.Add("distributorId", "");
            datagrid.Columns["itemCategoryId"].DataPropertyName = "ItemCategoryId";
            datagrid.Columns["companyId"].DataPropertyName = "CompanyId";
            datagrid.Columns["distributorId"].DataPropertyName = "DistributorId";
            datagrid.Columns["itemCategoryId"].Visible = false;
            datagrid.Columns["companyId"].Visible = false;
            datagrid.Columns["distributorId"].Visible = false;

            datagrid.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            datagrid.Columns["minimumQuantity"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["minimumQuantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["minimumQuantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            datagrid.Columns["id"].MinimumWidth = 10;
            datagrid.Columns["code"].Width = 100;
            datagrid.Columns["minimumQuantity"].Width = 100;
            datagrid.CurrentCell = null;
        }

        private async Task GetItemCategoryLookupAsync()
        {
            var data = await _purchaseItemAppService.GetItemCategoryLookupAsync();
            categoryCombobox.DataSource = data;
            categoryCombobox.DisplayMember = "Name";
            categoryCombobox.ValueMember = "Id";

            categoryCombobox.SelectedItem = null;
        }

        private async Task GetCompanyLookupAsync()
        {
            var data = await _purchaseItemAppService.GetCompanyLookupAsync();
            companyCombobox.DataSource = data;
            companyCombobox.DisplayMember = "Name";
            companyCombobox.ValueMember = "Id";

            companyCombobox.SelectedItem = null;
        }

        private async Task GetDistributorLookupAsync()
        {
            var data = await _purchaseItemAppService.GetDistributorLookupAsync();
            distributorCombobox.DataSource = data;
            distributorCombobox.DisplayMember = "Name";
            distributorCombobox.ValueMember = "Id";

            distributorCombobox.SelectedItem = null;
        }

        private bool IsValidForm()
        {
            ResetErrorLabels();
            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                nameErrorLabel.Visible = true;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(quantityTextbox.Text))
            {
                quantityErrorLabel.Visible = true;
                return false;
            }
            else if (categoryCombobox.SelectedValue == null)
            {
                categoryErrorLabel.Visible = true;
                return false;
            }


            return true;
        }

        private void ResetForm()
        {
            _purchaseItem = null;

            nameTextbox.Text = null;
            quantityTextbox.Text = null;
            categoryCombobox.SelectedItem = null;
            companyCombobox.SelectedItem = null;
            distributorCombobox.SelectedItem = null;
            descriptionTextbox.Text = null;

            saveButton.Text = SaveButtonText.Save;

            ResetErrorLabels();
        }

        private void ResetErrorLabels()
        {
            nameErrorLabel.Visible = false;
            quantityErrorLabel.Visible = false;
            categoryErrorLabel.Visible = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            GetListBackgroundWorker_DoWork(new object(), new DoWorkEventArgs(e));
        }

        private void QuantityTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SearchButton_Click(sender, e);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedCells.Count > 0)
            {
                SetSelectedPurchaseItem();

                nameTextbox.Text = _purchaseItem.Name;
                quantityTextbox.Text = _purchaseItem.MinimumQuantity.ToString();
                categoryCombobox.SelectedValue = _purchaseItem.ItemCategoryId;
                descriptionTextbox.Text = _purchaseItem.Description;

                _ = _purchaseItem.CompanyId == null ? companyCombobox.SelectedItem = null : companyCombobox.SelectedValue = _purchaseItem.CompanyId;
                _ = _purchaseItem.DistributorId == null ? distributorCombobox.SelectedItem = null : distributorCombobox.SelectedValue = _purchaseItem.DistributorId;

                saveButton.Text = SaveButtonText.Update;
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (datagrid.SelectedCells.Count > 0)
            {
                if (datagrid.SelectedCells.Count > 0)
                {
                    SetSelectedPurchaseItem();
                    if (MessageBox.Show($"Are you sure you want to delete {_purchaseItem.Name}", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        await _purchaseItemAppService.DeleteAsync(_purchaseItem.Id);
                        GetListBackgroundWorker_DoWork(sender, new DoWorkEventArgs(e));
                        _purchaseItem = null;
                    }
                    else
                    {
                        _purchaseItem = null;
                    }
                }
            }
        }

        private void SetSelectedPurchaseItem()
        {
            DataGridViewRow selectedRow = datagrid.SelectedCells[0].OwningRow;
            datagrid.CurrentCell = null;

            _purchaseItem = new PurchaseItem
            {
                Id = (int)selectedRow.Cells["id"].Value,
                Name = selectedRow.Cells["name"].Value.ToString(),
                Description = selectedRow.Cells["description"].Value.ToString(),
                Code = selectedRow.Cells["code"].Value.ToString(),
                ItemCategoryId = (int)selectedRow.Cells["itemCategoryId"].Value,
                CompanyId = (int?)selectedRow.Cells["companyId"].Value,
                DistributorId = (int?)selectedRow.Cells["distributorId"].Value,
                MinimumQuantity = (int)selectedRow.Cells["minimumQuantity"].Value
            };
        }

        private void ClearDistributor_Click(object sender, EventArgs e)
        {
            distributorCombobox.SelectedItem = null;
        }

        private void ClearCompany_Click(object sender, EventArgs e)
        {
            companyCombobox.SelectedItem = null;
        }
    }
}
