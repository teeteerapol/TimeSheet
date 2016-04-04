namespace Parking.Forms.Transection
{
    partial class frmCarOut
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
            this.txtCardVisitor = new System.Windows.Forms.TextBox();
            this.lblCardVisitor = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 137);
            this.btnSave.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(287, 137);
            this.btnCancel.TabIndex = 5;
            // 
            // txtCardVisitor
            // 
            this.txtCardVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardVisitor.Location = new System.Drawing.Point(150, 54);
            this.txtCardVisitor.Name = "txtCardVisitor";
            this.txtCardVisitor.Size = new System.Drawing.Size(248, 26);
            this.txtCardVisitor.TabIndex = 1;
            this.txtCardVisitor.Tag = "CardVisitor";
            this.txtCardVisitor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardVisitor_KeyDown);
            // 
            // lblCardVisitor
            // 
            this.lblCardVisitor.AutoSize = true;
            this.lblCardVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardVisitor.Location = new System.Drawing.Point(35, 57);
            this.lblCardVisitor.Name = "lblCardVisitor";
            this.lblCardVisitor.Size = new System.Drawing.Size(101, 20);
            this.lblCardVisitor.TabIndex = 0;
            this.lblCardVisitor.Text = "เลขบัตรผู้ติดต่อ";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlate.Location = new System.Drawing.Point(150, 96);
            this.txtLicensePlate.MaxLength = 10;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(248, 26);
            this.txtLicensePlate.TabIndex = 3;
            this.txtLicensePlate.Tag = "LicensePlate";
            this.txtLicensePlate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardVisitor_KeyDown);
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicensePlate.Location = new System.Drawing.Point(35, 99);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(97, 20);
            this.lblLicensePlate.TabIndex = 2;
            this.lblLicensePlate.Text = "เลขทะเบียนรถ";
            // 
            // frmCarOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(433, 196);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.txtCardVisitor);
            this.Controls.Add(this.lblCardVisitor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmCarOut";
            this.Text = "กรอกข้อมูลรถออก";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblCardVisitor, 0);
            this.Controls.SetChildIndex(this.txtCardVisitor, 0);
            this.Controls.SetChildIndex(this.lblLicensePlate, 0);
            this.Controls.SetChildIndex(this.txtLicensePlate, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardVisitor;
        private System.Windows.Forms.Label lblCardVisitor;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblLicensePlate;
    }
}
