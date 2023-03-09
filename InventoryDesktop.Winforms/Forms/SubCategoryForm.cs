using InventoryDesktop.Applications.SubCategories;
using InventoryDesktop.EntityFramework.Categories;
using InventoryDesktop.EntityFramework.SubCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class SubCategoryForm : Form
    {
        private readonly SubCategoryService _subCategoryService = new();
        private static List<Category> Categories = new();
        public SubCategoryForm()
        {
            InitializeComponent();
        }

        private async void SubCategoryForm_Load(object sender, EventArgs e)
        {
            await GetListAsync();
            await GetCategoryLookupAsync();
        }

        private async Task GetListAsync()
        {
            var data = await _subCategoryService.GetListAsync();
            subcategoryListBox.DataSource = data;
            subcategoryListBox.DisplayMember = "Name";
            subcategoryListBox.ValueMember = "Id";
        }

        private async Task GetCategoryLookupAsync()
        {
            Categories = await _subCategoryService.GetCategoryLookupAsync();
            categoryCombobox.DataSource = new List<Category>(Categories);
            categoryCombobox.DisplayMember = "Name";
            categoryCombobox.ValueMember = "Id";
            categoryCombobox.SelectedItem = null;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(subcategoryNameTextbox.Text))
                {
                    MessageBox.Show("Please enter sub category name.");
                }
                else if (categoryCombobox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category");
                }
                else
                {
                    var subcategory = new SubCategory
                    {
                        Name = subcategoryNameTextbox.Text,
                        CategoryId = (int)categoryCombobox.SelectedValue
                    };
                    await _subCategoryService.CreateAsync(subcategory);
                    await GetListAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (subcategoryListBox.SelectedItem is SubCategory subcategory)
            {
                updateCategoryCombobox.DataSource = new List<Category>(Categories);
                updateCategoryCombobox.DisplayMember = "Name";
                updateCategoryCombobox.ValueMember = "Id";

                updateIdLabel.Text = subcategory.Id.ToString();
                updateNameTextbox.Text = subcategory.Name;
                updateCategoryCombobox.SelectedValue = subcategory.CategoryId;
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if(subcategoryListBox.SelectedValue != null)
            {
                int id = Convert.ToInt32(subcategoryListBox.SelectedValue);
                await _subCategoryService.DeleteAsync(id);
                await GetListAsync();   
            }
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(updateNameTextbox.Text))
                {
                    MessageBox.Show("Please enter sub category name.");
                }
                else if (updateCategoryCombobox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category");
                }
                else
                {
                    var subcategory = new SubCategory
                    {
                        Id = Convert.ToInt32(updateIdLabel.Text),
                        Name = updateNameTextbox.Text,
                        CategoryId = (int)updateCategoryCombobox.SelectedValue
                    };
                    await _subCategoryService.UpdateAsync(subcategory);
                    await GetListAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
