namespace Parking.Forms.Reports
{
    partial class frmRptBetween
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptBetween));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblOrderBy = new System.Windows.Forms.Label();
            this.cmbOrderBy = new System.Windows.Forms.ComboBox();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muPrint});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(347, 24);
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // muPrint
            // 
            this.muPrint.Image = ((System.Drawing.Image)(resources.GetObject("muPrint.Image")));
            this.muPrint.Name = "muPrint";
            this.muPrint.Size = new System.Drawing.Size(58, 20);
            this.muPrint.Text = "พิมพ์";
            this.muPrint.Click += new System.EventHandler(this.muPrint_Click);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(12, 38);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(58, 20);
            this.lblDateFrom.TabIndex = 4;
            this.lblDateFrom.Text = "วันที่เริ่ม";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(90, 38);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 5;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(90, 81);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 7;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(12, 81);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(69, 20);
            this.lblDateTo.TabIndex = 6;
            this.lblDateTo.Text = "วันที่สิ้นสุด";
            // 
            // lblOrderBy
            // 
            this.lblOrderBy.AutoSize = true;
            this.lblOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderBy.Location = new System.Drawing.Point(12, 126);
            this.lblOrderBy.Name = "lblOrderBy";
            this.lblOrderBy.Size = new System.Drawing.Size(63, 20);
            this.lblOrderBy.TabIndex = 8;
            this.lblOrderBy.Text = "เรียงตาม";
            // 
            // cmbOrderBy
            // 
            this.cmbOrderBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderBy.FormattingEnabled = true;
            this.cmbOrderBy.Location = new System.Drawing.Point(90, 125);
            this.cmbOrderBy.Name = "cmbOrderBy";
            this.cmbOrderBy.Size = new System.Drawing.Size(200, 21);
            this.cmbOrderBy.TabIndex = 9;
            // 
            // frmRptBetween
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(347, 173);
            this.Controls.Add(this.cmbOrderBy);
            this.Controls.Add(this.lblOrderBy);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.MenuStrip1);
            this.MaximizeBox = false;
            this.Name = "frmRptBetween";
            this.Text = "frmRptBetween";
            this.Load += new System.EventHandler(this.frmRptBetween_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem muPrint;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblOrderBy;
        private System.Windows.Forms.ComboBox cmbOrderBy;
    }
}