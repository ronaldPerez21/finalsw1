using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace vehicle_speed_project.Recognized.services
{
    class SpeedRecognized
    {
        PictureBox pictureBox;
        //Video
        VideoCapture videoCapture;
        double fps;

        int speedBoxW, speedBoxH;
        Mat frame, frame_gray, mask;                // Matrices de máscara de marco, escala gris y sustracción
        Mat Cropped_mask, Cropped_frame;            // Matrices of Cropping
        // ROI
        Rectangle speedBox;

        // Valores de configuración relacionados con la velocidad
        double Ref_dist_m;                          // Reference Distance in Meters and Pixels
        double CalibrationVehicleLength;            // Calibration: the size of a vehicle
        double PixelFrameDensity;                   // How many pixels in each frame?
        int speedLimit;                             // Speed Limit for Violation Detection
        double MappingConstant;                     // To map correctly

        // Vehicle Detection
        IBackgroundSubtractor mog;                // Background Subtraction Method

        // Vehicle Tracking        
        int VehicleID_1;                            // ID of Each Detected Vehicle in ROI-1
        int ROI;                                    // ID of Each Detected Vehicle in ROI-1
        bool isTracking;                            // Is the tracker active?
        bool wasTracking;                           // Did it Changed?
        double previousCentroidY, currentCentroidY;
        int motionThreshold;                        // if box.Width > (speedBoxW / motionThreshold) then Show Rect
        int MaxDetectedCarSize;                     // Max Size of Detected Car for ListView
        int currentDetectedCarSize;                 // Current Size of Detected Car for ListView
        Bitmap DetectedVehicle;

        int trackingFrameCounter;                   // To Count Vehicle Presence Frames for speed Calculation
        double trackingDisplacement;                   // Sum of the Displacements of Vehicle

        Label labelSpeed;
        public SpeedRecognized(PictureBox pictureBox, VideoCapture videoCapture, Mat frame, double fps, Label labelSpeed)
        {

            this.pictureBox = pictureBox;
            this.videoCapture = videoCapture;
            this.frame = frame;
            this.fps = fps;
            this.labelSpeed = labelSpeed;
        }

        public void initValues()
        {
            frame_gray = new Mat();
            mask = new Mat();

            // Inicializar los valores de detección
            mog = new BackgroundSubtractorMOG2();

            // Configuración de video
            int CaptureH = Convert.ToInt32(videoCapture.GetCaptureProperty(CapProp.FrameHeight));
            int CaptureW = Convert.ToInt32(videoCapture.GetCaptureProperty(CapProp.FrameWidth));
            Ref_dist_m = 2.7;                               // Mapeo de Referencia en Metros (Tamaño del ROI en Metro)
            CalibrationVehicleLength = 5.7;                 // Calibration Size
            MappingConstant = 2.18;                         // For HD video input (Set01Vid01)
            PixelFrameDensity = 1.00;

            // ROI Initialization (Center of Screen)
            speedBoxW = CaptureW / 3;
            speedBoxH = CaptureH / 3;

            // Centroides de rastreadores
            previousCentroidY = -1;
            currentCentroidY = -1;
            wasTracking = false;
            isTracking = false;
            VehicleID_1 = 1;
            ROI = 2;
            motionThreshold = 3;
            trackingFrameCounter = 0;
            trackingDisplacement = 0;

        }

        public void proccessCapture()
        {

            speedBox = new Rectangle(0, 0, frame.Width, frame.Height);
            CvInvoke.Rectangle(frame, speedBox, new MCvScalar(0, 0, 255), 2); //(B, G, R) ROI
            PixelFrameDensity = Math.Round((Ref_dist_m + CalibrationVehicleLength) / frame.Width, 3);

            CvInvoke.CvtColor(frame, frame_gray, ColorConversion.Bgra2Gray, 1);
            mog.Apply(frame_gray, mask);

            // Crop to ROI
            CropROI();

            // Track
            TrackinROI();
        }

        private void CropROI()
        {
            try
            {
                Cropped_mask = new Mat(mask, speedBox);
                Cropped_frame = new Mat(frame, speedBox);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!:" + e.ToString(), "Execution Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TrackinROI()
        {

            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            // Construir lista de contornos
            CvInvoke.FindContours(Cropped_mask, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);

            // Seleccionando el contorno más grande
            if (contours.Size > 0)
            {
                double maxArea = 0;
                int chosen = 0;
                for (int i = 0; i < contours.Size; i++)
                {
                    VectorOfPoint contour = contours[i];
                    double area = CvInvoke.ContourArea(contour);
                    if (area > maxArea)
                    {
                        maxArea = area;
                        chosen = i;
                    }
                }

                Rectangle box = CvInvoke.BoundingRectangle(contours[chosen]);

                // Umbral
                if (box.Width > (speedBoxW / motionThreshold) && box.Height > (speedBoxH / motionThreshold))
                {
                    //CvInvoke.Polylines(Cropped_frame, contours[chosen], true, new Bgr(Color.Red).MCvScalar);
                    CvInvoke.Rectangle(Cropped_frame, box, new MCvScalar(0, 255.0, 0), 3);

                    if (!isTracking)
                    { // Si no se rastreó en el cuadro anterior: valores de entrada de calcelato
                        isTracking = true;
                        previousCentroidY = box.Top + (box.Bottom - box.Top) / 2; // Centro
                        //MessageBox.Show("Enterance: " + previousCentroidY, "Vehicle Entered!");
                    }
                    else
                    {   // Else if the tracker was working in the previous
                        // new
                        previousCentroidY = currentCentroidY;

                        currentCentroidY = box.Top + (box.Bottom - box.Top) / 2;

                        // Mostrar punto centralide
                        CvInvoke.Line(Cropped_frame, new Point(0, Convert.ToInt32(currentCentroidY)), new Point(speedBoxW, Convert.ToInt32(currentCentroidY)), new MCvScalar(128, 20, 215), 1);
                        CvInvoke.Rectangle(Cropped_frame, new Rectangle(box.X + (box.Width / 2), Convert.ToInt32(currentCentroidY), 2, 2), new MCvScalar(255.0, 0, 255.0), 2);
                    }

                    double tempDisplacement = Math.Abs(previousCentroidY - currentCentroidY);

                    if (previousCentroidY > -1 && currentCentroidY > -1 && tempDisplacement >= 0)
                    {

                        trackingDisplacement += tempDisplacement;
                        trackingFrameCounter++;
                    }

                    try
                    {
                        currentDetectedCarSize = Math.Abs(box.Bottom - box.Top);

                        if (currentDetectedCarSize >= MaxDetectedCarSize)
                        {
                            MaxDetectedCarSize = currentDetectedCarSize;
                            DetectedVehicle = new Bitmap(Cropped_frame.Bitmap);
                        }

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("" + err.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    wasTracking = isTracking;
                    isTracking = false;

                    if (wasTracking)
                    {  // Si estaba rastreando en un cuadro anterior                           
                        calculateSpeed(box, trackingFrameCounter, trackingDisplacement);
                        VehicleID_1++;
                    }
                    else
                    { // Si no estaba rastreando en un cuadro anterior

                    }

                }

                pictureBox.Image = new Bitmap(Cropped_frame.Bitmap);

            }

        }

        private void calculateSpeed(Rectangle rect, int totalFrames, double totalDisplacement)
        {

            // Displacement in pixels
            double displacement = totalDisplacement / (totalFrames + 4);    // Each Frame's Displacement

            double distancia = displacement * PixelFrameDensity * MappingConstant;     // Distance in Meters

            distancia = Math.Round(distancia * fps * 3.6, 3);              // Speed in m/s and then in Km/h

            // New aspect!
            //distancia = Math.Round((Ref_dist_m * FPS / (totalFrames + 4)) * 3.6, 3);

            if (distancia > 10)
            {
                labelSpeed.Text = "Velocidad: " + distancia + "Km/h";
                //myPanelCapture.labelSpeedResult.Text = distancia + "Km/h";
            }

            MaxDetectedCarSize = 0;
            previousCentroidY = -1;
            currentCentroidY = -1;
            trackingFrameCounter = 0;
            trackingDisplacement = 0;

        }

    }
}
