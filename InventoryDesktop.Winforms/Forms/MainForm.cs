using InventoryDesktop.Winforms.Enums;
using InventoryDesktop.Winforms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryDesktop.Winforms
{
    public partial class MainForm : Form
    {
        private Form? _activeForm { get; set; } = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(new DashboardForm(), PageTitles.Dashboard);
        }

        //method to open child forms inside parent form
        private void OpenChildForm(Form formObj, string title)
        {
            _activeForm?.Close(); // If there is any active form close it.

            pageTitleLabel.Text = title;
            formObj.MdiParent = this;
            formObj.Show();
            formObj.Dock = DockStyle.Fill;
            formObj.FormBorderStyle = FormBorderStyle.None;
            formObj.TopLevel = false;
            _activeForm = formObj;
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            if (menuItemType.Visible == true)
            {
                CloseDropDownItems();
            }
            else
            {
                menuItemType.Visible = true;
                menuItemCategory.Visible = true;
            }
        }

        private void MenuDashboard_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(new DashboardForm(), PageTitles.Dashboard);
        }

        private void CloseDropDownItems()
        {
            menuItemType.Visible = false;
            menuItemCategory.Visible = false;
        }

        private void MenuItemType_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(new ItemTypeForm(), PageTitles.ItemType);
        }

        private void MenuItemCategory_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(new ItemCategoryForm(), PageTitles.ItemCategory);
        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(new UserForm(), PageTitles.User);
        }
    }
}
