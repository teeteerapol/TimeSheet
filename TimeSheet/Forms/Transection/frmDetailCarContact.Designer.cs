namespace Parking.Forms.Transection
{
    partial class frmDetailCarContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetailCarContact));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.muPrevious = new System.Windows.Forms.ToolStripMenuItem();
            this.muNext = new System.Windows.Forms.ToolStripMenuItem();
            this.muPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtCardVisitor = new System.Windows.Forms.TextBox();
            this.lblCardVisitor = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.txtTimeIn = new System.Windows.Forms.TextBox();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muPrevious,
            this.muNext,
            this.muPrint});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(743, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // muPrevious
            // 
            this.muPrevious.Image = ((System.Drawing.Image)(resources.GetObject("muPrevious.Image")));
            this.muPrevious.Name = "muPrevious";
            this.muPrevious.Size = new System.Drawing.Size(74, 20);
            this.muPrevious.Text = "ก่อนหน้า";
            this.muPrevious.Click += new System.EventHandler(this.muPrevious_Click);
            // 
            // muNext
            // 
            this.muNext.Image = ((System.Drawing.Image)(resources.GetObject("muNext.Image")));
            this.muNext.Name = "muNext";
            this.muNext.Size = new System.Drawing.Size(59, 20);
            this.muNext.Text = "ถัดไป";
            this.muNext.Click += new System.EventHandler(this.muPrevious_Click);
            // 
            // muPrint
            // 
            this.muPrint.Image = ((System.Drawing.Image)(resources.GetObject("muPrint.Image")));
            this.muPrint.Name = "muPrint";
            this.muPrint.Size = new System.Drawing.Size(58, 20);
            this.muPrint.Text = "พิมพ์";
            this.muPrint.Click += new System.EventHandler(this.muPrevious_Click);
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(127, 157);
            this.txtContact.MaxLength = 255;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(248, 26);
            this.txtContact.TabIndex = 12;
            this.txtContact.Tag = "Contact";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(12, 160);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(102, 20);
            this.lblContact.TabIndex = 11;
            this.lblContact.Text = "ติดต่อบ้านเลขที่";
            // 
            // txtCardVisitor
            // 
            this.txtCardVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardVisitor.Location = new System.Drawing.Point(127, 102);
            this.txtCardVisitor.MaxLength = 20;
            this.txtCardVisitor.Name = "txtCardVisitor";
            this.txtCardVisitor.Size = new System.Drawing.Size(248, 26);
            this.txtCardVisitor.TabIndex = 10;
            this.txtCardVisitor.Tag = "CardVisitor";
            // 
            // lblCardVisitor
            // 
            this.lblCardVisitor.AutoSize = true;
            this.lblCardVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardVisitor.Location = new System.Drawing.Point(12, 105);
            this.lblCardVisitor.Name = "lblCardVisitor";
            this.lblCardVisitor.Size = new System.Drawing.Size(101, 20);
            this.lblCardVisitor.TabIndex = 8;
            this.lblCardVisitor.Text = "เลขบัตรผู้ติดต่อ";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlate.Location = new System.Drawing.Point(127, 46);
            this.txtLicensePlate.MaxLength = 10;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(248, 26);
            this.txtLicensePlate.TabIndex = 7;
            this.txtLicensePlate.Tag = "LicensePlate";
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicensePlate.Location = new System.Drawing.Point(12, 49);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(97, 20);
            this.lblLicensePlate.TabIndex = 6;
            this.lblLicensePlate.Text = "เลขทะเบียนรถ";
            // 
            // picContact
            // 
            this.picContact.Location = new System.Drawing.Point(404, 37);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(315, 243);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContact.TabIndex = 9;
            this.picContact.TabStop = false;
            this.picContact.Tag = "CardImagePath";
            // 
            // txtTimeIn
            // 
            this.txtTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeIn.Location = new System.Drawing.Point(127, 206);
            this.txtTimeIn.MaxLength = 255;
            this.txtTimeIn.Name = "txtTimeIn";
            this.txtTimeIn.Size = new System.Drawing.Size(248, 26);
            this.txtTimeIn.TabIndex = 14;
            this.txtTimeIn.Tag = "TimeIn";
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIn.Location = new System.Drawing.Point(12, 209);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(59, 20);
            this.lblTimeIn.TabIndex = 13;
            this.lblTimeIn.Text = "เวลาเข้า";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOut.Location = new System.Drawing.Point(127, 254);
            this.txtTimeOut.MaxLength = 255;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(248, 26);
            this.txtTimeOut.TabIndex = 16;
            this.txtTimeOut.Tag = "TimeOut";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOut.Location = new System.Drawing.Point(12, 257);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(62, 20);
            this.lblTimeOut.TabIndex = 15;
            this.lblTimeOut.Text = "เวลาออก";
            // 
            // frmDetailCarContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(743, 309);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.txtTimeIn);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtCardVisitor);
            this.Controls.Add(this.lblCardVisitor);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.picContact);
            this.Controls.Add(this.MenuStrip1);
            this.MaximizeBox = false;
            this.Name = "frmDetailCarContact";
            this.Text = "ดูข้อมูล";
            this.Load += new System.EventHandler(this.frmDetailCarContact_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem muPrevious;
        internal System.Windows.Forms.ToolStripMenuItem muNext;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtCardVisitor;
        private System.Windows.Forms.Label lblCardVisitor;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.TextBox txtTimeIn;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.ToolStripMenuItem muPrint;
    }
}