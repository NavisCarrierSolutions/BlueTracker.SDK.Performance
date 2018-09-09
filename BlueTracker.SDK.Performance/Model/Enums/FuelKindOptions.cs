// ReSharper disable InconsistentNaming
namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Known fuel kinds.
    /// </summary>
    public enum FuelKindOptions
    {
        /// <summary>
        /// Undefined fuel type. Use this if the kind of fuel is unknown or not included.
        /// </summary>
        Undef,

        /// <summary>
        /// Heavy Fuel Oil (unspecific sulfur content).
        /// </summary>
        HFO,

        /// <summary>
        /// Heavy Fuel Oil (high sulfur content).
        /// </summary>
        HFOHS,

        /// <summary>
        /// Heavy Fuel Oil (low sulfur content).
        /// </summary>
        HFOLS,

        /// <summary>
        /// Heavy Fuel Oil (very low sulfur content).
        /// </summary>
        HFOLLS,

        /// <summary>
        /// Marine Diesel Oil (unspecific sulfur content).
        /// </summary>
        MDO,

        /// <summary>
        /// Marine Diesel Oil (high sulfur content).
        /// </summary>
        MDOHS,

        /// <summary>
        /// Marine Diesel Oil(low sulfur content).
        /// </summary>
        MDOLS,

        /// <summary>
        /// Marine Diesel Oil (very low sulfur content).
        /// </summary>
        MDOLLS,

        /// <summary>
        /// Marine Gas Oil (unspecific sulfur content).
        /// </summary>
        MGO,

        /// <summary>
        /// Marine Gas Oil (low sulfur content).
        /// </summary>
        MGOLS,

        /// <summary>
        /// Marine Gas Oil (very low sulfur content).
        /// </summary>
        MGOLLS
    }
}