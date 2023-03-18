using InventoryDesktop.Applications.PurchaseItems;
using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using InventoryDesktop.EntityFramework.PurchaseItems;
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
                _purchaseItem = null;
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
            datagrid.Columns.Add("description", "Description");
            datagrid.Columns.Add("categoryName", "Item Category");
            datagrid.Columns.Add("companyName", "Company");
            datagrid.Columns.Add("distributorName", "Distributor");

            datagrid.Columns["id"].DataPropertyName = "Id";
            datagrid.Columns["code"].DataPropertyName = "Code";
            datagrid.Columns["name"].DataPropertyName = "Name";
            datagrid.Columns["description"].DataPropertyName = "Description";
            datagrid.Columns["categoryName"].DataPropertyName = "ItemCategoryName";
            datagrid.Columns["companyName"].DataPropertyName = "CompanyName";
            datagrid.Columns["distributorName"].DataPropertyName = "DistributorName";

            datagrid.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datagrid.Columns["id"].MinimumWidth = 10;
            datagrid.Columns["code"].Width = 100;
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
    }
}
