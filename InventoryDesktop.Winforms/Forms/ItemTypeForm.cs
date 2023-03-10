using InventoryDesktop.Applications.ItemTypes;
using InventoryDesktop.EntityFramework.ItemTypes;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Windows.Forms;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class ItemTypeForm : Form
    {
        private readonly ItemTypeService _itemTypeService = new();
        public ItemTypeForm()
        {
            InitializeComponent();
        }

        private async void CategoryForm_Load(object sender, EventArgs e)
        {
            await GetListAsync();
        }

        public async Task GetListAsync()
        {
            var types = await _itemTypeService.GetListAsync();
            datagrid.DataSource = types;

            CustomizeDataGridView();

        }

        private void CustomizeDataGridView()
        {
            datagrid.BackgroundColor = Color.White;
            datagrid.ForeColor = Color.Black;
            datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            datagrid.RowHeadersVisible = false;
            datagrid.BorderStyle = BorderStyle.None;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
                    var category = new ItemType()
                    {
                        Name = nameTextbox.Text,
                        Code = codeTextbox.Text
                    };
                    await _itemTypeService.CreateAsync(category);
                    nameTextbox.Text = "";
                    codeTextbox.Text = "";
                    await GetListAsync();
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
                Application.Restart();
                //if (typeListbox.SelectedValue != null)
                //{
                //    var id = Convert.ToInt32(typeListbox.SelectedValue);
                //    await _itemTypeService.DeleteAsync(id);
                //    await GetListAsync();
                //}
                //else
                //{
                //    MessageBox.Show("Please select a category to delete");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(updateNameTextbox.Text))
                {
                    MessageBox.Show("Please enter category name.");
                    return;
                }
                var category = new ItemType()
                {
                    Id = Convert.ToInt32(updateIdLabel.Text),
                    Name = updateNameTextbox.Text,
                };
                await _itemTypeService.UpdateAsync(category);
                updateNameTextbox.Text = "";
                await GetListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //if (typeListbox.SelectedItem is ItemType category)
            //{
            //    updateIdLabel.Text = category?.Id.ToString();
            //    updateNameTextbox.Text = category?.Name;
            //}
        }

        /* Validators Start Here */
        #region Validators

        private bool IsValidSaveForm()
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                nameErrorLabel.Visible = true;
                return false;
            }
            else if (string.IsNullOrWhiteSpace(codeTextbox.Text))
            {
                nameErrorLabel.Visible = false;
                codeErrorLabel.Visible = true;
                return false;
            }
            else
            {
                nameErrorLabel.Text = null;
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

        private void Datagrid_Leave(object sender, EventArgs e)
        {
            datagrid.CurrentCell = null;
        }
    }
}
