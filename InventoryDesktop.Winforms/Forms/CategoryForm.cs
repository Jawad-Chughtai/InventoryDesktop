using InventoryDesktop.Applications.Categories;
using InventoryDesktop.EntityFramework.Categories;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!errorProvider.HasErrors)
                {
                    var category = new Category()
                    {
                        Name = categoryNameTextbox.Text,
                    };
                    await _categoryService.CreateAsync(category);
                    categoryNameTextbox.Text = "";
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
                var category = new Category()
                {
                    Id = Convert.ToInt32(updateIdLabel.Text),
                    Name = updateNameTextbox.Text,
                };
                await _categoryService.UpdateAsync(category);
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
            if (categoryListbox.SelectedItem is Category category)
            {
                updateIdLabel.Text = category?.Id.ToString();
                updateNameTextbox.Text = category?.Name;
            }
        }

        /* Validators Start Here */
        #region Validators
        private void CategoryNameTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(categoryNameTextbox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(categoryNameTextbox, "Name is required.");
                categoryNameErrorLabel.Text = "Name is required.";
            }
            else
            {
                errorProvider.SetError(categoryNameTextbox, null);
                categoryNameErrorLabel.Text = null;
            }
        }
        #endregion
    }
}
