namespace Parking
{
    partial class frmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.CarInMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CarOutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewData = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCarIn = new System.Windows.Forms.Button();
            this.btnCarOut = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AllowMerge = false;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarInMenu,
            this.CarOutMenu,
            this.ViewData,
            this.reportMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(745, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // CarInMenu
            // 
            this.CarInMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.CarInMenu.Name = "CarInMenu";
            this.CarInMenu.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.CarInMenu.Size = new System.Drawing.Size(46, 20);
            this.CarInMenu.Text = "รถเข้า";
            this.CarInMenu.Click += new System.EventHandler(this.CarInMenu_Click);
            // 
            // CarOutMenu
            // 
            this.CarOutMenu.Name = "CarOutMenu";
            this.CarOutMenu.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.CarOutMenu.Size = new System.Drawing.Size(50, 20);
            this.CarOutMenu.Text = "รถออก";
            this.CarOutMenu.Click += new System.EventHandler(this.CarInMenu_Click);
            // 
            // ViewData
            // 
            this.ViewData.Name = "ViewData";
            this.ViewData.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.ViewData.Size = new System.Drawing.Size(52, 20);
            this.ViewData.Text = "ดูข้อมูล";
            this.ViewData.Click += new System.EventHandler(this.CarInMenu_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.reportMenu.Size = new System.Drawing.Size(52, 20);
            this.reportMenu.Text = "รายงาน";
            this.reportMenu.Click += new System.EventHandler(this.CarInMenu_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(745, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // btnCarIn
            // 
            this.btnCarIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarIn.Location = new System.Drawing.Point(117, 83);
            this.btnCarIn.Name = "btnCarIn";
            this.btnCarIn.Size = new System.Drawing.Size(187, 93);
            this.btnCarIn.TabIndex = 4;
            this.btnCarIn.Text = "รถเข้า";
            this.btnCarIn.UseVisualStyleBackColor = true;
            this.btnCarIn.Click += new System.EventHandler(this.btnCarIn_Click);
            // 
            // btnCarOut
            // 
            this.btnCarOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCarOut.Location = new System.Drawing.Point(427, 83);
            this.btnCarOut.Name = "btnCarOut";
            this.btnCarOut.Size = new System.Drawing.Size(187, 93);
            this.btnCarOut.TabIndex = 5;
            this.btnCarOut.Text = "รถออก";
            this.btnCarOut.UseVisualStyleBackColor = true;
            this.btnCarOut.Click += new System.EventHandler(this.btnCarIn_Click);
            // 
            // btnView
            // 
            this.btnView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnView.Location = new System.Drawing.Point(117, 227);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(187, 93);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "ดูข้อมูล";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnCarIn_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReport.Location = new System.Drawing.Point(427, 227);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(187, 93);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "รายงาน";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnCarIn_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(745, 453);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCarOut);
            this.Controls.Add(this.btnCarIn);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem CarInMenu;
        private System.Windows.Forms.ToolStripMenuItem reportMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem CarOutMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewData;
        private System.Windows.Forms.Button btnCarOut;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCarIn;
    }
}



