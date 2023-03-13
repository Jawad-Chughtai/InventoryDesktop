namespace InventoryDesktop.Winforms.Forms
{
    partial class ItemCategoryForm
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
            panel1 = new Panel();
            typeCombobox = new ComboBox();
            label5 = new Label();
            typeErrorLabel = new Label();
            resetButton = new Button();
            label1 = new Label();
            nameTextbox = new TextBox();
            saveButton = new Button();
            codeErrorLabel = new Label();
            nameErrorLabel = new Label();
            label2 = new Label();
            codeTextbox = new TextBox();
            panel4 = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            typeFilter = new ComboBox();
            label3 = new Label();
            searchButton = new Button();
            label4 = new Label();
            searchTextbox = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            fillPanel = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            datagrid = new DataGridView();
            panel8 = new Panel();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            fillPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(typeCombobox);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(typeErrorLabel);
            panel1.Controls.Add(resetButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nameTextbox);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(codeErrorLabel);
            panel1.Controls.Add(nameErrorLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(codeTextbox);
            panel1.Location = new Point(0, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 100);
            panel1.TabIndex = 18;
            // 
            // typeCombobox
            // 
            typeCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            typeCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            typeCombobox.FormattingEnabled = true;
            typeCombobox.Location = new Point(502, 20);
            typeCombobox.Name = "typeCombobox";
            typeCombobox.Size = new Size(226, 25);
            typeCombobox.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(502, 2);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 15;
            label5.Text = "Item Type *";
            // 
            // typeErrorLabel
            // 
            typeErrorLabel.AutoSize = true;
            typeErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            typeErrorLabel.ForeColor = Color.Firebrick;
            typeErrorLabel.Location = new Point(502, 50);
            typeErrorLabel.Name = "typeErrorLabel";
            typeErrorLabel.Size = new Size(112, 13);
            typeErrorLabel.TabIndex = 14;
            typeErrorLabel.Text = "Item type is required";
            typeErrorLabel.Visible = false;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Firebrick;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(572, 71);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 26);
            resetButton.TabIndex = 5;
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
            // nameTextbox
            // 
            nameTextbox.Location = new Point(2, 20);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(223, 25);
            nameTextbox.TabIndex = 1;
            nameTextbox.KeyDown += SaveForm_KeyDown;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(16, 163, 127);
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(653, 71);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 26);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // codeErrorLabel
            // 
            codeErrorLabel.AutoSize = true;
            codeErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            codeErrorLabel.ForeColor = Color.Firebrick;
            codeErrorLabel.Location = new Point(251, 50);
            codeErrorLabel.Name = "codeErrorLabel";
            codeErrorLabel.Size = new Size(92, 13);
            codeErrorLabel.TabIndex = 12;
            codeErrorLabel.Text = "Code is required";
            codeErrorLabel.Visible = false;
            // 
            // nameErrorLabel
            // 
            nameErrorLabel.AutoSize = true;
            nameErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            nameErrorLabel.ForeColor = Color.Firebrick;
            nameErrorLabel.Location = new Point(2, 50);
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
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Code *";
            // 
            // codeTextbox
            // 
            codeTextbox.CharacterCasing = CharacterCasing.Upper;
            codeTextbox.Location = new Point(251, 20);
            codeTextbox.Name = "codeTextbox";
            codeTextbox.Size = new Size(223, 25);
            codeTextbox.TabIndex = 2;
            codeTextbox.KeyDown += SaveForm_KeyDown;
            // 
            // panel4
            // 
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(editButton);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 607);
            panel4.Name = "panel4";
            panel4.Size = new Size(1082, 42);
            panel4.TabIndex = 21;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.BackColor = Color.Firebrick;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(918, 6);
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
            // typeFilter
            // 
            typeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            typeFilter.FormattingEnabled = true;
            typeFilter.Location = new Point(1, 32);
            typeFilter.Name = "typeFilter";
            typeFilter.Size = new Size(226, 25);
            typeFilter.TabIndex = 21;
            typeFilter.TabStop = false;
            typeFilter.SelectedIndexChanged += TypeFilter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-64, 7);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 22;
            label3.Text = "Item Type";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.FromArgb(16, 163, 127);
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1007, 31);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 26);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(767, 14);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "Search";
            // 
            // searchTextbox
            // 
            searchTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextbox.Location = new Point(770, 32);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.Size = new Size(223, 25);
            searchTextbox.TabIndex = 6;
            searchTextbox.KeyDown += Search_KeyDown;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(75, 649);
            panel5.TabIndex = 23;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1157, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 649);
            panel6.TabIndex = 24;
            // 
            // fillPanel
            // 
            fillPanel.Controls.Add(panel2);
            fillPanel.Controls.Add(panel7);
            fillPanel.Controls.Add(panel4);
            fillPanel.Dock = DockStyle.Fill;
            fillPanel.Location = new Point(75, 0);
            fillPanel.Name = "fillPanel";
            fillPanel.Size = new Size(1082, 649);
            fillPanel.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 482);
            panel2.TabIndex = 24;
            // 
            // panel3
            // 
            panel3.Controls.Add(datagrid);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1082, 422);
            panel3.TabIndex = 25;
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
            datagrid.Size = new Size(1082, 422);
            datagrid.TabIndex = 15;
            datagrid.TabStop = false;
            // 
            // panel8
            // 
            panel8.Controls.Add(label4);
            panel8.Controls.Add(searchTextbox);
            panel8.Controls.Add(typeFilter);
            panel8.Controls.Add(searchButton);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1082, 60);
            panel8.TabIndex = 24;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1082, 125);
            panel7.TabIndex = 23;
            // 
            // ItemCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1232, 649);
            Controls.Add(fillPanel);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ItemCategoryForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Category";
            Load += ItemCategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            fillPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button resetButton;
        private Label label1;
        private TextBox nameTextbox;
        private Button saveButton;
        private Label codeErrorLabel;
        private Label nameErrorLabel;
        private Label label2;
        private TextBox codeTextbox;
        private Panel panel4;
        private Button deleteButton;
        private Button editButton;
        private Label label5;
        private Label typeErrorLabel;
        private Button searchButton;
        private Label label4;
        private TextBox searchTextbox;
        private ComboBox typeCombobox;
        private ComboBox typeFilter;
        private Label label3;
        private Panel panel5;
        private Panel panel6;
        private Panel fillPanel;
        private Panel panel7;
        private Panel panel2;
        private Panel panel3;
        private DataGridView datagrid;
        private Panel panel8;
    }
}