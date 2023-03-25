namespace InventoryDesktop.Winforms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            topPanel = new Panel();
            superAdminLabel = new Label();
            focusButton = new Button();
            panel1 = new Panel();
            userButton = new Button();
            pageTitleLabel = new Label();
            sidePanel = new Panel();
            navPanel = new Panel();
            navbar = new MenuStrip();
            menuDashboard = new ToolStripMenuItem();
            menuItem = new ToolStripMenuItem();
            menuPurchaseItem = new ToolStripMenuItem();
            menuItemCategory = new ToolStripMenuItem();
            menuItemType = new ToolStripMenuItem();
            menuItemSetup = new ToolStripMenuItem();
            menuUser = new ToolStripMenuItem();
            menuCreatePurchase = new ToolStripMenuItem();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            userPropPanel = new Panel();
            logoutButton = new Button();
            topPanel.SuspendLayout();
            panel1.SuspendLayout();
            sidePanel.SuspendLayout();
            navPanel.SuspendLayout();
            navbar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            userPropPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.AutoScroll = true;
            ContentPanel.Size = new Size(1360, 749);
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(52, 53, 65);
            topPanel.Controls.Add(superAdminLabel);
            topPanel.Controls.Add(focusButton);
            topPanel.Controls.Add(panel1);
            topPanel.Controls.Add(pageTitleLabel);
            topPanel.Dock = DockStyle.Top;
            topPanel.ForeColor = SystemColors.ControlLightLight;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1360, 50);
            topPanel.TabIndex = 3;
            // 
            // superAdminLabel
            // 
            superAdminLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            superAdminLabel.AutoSize = true;
            superAdminLabel.Cursor = Cursors.Hand;
            superAdminLabel.ForeColor = Color.DodgerBlue;
            superAdminLabel.Location = new Point(966, 18);
            superAdminLabel.Name = "superAdminLabel";
            superAdminLabel.Size = new Size(138, 19);
            superAdminLabel.TabIndex = 10;
            superAdminLabel.Text = "Back To Super Admin";
            superAdminLabel.Visible = false;
            superAdminLabel.Click += SuperAdminLabel_Click;
            // 
            // focusButton
            // 
            focusButton.Location = new Point(1016, 17);
            focusButton.Name = "focusButton";
            focusButton.Size = new Size(0, 0);
            focusButton.TabIndex = 3;
            focusButton.UseVisualStyleBackColor = true;
            focusButton.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(userButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1110, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 50);
            panel1.TabIndex = 2;
            // 
            // userButton
            // 
            userButton.Cursor = Cursors.Hand;
            userButton.Dock = DockStyle.Fill;
            userButton.FlatAppearance.BorderColor = Color.FromArgb(119, 120, 128);
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            userButton.Location = new Point(0, 0);
            userButton.Name = "userButton";
            userButton.Size = new Size(250, 50);
            userButton.TabIndex = 0;
            userButton.TabStop = false;
            userButton.Text = "User";
            userButton.UseVisualStyleBackColor = true;
            userButton.Click += UserButton_Click;
            userButton.MouseLeave += UserButton_MouseLeave;
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            pageTitleLabel.Location = new Point(275, 9);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(60, 30);
            pageTitleLabel.TabIndex = 1;
            pageTitleLabel.Text = "Title";
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(52, 53, 65);
            sidePanel.Controls.Add(navPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = Color.White;
            sidePanel.Location = new Point(0, 50);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(200, 699);
            sidePanel.TabIndex = 4;
            // 
            // navPanel
            // 
            navPanel.AutoScroll = true;
            navPanel.BackColor = Color.Transparent;
            navPanel.Controls.Add(navbar);
            navPanel.Controls.Add(panel2);
            navPanel.Dock = DockStyle.Fill;
            navPanel.Location = new Point(0, 0);
            navPanel.Name = "navPanel";
            navPanel.Size = new Size(200, 699);
            navPanel.TabIndex = 1;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(52, 53, 65);
            navbar.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            navbar.ImeMode = ImeMode.Off;
            navbar.Items.AddRange(new ToolStripItem[] { menuDashboard, menuItem, menuPurchaseItem, menuItemCategory, menuItemType, menuItemSetup, menuUser, menuCreatePurchase });
            navbar.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            navbar.Location = new Point(0, 95);
            navbar.Name = "navbar";
            navbar.Padding = new Padding(0);
            navbar.Size = new Size(200, 330);
            navbar.TabIndex = 0;
            // 
            // menuDashboard
            // 
            menuDashboard.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            menuDashboard.ForeColor = Color.White;
            menuDashboard.Name = "menuDashboard";
            menuDashboard.Padding = new Padding(4, 10, 4, 10);
            menuDashboard.Size = new Size(199, 47);
            menuDashboard.Text = "- Dashboard";
            menuDashboard.TextAlign = ContentAlignment.MiddleLeft;
            menuDashboard.Click += MenuDashboard_Click;
            // 
            // menuItem
            // 
            menuItem.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            menuItem.ForeColor = Color.White;
            menuItem.Name = "menuItem";
            menuItem.Padding = new Padding(4, 10, 4, 10);
            menuItem.Size = new Size(199, 47);
            menuItem.Text = "- Items";
            menuItem.TextAlign = ContentAlignment.MiddleLeft;
            menuItem.Click += MenuItem_Click;
            // 
            // menuPurchaseItem
            // 
            menuPurchaseItem.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuPurchaseItem.ForeColor = Color.White;
            menuPurchaseItem.ImageAlign = ContentAlignment.TopCenter;
            menuPurchaseItem.Margin = new Padding(10, 0, 0, 0);
            menuPurchaseItem.Name = "menuPurchaseItem";
            menuPurchaseItem.Padding = new Padding(4, 6, 4, 6);
            menuPurchaseItem.Size = new Size(189, 35);
            menuPurchaseItem.Text = "- Purchase Item";
            menuPurchaseItem.TextAlign = ContentAlignment.MiddleLeft;
            menuPurchaseItem.Click += MenuPurchaseItem_Click;
            // 
            // menuItemCategory
            // 
            menuItemCategory.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemCategory.ForeColor = Color.White;
            menuItemCategory.Margin = new Padding(10, 0, 0, 0);
            menuItemCategory.Name = "menuItemCategory";
            menuItemCategory.Padding = new Padding(4, 6, 4, 6);
            menuItemCategory.Size = new Size(189, 35);
            menuItemCategory.Text = "- Item Categories";
            menuItemCategory.TextAlign = ContentAlignment.MiddleLeft;
            menuItemCategory.Click += MenuItemCategory_Click;
            // 
            // menuItemType
            // 
            menuItemType.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemType.ForeColor = Color.White;
            menuItemType.Margin = new Padding(10, 0, 0, 0);
            menuItemType.Name = "menuItemType";
            menuItemType.Padding = new Padding(4, 6, 4, 6);
            menuItemType.Size = new Size(189, 35);
            menuItemType.Text = "- Item Types";
            menuItemType.TextAlign = ContentAlignment.MiddleLeft;
            menuItemType.Click += MenuItemType_Click;
            // 
            // menuItemSetup
            // 
            menuItemSetup.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuItemSetup.ForeColor = Color.White;
            menuItemSetup.Margin = new Padding(10, 0, 0, 0);
            menuItemSetup.Name = "menuItemSetup";
            menuItemSetup.Padding = new Padding(4, 6, 4, 6);
            menuItemSetup.Size = new Size(189, 35);
            menuItemSetup.Text = "- Item Setup";
            menuItemSetup.TextAlign = ContentAlignment.MiddleLeft;
            menuItemSetup.Click += MenuItemSetup_Click;
            // 
            // menuUser
            // 
            menuUser.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            menuUser.ForeColor = Color.White;
            menuUser.Name = "menuUser";
            menuUser.Padding = new Padding(4, 10, 4, 10);
            menuUser.Size = new Size(199, 47);
            menuUser.Text = "- Users";
            menuUser.TextAlign = ContentAlignment.MiddleLeft;
            menuUser.Click += MenuUser_Click;
            // 
            // menuCreatePurchase
            // 
            menuCreatePurchase.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            menuCreatePurchase.ForeColor = Color.White;
            menuCreatePurchase.Name = "menuCreatePurchase";
            menuCreatePurchase.Padding = new Padding(4, 10, 4, 10);
            menuCreatePurchase.Size = new Size(199, 47);
            menuCreatePurchase.Text = "- Create Purchase";
            menuCreatePurchase.TextAlign = ContentAlignment.MiddleLeft;
            menuCreatePurchase.Click += MenuCreatePurchase_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 95);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(122, 22);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(122, 22);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(122, 22);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(122, 22);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(130, 22);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(130, 22);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(144, 22);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(144, 22);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(144, 22);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(144, 22);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(144, 22);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(144, 22);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(180, 22);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(180, 22);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(180, 22);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(180, 22);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // userPropPanel
            // 
            userPropPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userPropPanel.BackColor = Color.FromArgb(52, 53, 65);
            userPropPanel.Controls.Add(logoutButton);
            userPropPanel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            userPropPanel.ForeColor = Color.White;
            userPropPanel.Location = new Point(1110, 47);
            userPropPanel.Name = "userPropPanel";
            userPropPanel.Size = new Size(250, 44);
            userPropPanel.TabIndex = 8;
            userPropPanel.Visible = false;
            // 
            // logoutButton
            // 
            logoutButton.Cursor = Cursors.Hand;
            logoutButton.Dock = DockStyle.Fill;
            logoutButton.FlatAppearance.BorderColor = Color.FromArgb(119, 120, 128);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutButton.Location = new Point(0, 0);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(250, 44);
            logoutButton.TabIndex = 1;
            logoutButton.TabStop = false;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += LogoutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1360, 749);
            Controls.Add(userPropPanel);
            Controls.Add(sidePanel);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = navbar;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            panel1.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            userPropPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Panel topPanel;
        private Label pageTitleLabel;
        private Panel sidePanel;
        private Panel navPanel;
        private MenuStrip navbar;
        private ToolStripMenuItem menuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem menuItemType;
        private ToolStripMenuItem menuItemCategory;
        private ToolStripMenuItem menuDashboard;
        private ToolStripMenuItem menuUser;
        private Panel panel1;
        private Button userButton;
        private Button focusButton;
        private Panel userPropPanel;
        private Button logoutButton;
        private Label superAdminLabel;
        private ToolStripMenuItem menuItemSetup;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ToolStripMenuItem menuPurchaseItem;
        private ToolStripMenuItem menuCreatePurchase;
    }
}