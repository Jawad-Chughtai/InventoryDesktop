using InventoryDesktop.Applications.PurchaseItems;
using InventoryDesktop.Applications.Purchases;
using InventoryDesktop.EntityFramework.PurchaseItems;
using InventoryDesktop.EntityFramework.Purchases;
using System.ComponentModel;
using System.Windows.Forms;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class PurchaseForm : Form
    {
        private readonly PurchaseService _purchaseService = new();
        private bool IsLoading = true;
        private Purchase? _purchase = null;

        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            _purchase = null;
            ResetErrorLabels();

            totalQuantityLabel.Text = "0";
            saleUnitPriceLabel.Text = "0";
            purchaseUnitPriceLabel.Text = "0";

            itemCombobox.SelectedItem = null;
            batchTextbox.Text = null;
            expiryDate.Value = DateTime.Now;
            packetQuantityTextbox.Text = null;
            perPacketQuantityTextbox.Text = "1";
            purchasePacketPriceTextbox.Text = null;
            salePacketPriceTextbox.Text = null;
        }

        private void ResetErrorLabels()
        {
            itemErrorLabel.Visible = false;
            batchErrorLabel.Visible = false;
            expiryErrorLabel.Visible = false;
            packetQuantityErrorLabel.Visible = false;
            purchasePacketPriceErrorLabel.Visible = false;
            perPacketQuantityErrorLabel.Visible = false;
            salePacketPriceErrorLabel.Visible = false;
        }


        #region Event Handling

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ValidateInteger(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ValidateDouble(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Validate if input is other than digit, control and only one '.'
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || textBox.Text.Contains('.')))
            {
                e.Handled = true;
            }
        }


        #endregion

        private void CalculateValues(object sender, EventArgs e)
        {
            try
            {
                _ = double.TryParse(packetQuantityTextbox.Text, out double packetQuantity);
                _ = double.TryParse(perPacketQuantityTextbox.Text, out double perPacketQuantity);

                _ = double.TryParse(purchasePacketPriceTextbox.Text, out double purchasePacketPrice);
                _ = double.TryParse(salePacketPriceTextbox.Text, out double salePacketPrice);

                double totalQuantity = packetQuantity * perPacketQuantity;
                double purchaseUnitPrice = purchasePacketPrice / perPacketQuantity;
                double saleUnitPrice = salePacketPrice / perPacketQuantity;
                double purchaseTotal = totalQuantity * purchaseUnitPrice;

                totalQuantityLabel.Text = totalQuantity.ToString("N0");
                purchaseUnitPriceLabel.Text = purchaseUnitPrice.ToString("N2");
                saleUnitPriceLabel.Text = saleUnitPrice.ToString("N2");
                purchaseTotalLabel.Text = purchaseTotal.ToString("N2");
            }
            catch
            {
                return;
            }
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (!IsValidForm())
                {
                    return;
                }

                _purchase = new Purchase
                {
                    PurchaseItemId = (int)itemCombobox.SelectedValue,
                    Batch = batchTextbox.Text,
                    PerPacketQuantity = Convert.ToInt32(perPacketQuantityTextbox.Text.Replace(",", "")),
                    PurchasePacketQuantity = Convert.ToInt32(packetQuantityTextbox.Text.Replace(",", "")),
                    PurchasePacketPrice = Convert.ToDouble(purchasePacketPriceTextbox.Text.Replace(",", "")),
                    PurchaseQuantity = Convert.ToInt32(totalQuantityLabel.Text.Replace(",", "")),
                    PurchaseUnitPrice = Convert.ToDouble(purchaseUnitPriceLabel.Text.Replace(",", "")),
                    SalePacketPrice = Convert.ToDouble(salePacketPriceTextbox.Text.Replace(",", "")),
                    SaleUnitPrice = Convert.ToDouble(saleUnitPriceLabel.Text.Replace(",", "")),
                    Expiry = expiryDate.Checked ? expiryDate.Value : null
                };

                await _purchaseService.CreateAsync(_purchase);
                FetchDataBackgroundWorker_DoWork(sender, new DoWorkEventArgs(e));
                ResetForm();
            }

            catch (Exception ex)
            {
                _purchase = null;
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValidForm()
        {
            ResetErrorLabels();

            if (itemCombobox.SelectedItem == null)
            {
                itemErrorLabel.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(batchTextbox.Text))
            {
                batchErrorLabel.Visible = true;
                return false;
            }

            if (expiryDate.Checked && expiryDate.Value <= DateTime.Now)
            {
                expiryErrorLabel.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(packetQuantityTextbox.Text))
            {
                packetQuantityErrorLabel.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(perPacketQuantityTextbox.Text))
            {
                perPacketQuantityErrorLabel.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(purchasePacketPriceTextbox.Text))
            {
                purchasePacketPriceErrorLabel.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(salePacketPriceTextbox.Text))
            {
                salePacketPriceErrorLabel.Visible = true;
                return false;
            }

            return true;
        }

        private async void FetchDataBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (IsLoading)
            {
                await GetPurchaseItemsAsync();
            }
            await GetListAsync(searchTextbox.Text, (int?)itemFilter.SelectedValue);
            IsLoading = false;
        }

        private async Task GetPurchaseItemsAsync()
        {
            var items = await _purchaseService.GetPurchaseItemLookupAsync();

            itemCombobox.DataSource = new List<PurchaseItemLookupDto>(items);
            itemCombobox.DisplayMember = "Name";
            itemCombobox.ValueMember = "Id";
            itemCombobox.SelectedItem = null;

            itemFilter.DataSource = new List<PurchaseItemLookupDto>(items);
            itemFilter.DisplayMember = "Name";
            itemFilter.ValueMember = "Id";
            itemFilter.SelectedItem = null;
        }

        private async Task GetListAsync(string? filter = null, int? purchaseItemId = null)
        {
            try
            {
                var items = await _purchaseService.GetListAsync(filter, purchaseItemId);
                datagrid.DataSource = items;
                InitDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InitDataGridView()
        {
            datagrid.AutoGenerateColumns = false;
            datagrid.Columns.Clear();

            datagrid.Columns.Add("id", "Id");
            datagrid.Columns.Add("item", "Purchase Item");
            datagrid.Columns.Add("batch", "Batch");
            datagrid.Columns.Add("barcode", "Barcode");
            datagrid.Columns.Add("purchasePacketQuantity", "Purchase Packet Qty");
            datagrid.Columns.Add("perPacketQuantity", "Per Packet Qty");
            datagrid.Columns.Add("purchasePacketPrice", "Purchase Price");
            datagrid.Columns.Add("purchaseQuantity", "Total Qty");
            datagrid.Columns.Add("purchaseUnitPrice", "Purchase Unit Price");
            datagrid.Columns.Add("purchaseTotal", "Purchase Total");
            datagrid.Columns.Add("salePacketPrice", "Packet Sale");
            datagrid.Columns.Add("saleUnitPrice", "Unit Sale Price");
            datagrid.Columns.Add("expiry", "Expiry");
            datagrid.Columns.Add("creationTime", "Purchase Date");

            datagrid.Columns["id"].DataPropertyName = "Id";
            datagrid.Columns["item"].DataPropertyName = "PurchaseItemDescription";
            datagrid.Columns["batch"].DataPropertyName = "Batch";
            datagrid.Columns["barcode"].DataPropertyName = "Barcode";
            datagrid.Columns["purchasePacketQuantity"].DataPropertyName = "PurchasePacketQuantity";
            datagrid.Columns["perPacketQuantity"].DataPropertyName = "PerPacketQuantity";
            datagrid.Columns["purchasePacketPrice"].DataPropertyName = "PurchasePacketPrice";
            datagrid.Columns["purchaseQuantity"].DataPropertyName = "PurchaseQuantity";
            datagrid.Columns["purchaseUnitPrice"].DataPropertyName = "PurchaseUnitPrice";
            datagrid.Columns["purchaseTotal"].DataPropertyName = "PurchaseTotal";
            datagrid.Columns["salePacketPrice"].DataPropertyName = "SalePacketPrice";
            datagrid.Columns["saleUnitPrice"].DataPropertyName = "SaleUnitPrice";
            datagrid.Columns["expiry"].DataPropertyName = "Expiry";
            datagrid.Columns["creationTime"].DataPropertyName = "CreationTimeString";

            datagrid.Columns["purchasePacketQuantity"].DefaultCellStyle.Format = "N0";
            datagrid.Columns["perPacketQuantity"].DefaultCellStyle.Format = "N0";
            datagrid.Columns["purchasePacketPrice"].DefaultCellStyle.Format = "N2";
            datagrid.Columns["purchaseQuantity"].DefaultCellStyle.Format = "N0";
            datagrid.Columns["purchaseUnitPrice"].DefaultCellStyle.Format = "N2";
            datagrid.Columns["purchaseTotal"].DefaultCellStyle.Format = "N2";
            datagrid.Columns["salePacketPrice"].DefaultCellStyle.Format = "N2";
            datagrid.Columns["saleUnitPrice"].DefaultCellStyle.Format = "N2";
            datagrid.Columns["expiry"].DefaultCellStyle.Format = "dd/MM/yyyy";


            datagrid.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagrid.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            datagrid.Columns["id"].MinimumWidth = 10;
            datagrid.CurrentCell = null;

            foreach (DataGridViewColumn col in datagrid.Columns)
            {
                col.MinimumWidth = 180;
            }
        }

        private void PurchaseForm_Shown(object sender, EventArgs e)
        {
            FetchDataBackgroundWorker_DoWork(sender, new DoWorkEventArgs(e));
        }

        private void ClearItemFilter_Click(object sender, EventArgs e)
        {
            itemFilter.SelectedItem = null;
            FetchDataBackgroundWorker_DoWork(sender, new DoWorkEventArgs(e));
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            FetchDataBackgroundWorker_DoWork(sender, new DoWorkEventArgs(e));
        }

        private void SearchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                FetchDataBackgroundWorker_DoWork(sender, new DoWorkEventArgs(e));
            }
        }

        private void ItemFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsLoading)
            {
                FetchDataBackgroundWorker_DoWork(sender, new DoWorkEventArgs(e));
            }
        }
    }
}
