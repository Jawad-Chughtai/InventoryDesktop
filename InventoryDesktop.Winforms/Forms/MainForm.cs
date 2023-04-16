using Autofac;
using InventoryDesktop.Applications.Users;
using InventoryDesktop.EntityFramework.Users;
using InventoryDesktop.Winforms.Enums;
using InventoryDesktop.Winforms.Forms;
using Serilog;

namespace InventoryDesktop.Winforms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// If super admin is logged in from another user's account then set it to true
        /// </summary>
        public bool IsSuperAdmin { get; set; } = false;
        public User? LoggedInUser { get; set; } = null;

        private readonly IUserService _userService;
        private readonly IContainer _container;

        private Form? _activeForm = null;

        public MainForm(
            User? loggedInUser,
            IContainer container,
            IUserService userService)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
            _container = container;
            _userService = userService;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CloseDropDownItems();
            SetUpUser();
            OpenChildForm(_container.Resolve<DashboardForm>(), PageTitles.Dashboard);
            navbar.Renderer = _container.Resolve<CustomToolStripRenderer>();
        }

        public void SetUpUser(User? user = null)
        {
            if (user != null)
            {
                LoggedInUser = user;
            }
            superAdminLabel.Visible = false;
            userButton.Text = LoggedInUser?.FullName;
            menuUser.Visible = true;

            var userRole = LoggedInUser?.Role;

            if (userRole != null
                && !userRole.Equals(UserRoles.Admin)
                && !userRole.Equals(UserRoles.SuperAdmin))
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
                menuPurchaseItem.Visible = true;
                menuItemType.Visible = true;
                menuItemCategory.Visible = true;
                menuItemSetup.Visible = true;
            }
        }

        private void MenuDashboard_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(_container.Resolve<DashboardForm>(), PageTitles.Dashboard);
        }

        private void MenuItemType_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(_container.Resolve<ItemTypeForm>(), PageTitles.ItemType);
        }

        private void MenuItemCategory_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(_container.Resolve<ItemCategoryForm>(), PageTitles.ItemCategory);
        }

        private void MenuUser_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(_container.Resolve<UserForm>(), PageTitles.User);
        }

        private void MenuItemSetup_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(_container.Resolve<ItemSetupForm>(), PageTitles.ItemSetup);
        }

        private void MenuPurchaseItem_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(_container.Resolve<PurchaseItemForm>(), PageTitles.PurchaseItem);
        }

        private void MenuCreatePurchase_Click(object sender, EventArgs e)
        {
            CloseDropDownItems();
            OpenChildForm(_container.Resolve<PurchaseForm>(), PageTitles.Purchase);
        }

        private void CloseDropDownItems()
        {
            userPropPanel.Visible = false;
            menuPurchaseItem.Visible = false;
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.Information("Application Closed.");
            Log.CloseAndFlush();
        }
    }
}
