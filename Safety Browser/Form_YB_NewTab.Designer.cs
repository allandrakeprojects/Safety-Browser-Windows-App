﻿namespace Safety_Browser
{
    partial class Form_YB_NewTab
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_YB_NewTab));
            this.domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_domain = new System.Windows.Forms.DataGridView();
            this.label_current_web_service = new System.Windows.Forms.Label();
            this.label_current_domain_service = new System.Windows.Forms.Label();
            this.timer_handler = new System.Windows.Forms.Timer(this.components);
            this.panel_connection = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_loadingstate = new System.Windows.Forms.Label();
            this.label_titlebar = new System.Windows.Forms.Label();
            this.webBrowser_handler = new System.Windows.Forms.WebBrowser();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_hover = new System.Windows.Forms.PictureBox();
            this.pictureBox_loader = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.panel_cefsharp = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanAndReloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_version = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_menu = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_domain)).BeginInit();
            this.panel_connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // domain
            // 
            this.domain.HeaderText = "Domain";
            this.domain.Name = "domain";
            this.domain.ReadOnly = true;
            // 
            // dataGridView_domain
            // 
            this.dataGridView_domain.AllowUserToAddRows = false;
            this.dataGridView_domain.AllowUserToDeleteRows = false;
            this.dataGridView_domain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.dataGridView_domain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_domain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_domain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_domain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_domain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_domain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_domain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_domain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domain});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_domain.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_domain.Location = new System.Drawing.Point(1292, 46);
            this.dataGridView_domain.MultiSelect = false;
            this.dataGridView_domain.Name = "dataGridView_domain";
            this.dataGridView_domain.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_domain.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_domain.RowHeadersVisible = false;
            this.dataGridView_domain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_domain.Size = new System.Drawing.Size(196, 276);
            this.dataGridView_domain.TabIndex = 20;
            this.dataGridView_domain.TabStop = false;
            this.dataGridView_domain.SelectionChanged += new System.EventHandler(this.DataGridView_domain_SelectionChanged);
            // 
            // label_current_web_service
            // 
            this.label_current_web_service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_current_web_service.AutoSize = true;
            this.label_current_web_service.Location = new System.Drawing.Point(1290, 349);
            this.label_current_web_service.Name = "label_current_web_service";
            this.label_current_web_service.Size = new System.Drawing.Size(106, 13);
            this.label_current_web_service.TabIndex = 27;
            this.label_current_web_service.Text = "current_web_service";
            this.label_current_web_service.Visible = false;
            // 
            // label_current_domain_service
            // 
            this.label_current_domain_service.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_current_domain_service.AutoSize = true;
            this.label_current_domain_service.Location = new System.Drawing.Point(1290, 366);
            this.label_current_domain_service.Name = "label_current_domain_service";
            this.label_current_domain_service.Size = new System.Drawing.Size(120, 13);
            this.label_current_domain_service.TabIndex = 28;
            this.label_current_domain_service.Text = "current_domain_service";
            this.label_current_domain_service.Visible = false;
            // 
            // timer_handler
            // 
            this.timer_handler.Interval = 60000;
            this.timer_handler.Tick += new System.EventHandler(this.Timer_handler_Tick);
            // 
            // panel_connection
            // 
            this.panel_connection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_connection.Controls.Add(this.pictureBox1);
            this.panel_connection.Controls.Add(this.label1);
            this.panel_connection.Controls.Add(this.label8);
            this.panel_connection.Location = new System.Drawing.Point(961, 817);
            this.panel_connection.Name = "panel_connection";
            this.panel_connection.Size = new System.Drawing.Size(335, 289);
            this.panel_connection.TabIndex = 39;
            this.panel_connection.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(81, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "You\'re Offline";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(3, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Check you Internet connection.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_loadingstate
            // 
            this.label_loadingstate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_loadingstate.AutoSize = true;
            this.label_loadingstate.Location = new System.Drawing.Point(1290, 330);
            this.label_loadingstate.Name = "label_loadingstate";
            this.label_loadingstate.Size = new System.Drawing.Size(64, 13);
            this.label_loadingstate.TabIndex = 21;
            this.label_loadingstate.Text = "loadingstate";
            this.label_loadingstate.Visible = false;
            this.label_loadingstate.TextChanged += new System.EventHandler(this.Label_loadingstate_TextChanged);
            // 
            // label_titlebar
            // 
            this.label_titlebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(99)))), ((int)(((byte)(6)))));
            this.label_titlebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titlebar.ForeColor = System.Drawing.Color.White;
            this.label_titlebar.Location = new System.Drawing.Point(2, 1);
            this.label_titlebar.Name = "label_titlebar";
            this.label_titlebar.Size = new System.Drawing.Size(1267, 37);
            this.label_titlebar.TabIndex = 40;
            this.label_titlebar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_titlebar_MouseDown);
            // 
            // webBrowser_handler
            // 
            this.webBrowser_handler.AllowWebBrowserDrop = false;
            this.webBrowser_handler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser_handler.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser_handler.Location = new System.Drawing.Point(1306, 422);
            this.webBrowser_handler.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser_handler.Name = "webBrowser_handler";
            this.webBrowser_handler.ScriptErrorsSuppressed = true;
            this.webBrowser_handler.Size = new System.Drawing.Size(52, 51);
            this.webBrowser_handler.TabIndex = 37;
            this.webBrowser_handler.Visible = false;
            this.webBrowser_handler.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_handler_DocumentCompleted);
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(99)))), ((int)(((byte)(6)))));
            this.pictureBox_minimize.ErrorImage = null;
            this.pictureBox_minimize.Image = global::Safety_Browser.Properties.Resources.minimize;
            this.pictureBox_minimize.Location = new System.Drawing.Point(1140, 1);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Size = new System.Drawing.Size(43, 37);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_minimize.TabIndex = 43;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            this.pictureBox_minimize.MouseLeave += new System.EventHandler(this.pictureBox_minimize_MouseLeave);
            this.pictureBox_minimize.MouseHover += new System.EventHandler(this.pictureBox_minimize_MouseHover);
            // 
            // pictureBox_maximize
            // 
            this.pictureBox_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(99)))), ((int)(((byte)(6)))));
            this.pictureBox_maximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_maximize.Image")));
            this.pictureBox_maximize.Location = new System.Drawing.Point(1183, 1);
            this.pictureBox_maximize.Name = "pictureBox_maximize";
            this.pictureBox_maximize.Size = new System.Drawing.Size(43, 37);
            this.pictureBox_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_maximize.TabIndex = 42;
            this.pictureBox_maximize.TabStop = false;
            this.pictureBox_maximize.Click += new System.EventHandler(this.pictureBox_maximize_Click);
            this.pictureBox_maximize.MouseLeave += new System.EventHandler(this.pictureBox_maximize_MouseLeave);
            this.pictureBox_maximize.MouseHover += new System.EventHandler(this.pictureBox_maximize_MouseHover);
            // 
            // pictureBox_hover
            // 
            this.pictureBox_hover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(99)))), ((int)(((byte)(6)))));
            this.pictureBox_hover.Location = new System.Drawing.Point(1, 1);
            this.pictureBox_hover.Name = "pictureBox_hover";
            this.pictureBox_hover.Size = new System.Drawing.Size(58, 37);
            this.pictureBox_hover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_hover.TabIndex = 41;
            this.pictureBox_hover.TabStop = false;
            this.pictureBox_hover.Click += new System.EventHandler(this.pictureBox_hover_Click);
            this.pictureBox_hover.MouseLeave += new System.EventHandler(this.pictureBox_hover_MouseLeave);
            this.pictureBox_hover.MouseHover += new System.EventHandler(this.pictureBox_hover_MouseHover);
            // 
            // pictureBox_loader
            // 
            this.pictureBox_loader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_loader.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_loader.ErrorImage = null;
            this.pictureBox_loader.Image = global::Safety_Browser.Properties.Resources.loader;
            this.pictureBox_loader.Location = new System.Drawing.Point(503, 289);
            this.pictureBox_loader.Name = "pictureBox_loader";
            this.pictureBox_loader.Size = new System.Drawing.Size(265, 265);
            this.pictureBox_loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_loader.TabIndex = 38;
            this.pictureBox_loader.TabStop = false;
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(99)))), ((int)(((byte)(6)))));
            this.pictureBox_close.Image = global::Safety_Browser.Properties.Resources.close;
            this.pictureBox_close.Location = new System.Drawing.Point(1226, 1);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(43, 37);
            this.pictureBox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_close.TabIndex = 44;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            this.pictureBox_close.MouseLeave += new System.EventHandler(this.pictureBox_close_MouseLeave);
            this.pictureBox_close.MouseHover += new System.EventHandler(this.pictureBox_close_MouseHover);
            // 
            // panel_cefsharp
            // 
            this.panel_cefsharp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_cefsharp.Location = new System.Drawing.Point(1, 38);
            this.panel_cefsharp.Name = "panel_cefsharp";
            this.panel_cefsharp.Size = new System.Drawing.Size(1268, 725);
            this.panel_cefsharp.TabIndex = 48;
            this.panel_cefsharp.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(99)))), ((int)(((byte)(6)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(-5, 14);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(20, 24);
            this.menuStrip.TabIndex = 49;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.versionToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem,
            this.forwardToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.cleanAndReloadToolStripMenuItem,
            this.toolStripMenuItem1,
            this.resetZoomToolStripMenuItem,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.ShortcutKeyDisplayString = "Left Key";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.goBackToolStripMenuItem.Text = "Go back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.ShortcutKeyDisplayString = "Right Key";
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.forwardToolStripMenuItem.Text = "Forward";
            this.forwardToolStripMenuItem.Click += new System.EventHandler(this.forwardToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // cleanAndReloadToolStripMenuItem
            // 
            this.cleanAndReloadToolStripMenuItem.Name = "cleanAndReloadToolStripMenuItem";
            this.cleanAndReloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.cleanAndReloadToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.cleanAndReloadToolStripMenuItem.Text = "Clean and Reload";
            this.cleanAndReloadToolStripMenuItem.Click += new System.EventHandler(this.cleanAndReloadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(236, 6);
            // 
            // resetZoomToolStripMenuItem
            // 
            this.resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            this.resetZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.resetZoomToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.resetZoomToolStripMenuItem.Text = "Reset Zoom";
            this.resetZoomToolStripMenuItem.Click += new System.EventHandler(this.resetZoomToolStripMenuItem_Click);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl++";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom in";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+-";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_version});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // toolStripMenuItem_version
            // 
            this.toolStripMenuItem_version.Enabled = false;
            this.toolStripMenuItem_version.Name = "toolStripMenuItem_version";
            this.toolStripMenuItem_version.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem_version.Text = "0.0.1";
            // 
            // pictureBox_menu
            // 
            this.pictureBox_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(99)))), ((int)(((byte)(6)))));
            this.pictureBox_menu.Location = new System.Drawing.Point(16, 9);
            this.pictureBox_menu.Name = "pictureBox_menu";
            this.pictureBox_menu.Size = new System.Drawing.Size(29, 18);
            this.pictureBox_menu.TabIndex = 45;
            this.pictureBox_menu.TabStop = false;
            this.pictureBox_menu.Click += new System.EventHandler(this.pictureBox_menu_Click);
            this.pictureBox_menu.MouseLeave += new System.EventHandler(this.pictureBox_menu_MouseLeave);
            this.pictureBox_menu.MouseHover += new System.EventHandler(this.pictureBox_menu_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(790, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_YB_NewTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1270, 764);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox_menu);
            this.Controls.Add(this.pictureBox_hover);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.pictureBox_minimize);
            this.Controls.Add(this.pictureBox_maximize);
            this.Controls.Add(this.panel_connection);
            this.Controls.Add(this.pictureBox_loader);
            this.Controls.Add(this.label_current_domain_service);
            this.Controls.Add(this.label_current_web_service);
            this.Controls.Add(this.label_loadingstate);
            this.Controls.Add(this.dataGridView_domain);
            this.Controls.Add(this.webBrowser_handler);
            this.Controls.Add(this.panel_cefsharp);
            this.Controls.Add(this.label_titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1270, 764);
            this.Name = "Form_YB_NewTab";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_domain)).EndInit();
            this.panel_connection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_hover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn domain;
        private System.Windows.Forms.DataGridView dataGridView_domain;
        private System.Windows.Forms.Label label_current_web_service;
        private System.Windows.Forms.Label label_current_domain_service;
        private System.Windows.Forms.Timer timer_handler;
        private System.Windows.Forms.PictureBox pictureBox_loader;
        private System.Windows.Forms.Panel panel_connection;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_loadingstate;
        private System.Windows.Forms.Label label_titlebar;
        private System.Windows.Forms.PictureBox pictureBox_hover;
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.WebBrowser webBrowser_handler;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Panel panel_cefsharp;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cleanAndReloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_version;
        private System.Windows.Forms.PictureBox pictureBox_menu;
        private System.Windows.Forms.Button button1;
    }
}
