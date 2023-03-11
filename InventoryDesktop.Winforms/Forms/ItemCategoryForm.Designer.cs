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
            panel2 = new Panel();
            typeFilter = new ComboBox();
            label3 = new Label();
            searchButton = new Button();
            label4 = new Label();
            searchTextbox = new TextBox();
            panel3 = new Panel();
            datagrid = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
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
            panel1.Location = new Point(80, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 100);
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
            resetButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(572, 71);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 26);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
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
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(653, 71);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 26);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
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
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(editButton);
            panel4.Location = new Point(80, 637);
            panel4.Name = "panel4";
            panel4.Size = new Size(1094, 35);
            panel4.TabIndex = 21;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1019, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 26);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(938, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 26);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(typeFilter);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(searchTextbox);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(datagrid);
            panel2.Location = new Point(80, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(1094, 496);
            panel2.TabIndex = 22;
            // 
            // typeFilter
            // 
            typeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            typeFilter.FormattingEnabled = true;
            typeFilter.Location = new Point(2, 36);
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
            label3.Location = new Point(2, 18);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 22;
            label3.Text = "Item Type";
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(1019, 35);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 26);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(779, 18);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "Search";
            // 
            // searchTextbox
            // 
            searchTextbox.Location = new Point(781, 36);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.Size = new Size(223, 25);
            searchTextbox.TabIndex = 6;
            searchTextbox.KeyDown += Search_KeyDown;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.MaximumSize = new Size(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1094, 1);
            panel3.TabIndex = 16;
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            datagrid.DefaultCellStyle = dataGridViewCellStyle2;
            datagrid.Dock = DockStyle.Bottom;
            datagrid.GridColor = SystemColors.ActiveBorder;
            datagrid.Location = new Point(0, 67);
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
            datagrid.Size = new Size(1094, 429);
            datagrid.TabIndex = 15;
            datagrid.TabStop = false;
            // 
            // ItemCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ItemCategoryForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Category";
            Load += SubCategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
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
        private Panel panel2;
        private Button searchButton;
        private Label label4;
        private TextBox searchTextbox;
        private Panel panel3;
        private DataGridView datagrid;
        private ComboBox typeCombobox;
        private ComboBox typeFilter;
        private Label label3;
    }
}