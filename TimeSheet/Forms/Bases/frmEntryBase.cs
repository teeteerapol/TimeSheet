using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking.Forms.Bases
{
    public partial class frmEntryBase : BaseForm
    {
        #region Fields
        #endregion

        #region Properties
        protected String TableName { get; set; }
        protected String FormName { get; set; }
        #endregion

        #region Constructors
        public frmEntryBase()
        {
            InitializeComponent();
        }

        public frmEntryBase(String tableName, String formName)
        {
            //This call is required by the Windows Form Designer.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call.
            TableName = tableName;
            FormName = formName;
        }
        #endregion

        #region Control Events
        private void frmEntryBase_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                AddCombobox();
                DisplayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void muSave_Click(object sender, EventArgs e)
        {
            try
            {
                String ctlName = string.Empty;
                if (sender.GetType() == typeof(ToolStripMenuItem))
                    ctlName = ((ToolStripMenuItem)sender).Name;
                else if (sender.GetType() == typeof(Button))
                    ctlName = ((Button)sender).Name;
                switch (ctlName)
                {
                    case "muSave":
                    case "btnSave":
                        SaveData();
                        break;
                    case "muCancel":
                    case "btnCancel":
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Protected Methods

        protected virtual void SetTablePrimaryKey()
        {
        }

        protected virtual void AddCombobox()
        {
        }

        protected virtual void SetControlEnable()
        {
        }

        protected virtual void DisplayData()
        {
            SetControlEnable();
            SetToolbarEnables();
        }

        protected virtual void SaveData()
        {
            String sql = string.Empty;
            try
            {
                String msg = ValidateData();
                if (string.IsNullOrWhiteSpace(msg))
                {
                    sql = GetSqlSaveData();
                    Int32 result = GlobalVariables.accessDB.ExecuteScalar(sql);
                    SaveImage();
                    MessageBox.Show(string.Format(Properties.Resources.SuccessSaveData, this.FormName));
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show(msg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(ex.Message);
                sb.AppendLine(string.Format("Sql : {0}", sql));
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void SetToolbarEnables()
        {
        }

        protected virtual void SaveImage()
        {

        }

        protected virtual String ValidateData()
        {
            return string.Empty;
        }

        //Protected Overridable Sub SetEntityValueToControl()
        //    If Mode = EntryMode.EditMode And Not IsNothing(_currentData) Then
        //        SetEntityValueFromDataView(Me, _currentData)
        //    End If
        //End Sub

        //Protected Overridable Function GetSqlViewData() As String
        //    Return String.Empty
        //End Function

        protected virtual void ClearControlValue()
        {
            TimeSheet.Program.ClearControlsValue(this);
        }

        protected virtual void GetSqlInsertData(Control controlContainer, ref String fields, ref String values)
        {
            foreach (Control ctl in controlContainer.Controls)
            {
                if (ctl.Controls.Count > 0)
                {
                    GetSqlInsertData(ctl, ref fields, ref values);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(Convert.ToString(ctl.Tag)))
                    {
                        String value = TimeSheet.Program.GetControlValue(ctl);
                        if (!string.IsNullOrWhiteSpace(value))
                        {
                            fields += string.IsNullOrWhiteSpace(fields) ? "" : ",";
                            values += string.IsNullOrWhiteSpace(values) ? "" : ",";

                            fields += ctl.Tag;
                            values += string.Format("'{0}'", value);
                        }
                    }
                }
            }
        }

        protected virtual String GetSqlSaveData()
        {
            String sql = string.Empty;
            String fields = string.Empty;
            String values = string.Empty;
            GetSqlInsertData(this, ref  fields, ref values);
            sql = string.Format("Insert into {0} ({1}) values({2})", this.TableName, fields, values);
            return sql;
        }

        #endregion

        #region Private Methods

        #endregion
    }
}
