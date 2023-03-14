using InventoryDesktop.Applications.Users;
using InventoryDesktop.EntityFramework.Users;

namespace InventoryDesktop.Winforms.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService = new();
        public User? LoggedInUser { get; private set; } = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;

            var username = usernameTextbox.Text;
            var password = passwordTextbox.Text;
            Thread.Sleep(50);
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorLabel.Visible = true;
            }
            else
            {
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
                    }
                }
                catch
                {
                    errorLabel.Visible = true;
                }
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
