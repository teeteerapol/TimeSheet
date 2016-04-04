using Parking.Forms.Reports;
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
    public partial class frmDetailCarContact : Form
    {
        public delegate void Previous(frmDetailCarContact sender);
        public Previous PreviousData;
        public delegate void Next(frmDetailCarContact sender);
        public Next NextData;
        public delegate void Print();
        public Print PrintData;

        public DataView _dv = null;

        public frmDetailCarContact()
        {
            InitializeComponent();
        }

        public frmDetailCarContact(DataView dv)
        {
            _dv = dv;

            InitializeComponent();
        }

        private void frmDetailCarContact_Load(object sender, EventArgs e)
        {
            try
            {
                TimeSheet.Program.SetEntityValueFromDataView(this, _dv);
                TimeSheet.Program.EnableControlsValue(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void muPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                String name = ((ToolStripMenuItem)sender).Name;
                if (name != muPrint.Name)
                {
                    muNext.Enabled = true;
                    muPrevious.Enabled = true;
                }

                if (name == muPrevious.Name)
                {
                    if (PreviousData != null)
                        PreviousData(this);
                }
                else if (name == muNext.Name)
                {
                    if (NextData != null)
                        NextData(this);
                }
                else if (name == muPrint.Name)
                {
                    if (PrintData != null)
                        PrintData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
