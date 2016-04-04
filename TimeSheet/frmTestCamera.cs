using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Camera.Class;

namespace TimeSheet
{
    public partial class frmTestCamera : Form
    {
        public CameraMicrosoft _cameraMicrosoft { get; set; }
        public CameraAForge _cameraAForge { get; set; }

        public frmTestCamera()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (_cameraMicrosoft != null)
                btnStop_Click(btnStop, null);

            _cameraMicrosoft = new CameraMicrosoft();
            List<String> name = _cameraMicrosoft.GetCameraName();
            _cameraMicrosoft.Start(name[1], panelVideoPreview);

            //_cameraAForge = new CameraAForge(picBox);
            //Dictionary<String, Int32> dic = _cameraAForge.GetCameraName();
            //_cameraAForge.Start(dic["Integrated Camera"]);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_cameraMicrosoft != null)
            {
                _cameraMicrosoft.Stop();
                _cameraMicrosoft = null;
            }

            //if (_cameraAForge != null)
            //{
            //    _cameraAForge.Stop();
            //    _cameraAForge = null;
            //    picBox.Image = null;
            //    picBox.Invalidate();
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_cameraMicrosoft != null)
            {
                //_cameraMicrosoft.Start(string.Format("{0}/{1}.wmv", Application.StartupPath, "123"), panelVideoPreview);
                _cameraMicrosoft.StartRecords(string.Format("{0}/{1}.wmv", Application.StartupPath, "123"));
                //btnStop_Click(btnStop, null);
            }

            //if (_cameraAForge != null)
            //{
            //    _cameraAForge.Capture(string.Format("{0}\\{1}.jpg", Application.StartupPath, "123"));
            //    btnStop_Click(btnStop, null);
            //}
        }
    }
}
