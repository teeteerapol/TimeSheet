using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Live;
using Microsoft.Expression.Encoder;
using System.Runtime.InteropServices;

namespace Camera.Class
{
    public class CameraMicrosoft : IDisposable
    {
        /// <summary>
        /// Creates job for capture of live source
        /// </summary>
        private LiveJob _job;

        /// <summary>
        /// Device for live source
        /// </summary>
        private LiveDeviceSource _deviceSource;

        public List<String> GetCameraName()
        {
            List<String> list = new List<string>();
            foreach (EncoderDevice edv in EncoderDevices.FindDevices(EncoderDeviceType.Video))
            {
                list.Add(edv.Name);
            }
            return list;
        }

        public void Stop()
        {
            // Has the Job already been created ?
            if ((_job != null) && (_deviceSource != null))
            {
                _job.StopEncoding();

                // Remove the Device Source and destroy the job
                _job.RemoveDeviceSource(_deviceSource);

                // Destroy the device source
                _deviceSource.PreviewWindow = null;
                _deviceSource = null;
            }
        }

        public void Start(String strCameraName, Panel pnlPreview)
        {
            if (string.IsNullOrWhiteSpace(strCameraName))
            {
                return;
            }

            // Starts new job for preview window
            _job = new LiveJob();

            // Checks for a/v devices
            if (!string.IsNullOrWhiteSpace(strCameraName))
            {
                // Create a new device source. We use the first audio and video devices on the system
                var edv = EncoderDevices.FindDevices(EncoderDeviceType.Video).ToList().Find(x => x.Name == strCameraName);
                _deviceSource = _job.AddDeviceSource(edv, null);
                _deviceSource.PickBestVideoFormat(new Size(640, 480), 15);

                // Get the properties of the device video
                SourceProperties sp = _deviceSource.SourcePropertiesSnapshot();

                // Resize the preview panel to match the video device resolution set
                pnlPreview.Size = new Size(sp.Size.Width, sp.Size.Height);

                // Setup the output video resolution file as the preview
                _job.OutputFormat.VideoProfile.Size = new Size(sp.Size.Width, sp.Size.Height);

                // Sets preview window to winform panel hosted by xaml window
                _deviceSource.PreviewWindow = new PreviewWindow(new HandleRef(pnlPreview, pnlPreview.Handle));

                // Make this source the active one
                _job.ActivateSource(_deviceSource);

            }
            else
            {
                // Gives error message as no audio and/or video devices found
                MessageBox.Show("No Video/Audio capture devices have been found.", "Warning");
            }
        }

        public void Capture(String path, Panel pnlPreview)
        {
            // Create a Bitmap of the same dimension of panelVideoPreview (Width x Height)
            using (Bitmap bitmap = new Bitmap(pnlPreview.Width, pnlPreview.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Get the paramters to call g.CopyFromScreen and get the image
                    Rectangle rectanglePanelVideoPreview = pnlPreview.Bounds;
                    Point sourcePoints = pnlPreview.PointToScreen(new Point(pnlPreview.ClientRectangle.X, pnlPreview.ClientRectangle.Y));
                    g.CopyFromScreen(sourcePoints, Point.Empty, rectanglePanelVideoPreview.Size);
                }

                string strGrabFileName = path;
                bitmap.Save(strGrabFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        public void StartRecords(String path)
        {
            // Sets up publishing format for file archival type
            FileArchivePublishFormat fileOut = new FileArchivePublishFormat();

            // Sets file path and name
            fileOut.OutputFileName = path;

            // Adds the format to the job. You can add additional formats as well such as
            // Publishing streams or broadcasting from a port
            _job.PublishFormats.Add(fileOut);

            // Start encoding
            _job.StartEncoding();
        }

        public void StopRecords()
        {
            _job.StopEncoding();
        }

        public void Dispose()
        {
            if (_job != null)
            {
                this.Stop();
                _job = null;
            }
        }

        ~CameraMicrosoft()
        {
            this.Dispose();
        }
    }
}
