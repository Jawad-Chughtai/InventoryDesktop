namespace InventoryDesktop.Winforms.Forms
{
    partial class PurchaseForm
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
            panel7 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel14 = new Panel();
            purchaseTotalLabel = new Label();
            label7 = new Label();
            panel9 = new Panel();
            totalQuantityLabel = new Label();
            label12 = new Label();
            panel8 = new Panel();
            purchaseUnitPriceLabel = new Label();
            label13 = new Label();
            panel6 = new Panel();
            saleUnitPriceLabel = new Label();
            label14 = new Label();
            expiryDate = new DateTimePicker();
            label10 = new Label();
            expiryErrorLabel = new Label();
            salePacketPriceTextbox = new TextBox();
            label4 = new Label();
            salePacketPriceErrorLabel = new Label();
            purchasePacketPriceTextbox = new TextBox();
            label8 = new Label();
            purchasePacketPriceErrorLabel = new Label();
            packetQuantityTextbox = new TextBox();
            packetQuantityErrorLabel = new Label();
            perPacketQuantityTextbox = new TextBox();
            itemCombobox = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            perPacketQuantityErrorLabel = new Label();
            resetButton = new Button();
            label1 = new Label();
            saveButton = new Button();
            batchErrorLabel = new Label();
            itemErrorLabel = new Label();
            label2 = new Label();
            batchTextbox = new TextBox();
            panel4 = new Panel();
            panel13 = new Panel();
            datagrid = new DataGridView();
            panel12 = new Panel();
            deleteButton = new Button();
            editButton = new Button();
            panel11 = new Panel();
            clearItemFilter = new Label();
            itemFilter = new ComboBox();
            searchButton = new Button();
            searchTextbox = new TextBox();
            panel10 = new Panel();
            FetchDataBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel14.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagrid).BeginInit();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(75, 736);
            panel5.TabIndex = 25;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1157, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 736);
            panel1.TabIndex = 26;
            // 
            // panel7
            // 
            panel7.AutoScroll = true;
            panel7.Controls.Add(panel3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(75, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1082, 144);
            panel7.TabIndex = 27;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(expiryDate);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(expiryErrorLabel);
            panel3.Controls.Add(salePacketPriceTextbox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(salePacketPriceErrorLabel);
            panel3.Controls.Add(purchasePacketPriceTextbox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(purchasePacketPriceErrorLabel);
            panel3.Controls.Add(packetQuantityTextbox);
            panel3.Controls.Add(packetQuantityErrorLabel);
            panel3.Controls.Add(perPacketQuantityTextbox);
            panel3.Controls.Add(itemCombobox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(perPacketQuantityErrorLabel);
            panel3.Controls.Add(resetButton);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(saveButton);
            panel3.Controls.Add(batchErrorLabel);
            panel3.Controls.Add(itemErrorLabel);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(batchTextbox);
            panel3.Location = new Point(0, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(887, 129);
            panel3.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel14);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(673, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 89);
            panel2.TabIndex = 19;
            // 
            // panel14
            // 
            panel14.Controls.Add(purchaseTotalLabel);
            panel14.Controls.Add(label7);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(214, 20);
            panel14.TabIndex = 7;
            // 
            // purchaseTotalLabel
            // 
            purchaseTotalLabel.AutoSize = true;
            purchaseTotalLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseTotalLabel.Location = new Point(127, 0);
            purchaseTotalLabel.Name = "purchaseTotalLabel";
            purchaseTotalLabel.Size = new Size(14, 15);
            purchaseTotalLabel.TabIndex = 1;
            purchaseTotalLabel.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 0;
            label7.Text = "Purchase Total:";
            // 
            // panel9
            // 
            panel9.Controls.Add(totalQuantityLabel);
            panel9.Controls.Add(label12);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 29);
            panel9.Name = "panel9";
            panel9.Size = new Size(214, 20);
            panel9.TabIndex = 6;
            // 
            // totalQuantityLabel
            // 
            totalQuantityLabel.AutoSize = true;
            totalQuantityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            totalQuantityLabel.Location = new Point(127, 0);
            totalQuantityLabel.Name = "totalQuantityLabel";
            totalQuantityLabel.Size = new Size(14, 15);
            totalQuantityLabel.TabIndex = 1;
            totalQuantityLabel.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(3, 0);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 0;
            label12.Text = "Total Quantity:";
            // 
            // panel8
            // 
            panel8.Controls.Add(purchaseUnitPriceLabel);
            panel8.Controls.Add(label13);
            panel8.Dock = DockStyle.Bottom;
            panel8.Location = new Point(0, 49);
            panel8.Name = "panel8";
            panel8.Size = new Size(214, 20);
            panel8.TabIndex = 5;
            // 
            // purchaseUnitPriceLabel
            // 
            purchaseUnitPriceLabel.AutoSize = true;
            purchaseUnitPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            purchaseUnitPriceLabel.Location = new Point(127, 0);
            purchaseUnitPriceLabel.Name = "purchaseUnitPriceLabel";
            purchaseUnitPriceLabel.Size = new Size(14, 15);
            purchaseUnitPriceLabel.TabIndex = 2;
            purchaseUnitPriceLabel.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(118, 15);
            label13.TabIndex = 1;
            label13.Text = "Purchase Unit Price:";
            // 
            // panel6
            // 
            panel6.Controls.Add(saleUnitPriceLabel);
            panel6.Controls.Add(label14);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 69);
            panel6.Name = "panel6";
            panel6.Size = new Size(214, 20);
            panel6.TabIndex = 4;
            // 
            // saleUnitPriceLabel
            // 
            saleUnitPriceLabel.AutoSize = true;
            saleUnitPriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saleUnitPriceLabel.Location = new Point(127, 1);
            saleUnitPriceLabel.Name = "saleUnitPriceLabel";
            saleUnitPriceLabel.Size = new Size(14, 15);
            saleUnitPriceLabel.TabIndex = 3;
            saleUnitPriceLabel.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(3, 1);
            label14.Name = "label14";
            label14.Size = new Size(91, 15);
            label14.TabIndex = 2;
            label14.Text = "Sale Unit Price:";
            // 
            // expiryDate
            // 
            expiryDate.CustomFormat = "dd-MM-yyyy";
            expiryDate.Format = DateTimePickerFormat.Custom;
            expiryDate.Location = new Point(495, 21);
            expiryDate.MinDate = new DateTime(2023, 3, 25, 0, 0, 0, 0);
            expiryDate.Name = "expiryDate";
            expiryDate.ShowCheckBox = true;
            expiryDate.Size = new Size(156, 25);
            expiryDate.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(495, 2);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 37;
            label10.Text = "Expiry *";
            // 
            // expiryErrorLabel
            // 
            expiryErrorLabel.AutoSize = true;
            expiryErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            expiryErrorLabel.ForeColor = Color.Firebrick;
            expiryErrorLabel.Location = new Point(495, 49);
            expiryErrorLabel.Name = "expiryErrorLabel";
            expiryErrorLabel.Size = new Size(100, 13);
            expiryErrorLabel.TabIndex = 36;
            expiryErrorLabel.Text = "Invalid expiry date";
            expiryErrorLabel.Visible = false;
            // 
            // salePacketPriceTextbox
            // 
            salePacketPriceTextbox.Location = new Point(495, 85);
            salePacketPriceTextbox.Name = "salePacketPriceTextbox";
            salePacketPriceTextbox.Size = new Size(156, 25);
            salePacketPriceTextbox.TabIndex = 7;
            salePacketPriceTextbox.TextAlign = HorizontalAlignment.Right;
            salePacketPriceTextbox.KeyPress += ValidateDouble;
            salePacketPriceTextbox.Leave += CalculateValues;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(495, 67);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 34;
            label4.Text = "Packet Sale Price *";
            // 
            // salePacketPriceErrorLabel
            // 
            salePacketPriceErrorLabel.AutoSize = true;
            salePacketPriceErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            salePacketPriceErrorLabel.ForeColor = Color.Firebrick;
            salePacketPriceErrorLabel.Location = new Point(495, 114);
            salePacketPriceErrorLabel.Name = "salePacketPriceErrorLabel";
            salePacketPriceErrorLabel.Size = new Size(86, 13);
            salePacketPriceErrorLabel.TabIndex = 33;
            salePacketPriceErrorLabel.Text = "This is required";
            salePacketPriceErrorLabel.Visible = false;
            // 
            // purchasePacketPriceTextbox
            // 
            purchasePacketPriceTextbox.Location = new Point(327, 85);
            purchasePacketPriceTextbox.Name = "purchasePacketPriceTextbox";
            purchasePacketPriceTextbox.Size = new Size(156, 25);
            purchasePacketPriceTextbox.TabIndex = 6;
            purchasePacketPriceTextbox.TextAlign = HorizontalAlignment.Right;
            purchasePacketPriceTextbox.KeyPress += ValidateDouble;
            purchasePacketPriceTextbox.Leave += CalculateValues;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(327, 67);
            label8.Name = "label8";
            label8.Size = new Size(130, 15);
            label8.TabIndex = 31;
            label8.Text = "Packet Purchase Price *";
            // 
            // purchasePacketPriceErrorLabel
            // 
            purchasePacketPriceErrorLabel.AutoSize = true;
            purchasePacketPriceErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            purchasePacketPriceErrorLabel.ForeColor = Color.Firebrick;
            purchasePacketPriceErrorLabel.Location = new Point(327, 114);
            purchasePacketPriceErrorLabel.Name = "purchasePacketPriceErrorLabel";
            purchasePacketPriceErrorLabel.Size = new Size(86, 13);
            purchasePacketPriceErrorLabel.TabIndex = 30;
            purchasePacketPriceErrorLabel.Text = "This is required";
            purchasePacketPriceErrorLabel.Visible = false;
            // 
            // packetQuantityTextbox
            // 
            packetQuantityTextbox.Location = new Point(2, 85);
            packetQuantityTextbox.Name = "packetQuantityTextbox";
            packetQuantityTextbox.Size = new Size(150, 25);
            packetQuantityTextbox.TabIndex = 4;
            packetQuantityTextbox.TextAlign = HorizontalAlignment.Right;
            packetQuantityTextbox.KeyPress += ValidateInteger;
            packetQuantityTextbox.Leave += CalculateValues;
            // 
            // packetQuantityErrorLabel
            // 
            packetQuantityErrorLabel.AutoSize = true;
            packetQuantityErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            packetQuantityErrorLabel.ForeColor = Color.Firebrick;
            packetQuantityErrorLabel.Location = new Point(2, 114);
            packetQuantityErrorLabel.Name = "packetQuantityErrorLabel";
            packetQuantityErrorLabel.Size = new Size(86, 13);
            packetQuantityErrorLabel.TabIndex = 28;
            packetQuantityErrorLabel.Text = "This is required";
            packetQuantityErrorLabel.Visible = false;
            // 
            // perPacketQuantityTextbox
            // 
            perPacketQuantityTextbox.Location = new Point(165, 85);
            perPacketQuantityTextbox.Name = "perPacketQuantityTextbox";
            perPacketQuantityTextbox.Size = new Size(150, 25);
            perPacketQuantityTextbox.TabIndex = 5;
            perPacketQuantityTextbox.Text = "1";
            perPacketQuantityTextbox.TextAlign = HorizontalAlignment.Right;
            perPacketQuantityTextbox.KeyPress += ValidateInteger;
            perPacketQuantityTextbox.Leave += CalculateValues;
            // 
            // itemCombobox
            // 
            itemCombobox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            itemCombobox.AutoCompleteSource = AutoCompleteSource.ListItems;
            itemCombobox.FormattingEnabled = true;
            itemCombobox.Location = new Point(2, 20);
            itemCombobox.Name = "itemCombobox";
            itemCombobox.Size = new Size(226, 25);
            itemCombobox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 67);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 18;
            label3.Text = "Packet Quantity *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(165, 67);
            label5.Name = "label5";
            label5.Size = new Size(119, 15);
            label5.TabIndex = 15;
            label5.Text = "Quantity Per Packet *";
            // 
            // perPacketQuantityErrorLabel
            // 
            perPacketQuantityErrorLabel.AutoSize = true;
            perPacketQuantityErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            perPacketQuantityErrorLabel.ForeColor = Color.Firebrick;
            perPacketQuantityErrorLabel.Location = new Point(165, 114);
            perPacketQuantityErrorLabel.Name = "perPacketQuantityErrorLabel";
            perPacketQuantityErrorLabel.Size = new Size(86, 13);
            perPacketQuantityErrorLabel.TabIndex = 14;
            perPacketQuantityErrorLabel.Text = "This is required";
            perPacketQuantityErrorLabel.Visible = false;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.Firebrick;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.ForeColor = Color.White;
            resetButton.Location = new Point(719, 98);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 26);
            resetButton.TabIndex = 9;
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
            label1.Size = new Size(90, 15);
            label1.TabIndex = 9;
            label1.Text = "Purchase Item *";
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(16, 163, 127);
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(800, 98);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 26);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // batchErrorLabel
            // 
            batchErrorLabel.AutoSize = true;
            batchErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            batchErrorLabel.ForeColor = Color.Firebrick;
            batchErrorLabel.Location = new Point(251, 49);
            batchErrorLabel.Name = "batchErrorLabel";
            batchErrorLabel.Size = new Size(86, 13);
            batchErrorLabel.TabIndex = 12;
            batchErrorLabel.Text = "This is required";
            batchErrorLabel.Visible = false;
            // 
            // itemErrorLabel
            // 
            itemErrorLabel.AutoSize = true;
            itemErrorLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            itemErrorLabel.ForeColor = Color.Firebrick;
            itemErrorLabel.Location = new Point(2, 49);
            itemErrorLabel.Name = "itemErrorLabel";
            itemErrorLabel.Size = new Size(86, 13);
            itemErrorLabel.TabIndex = 8;
            itemErrorLabel.Text = "This is required";
            itemErrorLabel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(249, 2);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 11;
            label2.Text = "Batch *";
            // 
            // batchTextbox
            // 
            batchTextbox.Location = new Point(251, 20);
            batchTextbox.Name = "batchTextbox";
            batchTextbox.Size = new Size(223, 25);
            batchTextbox.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(panel11);
            panel4.Controls.Add(panel10);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(75, 144);
            panel4.Name = "panel4";
            panel4.Size = new Size(1082, 592);
            panel4.TabIndex = 28;
            // 
            // panel13
            // 
            panel13.AutoScroll = true;
            panel13.Controls.Add(datagrid);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 41);
            panel13.Name = "panel13";
            panel13.Size = new Size(1082, 510);
            panel13.TabIndex = 3;
            // 
            // datagrid
            // 
            datagrid.AllowUserToAddRows = false;
            datagrid.AllowUserToDeleteRows = false;
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
            datagrid.Size = new Size(1082, 510);
            datagrid.TabIndex = 17;
            datagrid.TabStop = false;
            // 
            // panel12
            // 
            panel12.Controls.Add(deleteButton);
            panel12.Controls.Add(editButton);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 551);
            panel12.Name = "panel12";
            panel12.Size = new Size(1082, 41);
            panel12.TabIndex = 2;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            deleteButton.BackColor = Color.Firebrick;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(926, 7);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 26);
            deleteButton.TabIndex = 11;
            deleteButton.TabStop = false;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            editButton.BackColor = Color.FromArgb(16, 163, 127);
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.ForeColor = Color.White;
            editButton.Location = new Point(1007, 7);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 26);
            editButton.TabIndex = 10;
            editButton.TabStop = false;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(clearItemFilter);
            panel11.Controls.Add(itemFilter);
            panel11.Controls.Add(searchButton);
            panel11.Controls.Add(searchTextbox);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 1);
            panel11.Name = "panel11";
            panel11.Size = new Size(1082, 40);
            panel11.TabIndex = 1;
            // 
            // clearItemFilter
            // 
            clearItemFilter.AutoSize = true;
            clearItemFilter.Cursor = Cursors.Hand;
            clearItemFilter.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            clearItemFilter.ForeColor = Color.Firebrick;
            clearItemFilter.Location = new Point(234, 19);
            clearItemFilter.Name = "clearItemFilter";
            clearItemFilter.Size = new Size(34, 15);
            clearItemFilter.TabIndex = 26;
            clearItemFilter.Text = "Clear";
            clearItemFilter.Click += ClearItemFilter_Click;
            // 
            // itemFilter
            // 
            itemFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            itemFilter.AutoCompleteSource = AutoCompleteSource.ListItems;
            itemFilter.FormattingEnabled = true;
            itemFilter.Location = new Point(2, 9);
            itemFilter.Name = "itemFilter";
            itemFilter.Size = new Size(226, 25);
            itemFilter.TabIndex = 25;
            itemFilter.TabStop = false;
            itemFilter.SelectedIndexChanged += ItemFilter_SelectedIndexChanged;
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.BackColor = Color.FromArgb(16, 163, 127);
            searchButton.FlatStyle = FlatStyle.Popup;
            searchButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(1006, 9);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 26);
            searchButton.TabIndex = 12;
            searchButton.TabStop = false;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += SearchButton_Click;
            // 
            // searchTextbox
            // 
            searchTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextbox.Location = new Point(779, 9);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.Size = new Size(223, 25);
            searchTextbox.TabIndex = 11;
            searchTextbox.TabStop = false;
            searchTextbox.KeyDown += SearchTextbox_KeyDown;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ActiveBorder;
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1082, 1);
            panel10.TabIndex = 0;
            // 
            // FetchDataBackgroundWorker
            // 
            FetchDataBackgroundWorker.DoWork += FetchDataBackgroundWorker_DoWork;
            // 
            // PurchaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 736);
            Controls.Add(panel4);
            Controls.Add(panel7);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PurchaseForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase";
            Shown += PurchaseForm_Shown;
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)datagrid).EndInit();
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel1;
        private Panel panel7;
        private Panel panel3;
        private Label label3;
        private Label label5;
        private Label perPacketQuantityErrorLabel;
        private Button resetButton;
        private Label label1;
        private Button saveButton;
        private Label batchErrorLabel;
        private Label itemErrorLabel;
        private Label label2;
        private TextBox batchTextbox;
        private ComboBox itemCombobox;
        private TextBox packetQuantityTextbox;
        private Label packetQuantityErrorLabel;
        private TextBox perPacketQuantityTextbox;
        private TextBox purchasePacketPriceTextbox;
        private Label label8;
        private Label purchasePacketPriceErrorLabel;
        private TextBox salePacketPriceTextbox;
        private Label label4;
        private Label salePacketPriceErrorLabel;
        private DateTimePicker expiryDate;
        private Label label10;
        private Label expiryErrorLabel;
        private Panel panel2;
        private Label label14;
        private Label label13;
        private Label label12;
        private Panel panel9;
        private Label totalQuantityLabel;
        private Panel panel8;
        private Label purchaseUnitPriceLabel;
        private Panel panel6;
        private Label saleUnitPriceLabel;
        private Panel panel4;
        private Panel panel10;
        private Panel panel11;
        private Button searchButton;
        private TextBox searchTextbox;
        private ComboBox itemFilter;
        private Panel panel12;
        private Button deleteButton;
        private Button editButton;
        private Panel panel13;
        private DataGridView datagrid;
        private System.ComponentModel.BackgroundWorker FetchDataBackgroundWorker;
        private Label clearItemFilter;
        private Panel panel14;
        private Label purchaseTotalLabel;
        private Label label7;
    }
}