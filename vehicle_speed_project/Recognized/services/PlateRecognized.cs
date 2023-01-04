using System;

using Newtonsoft.Json;
using RestSharp;
using vehicle_speed_project.Recognized.Interfaces;

namespace vehicle_speed_project.Recognized.services
{
    class PlateRecognized
    {

        private string urlCloudRecognition;
        private string apiKey;

        public PlateRecognized()
        {
            urlCloudRecognition = "https://api.cloud.adaptiverecognition.com/";
            apiKey = "4499a8ad034551f5252a78facd588b54f364a03f";
        }

        public VehicleData analizeVehicle(string service, string fileName, string location, int maxreads)
        {
            try
            {
                var client = new RestClient(urlCloudRecognition);
                var request = new RestRequest("vehicle/sam", Method.Post);
                request.AddHeader("X-Api-Key", apiKey);
                request.AddParameter("service", service);
                request.AddFile("image", fileName);
                request.AddParameter("location", location);
                request.AddParameter("maxreads", maxreads);

                var response = client.Execute(request);
                VehicleData vehicleData = JsonConvert.DeserializeObject<VehicleData>(response.Content);
                return vehicleData;
            }catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                return null;
            }
        }
    }
}
