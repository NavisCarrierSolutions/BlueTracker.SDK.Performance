using BlueTracker.SDK.Performance.Core;

namespace BlueTracker.SDK.Performance.Processing.Reports
{
    public class Environment
    {
        public double? AirTemp { get; set; }

        public double? AirPress { get; set; }

        public double? AirDensity { get; set; }

        public double? SeaWaterTemp { get; set; }

        public int? SeaState { get; set; }

        public int? DouglasSeaScale { get; set; }

        public double? ReferenceHeight { get; set; }

        public HeightDirection Wave { get; set; }

        public HeightDirection Swell { get; set; }

        public SpeedDirection Wind { get; set; }

        public SpeedDirection WindAtReferenceHeight { get; set; }
    }
}