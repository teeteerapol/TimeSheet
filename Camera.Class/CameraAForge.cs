using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace Camera.Class
{
    public class CameraAForge : IDisposable
    {
        public PictureBox _picBox { get; set; }
        private FilterInfoCollection _captureDevice { get; set; }
        private VideoCaptureDevice _finalFrame { get; set; }

        public CameraAForge(PictureBox picBox)
        {
            _picBox = picBox;
        }

        //public List<String> GetCameraName()
        //{
        //    List<String> list = new List<string>();
        //    _captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        //    foreach (FilterInfo device in _captureDevice)
        //    {
        //        list.Add(device.Name);
        //    }
        //    return list;
        //}

        public Dictionary<String, Int32> GetCameraName()
        {
            Dictionary<String, Int32> dic = new Dictionary<String, Int32>();
            _captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            for (int i = 0; i < _captureDevice.Count; i++)
            {
                dic.Add(_captureDevice[i].Name, i);
            }
            return dic;
        }

        public void Start(Int32 iDevice)
        {
            _finalFrame = new VideoCaptureDevice(_captureDevice[iDevice].MonikerString);
            _finalFrame.NewFrame += finalFrame_NewFrame;
            _finalFrame.Start();
        }

        void finalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            _picBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void Stop()
        {
            _finalFrame.Stop();
        }

        public void Capture(String path)
        {
            _picBox.Image.Save(path);
        }

        public void Dispose()
        {
            if ((_finalFrame != null) && (_finalFrame.IsRunning))
                this.Stop();

            _finalFrame = null;
            _captureDevice = null;
            _picBox = null;
        }

        ~CameraAForge()
        {
            this.Dispose();
        }
    }
}
