namespace minTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.macquarieToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.lblMacqFTPStatusAnswer = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.niSysTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.sMTPCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(308, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolsToolStripMenuItem,
            this.macquarieToolsToolStripMenuItem,
            this.sMTPCheckerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // folderToolsToolStripMenuItem
            // 
            this.folderToolsToolStripMenuItem.Name = "folderToolsToolStripMenuItem";
            this.folderToolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.folderToolsToolStripMenuItem.Text = "Folder Tools";
            this.folderToolsToolStripMenuItem.Click += new System.EventHandler(this.folderToolsToolStripMenuItem_Click);
            // 
            // macquarieToolsToolStripMenuItem
            // 
            this.macquarieToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fTPCheckerToolStripMenuItem});
            this.macquarieToolsToolStripMenuItem.Name = "macquarieToolsToolStripMenuItem";
            this.macquarieToolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.macquarieToolsToolStripMenuItem.Text = "Macquarie Tools";
            // 
            // fTPCheckerToolStripMenuItem
            // 
            this.fTPCheckerToolStripMenuItem.Name = "fTPCheckerToolStripMenuItem";
            this.fTPCheckerToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fTPCheckerToolStripMenuItem.Text = "FTP Checker";
            this.fTPCheckerToolStripMenuItem.Click += new System.EventHandler(this.fTPCheckerToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.lblMacqFTPStatusAnswer,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(308, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Macquarie";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lblMacqFTPStatusAnswer
            // 
            this.lblMacqFTPStatusAnswer.Name = "lblMacqFTPStatusAnswer";
            this.lblMacqFTPStatusAnswer.Size = new System.Drawing.Size(66, 22);
            this.lblMacqFTPStatusAnswer.Text = "Checking...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 85);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(308, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusMain
            // 
            this.lblStatusMain.Name = "lblStatusMain";
            this.lblStatusMain.Size = new System.Drawing.Size(79, 17);
            this.lblStatusMain.Text = "lblStatusMain";
            // 
            // niSysTray
            // 
            this.niSysTray.Text = "niSysTray";
            this.niSysTray.Visible = true;
            this.niSysTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // sMTPCheckerToolStripMenuItem
            // 
            this.sMTPCheckerToolStripMenuItem.Name = "sMTPCheckerToolStripMenuItem";
            this.sMTPCheckerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sMTPCheckerToolStripMenuItem.Text = "SMTP Checker";
            this.sMTPCheckerToolStripMenuItem.Click += new System.EventHandler(this.sMTPCheckerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 107);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "minTools";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem macquarieToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPCheckerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel lblMacqFTPStatusAnswer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMain;
        private System.Windows.Forms.NotifyIcon niSysTray;
        private System.Windows.Forms.ToolStripMenuItem sMTPCheckerToolStripMenuItem;
    }
}

