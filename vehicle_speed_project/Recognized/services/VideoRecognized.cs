using Emgu.CV;
using Emgu.CV.CvEnum;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace vehicle_speed_project.Recognized.services
{
    class VideoRecognized
    {
        public VideoCapture videoCapture;
        private string _pathVideo;
        Mat frame;
        int totalFrames;
        int countFrame;
        public Mat currentFrame;
        double fps;


        TrackBar trackBar;
        PictureBox pictureBox;
        Label labelSpeed;

        SpeedRecognized speedRecognized;

        public string pathVideo
        {
            set { _pathVideo = value; }
        }

        public VideoRecognized(PictureBox pictureBox, TrackBar trackBar, Label labelSpeed)
        {
            this.trackBar = trackBar;
            this.pictureBox = pictureBox;
            this.labelSpeed = labelSpeed;
        }

        public void openVideo()
        {
            clearCapture();
            videoCapture = new VideoCapture(_pathVideo);
            initValues();

            speedRecognized = new SpeedRecognized(pictureBox, videoCapture, frame, fps, labelSpeed);
            speedRecognized.initValues();

            playVideo();
        }

        private void initValues()
        {
            totalFrames = Convert.ToInt32(videoCapture.GetCaptureProperty(CapProp.FrameCount));
            frame = new Mat();
            fps = videoCapture.GetCaptureProperty(CapProp.Fps);


            currentFrame = new Mat();
            countFrame = 0;
            trackBar.Minimum = 0;
            trackBar.Maximum = totalFrames;
            trackBar.Value = 0;
        }

        public void playVideo()
        {
            videoCapture.ImageGrabbed += proccess;
            videoCapture.Start();
        }

        private void proccess(object sender, EventArgs e)
        {
            if(videoCapture != null)
            {
                countFrame++;
                videoCapture.Read(currentFrame);
                videoCapture.Retrieve(frame);

                pictureBox.Image = new Bitmap(frame.Bitmap);

                speedRecognized.proccessCapture();

                if (trackBar.Value <= trackBar.Maximum) trackBar.Value = countFrame;
                if (countFrame == totalFrames)
                {
                    MessageBox.Show("End of video", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearCapture();
                }
            }
        }

        public void clearCapture()
        {           
            if (videoCapture != null)
            {
                videoCapture.Stop();
                videoCapture = null;
                labelSpeed.Text = "Velocidad: ";
            }
        }
    }
}
