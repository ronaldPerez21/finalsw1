using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using vehicle_speed_project.Historial.Components;
using vehicle_speed_project.Recognized.Interfaces;
using Color = System.Drawing.Color;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace vehicle_speed_project.Recognized.services
{
    class PlateAnalized
    {
        RestClient client = new RestClient("https://sw1-final-api.herokuapp.com/api");
        private PictureBox pictureBoxOutput, pictureBoxPlate;
        private Label labelInfoCapture, labelResult, labelColor;

        private HistorialSpeed historialSpeed;
        public PlateAnalized(
            HistorialSpeed historialSpeed,
            PictureBox pictureBoxOutput,
            PictureBox pictureBoxPlate,
            Label labelInfoCapture,
            Label labelResult,
            Label labelColor)
        {
            this.historialSpeed = historialSpeed;
            this.pictureBoxOutput = pictureBoxOutput;
            this.pictureBoxPlate = pictureBoxPlate;
            this.labelInfoCapture = labelInfoCapture;
            this.labelResult = labelResult;
            this.labelColor = labelColor;
        }

        public void pictureBoxCapture_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxOutput.Image != null)
            {
                labelResult.Text = "";
                labelInfoCapture.Text = "Analizando...";
                labelInfoCapture.ForeColor = Color.Black;

                string path = @"..\..\Analized\";
                string nameImg = DateTime.Now.ToString("[dd_MM_yyyy]-[HH_mm_ss]"); //Get fecha y hora actual 
                string fileName = path + nameImg + ".jpg";
                pictureBoxOutput.Image.Save(fileName, ImageFormat.Jpeg);

                PlateRecognized recognized = new PlateRecognized();
                VehicleData vehicleData = recognized.analizeVehicle("anpr, mmr", fileName, "BOL", 1);

                if (vehicleData != null && vehicleData.Data.Vehicles.Length != 0 && vehicleData.Data.Vehicles[0].Plate.Found)
                {
                    String licensePlateString = vehicleData.Data.Vehicles[0].Plate.SeparatedText;
                    Mmr mmr = vehicleData.Data.Vehicles[0].Mmr;
                    labelResult.Text = "Placa: " + licensePlateString +
                                       "\nModelo: " + mmr.Model +
                                       "\nMarca: " + mmr.Make +
                                       "\nCategoría: " + mmr.Category;

                    Interfaces.Color color = mmr.Color;
                    
                    if(color != null)
                    {
                        labelColor.BackColor = Color.FromArgb((int)color.R, (int)color.G, (int)color.B);
                        labelColor.Text = "";
                    }

                    ExtendedPlateFrame plateROI = vehicleData.Data.Vehicles[0].Plate.PlateRoi;
                    int posX = Convert.ToInt32(plateROI.TopLeft.X) - 6;
                    int posY = Convert.ToInt32(plateROI.TopLeft.Y) - 6;
                    int width = Convert.ToInt32(plateROI.BottomRight.X - plateROI.BottomLeft.X) + 12;
                    int height = Convert.ToInt32(plateROI.BottomLeft.Y - plateROI.TopLeft.Y) + 12;

                    cropImage(posX, posY, width, height, fileName, pictureBoxPlate);

                    historialSpeed.addData(
                        DateTime.Now.ToString("[dd_MM_yyyy]-[HH_mm_ss]"),
                        fileName,
                        vehicleData.Data.Vehicles[0].Plate.SeparatedText,
                        mmr.Model,
                        mmr.Make,
                        mmr.Category,
                        "-",
                        "Identificado"
                        );

                    labelInfoCapture.Text = "";
                    JObject payload = new JObject();
                    payload.Add("licensePlate", licensePlateString);
                    RestRequest request = new RestRequest("license-plate/search", Method.Post);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddHeader("Accept", "application/json");
                    request.AddJsonBody(payload.ToString());
                    RestResponse result = client.PostAsync(request).Result;
                    int statusCode = (int)result.StatusCode;
                    if (statusCode == 200 || statusCode == 201)
                    {
                        LicensePlate licensePlate = LicensePlate.FromJson(result.Content);

                        labelResult.Text = labelResult.Text
                                            + "\nDueño: " + licensePlate.LicensePlateOwner.ToString()
                                            + "\nCI: " + licensePlate.OwnerDocument.ToString();
                    }
                    else
                    {
                        labelResult.Text = labelResult.Text + "\n"
                                            + "Placa " + licensePlateString + " no registrado";
                    }
                }
                else
                {
                    historialSpeed.addData(
                        DateTime.Now.ToString("[dd_MM_yyyy]-[HH_mm_ss]"),
                        fileName,
                        "-",
                        "-",
                        "-",
                        "-",
                        "-",
                        "No identificado"
                        );
                    labelInfoCapture.Text = "Placa no identificado";
                    labelInfoCapture.ForeColor = Color.Red;
                }
            }
        }

        private void cropImage(int x, int y, int width, int height, string image, PictureBox pictureBox)
        {
            try
            {
                Rectangle rect = new Rectangle(x, y, width, height);

                Bitmap imgBmp = new Bitmap(image);
                imgBmp = imgBmp.Clone(rect, imgBmp.PixelFormat);
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                }

                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = imgBmp;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void clearDatas()
        {
            if (pictureBoxOutput.Image != null) pictureBoxOutput.Image = null;
            if (pictureBoxPlate.Image != null) pictureBoxPlate.Image = null;
            this.labelInfoCapture.Text = "Info message";
            this.labelResult.Text = "Placa: " +
                                    "\nModelo: " +
                                    "\nMarca: " +
                                    "\nCategoría: ";
            labelColor.BackColor = Color.Transparent;
            labelColor.Text = "Sin color";
        }
    }
}
