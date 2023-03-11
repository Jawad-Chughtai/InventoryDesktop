namespace InventoryDesktop.Winforms.Forms
{
    partial class ItemTypeForm
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
            nameTextbox = new TextBox();
            saveButton = new Button();
            nameErrorLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            codeTextbox = new TextBox();
            codeErrorLabel = new Label();
            panel1 = new Panel();
            resetButton = new Button();
            panel2 = new Panel();
            searchButton = new Button();
            label4 = new Label();
            searchTextbox = new TextBox();
            panel3 = new Panel();
            datagrid = new DataGridView();
            panel4 = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
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
            saveButton.Location = new Point(399, 71);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 26);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 2);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 11;
            label2.Text = "Code";
            // 
            // codeTextbox
            // 
            codeTextbox.Location = new Point(251, 20);
            codeTextbox.Name = "codeTextbox";
            codeTextbox.Size = new Size(223, 25);
            codeTextbox.TabIndex = 2;
            codeTextbox.KeyDown += SaveForm_KeyDown;
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
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
            panel1.Size = new Size(477, 100);
            panel1.TabIndex = 15;
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(318, 71);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 26);
            resetButton.TabIndex = 13;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(searchTextbox);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(datagrid);
            panel2.Location = new Point(80, 135);
            panel2.Name = "panel2";
            panel2.Size = new Size(1094, 496);
            panel2.TabIndex = 16;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(1019, 35);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 26);
            searchButton.TabIndex = 19;
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
            searchTextbox.TabIndex = 17;
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
            datagrid.BackgroundColor = Color.White;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagrid.Dock = DockStyle.Bottom;
            datagrid.GridColor = SystemColors.ActiveBorder;
            datagrid.Location = new Point(0, 67);
            datagrid.MultiSelect = false;
            datagrid.Name = "datagrid";
            datagrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            datagrid.RowHeadersVisible = false;
            datagrid.RowTemplate.Height = 25;
            datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagrid.Size = new Size(1094, 429);
            datagrid.TabIndex = 15;
            datagrid.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(editButton);
            panel4.Location = new Point(80, 637);
            panel4.Name = "panel4";
            panel4.Size = new Size(1094, 35);
            panel4.TabIndex = 20;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1019, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 26);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(938, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 26);
            editButton.TabIndex = 5;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // ItemTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ItemTypeForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Type";
            Load += CategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox nameTextbox;
        private Button saveButton;
        private Label nameErrorLabel;
        private Label label1;
        private Label label2;
        private TextBox codeTextbox;
        private Label codeErrorLabel;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView datagrid;
        private Button searchButton;
        private Label label4;
        private TextBox searchTextbox;
        private Panel panel4;
        private Button deleteButton;
        private Button editButton;
        private Button resetButton;
    }
}