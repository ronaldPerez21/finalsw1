using System;
using System.Drawing;
using System.Windows.Forms;

using vehicle_speed_project.Recognized.services;
using vehicle_speed_project.Recognized.Components;
using System.Threading;
using vehicle_speed_project.Historial.Components;

namespace vehicle_speed_project
{
    public partial class MyProject : Form
    {

        //WebCam
        private CameraRecognized cameraRecognized;
        private VideoRecognized videoRecognized;
        private CropImageOfVideo cropImageOfVideo;
        private PlateAnalized plateAnalized;
        HistorialSpeed historialSpeed;

        private bool isPanelHidden = false;
        private bool isOpenVideo = false; //isOpenVideo = true; Se abrio video
        private bool isStopVideo = false;
        public MyProject()
        {
            InitializeComponent();
            ControlExtension.Draggable(panelCapture, true);
            pictureBoxCapture.SizeMode = PictureBoxSizeMode.StretchImage;

            cameraRecognized = new CameraRecognized(pictureBoxInput);
            videoRecognized = new VideoRecognized(pictureBoxInput, trackBarVideo, labelSpeedResult);
            cropImageOfVideo = new CropImageOfVideo(pictureBoxInput, pictureBoxCapture);
            historialSpeed = new HistorialSpeed();

            pictureBoxInput.MouseDown += cropImageOfVideo.pictureBoxInput_MouseDown;
            pictureBoxInput.MouseMove += cropImageOfVideo.pictureBoxInput_MouseMove;
            pictureBoxInput.MouseUp += cropImageOfVideo.pictureBoxInput_MouseUp;
            pictureBoxInput.Paint += cropImageOfVideo.pictureBoxInput_Paint;

            plateAnalized = new PlateAnalized(
                                historialSpeed,
                                pictureBoxCapture,
                                pictureBoxPlate,
                                labelInfoCapture,
                                labelResult,
                                labelColor
                            );
            pictureBoxCapture.Paint += plateAnalized.pictureBoxCapture_Paint;

            pictureBoxInput.SizeMode = PictureBoxSizeMode.StretchImage;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void MyProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            plateAnalized.clearDatas();
            videoRecognized.clearCapture();
            cameraRecognized.clearCapture();
        }

        private void enableCommandsVideo(bool value)
        {
            if (value)
            {
                btnCapture.Cursor = Cursors.Hand;
                btnCapture.Enabled = true;

                btnPause.Cursor = Cursors.Hand;
                btnPause.Enabled = true;

                btnPlay.Cursor = Cursors.Hand;
                btnPlay.Enabled = true;

                btnStop.Cursor = Cursors.Hand;
                btnStop.Enabled = true;
            }
            else
            {
                btnCapture.Cursor = Cursors.No;
                btnCapture.Enabled = false;

                btnPause.Cursor = Cursors.No;
                btnPause.Enabled = false;

                btnPlay.Cursor = Cursors.No;
                btnPlay.Enabled = false;

                btnStop.Cursor = Cursors.No;
                btnStop.Enabled = false;
            }
        }

        private void abrirCámaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectCamera selectCamera = new SelectCamera();
            if (selectCamera.ShowDialog(this) == DialogResult.OK)
            {
                isOpenVideo = false;
                enableCommandsVideo(true);

                cameraRecognized.clearCapture();
                videoRecognized.clearCapture();
                plateAnalized.clearDatas();

                cameraRecognized.openCamera(selectCamera.device);

            }
        }

        private void abrirVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                isOpenVideo = true;
                enableCommandsVideo(true);

                cameraRecognized.clearCapture();
                videoRecognized.clearCapture();
                plateAnalized.clearDatas();

                videoRecognized.pathVideo = dialog.FileName;
                videoRecognized.openVideo();
            }
        }

        private void analizarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images: (*.jpg;*.png)|*.png;*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Thread t1 = new Thread(new ThreadStart(delegate {
                    videoRecognized.clearCapture();
                    cameraRecognized.clearCapture();
                    enableCommandsVideo(false);
                    pictureBoxCapture.Image = new Bitmap(dialog.FileName);
                }));

                t1.Start();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (isOpenVideo)
            {
                if (isStopVideo) videoRecognized.openVideo(); //Reinicio del video
                else videoRecognized.playVideo(); //Reanudar el video
            }
            else cameraRecognized.playCamera();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isOpenVideo)
            {
                if(videoRecognized.videoCapture != null)
                {
                    videoRecognized.videoCapture.Pause();
                    isStopVideo = false;
                }
            }
            else if (cameraRecognized.videoCapture != null) cameraRecognized.videoCapture.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (isOpenVideo) {
                videoRecognized.clearCapture();
                isStopVideo = true;
            }
            else cameraRecognized.clearCapture();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {            

            try
            {
                string path = @"..\..\Assets\";
                string nameImg = DateTime.Now.ToString("[dd_MM_yyyy]-[HH_mm_ss]"); //Get fecha y hora actual 

                string imageSaved = path + nameImg + ".jpg";
                if (isOpenVideo)
                {
                    if(videoRecognized.currentFrame != null)
                        videoRecognized.currentFrame.Save(imageSaved);
                }
                else
                {
                    using (var frameC = cameraRecognized.videoCapture.QueryFrame())
                    {
                        frameC.Save(imageSaved);
                    }
                }
                pictureBoxCapture.Image = new Bitmap(imageSaved);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void panelCapture_MouseHover(object sender, EventArgs e)
        {
            panelCapture.Cursor = Cursors.SizeAll;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            isPanelHidden = !isPanelHidden;
            if (isPanelHidden) panelCapture.Visible = false;
            else panelCapture.Visible = true;
        }

        #region pictureBoxInput SizeMode

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxInput.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void estiramientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxInput.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void automáticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxInput.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void centradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxInput.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxInput.SizeMode = PictureBoxSizeMode.Zoom;
        }

        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {            
            if(historialSpeed.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}