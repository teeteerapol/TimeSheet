using Parking.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Parking.Forms.Transection
{
    public partial class frmCarOut : Parking.Forms.Bases.frmEntryBase
    {
        public frmCarOut()
        {
            InitializeComponent();
        }

        public frmCarOut(String tableName, String formName)
            : base(tableName, formName)
        {
            InitializeComponent();
        }

        protected override string GetSqlSaveData()
        {
            String sql = string.Empty;
            String fields = string.Empty;
            String values = string.Empty;
            GetSqlInsertData(this, ref  fields, ref values);
            sql = string.Format(Resources.SQLUpdateCarOut, this.TableName, fields, values);
            return sql;
        }

        protected override String ValidateData()
        {
            StringBuilder sb = new StringBuilder();

            if ((string.IsNullOrWhiteSpace(txtCardVisitor.Text)) && (string.IsNullOrWhiteSpace(txtLicensePlate.Text)))
                sb.AppendLine(Resources.WarningNoInputCarVisitorAndCarLicense);

            if (!String.IsNullOrWhiteSpace(txtCardVisitor.Text))
            {
                DataView dv = GlobalVariables.accessDB.GetDataView(string.Format(Resources.SQLValidateCarOut, txtCardVisitor.Tag, txtCardVisitor.Text.Trim()));
                if ((dv == null) || (dv.Count == 0) || (Convert.ToInt32(dv[0][0]) == 0))
                    sb.AppendLine(Resources.WarningNoCarVisitor);
            }

            if (!string.IsNullOrWhiteSpace(txtLicensePlate.Text))
            {
                DataView dv = GlobalVariables.accessDB.GetDataView(string.Format(Resources.SQLValidateCarOut, txtLicensePlate.Tag, txtLicensePlate.Text.Trim()));
                if ((dv == null) || (dv.Count == 0) || (Convert.ToInt32(dv[0][0]) == 0))
                    sb.AppendLine(Resources.WarningNoCarLicense);
            }

            return sb.ToString();
        }

        private void txtCardVisitor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
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
