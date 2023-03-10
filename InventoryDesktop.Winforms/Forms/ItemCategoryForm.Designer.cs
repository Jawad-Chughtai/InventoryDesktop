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
            updateIdLabel = new Label();
            updateButton = new Button();
            updateNameTextbox = new TextBox();
            deleteButton = new Button();
            editButton = new Button();
            categoryListbox = new ListBox();
            saveButton = new Button();
            subcategoryNameTextbox = new TextBox();
            typeCombobox = new ComboBox();
            updateTypeListbox = new ComboBox();
            SuspendLayout();
            // 
            // updateIdLabel
            // 
            updateIdLabel.AutoSize = true;
            updateIdLabel.Location = new Point(426, 170);
            updateIdLabel.Name = "updateIdLabel";
            updateIdLabel.Size = new Size(38, 15);
            updateIdLabel.TabIndex = 15;
            updateIdLabel.Text = "label1";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(528, 226);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 14;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // updateNameTextbox
            // 
            updateNameTextbox.Location = new Point(426, 144);
            updateNameTextbox.Name = "updateNameTextbox";
            updateNameTextbox.Size = new Size(177, 23);
            updateNameTextbox.TabIndex = 13;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(404, 333);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(323, 333);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 11;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // subcategoryListBox
            // 
            categoryListbox.FormattingEnabled = true;
            categoryListbox.ItemHeight = 15;
            categoryListbox.Location = new Point(116, 144);
            categoryListbox.Name = "subcategoryListBox";
            categoryListbox.Size = new Size(177, 229);
            categoryListbox.TabIndex = 10;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(487, 79);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // subcategoryNameTextbox
            // 
            subcategoryNameTextbox.Location = new Point(116, 79);
            subcategoryNameTextbox.Name = "subcategoryNameTextbox";
            subcategoryNameTextbox.Size = new Size(177, 23);
            subcategoryNameTextbox.TabIndex = 8;
            // 
            // categoryCombobox
            // 
            typeCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            typeCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            typeCombobox.FormattingEnabled = true;
            typeCombobox.Location = new Point(299, 79);
            typeCombobox.Name = "categoryCombobox";
            typeCombobox.Size = new Size(180, 23);
            typeCombobox.TabIndex = 16;
            // 
            // updateCategoryCombobox
            // 
            updateTypeListbox.AutoCompleteMode = AutoCompleteMode.Suggest;
            updateTypeListbox.AutoCompleteSource = AutoCompleteSource.ListItems;
            updateTypeListbox.FormattingEnabled = true;
            updateTypeListbox.Location = new Point(423, 188);
            updateTypeListbox.Name = "updateCategoryCombobox";
            updateTypeListbox.Size = new Size(180, 23);
            updateTypeListbox.TabIndex = 17;
            // 
            // SubCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateTypeListbox);
            Controls.Add(typeCombobox);
            Controls.Add(updateIdLabel);
            Controls.Add(updateButton);
            Controls.Add(updateNameTextbox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(categoryListbox);
            Controls.Add(saveButton);
            Controls.Add(subcategoryNameTextbox);
            Name = "SubCategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubCategoryForm";
            Load += SubCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label updateIdLabel;
        private Button updateButton;
        private TextBox updateNameTextbox;
        private Button deleteButton;
        private Button editButton;
        private ListBox categoryListbox;
        private Button saveButton;
        private TextBox subcategoryNameTextbox;
        private ComboBox typeCombobox;
        private ComboBox updateTypeListbox;
    }
}