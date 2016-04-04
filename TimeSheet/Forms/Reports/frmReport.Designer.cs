namespace Parking.Forms.Reports
{
    partial class frmReport
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
            this.rptMain = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptMain
            // 
            this.rptMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptMain.Location = new System.Drawing.Point(0, 0);
            this.rptMain.Name = "rptMain";
            this.rptMain.Size = new System.Drawing.Size(744, 494);
            this.rptMain.TabIndex = 0;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 494);
            this.Controls.Add(this.rptMain);
            this.Name = "frmReport";
            this.Text = "รายงาน";
            this.Load += new System.EventHandler(this.frmReportMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptMain;
    }
}