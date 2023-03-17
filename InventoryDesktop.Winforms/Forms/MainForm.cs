using InventoryDesktop.Applications.Users;
using InventoryDesktop.EntityFramework.Users;
using InventoryDesktop.Winforms.Enums;
using InventoryDesktop.Winforms.Forms;
using System.Runtime.CompilerServices;

namespace InventoryDesktop.Winforms
{
    public partial class MainForm : Form
    {
        private readonly UserService _userService = new();
        private Form? _activeForm { get; set; } = null;
        public User? _loggedInUser { get; set; } = null;

        /// <summary>
        /// If super admin is logged in from another user's account then set it to true
        /// </summary>
        public bool IsSuperAdmin { get; set; } = false;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CloseDropDownItems();
            SetUpUser();
            OpenChildForm(new DashboardForm(), PageTitles.Dashboard);
            navbar.Renderer = new CustomToolStripRenderer();
        }

        public void SetUpUser(User? user = null)
        {
            if (user != null)
            {
                _loggedInUser = user;
            }
            superAdminLabel.Visible = false;
            userButton.Text = _loggedInUser.FullName;
            menuUser.Visible = true;

            if (!_loggedInUser.Role.Equals(UserRoles.Admin)
                && !_loggedInUser.Role.Equals(UserRoles.SuperAdmin))
            {
                menuUser.Visible = false;
            }

            if (IsSuperAdmin)
            {
                superAdminLabel.Visible = true;
            }
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
                userPropPanel.Visible = false;
                menuItemType.Visible = true;
                menuItemCategory.Visible = true;
                menuItemSetup.Visible = true;
            }
        }

        private void MenuDashboard_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(new DashboardForm(), PageTitles.Dashboard);
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

        private void MenuItemSetup_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(new ItemSetupForm(), PageTitles.ItemSetup);
        }


        private void CloseDropDownItems()
        {
            userPropPanel.Visible = false;
            menuItemType.Visible = false;
            menuItemCategory.Visible = false;
            menuItemSetup.Visible = false;
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

        private async void SuperAdminLabel_Click(object sender, EventArgs e)
        {
            var user = await _userService.GetSuperAdminAsync(UserRoles.SuperAdmin);
            IsSuperAdmin = false;
            SetUpUser(user);
        }

    }
}
