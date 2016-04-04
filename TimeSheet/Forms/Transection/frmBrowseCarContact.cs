using Parking.Forms.Bases;
using Parking.Forms.Reports;
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

namespace Parking.Forms.Transection
{
    public partial class frmBrowseCarContact : BaseForm
    {
        public Int32 SelectedRecord { get; set; }

        public frmBrowseCarContact()
        {
            InitializeComponent();
        }

        private void SetHeaderGrid()
        {
            if (dgvMain.ColumnCount > 0)
            {
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["Id"], "เลขที่", 0);
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["TimeIn"], "เวลาเข้า", 200);
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["TimeOut"], "เวลาออก", 200);
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["LicensePlate"], "เลขทะเบียน", 100);
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["CardImagePath"], "Path", 0);
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["CardVisitor"], "เลขบัตรผู้ติดต่อ", 200);
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["Contact"], "บ้านเลขที่", 100);
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["CreateDate"], "สร้างวันที่", 0);
                TimeSheet.Program.SetDisplayColumnGrid(dgvMain.Columns["UpdateDate"], "ปรับปรุงวันที่", 0);
            }
        }

        private void RefreshData()
        {
            DataView dv = GlobalVariables.accessDB.GetDataView(Resources.SQLGetDataAll);
            dgvMain.DataSource = dv;
        }

        private void frmBrowseCarContact_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshData();
                SetHeaderGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                SelectedRecord = e.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Int32 id = Convert.ToInt32(dgvMain.Rows[SelectedRecord].Cells["Id"].Value);
                DataView dv = GlobalVariables.accessDB.GetDataView(string.Format(Resources.SQLGetDataByRecord, id));
                frmDetailCarContact frm = new frmDetailCarContact(dv);
                frm.PreviousData += new frmDetailCarContact.Previous(PreviousData);
                frm.NextData += new frmDetailCarContact.Next(NextData);
                frm.PrintData += new frmDetailCarContact.Print(PrintData);
                if (SelectedRecord == 0)
                    frm.muPrevious.Enabled = false;
                else if (dgvMain.Rows.Count == SelectedRecord + 1)
                    frm.muNext.Enabled = false;
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreviousData(frmDetailCarContact sender)
        {
            SetDataDetailOnDelegate(sender, SelectedRecord - 1);
            if (SelectedRecord == 0)
                sender.muPrevious.Enabled = false;
        }

        private void NextData(frmDetailCarContact sender)
        {
            SetDataDetailOnDelegate(sender, SelectedRecord + 1);
            if (dgvMain.Rows.Count == SelectedRecord + 1)
                sender.muNext.Enabled = false;
        }

        private void PrintData()
        {
            Int32 id = Convert.ToInt32(dgvMain.Rows[SelectedRecord].Cells["Id"].Value);
            DataView dv = GlobalVariables.accessDB.GetDataView(string.Format(Resources.SQLGetDataByRecord, id));
            for (Int32 i = 0; i < dv.Count; i++)
            {
                dv[i]["CardImagePath"] = string.Format("File:\\{0}", dv[i]["CardImagePath"]);
            }
            frmReport frm = new frmReport(dv, "Parking.Reports.RptDetail.rdlc");
            frm.ShowDialog();
        }

        private void SetDataDetailOnDelegate(frmDetailCarContact sender, Int32 newRows)
        {
            dgvMain.Rows[SelectedRecord].Selected = false;
            SelectedRecord = newRows;
            dgvMain.Rows[SelectedRecord].Selected = true;
            Int32 id = Convert.ToInt32(dgvMain.Rows[SelectedRecord].Cells["Id"].Value);
            DataView dv = GlobalVariables.accessDB.GetDataView(string.Format(Resources.SQLGetDataByRecord, id));
            TimeSheet.Program.SetEntityValueFromDataView(sender, dv);
        }
    }
}
