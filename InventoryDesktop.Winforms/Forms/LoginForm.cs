using InventoryDesktop.Applications.Users;
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
    public partial class LoginForm : Form
    {
        private readonly UserService _userService = new();

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextbox.Text;
            var password = passwordTextbox.Text;
            
            errorLabel.Visible = false;
            
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorLabel.Visible = true;
            }
            else
            {
                try
                {
                    var result = await _userService.LoginAsync(username, password);

                    if (result == 1)
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
