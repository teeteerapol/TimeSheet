using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Camera.Class;
using System.IO;
using Parking.Properties;

namespace Parking.Forms.Transection
{
    public partial class frmCarIn : Parking.Forms.Bases.frmEntryBase
    {
        public CameraMicrosoft _cameraMicrosoft { get; set; }
        public CameraAForge _cameraAForge { get; set; }

        private String _imageFile = string.Empty;

        public frmCarIn()
        {
            InitializeComponent();
        }

        public frmCarIn(String tableName, String formName)
            : base(tableName, formName)
        {
            InitializeComponent();
        }

        protected override void DisplayData()
        {
            base.DisplayData();
            AddComboCamera();
            if (!Directory.Exists(GlobalVariables.PathImage))
            {
                Directory.CreateDirectory(GlobalVariables.PathImage);
            }
        }

        private void AddComboCamera()
        {
            _cameraAForge = new CameraAForge(picContact);
            Dictionary<String, Int32> dic = _cameraAForge.GetCameraName();
            cbCamera.ValueMember = "value";
            cbCamera.DisplayMember = "Key";
            cbCamera.DataSource = new BindingSource(dic, null);
        }

        private void cbCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cameraAForge.Start(Convert.ToInt32(((ComboBox)sender).SelectedValue));
        }

        ~frmCarIn()
        {
            if (_cameraAForge != null)
            {
                _cameraAForge.Stop();
                _cameraAForge = null;
                picContact.Image = null;
                picContact.Invalidate();
            }
        }

        private void frmCarIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_cameraAForge != null)
            {
                _cameraAForge.Stop();
                _cameraAForge = null;
                picContact.Image = null;
                picContact.Invalidate();
            }
        }

        protected override string GetSqlSaveData()
        {
            String sql = string.Empty;
            String fields = string.Empty;
            String values = string.Empty;
            GetSqlInsertData(this, ref  fields, ref values);
            _imageFile = string.Format("{0}\\{1:yyyyMMddHHmmss}.jpg", GlobalVariables.PathImage, DateTime.Now);
            fields += ",TimeIn,CreateDate,UpdateDate,CardImagePath";
            values += string.Format(",Now(),Now(),Now(),'{0}'", _imageFile);
            sql = string.Format("Insert into {0} ({1}) values({2})", this.TableName, fields, values);
            return sql;
        }

        protected override void SaveImage()
        {
            base.SaveImage();
            if (_cameraAForge != null)
            {
                _cameraAForge.Capture(_imageFile);
            }
        }

        protected override string ValidateData()
        {
            StringBuilder sb = new StringBuilder();

            if (txtCardVisitor.Text.Trim().Length == 0)
                sb.AppendLine(Resources.WarningNoInputCarVisitor);

            if (txtContact.Text.Trim().Length == 0)
                sb.AppendLine(Resources.WarningNoInputContact);

            if (txtLicensePlate.Text.Trim().Length == 0)
                sb.AppendLine(Resources.WarningNoInputLicensePlate);

            DataView dv = GlobalVariables.accessDB.GetDataView(string.Format(Resources.SQLValidateCarOut, txtCardVisitor.Tag, txtCardVisitor.Text.Trim()));
            if ((dv != null) && (dv.Count > 0) & (Convert.ToInt32(dv[0][0]) > 0))
                sb.AppendLine(Resources.WarningNoInputCarVistorDuplicate);

            return sb.ToString();
        }

        private void txtLicensePlate_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TextBox txt = (TextBox)sender;
                    if (txt.Name == txtLicensePlate.Name)
                        txtCardVisitor.Focus();
                    else if (txt.Name == txtCardVisitor.Name)
                        txtContact.Focus();
                    else if (txt.Name == txtContact.Name)
                        SaveData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
