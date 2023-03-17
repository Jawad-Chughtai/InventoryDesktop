using InventoryDesktop.Applications.Companies;
using InventoryDesktop.Applications.Distributors;
using InventoryDesktop.EntityFramework.Companies;
using InventoryDesktop.EntityFramework.Distributors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class ItemSetupForm : Form
    {
        private readonly CompanyAppService _companyAppService = new();
        private readonly DistributorAppService _distributorAppService = new();

        public ItemSetupForm()
        {
            InitializeComponent();
        }

        private async void ItemSetupForm_Load(object sender, EventArgs e)
        {
            await SetupCompany();
            await SetupDistributor();
        }

        public async Task SetupCompany()
        {
            var data = await _companyAppService.GetListAsync();
            companyListbox.DataSource = data;
            companyListbox.DisplayMember = "Name";
            companyListbox.ValueMember = "Id";

            companyListbox.SelectedItem = null;
        }

        public async Task SetupDistributor()
        {
            var data = await _distributorAppService.GetListAsync();
            distributorListbox.DataSource = data;
            distributorListbox.DisplayMember = "Name Contact";
            distributorListbox.ValueMember = "Id";

            distributorListbox.SelectedItem = null;
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

                Company company = new Company
                {
                    Name = companyNameTextbox.Text,
                };

                await _companyAppService.CreateAsync(company);
                companyNameTextbox.Text = null;
                await SetupCompany();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                Distributor distributor = new Distributor
                {
                    Name = distributorNameTextbox.Text,
                    Contact = distributorContactTextbox.Text
                };

                await _distributorAppService.CreateAsync(distributor);
                distributorContactTextbox.Text = null;
                distributorNameTextbox.Text = null;
                await SetupDistributor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void CompanyDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (companyListbox.SelectedItem != null)
                {
                    await _companyAppService.DeleteAsync((int)companyListbox.SelectedValue);
                    await SetupCompany();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void DistributorDeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (distributorListbox.SelectedItem != null)
                {
                    await _distributorAppService.DeleteAsync((int)distributorListbox.SelectedValue);
                    await SetupDistributor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
