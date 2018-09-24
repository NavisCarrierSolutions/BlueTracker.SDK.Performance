using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Scoc curve point
    /// </summary>
    public class ScocCurvePoint
    {
        /// <summary>
        /// X-Axis value ME load
        /// </summary>
        public double Load { get; set; }

        /// <summary>
        /// Y-Axis value specific cylinder oil consumption limit
        /// </summary>
        public double Scoc { get; set; }
    }
}
