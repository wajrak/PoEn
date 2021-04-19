
namespace PoEn
{
    partial class Form1
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
            this.lblInstallationPath = new System.Windows.Forms.Label();
            this.txtInstallationPath = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PossitionTop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PossitionLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Additional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStartThread = new System.Windows.Forms.Button();
            this.chkOptionsList = new System.Windows.Forms.CheckedListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStopThread = new System.Windows.Forms.Button();
            this.chkIgnoreHistoricalData = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportABugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projectWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.cmbGameMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDisplayLimiter = new System.Windows.Forms.ComboBox();
            this.cmbAlarm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkFlashWindow = new System.Windows.Forms.CheckBox();
            this.cmbTabSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDeviceToken = new System.Windows.Forms.Label();
            this.txtDeviceToken = new System.Windows.Forms.TextBox();
            this.lblLimitDisplay = new System.Windows.Forms.Label();
            this.chkStashLocation = new System.Windows.Forms.CheckBox();
            this.chkDoubleBuffered = new System.Windows.Forms.CheckBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.lblSSID = new System.Windows.Forms.Label();
            this.chkPlaySound = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstallationPath
            // 
            this.lblInstallationPath.AutoSize = true;
            this.lblInstallationPath.Location = new System.Drawing.Point(12, 33);
            this.lblInstallationPath.Name = "lblInstallationPath";
            this.lblInstallationPath.Size = new System.Drawing.Size(112, 17);
            this.lblInstallationPath.TabIndex = 1;
            this.lblInstallationPath.Text = "Installation Path:";
            // 
            // txtInstallationPath
            // 
            this.txtInstallationPath.Location = new System.Drawing.Point(130, 31);
            this.txtInstallationPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInstallationPath.Name = "txtInstallationPath";
            this.txtInstallationPath.Size = new System.Drawing.Size(268, 22);
            this.txtInstallationPath.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(686, 251);
            this.btnTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(171, 40);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Read Client Data";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Date,
            this.Type,
            this.Price,
            this.Item,
            this.PossitionTop,
            this.PossitionLeft,
            this.Currency,
            this.Additional});
            this.dgvMain.Location = new System.Drawing.Point(15, 296);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(842, 285);
            this.dgvMain.TabIndex = 4;
            this.dgvMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 30;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 50;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 6;
            this.Item.Name = "Item";
            this.Item.Width = 200;
            // 
            // PossitionTop
            // 
            this.PossitionTop.HeaderText = "P. Top";
            this.PossitionTop.MinimumWidth = 6;
            this.PossitionTop.Name = "PossitionTop";
            this.PossitionTop.Width = 40;
            // 
            // PossitionLeft
            // 
            this.PossitionLeft.HeaderText = "P. Left";
            this.PossitionLeft.MinimumWidth = 6;
            this.PossitionLeft.Name = "PossitionLeft";
            this.PossitionLeft.Width = 40;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.MinimumWidth = 6;
            this.Currency.Name = "Currency";
            this.Currency.Width = 125;
            // 
            // Additional
            // 
            this.Additional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Additional.HeaderText = "Additional";
            this.Additional.MinimumWidth = 6;
            this.Additional.Name = "Additional";
            // 
            // btnStartThread
            // 
            this.btnStartThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStartThread.Location = new System.Drawing.Point(15, 259);
            this.btnStartThread.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(111, 32);
            this.btnStartThread.TabIndex = 5;
            this.btnStartThread.Text = "Start Thread";
            this.btnStartThread.UseVisualStyleBackColor = true;
            this.btnStartThread.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkOptionsList
            // 
            this.chkOptionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOptionsList.CheckOnClick = true;
            this.chkOptionsList.FormattingEnabled = true;
            this.chkOptionsList.Items.AddRange(new object[] {
            "Trade Requests",
            "Incoming Messages",
            "Outgoing Messages",
            "Vulkan Messages",
            "Startup Messages",
            "Device Messages",
            "Location Messages",
            "Connection Messages",
            "Slain Counter"});
            this.chkOptionsList.Location = new System.Drawing.Point(686, 31);
            this.chkOptionsList.Name = "chkOptionsList";
            this.chkOptionsList.Size = new System.Drawing.Size(171, 208);
            this.chkOptionsList.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.Filter = "Client.txt";
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.NotifyFilter = System.IO.NotifyFilters.Size;
            this.fileSystemWatcher1.SynchronizingObject = this;
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(626, 259);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnStopThread
            // 
            this.btnStopThread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopThread.Location = new System.Drawing.Point(132, 259);
            this.btnStopThread.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopThread.Name = "btnStopThread";
            this.btnStopThread.Size = new System.Drawing.Size(111, 32);
            this.btnStopThread.TabIndex = 9;
            this.btnStopThread.Text = "Stop Thread";
            this.btnStopThread.UseVisualStyleBackColor = true;
            this.btnStopThread.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkIgnoreHistoricalData
            // 
            this.chkIgnoreHistoricalData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIgnoreHistoricalData.AutoSize = true;
            this.chkIgnoreHistoricalData.Checked = true;
            this.chkIgnoreHistoricalData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreHistoricalData.Location = new System.Drawing.Point(503, 96);
            this.chkIgnoreHistoricalData.Name = "chkIgnoreHistoricalData";
            this.chkIgnoreHistoricalData.Size = new System.Drawing.Size(166, 21);
            this.chkIgnoreHistoricalData.TabIndex = 10;
            this.chkIgnoreHistoricalData.Text = "Ignore Historical Data";
            this.chkIgnoreHistoricalData.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(566, 259);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Test2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.CheckedChanged += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_CheckedChanged);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportABugToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.projectWebsiteToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // reportABugToolStripMenuItem
            // 
            this.reportABugToolStripMenuItem.Name = "reportABugToolStripMenuItem";
            this.reportABugToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.reportABugToolStripMenuItem.Text = "Report bug";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(195, 26);
            this.aboutToolStripMenuItem1.Text = "Donate";
            // 
            // projectWebsiteToolStripMenuItem
            // 
            this.projectWebsiteToolStripMenuItem.Name = "projectWebsiteToolStripMenuItem";
            this.projectWebsiteToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.projectWebsiteToolStripMenuItem.Text = "Project Website";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(404, 30);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(73, 23);
            this.btnSelectFile.TabIndex = 13;
            this.btnSelectFile.Text = "Browse";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // cmbGameMode
            // 
            this.cmbGameMode.FormattingEnabled = true;
            this.cmbGameMode.Items.AddRange(new object[] {
            "Ritual",
            "Standard"});
            this.cmbGameMode.Location = new System.Drawing.Point(130, 168);
            this.cmbGameMode.Name = "cmbGameMode";
            this.cmbGameMode.Size = new System.Drawing.Size(121, 24);
            this.cmbGameMode.TabIndex = 14;
            this.cmbGameMode.Text = "Ritual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Game Mode:";
            // 
            // cmbDisplayLimiter
            // 
            this.cmbDisplayLimiter.FormattingEnabled = true;
            this.cmbDisplayLimiter.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25"});
            this.cmbDisplayLimiter.Location = new System.Drawing.Point(130, 226);
            this.cmbDisplayLimiter.Name = "cmbDisplayLimiter";
            this.cmbDisplayLimiter.Size = new System.Drawing.Size(50, 24);
            this.cmbDisplayLimiter.TabIndex = 16;
            this.cmbDisplayLimiter.Text = "5";
            // 
            // cmbAlarm
            // 
            this.cmbAlarm.FormattingEnabled = true;
            this.cmbAlarm.Items.AddRange(new object[] {
            "beep-01",
            "Beep-02",
            "Beep-03",
            "Beep-04",
            "Beep-05"});
            this.cmbAlarm.Location = new System.Drawing.Point(130, 197);
            this.cmbAlarm.Name = "cmbAlarm";
            this.cmbAlarm.Size = new System.Drawing.Size(121, 24);
            this.cmbAlarm.TabIndex = 17;
            this.cmbAlarm.Text = "beep-01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alarm:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(257, 200);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 17);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Play";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(503, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 21);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Mobile Notification";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkFlashWindow
            // 
            this.chkFlashWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFlashWindow.AutoSize = true;
            this.chkFlashWindow.Location = new System.Drawing.Point(503, 42);
            this.chkFlashWindow.Name = "chkFlashWindow";
            this.chkFlashWindow.Size = new System.Drawing.Size(117, 21);
            this.chkFlashWindow.TabIndex = 21;
            this.chkFlashWindow.Text = "Flash Window";
            this.chkFlashWindow.UseVisualStyleBackColor = true;
            // 
            // cmbTabSize
            // 
            this.cmbTabSize.FormattingEnabled = true;
            this.cmbTabSize.Items.AddRange(new object[] {
            "Normal",
            "Quad"});
            this.cmbTabSize.Location = new System.Drawing.Point(130, 139);
            this.cmbTabSize.Name = "cmbTabSize";
            this.cmbTabSize.Size = new System.Drawing.Size(121, 24);
            this.cmbTabSize.TabIndex = 22;
            this.cmbTabSize.Text = "Normal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tab Size:";
            // 
            // lblDeviceToken
            // 
            this.lblDeviceToken.AutoSize = true;
            this.lblDeviceToken.Location = new System.Drawing.Point(12, 60);
            this.lblDeviceToken.Name = "lblDeviceToken";
            this.lblDeviceToken.Size = new System.Drawing.Size(99, 17);
            this.lblDeviceToken.TabIndex = 24;
            this.lblDeviceToken.Text = "Device Token:";
            // 
            // txtDeviceToken
            // 
            this.txtDeviceToken.Location = new System.Drawing.Point(130, 58);
            this.txtDeviceToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDeviceToken.Name = "txtDeviceToken";
            this.txtDeviceToken.Size = new System.Drawing.Size(268, 22);
            this.txtDeviceToken.TabIndex = 25;
            // 
            // lblLimitDisplay
            // 
            this.lblLimitDisplay.AutoSize = true;
            this.lblLimitDisplay.Location = new System.Drawing.Point(12, 232);
            this.lblLimitDisplay.Name = "lblLimitDisplay";
            this.lblLimitDisplay.Size = new System.Drawing.Size(90, 17);
            this.lblLimitDisplay.TabIndex = 26;
            this.lblLimitDisplay.Text = "Limit rows to:";
            // 
            // chkStashLocation
            // 
            this.chkStashLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStashLocation.AutoSize = true;
            this.chkStashLocation.Location = new System.Drawing.Point(503, 123);
            this.chkStashLocation.Name = "chkStashLocation";
            this.chkStashLocation.Size = new System.Drawing.Size(173, 21);
            this.chkStashLocation.TabIndex = 27;
            this.chkStashLocation.Text = "Show In-Stash location";
            this.chkStashLocation.UseVisualStyleBackColor = true;
            // 
            // chkDoubleBuffered
            // 
            this.chkDoubleBuffered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDoubleBuffered.AutoSize = true;
            this.chkDoubleBuffered.Location = new System.Drawing.Point(503, 150);
            this.chkDoubleBuffered.Name = "chkDoubleBuffered";
            this.chkDoubleBuffered.Size = new System.Drawing.Size(163, 21);
            this.chkDoubleBuffered.TabIndex = 28;
            this.chkDoubleBuffered.Text = "Doule buffer for DGV";
            this.chkDoubleBuffered.UseVisualStyleBackColor = true;
            this.chkDoubleBuffered.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(12, 87);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(104, 17);
            this.lblAccountName.TabIndex = 29;
            this.lblAccountName.Text = "Account Name:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(130, 85);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(268, 22);
            this.txtAccountName.TabIndex = 30;
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(130, 112);
            this.txtSSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(268, 22);
            this.txtSSID.TabIndex = 32;
            // 
            // lblSSID
            // 
            this.lblSSID.AutoSize = true;
            this.lblSSID.Location = new System.Drawing.Point(12, 114);
            this.lblSSID.Name = "lblSSID";
            this.lblSSID.Size = new System.Drawing.Size(43, 17);
            this.lblSSID.TabIndex = 31;
            this.lblSSID.Text = "SSID:";
            // 
            // chkPlaySound
            // 
            this.chkPlaySound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPlaySound.AutoSize = true;
            this.chkPlaySound.Checked = true;
            this.chkPlaySound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlaySound.Location = new System.Drawing.Point(503, 177);
            this.chkPlaySound.Name = "chkPlaySound";
            this.chkPlaySound.Size = new System.Drawing.Size(102, 21);
            this.chkPlaySound.TabIndex = 33;
            this.chkPlaySound.Text = "Play Sound";
            this.chkPlaySound.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 610);
            this.Controls.Add(this.chkPlaySound);
            this.Controls.Add(this.txtSSID);
            this.Controls.Add(this.lblSSID);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.chkDoubleBuffered);
            this.Controls.Add(this.chkStashLocation);
            this.Controls.Add(this.lblLimitDisplay);
            this.Controls.Add(this.txtDeviceToken);
            this.Controls.Add(this.lblDeviceToken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTabSize);
            this.Controls.Add(this.chkFlashWindow);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAlarm);
            this.Controls.Add(this.cmbDisplayLimiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGameMode);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chkIgnoreHistoricalData);
            this.Controls.Add(this.btnStopThread);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chkOptionsList);
            this.Controls.Add(this.btnStartThread);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtInstallationPath);
            this.Controls.Add(this.lblInstallationPath);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wajrak\'s Path Of Exile Notifications (PoEn)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInstallationPath;
        private System.Windows.Forms.TextBox txtInstallationPath;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button btnStartThread;
        private System.Windows.Forms.CheckedListBox chkOptionsList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStopThread;
        private System.Windows.Forms.CheckBox chkIgnoreHistoricalData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportABugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGameMode;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbDisplayLimiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAlarm;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkFlashWindow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem projectWebsiteToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTabSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn PossitionTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn PossitionLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Additional;
        private System.Windows.Forms.TextBox txtDeviceToken;
        private System.Windows.Forms.Label lblDeviceToken;
        private System.Windows.Forms.Label lblLimitDisplay;
        private System.Windows.Forms.CheckBox chkStashLocation;
        private System.Windows.Forms.CheckBox chkDoubleBuffered;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.Label lblSSID;
        private System.Windows.Forms.CheckBox chkPlaySound;
    }
}

