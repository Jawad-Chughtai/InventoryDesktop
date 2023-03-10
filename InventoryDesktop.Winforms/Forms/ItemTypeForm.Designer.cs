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
            panel2 = new Panel();
            button1 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            panel3 = new Panel();
            datagrid = new DataGridView();
            updateIdLabel = new Label();
            updateButton = new Button();
            updateNameTextbox = new TextBox();
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
            saveButton.Location = new Point(399, 62);
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
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 9;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 0);
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nameTextbox);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(codeErrorLabel);
            panel1.Controls.Add(nameErrorLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(codeTextbox);
            panel1.Location = new Point(80, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 89);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(datagrid);
            panel2.Location = new Point(80, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(1094, 489);
            panel2.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(1019, 28);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 19;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(779, 9);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 18;
            label4.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(781, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 25);
            textBox1.TabIndex = 17;
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
            datagrid.Location = new Point(0, 60);
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
            // updateIdLabel
            // 
            updateIdLabel.AutoSize = true;
            updateIdLabel.Location = new Point(861, 59);
            updateIdLabel.Name = "updateIdLabel";
            updateIdLabel.Size = new Size(45, 19);
            updateIdLabel.TabIndex = 19;
            updateIdLabel.Text = "label1";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(1044, 29);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 26);
            updateButton.TabIndex = 18;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // updateNameTextbox
            // 
            updateNameTextbox.Location = new Point(861, 30);
            updateNameTextbox.Name = "updateNameTextbox";
            updateNameTextbox.Size = new Size(177, 25);
            updateNameTextbox.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(deleteButton);
            panel4.Controls.Add(editButton);
            panel4.Location = new Point(80, 619);
            panel4.Name = "panel4";
            panel4.Size = new Size(1094, 53);
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
            // 
            // editButton
            // 
            editButton.Location = new Point(938, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 26);
            editButton.TabIndex = 5;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // ItemTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel4);
            Controls.Add(updateIdLabel);
            Controls.Add(updateButton);
            Controls.Add(updateNameTextbox);
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
            PerformLayout();
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
        private Button button1;
        private Label label4;
        private TextBox textBox1;
        private Label updateIdLabel;
        private Button updateButton;
        private TextBox updateNameTextbox;
        private Panel panel4;
        private Button deleteButton;
        private Button editButton;
    }
}