using Parking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;
using System.Data;
using System.Drawing;

namespace TimeSheet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GlobalVariables.databasePath = String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["DBPath"]) ? String.Format("{0}\\{1}", Application.StartupPath, "Car.accdb") : ConfigurationManager.AppSettings["DBPath"];
            GlobalVariables.PathImage = String.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["ImagePath"]) ? String.Format("{0}\\Images\\{1}", Application.StartupPath, DateTime.Now.ToString("yyyyMMdd")) : ConfigurationManager.AppSettings["ImagePath"];
            Application.EnableVisualStyles();
            GlobalVariables.accessDB = new Parking.Engine.AccessOleDbProvider();
            GlobalVariables.accessDB.OpenConnection();

            String culture = string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Culture"]) ? "th" : ConfigurationManager.AppSettings["Culture"];

            Application.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture(culture);
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture(culture);
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.CreateSpecificCulture(culture);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            //Application.Run(new frmTestCamera());
        }

        public static void SetEntityValueFromDataView(Control containerControl, DataView dataView)
        {
            foreach (Control ctl in containerControl.Controls)
            {
                if ((ctl.Tag != null) && !string.IsNullOrWhiteSpace(ctl.Tag.ToString()))
                {
                    SetValueToControl(ctl, dataView[0][ctl.Tag.ToString()]);
                }
            }
        }

        public static void SetValueToControl(Control control, Object value)
        {
            if (control.GetType() == typeof(TextBox))
            {
                TextBox ctl = (TextBox)control;
                ctl.Text = Convert.ToString(value);
            }
            else if (control.GetType() == typeof(PictureBox))
            {
                PictureBox ctl = (PictureBox)control;
                if (!String.IsNullOrWhiteSpace(Convert.ToString(value)))
                {
                    ctl.Image = Image.FromFile(Convert.ToString(value));
                }
            }
        }

        public static void ClearControlsValue(Control containerControl)
        {
            foreach (Control ctl in containerControl.Controls)
            {
                if (ctl.Controls.Count > 0)
                    ClearControlsValue(ctl);
                else
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        TextBox ctlText = (TextBox)ctl;
                        ctlText.Text = string.Empty;
                    }
                }
            }
        }

        public static void EnableControlsValue(Control containerControl)
        {
            foreach (Control ctl in containerControl.Controls)
            {
                if (ctl.Controls.Count > 0)
                    EnableControlsValue(ctl);
                else
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        TextBox ctlText = (TextBox)ctl;
                        ctlText.ReadOnly = true;
                    }
                }
            }
        }

        public static String GetControlValue(Control control)
        {
            String value = string.Empty;
            if (control.GetType() == typeof(TextBox))
            {
                TextBox ctl = (TextBox)control;
                value = ctl.Text;
            }
            return value;
        }

        public static void SetDisplayColumnGrid(DataGridViewColumn col, String textDisplay, Int32 colWidth)
        {
            col.HeaderText = textDisplay;
            col.Width = colWidth;
            if (colWidth == 0)
                col.Visible = false;
            else
                col.Visible = true;
        }
    }
}
