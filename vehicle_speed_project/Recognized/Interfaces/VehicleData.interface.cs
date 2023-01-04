using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_speed_project.Recognized.Interfaces
{
    public partial class VehicleData
    {
        public Data Data { get; set; }
        public string Nodename { get; set; }
        public long Nodetime { get; set; }
        public string Version { get; set; }
    }

    public partial class Data
    {
        public Vehicle[] Vehicles { get; set; }
    }

    public partial class Vehicle
    {
        public Plate Plate { get; set; }
        public Mmr Mmr { get; set; }
        public Bounds Bounds { get; set; }
    }

    public partial class Bounds
    {
        public ExtendedPlateFrame VehicleFrame { get; set; }
        public ExtendedPlateFrame ExtendedPlateFrame { get; set; }
    }

    public partial class ExtendedPlateFrame
    {
        public BottomLeft BottomLeft { get; set; }
        public BottomLeft BottomRight { get; set; }
        public BottomLeft TopLeft { get; set; }
        public BottomLeft TopRight { get; set; }
    }

    public partial class BottomLeft
    {
        public long X { get; set; }
        public long Y { get; set; }
    }

    public partial class Mmr
    {
        public string Engine { get; set; }
        public bool Found { get; set; }
        public long Proctime { get; set; }
        public string Category { get; set; }
        public long CategoryConfidence { get; set; }
        public Color Color { get; set; }
        public long ColorConfidence { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public long MakeConfidence { get; set; }
        public long ModelConfidence { get; set; }
        public string Heading { get; set; }
        public long HeadingConfidence { get; set; }
    }

    public partial class Color
    {
        public long R { get; set; }
        public long G { get; set; }
        public long B { get; set; }
    }

    public partial class Plate
    {
        public bool Found { get; set; }
        public string Country { get; set; }
        public string Category { get; set; }
        public long PlateTypeConfidence { get; set; }
        public long PositionConfidence { get; set; }
        public PlateChar[] PlateChars { get; set; }
        public string UnicodeText { get; set; }
        public string SeparatedText { get; set; }
        public string Engine { get; set; }
        public long Proctime { get; set; }
        public Color BgColor { get; set; }
        public Color Color { get; set; }
        public long Confidence { get; set; }
        public ExtendedPlateFrame PlateRoi { get; set; }
        public long PlateType { get; set; }
    }

    public partial class PlateChar
    {
        public Color BgColor { get; set; }
        public ExtendedPlateFrame CharRoi { get; set; }
        public long Code { get; set; }
        public Color Color { get; set; }
        public long Confidence { get; set; }
    }
}
