using InventoryDesktop.Applications.Users;
using InventoryDesktop.EntityFramework.Users;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Eventing.Reader;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        public User? LoggedInUser { get; private set; } = null;

        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            loginButton.Enabled = false;
            errorLabel.Visible = false;

            var username = usernameTextbox.Text;
            var password = passwordTextbox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorLabel.Visible = true;
                loginButton.Enabled = true;
                return;
            }

            try
            {
                LoggedInUser = await _userService.LoginAsync(username, password);

                if (LoggedInUser != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    errorLabel.Visible = true;
                    loginButton.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                errorLabel.Visible = true;
                loginButton.Enabled = true;
                MessageBox.Show("An error occured during login. Contact Administrator", "Login Error");
                throw ex;
            }
        }

        private void TextBoxKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                LoginButton_Click(sender, e);
            }
        }
    }
}
