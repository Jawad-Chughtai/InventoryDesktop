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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            panel11 = new Panel();
            datagrid = new DataGridView();
            panel10 = new Panel();
            label4 = new Label();
            searchButton = new Button();
            searchTextbox = new TextBox();
            linePanel = new Panel();
            panel4 = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            panel10.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // nameTextbox
            // 
            nameTextbox.BackColor = SystemColors.Window;
            nameTextbox.ForeColor = SystemColors.ControlText;
            nameTextbox.Location = new Point(2, 20);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(223, 25);
            nameTextbox.TabIndex = 1;
            nameTextbox.KeyDown += SaveForm_KeyDown;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(16, 163, 127);
            saveButton.FlatAppearance.BorderColor = Color.FromArgb(16, 163, 127);
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = SystemColors.ControlLightLight;
            saveButton.Location = new Point(399, 71);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 26);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
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
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 9;
            label1.Text = "Name *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(249, 2);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 11;
            label2.Text = "Code *";
            // 
            // codeTextbox
            // 
            codeTextbox.BackColor = SystemColors.Window;
            codeTextbox.CharacterCasing = CharacterCasing.Upper;
            codeTextbox.ForeColor = SystemColors.ControlText;
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
            panel1.Anchor = AnchorStyles.Left;
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
            panel1.Size = new Size(477, 100);
            panel1.TabIndex = 15;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Firebrick;
            resetButton.FlatAppearance.BorderColor = Color.Firebrick;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = SystemColors.ControlLightLight;
            resetButton.Location = new Point(318, 71);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 26);
            resetButton.TabIndex = 13;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += ResetButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(linePanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1074, 474);
            panel2.TabIndex = 16;
            // 
            // panel11
            // 
            panel11.Controls.Add(datagrid);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 61);
            panel11.Name = "panel11";
            panel11.Size = new Size(1074, 413);
            panel11.TabIndex = 21;
            // 
            // datagrid
            // 
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.BackgroundColor = SystemColors.Window;
            datagrid.BorderStyle = BorderStyle.None;
            datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
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
            datagrid.Size = new Size(1074, 413);
            datagrid.TabIndex = 15;
            datagrid.TabStop = false;
            // 
            // panel10
            // 
            panel10.Controls.Add(label4);
            panel10.Controls.Add(searchButton);
            panel10.Controls.Add(searchTextbox);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 1);
            panel10.Name = "panel10";
            panel10.Size = new Size(1074, 60);
            panel10.TabIndex = 20;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(759, 14);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "Search";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchButton.BackColor = Color.FromArgb(16, 163, 127);
            searchButton.FlatAppearance.BorderColor = Color.FromArgb(16, 163, 127);
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = SystemColors.ControlLightLight;
            searchButton.Location = new Point(999, 31);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 26);
            searchButton.TabIndex = 19;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // searchTextbox
            // 
            searchTextbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            searchTextbox.BackColor = SystemColors.Window;
            searchTextbox.ForeColor = SystemColors.ControlText;
            searchTextbox.Location = new Point(762, 32);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.Size = new Size(223, 25);
            searchTextbox.TabIndex = 17;
            searchTextbox.KeyDown += Search_KeyDown;
            // 
            // linePanel
            // 
            linePanel.BackColor = SystemColors.ActiveBorder;
            linePanel.Dock = DockStyle.Top;
            linePanel.ForeColor = SystemColors.ActiveCaption;
            linePanel.Location = new Point(0, 0);
            linePanel.MaximumSize = new Size(0, 1);
            linePanel.Name = "linePanel";
            linePanel.Size = new Size(1074, 1);
            linePanel.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(editButton);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 599);
            panel4.Name = "panel4";
            panel4.Size = new Size(1074, 42);
            panel4.TabIndex = 20;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Right;
            deleteButton.BackColor = Color.Firebrick;
            deleteButton.FlatAppearance.BorderColor = Color.Firebrick;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = SystemColors.ControlLightLight;
            deleteButton.Location = new Point(910, 6);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 26);
            deleteButton.TabIndex = 6;
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
            editButton.Location = new Point(999, 6);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 26);
            editButton.TabIndex = 5;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(75, 641);
            panel5.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1149, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 641);
            panel6.TabIndex = 22;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel9);
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(panel4);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(75, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1074, 641);
            panel7.TabIndex = 23;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel2);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 125);
            panel9.Name = "panel9";
            panel9.Size = new Size(1074, 474);
            panel9.TabIndex = 22;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel1);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1074, 125);
            panel8.TabIndex = 21;
            // 
            // ItemTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1224, 641);
            ControlBox = false;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemTypeForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item Type";
            Load += ItemTypeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
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
        private Panel linePanel;
        private DataGridView datagrid;
        private Button searchButton;
        private Label label4;
        private TextBox searchTextbox;
        private Panel panel4;
        private Button deleteButton;
        private Button editButton;
        private Button resetButton;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel11;
        private Panel panel10;
    }
}