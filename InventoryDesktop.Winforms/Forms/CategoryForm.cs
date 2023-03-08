using InventoryDesktop.Applications.Categories;
using InventoryDesktop.EntityFramework.Categories;
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
    public partial class CategoryForm : Form
    {
        private readonly CategoryService _categoryService = new();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private async void CategoryForm_Load(object sender, EventArgs e)
        {
            await GetListAsync();
        }

        public async Task GetListAsync()
        {
            var categories = await _categoryService.GetListAsync();
            categoryListbox.DataSource = categories;
            categoryListbox.DisplayMember = "Name";
            categoryListbox.ValueMember = "Id";
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(categoryNameTextbox.Text))
            {
                MessageBox.Show("Please enter category name.");
                return;
            }
            var category = new Category()
            {
                Name = categoryNameTextbox.Text.Trim(),
            };
            await _categoryService.CreateAsync(category);
            categoryNameTextbox.Text = "";
            await GetListAsync();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (categoryListbox.SelectedValue != null)
            {
                var id = Convert.ToInt32(categoryListbox.SelectedValue);
                await _categoryService.DeleteAsync(id);
                await GetListAsync();
            }
            else
            {
                MessageBox.Show("Please select a category to delete");
            }
        }
    }
}
