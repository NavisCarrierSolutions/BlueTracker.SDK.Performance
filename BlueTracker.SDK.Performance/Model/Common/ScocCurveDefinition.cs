using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTracker.SDK.Performance.Model.Common
{
    /// <summary>
    /// Definition of scoc curve
    /// </summary>
    public class ScocCurveDefinition
    {
        /// <summary>
        /// The name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Points of load vs scoc curve.
        /// </summary>
        public ScocCurvePoint[] CurvePoints { get; set; }
    }
}
