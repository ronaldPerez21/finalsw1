using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


//    var licensePlate = LicensePlate.FromJson(jsonString);

namespace vehicle_speed_project.Recognized.Interfaces
{
    public partial class LicensePlate
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("licensePlate")]
        public string LicensePlateLicensePlate { get; set; }

        [JsonProperty("licensePlateOwner")]
        public string LicensePlateOwner { get; set; }

        [JsonProperty("ownerDocument")]
        public string OwnerDocument { get; set; }

        [JsonProperty("model")]
        public object Model { get; set; }

        [JsonProperty("year")]
        public object Year { get; set; }

        [JsonProperty("color")]
        public object Color { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class LicensePlate
    {
        public static LicensePlate FromJson(string json) => JsonConvert.DeserializeObject<LicensePlate>(json, vehicle_speed_project.Recognized.Interfaces.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LicensePlate self) => JsonConvert.SerializeObject(self, vehicle_speed_project.Recognized.Interfaces.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
