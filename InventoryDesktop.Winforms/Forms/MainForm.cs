using InventoryDesktop.EntityFramework.Users;
using InventoryDesktop.Winforms.Enums;
using InventoryDesktop.Winforms.Forms;

namespace InventoryDesktop.Winforms
{
    public partial class MainForm : Form
    {
        private Form? _activeForm { get; set; } = null;
        public User? _loggedInUser { get; set; } = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CloseDropDownItems();
            SetUpUser();
            OpenChildForm(new DashboardForm(), PageTitles.Dashboard);
        }

        private void SetUpUser()
        {
            userButton.Text = _loggedInUser.FullName;
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

        private void UserButton_MouseLeave(object sender, EventArgs e)
        {
            focusButton.Select();
        }

        private void UserButton_Click(object sender, EventArgs e)
        {
            if (userPropPanel.Visible == true)
            {
                userPropPanel.Visible = false;
            }
            else userPropPanel.Visible = true;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
