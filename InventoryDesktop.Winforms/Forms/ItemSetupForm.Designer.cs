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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            panel12 = new Panel();
            distributorDatagrid = new DataGridView();
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
            panel18 = new Panel();
            panel1 = new Panel();
            panel11 = new Panel();
            companyDatagrid = new DataGridView();
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
            panel17 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)distributorDatagrid).BeginInit();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)companyDatagrid).BeginInit();
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
            panel2.Controls.Add(panel18);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(612, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 623);
            panel2.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.BackColor = SystemColors.Window;
            panel12.Controls.Add(distributorDatagrid);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 191);
            panel12.Name = "panel12";
            panel12.Size = new Size(524, 392);
            panel12.TabIndex = 25;
            // 
            // distributorDatagrid
            // 
            distributorDatagrid.AllowUserToAddRows = false;
            distributorDatagrid.AllowUserToDeleteRows = false;
            distributorDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            distributorDatagrid.BackgroundColor = SystemColors.Window;
            distributorDatagrid.BorderStyle = BorderStyle.None;
            distributorDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            distributorDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            distributorDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            distributorDatagrid.DefaultCellStyle = dataGridViewCellStyle2;
            distributorDatagrid.Dock = DockStyle.Fill;
            distributorDatagrid.GridColor = SystemColors.ActiveBorder;
            distributorDatagrid.Location = new Point(0, 0);
            distributorDatagrid.MultiSelect = false;
            distributorDatagrid.Name = "distributorDatagrid";
            distributorDatagrid.ReadOnly = true;
            distributorDatagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            distributorDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            distributorDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            distributorDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            distributorDatagrid.RowTemplate.Height = 25;
            distributorDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            distributorDatagrid.ShowCellErrors = false;
            distributorDatagrid.ShowCellToolTips = false;
            distributorDatagrid.ShowEditingIcon = false;
            distributorDatagrid.ShowRowErrors = false;
            distributorDatagrid.Size = new Size(524, 392);
            distributorDatagrid.TabIndex = 17;
            distributorDatagrid.TabStop = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(distributorDeleteButton);
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 583);
            panel10.Name = "panel10";
            panel10.Size = new Size(524, 40);
            panel10.TabIndex = 24;
            // 
            // distributorDeleteButton
            // 
            distributorDeleteButton.Anchor = AnchorStyles.Right;
            distributorDeleteButton.BackColor = Color.Firebrick;
            distributorDeleteButton.FlatAppearance.BorderColor = Color.Firebrick;
            distributorDeleteButton.FlatStyle = FlatStyle.Popup;
            distributorDeleteButton.ForeColor = SystemColors.ControlLightLight;
            distributorDeleteButton.Location = new Point(446, 6);
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
            panel6.Location = new Point(0, 66);
            panel6.Name = "panel6";
            panel6.Size = new Size(524, 125);
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
            panel4.Size = new Size(524, 66);
            panel4.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 2;
            label2.Text = "Distributors";
            // 
            // panel18
            // 
            panel18.Dock = DockStyle.Right;
            panel18.Location = new Point(524, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(75, 623);
            panel18.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel17);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(599, 623);
            panel1.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = SystemColors.Window;
            panel11.Controls.Add(companyDatagrid);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(75, 191);
            panel11.Name = "panel11";
            panel11.Size = new Size(524, 392);
            panel11.TabIndex = 24;
            // 
            // companyDatagrid
            // 
            companyDatagrid.AllowUserToAddRows = false;
            companyDatagrid.AllowUserToDeleteRows = false;
            companyDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            companyDatagrid.BackgroundColor = SystemColors.Window;
            companyDatagrid.BorderStyle = BorderStyle.None;
            companyDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            companyDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            companyDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            companyDatagrid.DefaultCellStyle = dataGridViewCellStyle6;
            companyDatagrid.Dock = DockStyle.Fill;
            companyDatagrid.GridColor = SystemColors.ActiveBorder;
            companyDatagrid.Location = new Point(0, 0);
            companyDatagrid.MultiSelect = false;
            companyDatagrid.Name = "companyDatagrid";
            companyDatagrid.ReadOnly = true;
            companyDatagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            companyDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            companyDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            companyDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            companyDatagrid.RowTemplate.Height = 25;
            companyDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            companyDatagrid.ShowCellErrors = false;
            companyDatagrid.ShowCellToolTips = false;
            companyDatagrid.ShowEditingIcon = false;
            companyDatagrid.ShowRowErrors = false;
            companyDatagrid.Size = new Size(524, 392);
            companyDatagrid.TabIndex = 16;
            companyDatagrid.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(companyDeleteButton);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(75, 583);
            panel9.Name = "panel9";
            panel9.Size = new Size(524, 40);
            panel9.TabIndex = 23;
            // 
            // companyDeleteButton
            // 
            companyDeleteButton.Anchor = AnchorStyles.Right;
            companyDeleteButton.BackColor = Color.Firebrick;
            companyDeleteButton.FlatAppearance.BorderColor = Color.Firebrick;
            companyDeleteButton.FlatStyle = FlatStyle.Popup;
            companyDeleteButton.ForeColor = SystemColors.ControlLightLight;
            companyDeleteButton.Location = new Point(449, 6);
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
            panel8.Location = new Point(75, 66);
            panel8.Name = "panel8";
            panel8.Size = new Size(524, 125);
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
            panel3.Location = new Point(75, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 66);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 2;
            label1.Text = "Companies";
            // 
            // panel17
            // 
            panel17.Dock = DockStyle.Left;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(75, 623);
            panel17.TabIndex = 25;
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
            ((System.ComponentModel.ISupportInitialize)distributorDatagrid).EndInit();
            panel10.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)companyDatagrid).EndInit();
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
        private Panel panel17;
        private Panel panel18;
        private DataGridView companyDatagrid;
        private DataGridView distributorDatagrid;
    }
}