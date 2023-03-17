namespace InventoryDesktop.Winforms.Forms
{
    partial class ItemSetupForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel12 = new Panel();
            distributorListbox = new ListBox();
            panel16 = new Panel();
            panel15 = new Panel();
            panel10 = new Panel();
            distributorDeleteButton = new Button();
            panel6 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            distributorNameTextbox = new TextBox();
            distributorSaveButton = new Button();
            distributorNameErrorLabel = new Label();
            label6 = new Label();
            distributorContactTextbox = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            panel11 = new Panel();
            companyListbox = new ListBox();
            panel14 = new Panel();
            panel13 = new Panel();
            panel9 = new Panel();
            companyDeleteButton = new Button();
            panel8 = new Panel();
            panel5 = new Panel();
            label3 = new Label();
            companyNameTextbox = new TextBox();
            companySaveButton = new Button();
            companyNameErrorLabel = new Label();
            panel3 = new Panel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1216, 633);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel12);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(612, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 623);
            panel2.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Window;
            panel12.Controls.Add(distributorListbox);
            panel12.Controls.Add(panel16);
            panel12.Controls.Add(panel15);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 170);
            panel12.Name = "panel12";
            panel12.Size = new Size(599, 413);
            panel12.TabIndex = 25;
            // 
            // distributorListbox
            // 
            distributorListbox.BorderStyle = BorderStyle.None;
            distributorListbox.Dock = DockStyle.Fill;
            distributorListbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            distributorListbox.FormattingEnabled = true;
            distributorListbox.ItemHeight = 21;
            distributorListbox.Location = new Point(30, 0);
            distributorListbox.Name = "distributorListbox";
            distributorListbox.Size = new Size(539, 413);
            distributorListbox.TabIndex = 4;
            // 
            // panel16
            // 
            panel16.BackColor = SystemColors.Window;
            panel16.Dock = DockStyle.Left;
            panel16.Location = new Point(0, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(30, 413);
            panel16.TabIndex = 3;
            // 
            // panel15
            // 
            panel15.BackColor = SystemColors.Window;
            panel15.Dock = DockStyle.Right;
            panel15.Location = new Point(569, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(30, 413);
            panel15.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(distributorDeleteButton);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 583);
            panel10.Name = "panel10";
            panel10.Size = new Size(599, 40);
            panel10.TabIndex = 24;
            // 
            // distributorDeleteButton
            // 
            distributorDeleteButton.Anchor = AnchorStyles.Right;
            distributorDeleteButton.BackColor = Color.Firebrick;
            distributorDeleteButton.FlatAppearance.BorderColor = Color.Firebrick;
            distributorDeleteButton.FlatStyle = FlatStyle.Popup;
            distributorDeleteButton.ForeColor = SystemColors.ControlLightLight;
            distributorDeleteButton.Location = new Point(521, 6);
            distributorDeleteButton.Name = "distributorDeleteButton";
            distributorDeleteButton.Size = new Size(75, 26);
            distributorDeleteButton.TabIndex = 7;
            distributorDeleteButton.Text = "Delete";
            distributorDeleteButton.UseVisualStyleBackColor = false;
            distributorDeleteButton.Click += DistributorDeleteButton_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 45);
            panel6.Name = "panel6";
            panel6.Size = new Size(599, 125);
            panel6.TabIndex = 22;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Left;
            panel7.Controls.Add(label4);
            panel7.Controls.Add(distributorNameTextbox);
            panel7.Controls.Add(distributorSaveButton);
            panel7.Controls.Add(distributorNameErrorLabel);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(distributorContactTextbox);
            panel7.Location = new Point(3, 24);
            panel7.Name = "panel7";
            panel7.Size = new Size(477, 100);
            panel7.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(0, 2);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 9;
            label4.Text = "Name *";
            // 
            // distributorNameTextbox
            // 
            distributorNameTextbox.BackColor = SystemColors.Window;
            distributorNameTextbox.ForeColor = SystemColors.ControlText;
            distributorNameTextbox.Location = new Point(2, 20);
            distributorNameTextbox.Name = "distributorNameTextbox";
            distributorNameTextbox.Size = new Size(223, 25);
            distributorNameTextbox.TabIndex = 1;
            // 
            // distributorSaveButton
            // 
            distributorSaveButton.BackColor = Color.FromArgb(16, 163, 127);
            distributorSaveButton.FlatAppearance.BorderColor = Color.FromArgb(16, 163, 127);
            distributorSaveButton.FlatStyle = FlatStyle.Popup;
            distributorSaveButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            distributorSaveButton.ForeColor = SystemColors.ControlLightLight;
            distributorSaveButton.Location = new Point(399, 71);
            distributorSaveButton.Name = "distributorSaveButton";
            distributorSaveButton.Size = new Size(75, 26);
            distributorSaveButton.TabIndex = 3;
            distributorSaveButton.Text = "Save";
            distributorSaveButton.UseVisualStyleBackColor = false;
            distributorSaveButton.Click += DistributorSaveButton_Click;
            // 
            // distributorNameErrorLabel
            // 
            distributorNameErrorLabel.AutoSize = true;
            distributorNameErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            distributorNameErrorLabel.ForeColor = Color.Firebrick;
            distributorNameErrorLabel.Location = new Point(2, 50);
            distributorNameErrorLabel.Name = "distributorNameErrorLabel";
            distributorNameErrorLabel.Size = new Size(94, 13);
            distributorNameErrorLabel.TabIndex = 8;
            distributorNameErrorLabel.Text = "Name is required";
            distributorNameErrorLabel.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(249, 2);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 11;
            label6.Text = "Contact";
            // 
            // distributorContactTextbox
            // 
            distributorContactTextbox.BackColor = SystemColors.Window;
            distributorContactTextbox.CharacterCasing = CharacterCasing.Upper;
            distributorContactTextbox.ForeColor = SystemColors.ControlText;
            distributorContactTextbox.Location = new Point(251, 20);
            distributorContactTextbox.Name = "distributorContactTextbox";
            distributorContactTextbox.Size = new Size(223, 25);
            distributorContactTextbox.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(599, 45);
            panel4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 2;
            label2.Text = "Distributors";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 623);
            panel1.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.Window;
            panel11.Controls.Add(companyListbox);
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel13);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 170);
            panel11.Name = "panel11";
            panel11.Size = new Size(599, 413);
            panel11.TabIndex = 24;
            // 
            // companyListbox
            // 
            companyListbox.BorderStyle = BorderStyle.None;
            companyListbox.Dock = DockStyle.Fill;
            companyListbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            companyListbox.FormattingEnabled = true;
            companyListbox.ItemHeight = 21;
            companyListbox.Location = new Point(30, 0);
            companyListbox.Name = "companyListbox";
            companyListbox.Size = new Size(539, 413);
            companyListbox.TabIndex = 2;
            companyListbox.TabStop = false;
            companyListbox.UseTabStops = false;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.Window;
            panel14.Dock = DockStyle.Right;
            panel14.Location = new Point(569, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(30, 413);
            panel14.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.Window;
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(30, 413);
            panel13.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(companyDeleteButton);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 583);
            panel9.Name = "panel9";
            panel9.Size = new Size(599, 40);
            panel9.TabIndex = 23;
            // 
            // companyDeleteButton
            // 
            companyDeleteButton.Anchor = AnchorStyles.Right;
            companyDeleteButton.BackColor = Color.Firebrick;
            companyDeleteButton.FlatAppearance.BorderColor = Color.Firebrick;
            companyDeleteButton.FlatStyle = FlatStyle.Popup;
            companyDeleteButton.ForeColor = SystemColors.ControlLightLight;
            companyDeleteButton.Location = new Point(521, 6);
            companyDeleteButton.Name = "companyDeleteButton";
            companyDeleteButton.Size = new Size(75, 26);
            companyDeleteButton.TabIndex = 7;
            companyDeleteButton.Text = "Delete";
            companyDeleteButton.UseVisualStyleBackColor = false;
            companyDeleteButton.Click += CompanyDeleteButton_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel5);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 45);
            panel8.Name = "panel8";
            panel8.Size = new Size(599, 125);
            panel8.TabIndex = 22;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(companyNameTextbox);
            panel5.Controls.Add(companySaveButton);
            panel5.Controls.Add(companyNameErrorLabel);
            panel5.Location = new Point(0, 22);
            panel5.Name = "panel5";
            panel5.Size = new Size(242, 100);
            panel5.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(0, 2);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 9;
            label3.Text = "Name *";
            // 
            // companyNameTextbox
            // 
            companyNameTextbox.BackColor = SystemColors.Window;
            companyNameTextbox.ForeColor = SystemColors.ControlText;
            companyNameTextbox.Location = new Point(2, 20);
            companyNameTextbox.Name = "companyNameTextbox";
            companyNameTextbox.Size = new Size(223, 25);
            companyNameTextbox.TabIndex = 1;
            // 
            // companySaveButton
            // 
            companySaveButton.BackColor = Color.FromArgb(16, 163, 127);
            companySaveButton.FlatAppearance.BorderColor = Color.FromArgb(16, 163, 127);
            companySaveButton.FlatStyle = FlatStyle.Popup;
            companySaveButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            companySaveButton.ForeColor = SystemColors.ControlLightLight;
            companySaveButton.Location = new Point(150, 71);
            companySaveButton.Name = "companySaveButton";
            companySaveButton.Size = new Size(75, 26);
            companySaveButton.TabIndex = 3;
            companySaveButton.Text = "Save";
            companySaveButton.UseVisualStyleBackColor = false;
            companySaveButton.Click += CompanySaveButton_Click;
            // 
            // companyNameErrorLabel
            // 
            companyNameErrorLabel.AutoSize = true;
            companyNameErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            companyNameErrorLabel.ForeColor = Color.Firebrick;
            companyNameErrorLabel.Location = new Point(2, 50);
            companyNameErrorLabel.Name = "companyNameErrorLabel";
            companyNameErrorLabel.Size = new Size(94, 13);
            companyNameErrorLabel.TabIndex = 8;
            companyNameErrorLabel.Text = "Name is required";
            companyNameErrorLabel.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(599, 45);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 2;
            label1.Text = "Companies";
            // 
            // ItemSetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1216, 633);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ItemSetupForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Setup";
            Load += ItemSetupForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private Label label2;
        private Panel panel3;
        private Panel panel8;
        private Panel panel5;
        private Label label3;
        private TextBox companyNameTextbox;
        private Button companySaveButton;
        private Label companyNameErrorLabel;
        private Panel panel6;
        private Panel panel7;
        private Label label4;
        private TextBox distributorNameTextbox;
        private Button distributorSaveButton;
        private Label distributorNameErrorLabel;
        private Label label6;
        private TextBox distributorContactTextbox;
        private Panel panel9;
        private Panel panel10;
        private Button distributorDeleteButton;
        private Button companyDeleteButton;
        private Panel panel12;
        private Panel panel11;
        private Panel panel14;
        private Panel panel13;
        private ListBox companyListbox;
        private Panel panel16;
        private Panel panel15;
        private ListBox distributorListbox;
    }
}