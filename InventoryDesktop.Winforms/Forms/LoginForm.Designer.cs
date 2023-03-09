namespace InventoryDesktop.Winforms.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            errorLabel = new Label();
            passwordLabel = new Label();
            passwordTextbox = new TextBox();
            usernameLabel = new Label();
            usernameTextbox = new TextBox();
            loginButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(errorLabel);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(passwordTextbox);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(usernameTextbox);
            panel1.Controls.Add(loginButton);
            panel1.Location = new Point(259, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 160);
            panel1.TabIndex = 0;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Firebrick;
            errorLabel.Location = new Point(-1, 101);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(164, 15);
            errorLabel.TabIndex = 0;
            errorLabel.Text = "Invalid username or password";
            errorLabel.Visible = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(-1, 57);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(0, 75);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(251, 23);
            passwordTextbox.TabIndex = 2;
            passwordTextbox.KeyDown += TextBoxKeyDownEvent;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(-1, 3);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(0, 21);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(251, 23);
            usernameTextbox.TabIndex = 1;
            usernameTextbox.KeyDown += TextBoxKeyDownEvent;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(51, 131);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(149, 26);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label errorLabel;
        private Label passwordLabel;
        private TextBox passwordTextbox;
        private Label usernameLabel;
        private TextBox usernameTextbox;
        private Button loginButton;
    }
}