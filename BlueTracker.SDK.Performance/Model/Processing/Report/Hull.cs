namespace BlueTracker.SDK.Performance.Model.Processing.Report
{
    public class Hull
    {
        public double? MeanDraft { get; set; }

        public double? TransverseProjectedArea { get; set; }

        public double? WindResistanceCoefficientHead { get; set; }

        public double? WindResistanceCoefficientActual { get; set; }

        public double? PropulsionEfficiencyCoefficientCalm { get; set; }

        public double? PropulsionEfficiencyCoefficientActual { get; set; }

        public double? WindResistanceCorrection { get; set; }

        public double? DeliveredPowerCorrected { get; set; }

        public double? SpeedLossCorrected { get; set; }

        public double? SpeedLossUncorrected { get; set; }
    }
}