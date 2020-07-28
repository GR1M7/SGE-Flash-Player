namespace SGE.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_ClearCache = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_HowToUse = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_About = new System.Windows.Forms.ToolStripMenuItem();
            this.SWF_Player = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SWF_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(784, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Open,
            this.BTN_Close,
            this.toolStripSeparator1,
            this.BTN_ClearCache});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // BTN_Open
            // 
            this.BTN_Open.Name = "BTN_Open";
            this.BTN_Open.Size = new System.Drawing.Size(171, 22);
            this.BTN_Open.Text = "Open";
            this.BTN_Open.Click += new System.EventHandler(this.BTN_Open_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(171, 22);
            this.BTN_Close.Text = "Close";
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // BTN_ClearCache
            // 
            this.BTN_ClearCache.Name = "BTN_ClearCache";
            this.BTN_ClearCache.Size = new System.Drawing.Size(180, 22);
            this.BTN_ClearCache.Text = "Clear all SWF cache";
            this.BTN_ClearCache.Click += new System.EventHandler(this.BTN_ClearCache_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_HowToUse,
            this.BTN_About});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // BTN_HowToUse
            // 
            this.BTN_HowToUse.Name = "BTN_HowToUse";
            this.BTN_HowToUse.Size = new System.Drawing.Size(134, 22);
            this.BTN_HowToUse.Text = "How to use";
            this.BTN_HowToUse.Click += new System.EventHandler(this.BTN_HowToUse_Click);
            // 
            // BTN_About
            // 
            this.BTN_About.Name = "BTN_About";
            this.BTN_About.Size = new System.Drawing.Size(134, 22);
            this.BTN_About.Text = "About";
            this.BTN_About.Click += new System.EventHandler(this.BTN_About_Click);
            // 
            // SWF_Player
            // 
            this.SWF_Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SWF_Player.Enabled = true;
            this.SWF_Player.Location = new System.Drawing.Point(0, 24);
            this.SWF_Player.Name = "SWF_Player";
            this.SWF_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SWF_Player.OcxState")));
            this.SWF_Player.Size = new System.Drawing.Size(784, 537);
            this.SWF_Player.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.SWF_Player);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGE Flash Player";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SWF_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BTN_Open;
        private System.Windows.Forms.ToolStripMenuItem BTN_Close;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BTN_ClearCache;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BTN_HowToUse;
        private System.Windows.Forms.ToolStripMenuItem BTN_About;
        private AxShockwaveFlashObjects.AxShockwaveFlash SWF_Player;
    }
}