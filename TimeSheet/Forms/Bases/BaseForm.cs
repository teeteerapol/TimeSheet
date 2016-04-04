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
    public partial class BaseForm : Form
    {
        public delegate void OpenButton();
        public OpenButton OpenButtonMDIForm;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OpenButtonMDIForm != null)
                OpenButtonMDIForm();
        }
    }
}
