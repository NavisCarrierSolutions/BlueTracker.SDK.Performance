using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Model.Common
{
    public class PlausibilityResult
    {
        public PlausibilityResultOptions Result { get; set; }

        public string Message { get; set; }

        public PlausibilationAreaOptions[] PlausibilationAreas { get; set; }
    }
}