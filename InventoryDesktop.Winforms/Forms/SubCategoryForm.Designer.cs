namespace InventoryDesktop.Winforms.Forms
{
    partial class SubCategoryForm
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
            subcategoryListBox = new ListBox();
            saveButton = new Button();
            subcategoryNameTextbox = new TextBox();
            categoryCombobox = new ComboBox();
            updateCategoryCombobox = new ComboBox();
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
            subcategoryListBox.FormattingEnabled = true;
            subcategoryListBox.ItemHeight = 15;
            subcategoryListBox.Location = new Point(116, 144);
            subcategoryListBox.Name = "subcategoryListBox";
            subcategoryListBox.Size = new Size(177, 229);
            subcategoryListBox.TabIndex = 10;
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
            categoryCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            categoryCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            categoryCombobox.FormattingEnabled = true;
            categoryCombobox.Location = new Point(299, 79);
            categoryCombobox.Name = "categoryCombobox";
            categoryCombobox.Size = new Size(180, 23);
            categoryCombobox.TabIndex = 16;
            // 
            // updateCategoryCombobox
            // 
            updateCategoryCombobox.AutoCompleteMode = AutoCompleteMode.Suggest;
            updateCategoryCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            updateCategoryCombobox.FormattingEnabled = true;
            updateCategoryCombobox.Location = new Point(423, 188);
            updateCategoryCombobox.Name = "updateCategoryCombobox";
            updateCategoryCombobox.Size = new Size(180, 23);
            updateCategoryCombobox.TabIndex = 17;
            // 
            // SubCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateCategoryCombobox);
            Controls.Add(categoryCombobox);
            Controls.Add(updateIdLabel);
            Controls.Add(updateButton);
            Controls.Add(updateNameTextbox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(subcategoryListBox);
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
        private ListBox subcategoryListBox;
        private Button saveButton;
        private TextBox subcategoryNameTextbox;
        private ComboBox categoryCombobox;
        private ComboBox updateCategoryCombobox;
    }
}