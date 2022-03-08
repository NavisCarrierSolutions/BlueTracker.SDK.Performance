using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.DTO.Post
{
    /// <summary>
    /// Defines a cargo parcel sequence for voyage.
    /// </summary>
    public class CargoParcelSequenceData
    {
        public List<CargoParcelData> CargoParcels { get; set; }
    }
}
