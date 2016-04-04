namespace Parking.Forms.Transection
{
    partial class frmCarIn
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
            this.picContact = new System.Windows.Forms.PictureBox();
            this.lblLicensePlate = new System.Windows.Forms.Label();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtCardVisitor = new System.Windows.Forms.TextBox();
            this.lblCardVisitor = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.lblCamera = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 243);
            this.btnSave.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 243);
            this.btnCancel.TabIndex = 9;
            // 
            // picContact
            // 
            this.picContact.Location = new System.Drawing.Point(405, 27);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(315, 243);
            this.picContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContact.TabIndex = 2;
            this.picContact.TabStop = false;
            // 
            // lblLicensePlate
            // 
            this.lblLicensePlate.AutoSize = true;
            this.lblLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicensePlate.Location = new System.Drawing.Point(13, 39);
            this.lblLicensePlate.Name = "lblLicensePlate";
            this.lblLicensePlate.Size = new System.Drawing.Size(97, 20);
            this.lblLicensePlate.TabIndex = 0;
            this.lblLicensePlate.Text = "เลขทะเบียนรถ";
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensePlate.Location = new System.Drawing.Point(128, 36);
            this.txtLicensePlate.MaxLength = 10;
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(248, 26);
            this.txtLicensePlate.TabIndex = 1;
            this.txtLicensePlate.Tag = "LicensePlate";
            this.txtLicensePlate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLicensePlate_KeyDown);
            // 
            // txtCardVisitor
            // 
            this.txtCardVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardVisitor.Location = new System.Drawing.Point(128, 92);
            this.txtCardVisitor.MaxLength = 20;
            this.txtCardVisitor.Name = "txtCardVisitor";
            this.txtCardVisitor.Size = new System.Drawing.Size(248, 26);
            this.txtCardVisitor.TabIndex = 3;
            this.txtCardVisitor.Tag = "CardVisitor";
            this.txtCardVisitor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLicensePlate_KeyDown);
            // 
            // lblCardVisitor
            // 
            this.lblCardVisitor.AutoSize = true;
            this.lblCardVisitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardVisitor.Location = new System.Drawing.Point(13, 95);
            this.lblCardVisitor.Name = "lblCardVisitor";
            this.lblCardVisitor.Size = new System.Drawing.Size(101, 20);
            this.lblCardVisitor.TabIndex = 2;
            this.lblCardVisitor.Text = "เลขบัตรผู้ติดต่อ";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(128, 147);
            this.txtContact.MaxLength = 255;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(248, 26);
            this.txtContact.TabIndex = 5;
            this.txtContact.Tag = "Contact";
            this.txtContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLicensePlate_KeyDown);
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(13, 150);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(102, 20);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "ติดต่อบ้านเลขที่";
            // 
            // cbCamera
            // 
            this.cbCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(128, 198);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(248, 28);
            this.cbCamera.TabIndex = 7;
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamera.Location = new System.Drawing.Point(13, 205);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(41, 20);
            this.lblCamera.TabIndex = 6;
            this.lblCamera.Text = "กล้อง";
            // 
            // frmCarIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(740, 302);
            this.Controls.Add(this.lblCamera);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtCardVisitor);
            this.Controls.Add(this.lblCardVisitor);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.lblLicensePlate);
            this.Controls.Add(this.picContact);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "frmCarIn";
            this.Text = "กรอกข้อมูลรถเข้า";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCarIn_FormClosing);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.picContact, 0);
            this.Controls.SetChildIndex(this.lblLicensePlate, 0);
            this.Controls.SetChildIndex(this.txtLicensePlate, 0);
            this.Controls.SetChildIndex(this.lblCardVisitor, 0);
            this.Controls.SetChildIndex(this.txtCardVisitor, 0);
            this.Controls.SetChildIndex(this.lblContact, 0);
            this.Controls.SetChildIndex(this.txtContact, 0);
            this.Controls.SetChildIndex(this.cbCamera, 0);
            this.Controls.SetChildIndex(this.lblCamera, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtCardVisitor;
        private System.Windows.Forms.Label lblCardVisitor;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.Label lblCamera;
    }
}
