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
            label1 = new Label();
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
            panel1.Location = new Point(98, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 181);
            panel1.TabIndex = 0;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Firebrick;
            errorLabel.Location = new Point(-1, 115);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(161, 13);
            errorLabel.TabIndex = 0;
            errorLabel.Text = "Invalid username or password";
            errorLabel.Visible = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(-1, 65);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 10;
            passwordLabel.Text = "Password";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(0, 85);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(251, 25);
            passwordTextbox.TabIndex = 2;
            passwordTextbox.KeyDown += TextBoxKeyDownEvent;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(-1, 3);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 8;
            usernameLabel.Text = "Username";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(0, 24);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(251, 25);
            usernameTextbox.TabIndex = 1;
            usernameTextbox.KeyDown += TextBoxKeyDownEvent;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(51, 149);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(149, 30);
            loginButton.TabIndex = 3;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(190, 64);
            label1.Name = "label1";
            label1.Size = new Size(66, 30);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 368);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label errorLabel;
        private Label passwordLabel;
        private TextBox passwordTextbox;
        private Label usernameLabel;
        private TextBox usernameTextbox;
        private Button loginButton;
        private Label label1;
    }
}