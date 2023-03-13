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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //errorLabel.Visible = false;
            //if (string.IsNullOrWhiteSpace(usernameTextbox.Text) || string.IsNullOrWhiteSpace(passwordTextbox.Text))
            //{
            //    errorLabel.Visible = true;
            //}
            //else if (usernameTextbox.Text == "admin" && passwordTextbox.Text == "admin")
            //{
            //    DialogResult = DialogResult.OK;
            //    Close();
            //}
            //else
            //{
            //    errorLabel.Visible = true;
            //}

            DialogResult = DialogResult.OK;
            Close();
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
