using System;

using Emgu.CV;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace vehicle_speed_project.Recognized.services
{
    class CameraRecognized
    {
        public VideoCapture videoCapture;
        private int _camera;
        private PictureBox pictureBox;

        public CameraRecognized(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }

        public void openCamera(int camera)
        {
            _camera = camera;
            Thread.Sleep(500);
            playCamera();
        }

        public void playCamera()
        {
            videoCapture = new VideoCapture(_camera);
            videoCapture.ImageGrabbed += proccess;
            videoCapture.Start();
        }

        private void proccess(object sender, EventArgs e)
        {
            try
            {
                if (videoCapture != null)
                {
                    Mat frame = new Mat();
                    videoCapture.Retrieve(frame);
                    pictureBox.Image = new Bitmap(frame.Bitmap);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        public void clearCapture()
        {
            // Stop Capture            
            if (videoCapture != null)
            {
                videoCapture.Stop();
                videoCapture = null;
            }
        }
    }
}
