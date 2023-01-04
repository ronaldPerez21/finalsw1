using System;
using System.Drawing;
using System.Windows.Forms;

namespace vehicle_speed_project.Recognized.services
{
    class CropImageOfVideo
    {
        PictureBox pictureBoxInput, pictureBoxOutput;

        private Rectangle rect;
        private Point startLocation;
        private Point endLocation;
        private bool isMouseDown = false;

        public CropImageOfVideo(PictureBox pictureBoxInput, PictureBox pictureBoxOutput)
        {
            this.pictureBoxInput = pictureBoxInput;
            this.pictureBoxOutput = pictureBoxOutput;
        }

        public Rectangle getRectangle()
        {
            rect = new Rectangle();
            rect.X = Math.Min(startLocation.X, endLocation.X);
            rect.Y = Math.Min(startLocation.Y, endLocation.Y);
            rect.Width = Math.Abs(startLocation.X - endLocation.X);
            rect.Height = Math.Abs(startLocation.Y - endLocation.Y);

            return rect;
        }

        public void pictureBoxInput_MouseDown(object sender, MouseEventArgs e)
        {
            if(pictureBoxInput.Image != null)
            {
                isMouseDown = true;
                startLocation = e.Location;
            }
        }

        public void pictureBoxInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                endLocation = e.Location;
                pictureBoxInput.Invalidate();
            }
        }

        public void pictureBoxInput_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (isMouseDown)
                {
                    endLocation = e.Location;
                    isMouseDown = false;
                    if (rect != null)
                    {
                        Bitmap imgBmp = new Bitmap(pictureBoxInput.Image);
                        imgBmp = imgBmp.Clone(rect, imgBmp.PixelFormat); //Ver memoria insuficiente
                        if (pictureBoxOutput.Image != null)
                        {
                            pictureBoxOutput.Image.Dispose();
                            pictureBoxOutput.Image = null;
                        }
                        pictureBoxOutput.Image = imgBmp;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void pictureBoxInput_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Red, getRectangle());
            }
        }

    }
}
