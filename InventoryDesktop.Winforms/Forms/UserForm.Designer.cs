namespace InventoryDesktop.Winforms.Forms
{
    partial class UserForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            datagrid = new DataGridView();
            panel8 = new Panel();
            panel10 = new Panel();
            panel3 = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            roleCombobox = new ComboBox();
            label5 = new Label();
            roleErrorLabel = new Label();
            label4 = new Label();
            passwordTextbox = new TextBox();
            passwordErrorLabel = new Label();
            label3 = new Label();
            usernameTextbox = new TextBox();
            usernameErrorLabel = new Label();
            resetButton = new Button();
            label1 = new Label();
            fnameTextbox = new TextBox();
            saveButton = new Button();
            lnameErrorLabel = new Label();
            fnameErrorLabel = new Label();
            label2 = new Label();
            lnameTextbox = new TextBox();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(75, 637);
            panel5.TabIndex = 22;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1145, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 637);
            panel6.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(75, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1070, 637);
            panel1.TabIndex = 24;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 159);
            panel7.Name = "panel7";
            panel7.Size = new Size(1070, 436);
            panel7.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(datagrid);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 1);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(0, 10, 0, 0);
            panel9.Size = new Size(1070, 435);
            panel9.TabIndex = 1;
            // 
            // datagrid
            // 
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.BackgroundColor = SystemColors.ControlLightLight;
            datagrid.BorderStyle = BorderStyle.None;
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            datagrid.Dock = DockStyle.Fill;
            datagrid.GridColor = SystemColors.ActiveBorder;
            datagrid.Location = new Point(0, 10);
            datagrid.MultiSelect = false;
            datagrid.Name = "datagrid";
            datagrid.ReadOnly = true;
            datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            datagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            datagrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            datagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            datagrid.RowTemplate.Height = 25;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.ShowCellErrors = false;
            datagrid.ShowCellToolTips = false;
            datagrid.ShowEditingIcon = false;
            datagrid.ShowRowErrors = false;
            datagrid.Size = new Size(1070, 425);
            datagrid.TabIndex = 16;
            datagrid.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.ActiveBorder;
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1070, 1);
            panel8.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1070, 10);
            panel10.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(deleteButton);
            panel3.Controls.Add(editButton);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 595);
            panel3.Name = "panel3";
            panel3.Size = new Size(1070, 42);
            panel3.TabIndex = 1;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Right;
            deleteButton.BackColor = Color.Firebrick;
            deleteButton.FlatAppearance.BorderColor = Color.Firebrick;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = SystemColors.ControlLightLight;
            deleteButton.Location = new Point(906, 8);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 26);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Right;
            editButton.BackColor = Color.FromArgb(16, 163, 127);
            editButton.FlatAppearance.BorderColor = Color.FromArgb(16, 163, 127);
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.ForeColor = SystemColors.ControlLightLight;
            editButton.Location = new Point(995, 8);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 26);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 159);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.Controls.Add(roleCombobox);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(roleErrorLabel);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(passwordTextbox);
            panel4.Controls.Add(passwordErrorLabel);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(usernameTextbox);
            panel4.Controls.Add(usernameErrorLabel);
            panel4.Controls.Add(resetButton);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(fnameTextbox);
            panel4.Controls.Add(saveButton);
            panel4.Controls.Add(lnameErrorLabel);
            panel4.Controls.Add(fnameErrorLabel);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(lnameTextbox);
            panel4.Location = new Point(0, 18);
            panel4.Name = "panel4";
            panel4.Size = new Size(912, 135);
            panel4.TabIndex = 16;
            // 
            // roleCombobox
            // 
            roleCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            roleCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            roleCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleCombobox.FormattingEnabled = true;
            roleCombobox.Location = new Point(495, 89);
            roleCombobox.Name = "roleCombobox";
            roleCombobox.Size = new Size(226, 25);
            roleCombobox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(493, 71);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 22;
            label5.Text = "Role *";
            // 
            // roleErrorLabel
            // 
            roleErrorLabel.AutoSize = true;
            roleErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            roleErrorLabel.ForeColor = Color.Firebrick;
            roleErrorLabel.Location = new Point(495, 119);
            roleErrorLabel.Name = "roleErrorLabel";
            roleErrorLabel.Size = new Size(88, 13);
            roleErrorLabel.TabIndex = 21;
            roleErrorLabel.Text = "Role is required";
            roleErrorLabel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(247, 71);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 19;
            label4.Text = "Password *";
            // 
            // passwordTextbox
            // 
            passwordTextbox.BackColor = SystemColors.Window;
            passwordTextbox.ForeColor = SystemColors.ControlText;
            passwordTextbox.Location = new Point(249, 89);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(223, 25);
            passwordTextbox.TabIndex = 4;
            // 
            // passwordErrorLabel
            // 
            passwordErrorLabel.AutoSize = true;
            passwordErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            passwordErrorLabel.ForeColor = Color.Firebrick;
            passwordErrorLabel.Location = new Point(249, 119);
            passwordErrorLabel.Name = "passwordErrorLabel";
            passwordErrorLabel.Size = new Size(114, 13);
            passwordErrorLabel.TabIndex = 18;
            passwordErrorLabel.Text = "Password is required";
            passwordErrorLabel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(0, 71);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 16;
            label3.Text = "Username *";
            // 
            // usernameTextbox
            // 
            usernameTextbox.BackColor = SystemColors.Window;
            usernameTextbox.ForeColor = SystemColors.ControlText;
            usernameTextbox.Location = new Point(2, 89);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(223, 25);
            usernameTextbox.TabIndex = 3;
            // 
            // usernameErrorLabel
            // 
            usernameErrorLabel.AutoSize = true;
            usernameErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            usernameErrorLabel.ForeColor = Color.Firebrick;
            usernameErrorLabel.Location = new Point(2, 119);
            usernameErrorLabel.Name = "usernameErrorLabel";
            usernameErrorLabel.Size = new Size(116, 13);
            usernameErrorLabel.TabIndex = 15;
            usernameErrorLabel.Text = "Username is required";
            usernameErrorLabel.Visible = false;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Firebrick;
            resetButton.FlatAppearance.BorderColor = Color.Firebrick;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = SystemColors.ControlLightLight;
            resetButton.Location = new Point(754, 89);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 26);
            resetButton.TabIndex = 7;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += ResetButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 9;
            label1.Text = "First Name *";
            // 
            // fnameTextbox
            // 
            fnameTextbox.BackColor = SystemColors.Window;
            fnameTextbox.ForeColor = SystemColors.ControlText;
            fnameTextbox.Location = new Point(2, 20);
            fnameTextbox.Name = "fnameTextbox";
            fnameTextbox.Size = new Size(223, 25);
            fnameTextbox.TabIndex = 1;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(16, 163, 127);
            saveButton.FlatAppearance.BorderColor = Color.FromArgb(16, 163, 127);
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ControlLightLight;
            saveButton.Location = new Point(835, 89);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 26);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // lnameErrorLabel
            // 
            lnameErrorLabel.AutoSize = true;
            lnameErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lnameErrorLabel.ForeColor = Color.Firebrick;
            lnameErrorLabel.Location = new Point(251, 50);
            lnameErrorLabel.Name = "lnameErrorLabel";
            lnameErrorLabel.Size = new Size(116, 13);
            lnameErrorLabel.TabIndex = 12;
            lnameErrorLabel.Text = "Last name is required";
            lnameErrorLabel.Visible = false;
            // 
            // fnameErrorLabel
            // 
            fnameErrorLabel.AutoSize = true;
            fnameErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            fnameErrorLabel.ForeColor = Color.Firebrick;
            fnameErrorLabel.Location = new Point(2, 50);
            fnameErrorLabel.Name = "fnameErrorLabel";
            fnameErrorLabel.Size = new Size(118, 13);
            fnameErrorLabel.TabIndex = 8;
            fnameErrorLabel.Text = "First name is required";
            fnameErrorLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(249, 2);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 11;
            label2.Text = "Last Name *";
            // 
            // lnameTextbox
            // 
            lnameTextbox.BackColor = SystemColors.Window;
            lnameTextbox.ForeColor = SystemColors.ControlText;
            lnameTextbox.Location = new Point(251, 20);
            lnameTextbox.Name = "lnameTextbox";
            lnameTextbox.Size = new Size(223, 25);
            lnameTextbox.TabIndex = 2;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 637);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "User";
            Load += UserForm_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel6;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button deleteButton;
        private Button editButton;
        private Panel panel4;
        private Button resetButton;
        private Label label1;
        private TextBox fnameTextbox;
        private Button saveButton;
        private Label lnameErrorLabel;
        private Label fnameErrorLabel;
        private Label label2;
        private TextBox lnameTextbox;
        private Label label5;
        private Label roleErrorLabel;
        private Label label4;
        private TextBox passwordTextbox;
        private Label passwordErrorLabel;
        private Label label3;
        private TextBox usernameTextbox;
        private Label usernameErrorLabel;
        private ComboBox roleCombobox;
        private Panel panel7;
        private Panel panel9;
        private Panel panel8;
        private DataGridView datagrid;
        private Panel panel10;
    }
}