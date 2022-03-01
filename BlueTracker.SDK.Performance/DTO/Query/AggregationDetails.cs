using System.Collections.Generic;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    public class AggregationDetails
    {
        public List<MainEngine> MainEngines { get; set; }

        public List<AuxEngine> AuxEngines { get; set; }

        public List<Boiler> Boilers { get; set; }

        public List<AggregateConsumption> AggregateConsumptions { get; set; }

        public OtherConsumption OtherConsumptions { get; set; }
    }
}
