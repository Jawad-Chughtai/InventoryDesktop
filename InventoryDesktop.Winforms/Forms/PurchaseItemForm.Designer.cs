namespace InventoryDesktop.Winforms.Forms
{
    partial class PurchaseItemForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel10 = new Panel();
            datagrid = new DataGridView();
            panel9 = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            panel8 = new Panel();
            searchButton = new Button();
            searchTextbox = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            panel3 = new Panel();
            clearCompany = new Label();
            clearDistributor = new Label();
            label4 = new Label();
            descriptionTextbox = new TextBox();
            distributorCombobox = new ComboBox();
            label6 = new Label();
            companyCombobox = new ComboBox();
            label3 = new Label();
            categoryCombobox = new ComboBox();
            label5 = new Label();
            categoryErrorLabel = new Label();
            resetButton = new Button();
            label1 = new Label();
            saveButton = new Button();
            quantityErrorLabel = new Label();
            nameErrorLabel = new Label();
            label2 = new Label();
            quantityTextbox = new TextBox();
            nameTextbox = new TextBox();
            FetchDataBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(75, 736);
            panel5.TabIndex = 24;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1157, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 736);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(75, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 736);
            panel2.TabIndex = 26;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 144);
            panel4.Name = "panel4";
            panel4.Size = new Size(1082, 592);
            panel4.TabIndex = 25;
            // 
            // panel10
            // 
            panel10.AutoScroll = true;
            panel10.Controls.Add(datagrid);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 45);
            panel10.Name = "panel10";
            panel10.Size = new Size(1082, 505);
            panel10.TabIndex = 23;
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
            datagrid.Location = new Point(0, 0);
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
            datagrid.Size = new Size(1082, 505);
            datagrid.TabIndex = 16;
            datagrid.TabStop = false;
            // 
            // panel9
            // 
            panel9.Controls.Add(deleteButton);
            panel9.Controls.Add(editButton);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 550);
            panel9.Name = "panel9";
            panel9.Size = new Size(1082, 42);
            panel9.TabIndex = 22;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.BackColor = Color.Firebrick;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(926, 6);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 26);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.BackColor = Color.FromArgb(16, 163, 127);
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(1007, 6);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 26);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(searchButton);
            panel8.Controls.Add(searchTextbox);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 1);
            panel8.Name = "panel8";
            panel8.Size = new Size(1082, 44);
            panel8.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.FromArgb(16, 163, 127);
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1007, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 26);
            searchButton.TabIndex = 10;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // searchTextbox
            // 
            searchTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextbox.Location = new Point(778, 12);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.Size = new Size(223, 25);
            searchTextbox.TabIndex = 9;
            searchTextbox.KeyDown += SearchTextbox_KeyDown;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveBorder;
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1082, 1);
            panel6.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1082, 144);
            panel7.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Controls.Add(clearCompany);
            panel3.Controls.Add(clearDistributor);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(descriptionTextbox);
            panel3.Controls.Add(distributorCombobox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(companyCombobox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(categoryCombobox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(categoryErrorLabel);
            panel3.Controls.Add(resetButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(saveButton);
            panel3.Controls.Add(quantityErrorLabel);
            panel3.Controls.Add(nameErrorLabel);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(quantityTextbox);
            panel3.Controls.Add(nameTextbox);
            panel3.Location = new Point(0, 18);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 129);
            panel3.TabIndex = 18;
            // 
            // clearCompany
            // 
            clearCompany.AutoSize = true;
            clearCompany.Cursor = Cursors.Hand;
            clearCompany.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            clearCompany.ForeColor = Color.Firebrick;
            clearCompany.Location = new Point(947, 2);
            clearCompany.Name = "clearCompany";
            clearCompany.Size = new Size(34, 15);
            clearCompany.TabIndex = 25;
            clearCompany.Text = "Clear";
            clearCompany.Click += ClearCompany_Click;
            // 
            // clearDistributor
            // 
            clearDistributor.AutoSize = true;
            clearDistributor.Cursor = Cursors.Hand;
            clearDistributor.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            clearDistributor.ForeColor = Color.Firebrick;
            clearDistributor.Location = new Point(194, 67);
            clearDistributor.Name = "clearDistributor";
            clearDistributor.Size = new Size(34, 15);
            clearDistributor.TabIndex = 24;
            clearDistributor.Text = "Clear";
            clearDistributor.Click += ClearDistributor_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(249, 67);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 23;
            label4.Text = "Description";
            // 
            // descriptionTextbox
            // 
            descriptionTextbox.Location = new Point(251, 85);
            descriptionTextbox.Name = "descriptionTextbox";
            descriptionTextbox.Size = new Size(477, 25);
            descriptionTextbox.TabIndex = 6;
            // 
            // distributorCombobox
            // 
            distributorCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            distributorCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            distributorCombobox.FormattingEnabled = true;
            distributorCombobox.Location = new Point(2, 85);
            distributorCombobox.Name = "distributorCombobox";
            distributorCombobox.Size = new Size(226, 25);
            distributorCombobox.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(0, 67);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 21;
            label6.Text = "Distributor";
            // 
            // companyCombobox
            // 
            companyCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            companyCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            companyCombobox.FormattingEnabled = true;
            companyCombobox.Location = new Point(755, 20);
            companyCombobox.Name = "companyCombobox";
            companyCombobox.Size = new Size(226, 25);
            companyCombobox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(753, 2);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 18;
            label3.Text = "Company";
            // 
            // categoryCombobox
            // 
            categoryCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            categoryCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            categoryCombobox.FormattingEnabled = true;
            categoryCombobox.Location = new Point(502, 20);
            categoryCombobox.Name = "categoryCombobox";
            categoryCombobox.Size = new Size(226, 25);
            categoryCombobox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(502, 2);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 15;
            label5.Text = "Item Category *";
            // 
            // categoryErrorLabel
            // 
            categoryErrorLabel.AutoSize = true;
            categoryErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            categoryErrorLabel.ForeColor = Color.Firebrick;
            categoryErrorLabel.Location = new Point(502, 49);
            categoryErrorLabel.Name = "categoryErrorLabel";
            categoryErrorLabel.Size = new Size(134, 13);
            categoryErrorLabel.TabIndex = 14;
            categoryErrorLabel.Text = "Item category is required";
            categoryErrorLabel.Visible = false;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Firebrick;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(825, 85);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 26);
            resetButton.TabIndex = 8;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += ResetButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 9;
            label1.Text = "Name *";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(16, 163, 127);
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(906, 85);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 26);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // quantityErrorLabel
            // 
            quantityErrorLabel.AutoSize = true;
            quantityErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            quantityErrorLabel.ForeColor = Color.Firebrick;
            quantityErrorLabel.Location = new Point(251, 49);
            quantityErrorLabel.Name = "quantityErrorLabel";
            quantityErrorLabel.Size = new Size(159, 13);
            quantityErrorLabel.TabIndex = 12;
            quantityErrorLabel.Text = "Minimum quantity is required";
            quantityErrorLabel.Visible = false;
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            nameErrorLabel.ForeColor = Color.Firebrick;
            nameErrorLabel.Location = new Point(2, 49);
            nameErrorLabel.Name = "nameErrorLabel";
            nameErrorLabel.Size = new Size(94, 13);
            nameErrorLabel.TabIndex = 8;
            nameErrorLabel.Text = "Name is required";
            nameErrorLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 2);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 11;
            label2.Text = "Minimum Quantity *";
            // 
            // quantityTextbox
            // 
            quantityTextbox.Location = new Point(251, 20);
            quantityTextbox.Name = "quantityTextbox";
            quantityTextbox.Size = new Size(223, 25);
            quantityTextbox.TabIndex = 2;
            quantityTextbox.KeyPress += QuantityTextbox_KeyPress;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(2, 20);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(223, 25);
            nameTextbox.TabIndex = 1;
            // 
            // FetchDataBackgroundWorker
            // 
            FetchDataBackgroundWorker.WorkerReportsProgress = true;
            FetchDataBackgroundWorker.DoWork += GetListBackgroundWorker_DoWork;
            // 
            // PurchaseItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1232, 736);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PurchaseItemForm";
            ShowIcon = false;
            Text = "Purchase Item";
            Shown += PurchaseItemForm_Shown;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel7;
        private Panel panel3;
        private ComboBox categoryCombobox;
        private Label label5;
        private Label categoryErrorLabel;
        private Button resetButton;
        private Label label1;
        private Button saveButton;
        private Label quantityErrorLabel;
        private Label nameErrorLabel;
        private Label label2;
        private TextBox quantityTextbox;
        private TextBox nameTextbox;
        private Label label4;
        private TextBox descriptionTextbox;
        private ComboBox distributorCombobox;
        private Label label6;
        private ComboBox companyCombobox;
        private Label label3;
        private Panel panel4;
        private Panel panel6;
        private Panel panel8;
        private Button searchButton;
        private TextBox searchTextbox;
        private Panel panel9;
        private Button deleteButton;
        private Button editButton;
        private Panel panel10;
        private DataGridView datagrid;
        private System.ComponentModel.BackgroundWorker FetchDataBackgroundWorker;
        private Label clearCompany;
        private Label clearDistributor;
    }
}