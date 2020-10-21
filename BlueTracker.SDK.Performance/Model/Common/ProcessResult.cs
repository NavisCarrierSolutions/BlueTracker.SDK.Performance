using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Model.Common
{
    public class ProcessResult
    {
        public ProcessResultOptions Result { get; set; }

        public string Message { get; set; }

        public double Accuracy { get; set; }

        public double? FinalAccuracy { get; set; }
    }
}