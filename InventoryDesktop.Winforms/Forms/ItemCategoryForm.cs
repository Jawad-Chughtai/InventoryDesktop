using InventoryDesktop.Applications.ItemCategories;
using InventoryDesktop.EntityFramework.ItemCategories;
using InventoryDesktop.EntityFramework.ItemTypes;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class ItemCategoryForm : Form
    {
        private readonly ItemCategoryService _itemCategoryService = new();
        private static List<ItemType> ItemTypes = new();
        public ItemCategoryForm()
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
            var data = await _itemCategoryService.GetListAsync();
            categoryListbox.DataSource = data;
            categoryListbox.DisplayMember = "Name";
            categoryListbox.ValueMember = "Id";
        }

        private async Task GetCategoryLookupAsync()
        {
            ItemTypes = await _itemCategoryService.GetCategoryLookupAsync();
            typeCombobox.DataSource = new List<ItemType>(ItemTypes);
            typeCombobox.DisplayMember = "Name";
            typeCombobox.ValueMember = "Id";
            typeCombobox.SelectedItem = null;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(subcategoryNameTextbox.Text))
                {
                    MessageBox.Show("Please enter sub category name.");
                }
                else if (typeCombobox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category");
                }
                else
                {
                    var subcategory = new ItemCategory
                    {
                        Name = subcategoryNameTextbox.Text,
                        ItemTypeId = (int)typeCombobox.SelectedValue
                    };
                    await _itemCategoryService.CreateAsync(subcategory);
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
            if (categoryListbox.SelectedItem is ItemCategory subcategory)
            {
                updateTypeListbox.DataSource = new List<ItemType>(ItemTypes);
                updateTypeListbox.DisplayMember = "Name";
                updateTypeListbox.ValueMember = "Id";

                updateIdLabel.Text = subcategory.Id.ToString();
                updateNameTextbox.Text = subcategory.Name;
                updateTypeListbox.SelectedValue = subcategory.ItemTypeId;
            }
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if(categoryListbox.SelectedValue != null)
            {
                int id = Convert.ToInt32(categoryListbox.SelectedValue);
                await _itemCategoryService.DeleteAsync(id);
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
                else if (updateTypeListbox.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category");
                }
                else
                {
                    var category = new ItemCategory
                    {
                        Id = Convert.ToInt32(updateIdLabel.Text),
                        Name = updateNameTextbox.Text,
                        ItemTypeId = (int)updateTypeListbox.SelectedValue
                    };
                    await _itemCategoryService.UpdateAsync(category);
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
