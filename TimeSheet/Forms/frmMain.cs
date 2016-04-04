using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        ~frmMain()
        {
            GlobalVariables.accessDB.CloseConnection();
        }

        private void CarInMenu_Click(object sender, EventArgs e)
        {
            try
            {
                OpenModuleWithKey(((ToolStripMenuItem)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenModuleWithKey(String key)
        {
            Parking.Forms.Bases.BaseForm frm = null;
            CloseAllChildForm();
            VisibleButton(false);

            if ((key == CarInMenu.Name) || (key == btnCarIn.Name))
                frm = new Forms.Transection.frmCarIn("CarContact","รถเข้า");
            else if ((key == CarOutMenu.Name)|| (key == btnCarOut.Name))
                frm = new Forms.Transection.frmCarOut("CarContact","รถออก");
            else if ((key == ViewData.Name)|| (key == btnView.Name))
                frm = new Forms.Transection.frmBrowseCarContact();
            else if ((key == reportMenu.Name) || (key == btnReport.Name))
                frm = new Forms.Reports.frmRptBetween();

            if (frm != null)
            {
                frm.OpenButtonMDIForm += new Forms.Bases.BaseForm.OpenButton(OpenButton);

                frm.MdiParent = this;
                frm.Show();
                frm.StartPosition = FormStartPosition.CenterScreen;

                if ((frm.GetType() == typeof(Forms.Transection.frmBrowseCarContact))
                    || (frm.GetType() == typeof(Forms.Reports.frmReport)))
                    frm.WindowState = FormWindowState.Maximized;

            }
        }

        private void OpenButton()
        {
            VisibleButton(true);
        }

        private void VisibleButton(Boolean enable)
        {
            btnCarIn.Visible = enable;
            btnCarOut.Visible = enable;
            btnView.Visible = enable;
            btnReport.Visible = enable;
        }

        private void CloseAllChildForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            GlobalVariables.accessDB.CloseConnection();
        }

        private void btnCarIn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenModuleWithKey(((Button)sender).Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
