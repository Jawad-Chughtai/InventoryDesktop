namespace InventoryDesktop.Winforms.Forms
{
    partial class CategoryForm
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
            categoryNameTextbox = new TextBox();
            saveButton = new Button();
            categoryListbox = new ListBox();
            editButton = new Button();
            deleteButton = new Button();
            updateNameTextbox = new TextBox();
            updateButton = new Button();
            updateIdLabel = new Label();
            SuspendLayout();
            // 
            // categoryNameTextbox
            // 
            categoryNameTextbox.Location = new Point(160, 46);
            categoryNameTextbox.Name = "categoryNameTextbox";
            categoryNameTextbox.Size = new Size(177, 23);
            categoryNameTextbox.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(370, 45);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 1;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // categoryListbox
            // 
            categoryListbox.FormattingEnabled = true;
            categoryListbox.ItemHeight = 15;
            categoryListbox.Location = new Point(160, 111);
            categoryListbox.Name = "categoryListbox";
            categoryListbox.Size = new Size(177, 229);
            categoryListbox.TabIndex = 2;
            // 
            // editButton
            // 
            editButton.Location = new Point(367, 300);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += EditButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(448, 300);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // updateNameTextbox
            // 
            updateNameTextbox.Location = new Point(470, 111);
            updateNameTextbox.Name = "updateNameTextbox";
            updateNameTextbox.Size = new Size(177, 23);
            updateNameTextbox.TabIndex = 5;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(653, 110);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // updateIdLabel
            // 
            updateIdLabel.AutoSize = true;
            updateIdLabel.Location = new Point(470, 137);
            updateIdLabel.Name = "updateIdLabel";
            updateIdLabel.Size = new Size(38, 15);
            updateIdLabel.TabIndex = 7;
            updateIdLabel.Text = "label1";
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateIdLabel);
            Controls.Add(updateButton);
            Controls.Add(updateNameTextbox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(categoryListbox);
            Controls.Add(saveButton);
            Controls.Add(categoryNameTextbox);
            Name = "CategoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CategoryForm";
            Load += CategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox categoryNameTextbox;
        private Button saveButton;
        private ListBox categoryListbox;
        private Button editButton;
        private Button deleteButton;
        private TextBox updateNameTextbox;
        private Button updateButton;
        private Label updateIdLabel;
    }
}