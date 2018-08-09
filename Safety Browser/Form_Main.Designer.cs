﻿namespace Safety_Browser
{
    partial class Form_Main
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_browser = new System.Windows.Forms.Panel();
            this.label_separator = new System.Windows.Forms.Label();
            this.domain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_domain = new System.Windows.Forms.DataGridView();
            this.timer_timeout = new System.Windows.Forms.Timer(this.components);
            this.label_loadingstate = new System.Windows.Forms.Label();
            this.label_timeout_count = new System.Windows.Forms.Label();
            this.label_current_web_service = new System.Windows.Forms.Label();
            this.label_current_domain_service = new System.Windows.Forms.Label();
            this.timer_detectnotloading = new System.Windows.Forms.Timer(this.components);
            this.label_detectnotloading = new System.Windows.Forms.Label();
            this.label_get = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_connection = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_loader = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_domain)).BeginInit();
            this.panel_connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1254, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeyDisplayString = "E";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.editToolStripMenuItem.Text = "File";
            // 
            // panel_browser
            // 
            this.panel_browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_browser.Location = new System.Drawing.Point(0, 27);
            this.panel_browser.Name = "panel_browser";
            this.panel_browser.Size = new System.Drawing.Size(1005, 698);
            this.panel_browser.TabIndex = 1;
            this.panel_browser.TabStop = true;
            // 
            // label_separator
            // 
            this.label_separator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.label_separator.Location = new System.Drawing.Point(-4, 22);
            this.label_separator.Name = "label_separator";
            this.label_separator.Size = new System.Drawing.Size(1266, 1);
            this.label_separator.TabIndex = 19;
            this.label_separator.Text = " ";
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
            this.dataGridView_domain.Location = new System.Drawing.Point(1042, 28);
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
            this.dataGridView_domain.SelectionChanged += new System.EventHandler(this.dataGridView_domain_SelectionChanged);
            // 
            // timer_timeout
            // 
            this.timer_timeout.Interval = 1000;
            this.timer_timeout.Tick += new System.EventHandler(this.timer_timeout_Tick);
            // 
            // label_loadingstate
            // 
            this.label_loadingstate.AutoSize = true;
            this.label_loadingstate.Location = new System.Drawing.Point(1040, 312);
            this.label_loadingstate.Name = "label_loadingstate";
            this.label_loadingstate.Size = new System.Drawing.Size(64, 13);
            this.label_loadingstate.TabIndex = 21;
            this.label_loadingstate.Text = "loadingstate";
            this.label_loadingstate.TextChanged += new System.EventHandler(this.label_loadingstate_TextChanged);
            // 
            // label_timeout_count
            // 
            this.label_timeout_count.AutoSize = true;
            this.label_timeout_count.Location = new System.Drawing.Point(1040, 331);
            this.label_timeout_count.Name = "label_timeout_count";
            this.label_timeout_count.Size = new System.Drawing.Size(74, 13);
            this.label_timeout_count.TabIndex = 22;
            this.label_timeout_count.Text = "timeout_count";
            // 
            // label_current_web_service
            // 
            this.label_current_web_service.AutoSize = true;
            this.label_current_web_service.Location = new System.Drawing.Point(1040, 350);
            this.label_current_web_service.Name = "label_current_web_service";
            this.label_current_web_service.Size = new System.Drawing.Size(106, 13);
            this.label_current_web_service.TabIndex = 27;
            this.label_current_web_service.Text = "current_web_service";
            // 
            // label_current_domain_service
            // 
            this.label_current_domain_service.AutoSize = true;
            this.label_current_domain_service.Location = new System.Drawing.Point(1040, 367);
            this.label_current_domain_service.Name = "label_current_domain_service";
            this.label_current_domain_service.Size = new System.Drawing.Size(120, 13);
            this.label_current_domain_service.TabIndex = 28;
            this.label_current_domain_service.Text = "current_domain_service";
            // 
            // timer_detectnotloading
            // 
            this.timer_detectnotloading.Interval = 1000;
            this.timer_detectnotloading.Tick += new System.EventHandler(this.timer_detectnotloading_Tick);
            // 
            // label_detectnotloading
            // 
            this.label_detectnotloading.AutoSize = true;
            this.label_detectnotloading.Location = new System.Drawing.Point(1040, 386);
            this.label_detectnotloading.Name = "label_detectnotloading";
            this.label_detectnotloading.Size = new System.Drawing.Size(98, 13);
            this.label_detectnotloading.TabIndex = 30;
            this.label_detectnotloading.Text = "detect_not_loading";
            // 
            // label_get
            // 
            this.label_get.AutoSize = true;
            this.label_get.Location = new System.Drawing.Point(1040, 405);
            this.label_get.Name = "label_get";
            this.label_get.Size = new System.Drawing.Size(0, 13);
            this.label_get.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(111, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Trying to reconnect...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "No Internet connection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_connection
            // 
            this.panel_connection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_connection.Controls.Add(this.pictureBox1);
            this.panel_connection.Controls.Add(this.label1);
            this.panel_connection.Controls.Add(this.label8);
            this.panel_connection.Location = new System.Drawing.Point(1043, 477);
            this.panel_connection.Name = "panel_connection";
            this.panel_connection.Size = new System.Drawing.Size(335, 289);
            this.panel_connection.TabIndex = 35;
            this.panel_connection.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Safety_Browser.Properties.Resources.connection;
            this.pictureBox1.Location = new System.Drawing.Point(79, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox_loader
            // 
            this.pictureBox_loader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_loader.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_loader.ErrorImage = null;
            this.pictureBox_loader.Image = global::Safety_Browser.Properties.Resources.loader;
            this.pictureBox_loader.Location = new System.Drawing.Point(495, 230);
            this.pictureBox_loader.Name = "pictureBox_loader";
            this.pictureBox_loader.Size = new System.Drawing.Size(265, 265);
            this.pictureBox_loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_loader.TabIndex = 32;
            this.pictureBox_loader.TabStop = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Safety_Browser.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 725);
            this.Controls.Add(this.panel_connection);
            this.Controls.Add(this.pictureBox_loader);
            this.Controls.Add(this.panel_browser);
            this.Controls.Add(this.label_separator);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.label_get);
            this.Controls.Add(this.label_current_domain_service);
            this.Controls.Add(this.label_current_web_service);
            this.Controls.Add(this.label_timeout_count);
            this.Controls.Add(this.label_loadingstate);
            this.Controls.Add(this.dataGridView_domain);
            this.Controls.Add(this.label_detectnotloading);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1270, 764);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_domain)).EndInit();
            this.panel_connection.ResumeLayout(false);
            this.panel_connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel_browser;
        private System.Windows.Forms.Label label_separator;
        private System.Windows.Forms.DataGridViewTextBoxColumn domain;
        private System.Windows.Forms.DataGridView dataGridView_domain;
        private System.Windows.Forms.Timer timer_timeout;
        private System.Windows.Forms.Label label_loadingstate;
        private System.Windows.Forms.Label label_timeout_count;
        private System.Windows.Forms.Label label_current_web_service;
        private System.Windows.Forms.Label label_current_domain_service;
        private System.Windows.Forms.Timer timer_detectnotloading;
        private System.Windows.Forms.Label label_detectnotloading;
        private System.Windows.Forms.Label label_get;
        private System.Windows.Forms.PictureBox pictureBox_loader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_connection;
    }
}

