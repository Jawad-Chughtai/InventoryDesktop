using InventoryDesktop.Applications.Companies;
using InventoryDesktop.Applications.Distributors;
using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using Serilog;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class ItemSetupForm : Form
    {
        private readonly ICompanyService _companyService;
        private readonly IDistributorService _distributorService;

        public ItemSetupForm(
            ICompanyService companyService,
            IDistributorService distributorService)
        {
            _companyService = companyService;
            _distributorService = distributorService;
            InitializeComponent();
        }

        private async void ItemSetupForm_Load(object sender, EventArgs e)
        {
            await SetupCompany();
            await SetupDistributor();
        }

        public async Task SetupCompany()
        {
            var data = await _companyService.GetListAsync();

            companyDatagrid.DataSource = data;

            companyDatagrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            companyDatagrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            companyDatagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            companyDatagrid.Columns[0].MinimumWidth = 10;
            companyDatagrid.CurrentCell = null;
        }

        public async Task SetupDistributor()
        {
            var data = await _distributorService.GetListAsync();

            distributorDatagrid.DataSource = data;

            distributorDatagrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            distributorDatagrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            distributorDatagrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            distributorDatagrid.Columns[0].MinimumWidth = 10;
            distributorDatagrid.CurrentCell = null;
        }

        private async void CompanySaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                companyNameErrorLabel.Visible = false;
                if (string.IsNullOrWhiteSpace(companyNameTextbox.Text))
                {
                    companyNameErrorLabel.Visible = true;
                    return;
                }

                Company company = new()
                {
                    Name = companyNameTextbox.Text,
                };

                await _companyService.CreateAsync(company);
                companyNameTextbox.Text = null;
                await SetupCompany();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.Error(ex.ToString());
            }
        }

        private async void DistributorSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                distributorNameErrorLabel.Visible = false;
                if (string.IsNullOrWhiteSpace(distributorNameTextbox.Text))
                {
                    distributorNameErrorLabel.Visible = true;
                    return;
                }

                Distributor distributor = new()
                {
                    Name = distributorNameTextbox.Text,
                    Contact = distributorContactTextbox.Text
                };

                await _distributorService.CreateAsync(distributor);
                distributorContactTextbox.Text = null;
                distributorNameTextbox.Text = null;
                await SetupDistributor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.Error(ex.ToString());
            }
        }

        private async void CompanyDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (companyDatagrid.SelectedCells.Count > 0)
                {
                    await _companyService.DeleteAsync((int)companyDatagrid.SelectedCells[0].Value);
                    await SetupCompany();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.Error(ex.ToString());
            }
        }

        private async void DistributorDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (distributorDatagrid.SelectedCells.Count > 0)
                {
                    await _distributorService.DeleteAsync((int)distributorDatagrid.SelectedCells[0].Value);
                    await SetupDistributor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Log.Error(ex.ToString());
            }
        }
    }
}
