using Parking.Forms.Bases;
using Parking.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Forms.Reports
{
    public partial class frmRptBetween : BaseForm
    {
        public frmRptBetween()
        {
            InitializeComponent();
        }

        private void muPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = GlobalVariables.accessDB.GetDataView(string.Format(Resources.SQLGetDataBetweenDate, dtpFrom.Value, dtpTo.Value,cmbOrderBy.SelectedValue));
                for (Int32 i = 0; i < dv.Count; i++)
                {
                    dv[i]["CardImagePath"] = string.Format("File:\\{0}", dv[i]["CardImagePath"]);
                }
                Dictionary<String, String> para = new Dictionary<string, string>();
                para.Add("paraStartDate", dtpFrom.Value.ToString("dd/MM/yyyy"));
                para.Add("paraEndDate", dtpTo.Value.ToString("dd/MM/yyyy"));
                frmReport frm = new frmReport(dv, "Parking.Reports.RptMain.rdlc", para);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRptBetween_Load(object sender, EventArgs e)
        {
            try
            {
                cmbOrderBy.DataSource = CreateOrderBy();
                cmbOrderBy.ValueMember = "Values";
                cmbOrderBy.DisplayMember = "Text";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable CreateOrderBy()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Text");
            dt.Columns.Add("Values");
            dt.Rows.Add("เวลารถเข้า", "TimeIn");
            dt.Rows.Add("เวลารถออก", "TimeOut");
            return dt;
        }
    }
}
