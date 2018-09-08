namespace BlueTracker.SDK.Performance.Ship
{
    /// <summary>
    /// Cargo related ship data.
    /// </summary>
    public class Cargo
    {
        /// <summary>
        /// TEU capacity (including FEU).
        /// </summary>
        public double? TeuCapacity { get; set; }

        /// <summary>
        /// Cargo deadweight. (tons)
        /// </summary>
        public double? DeadWeight { get; set; }

        /// <summary>
        /// Number of available reefer plugs.
        /// </summary>
        public int? ReeferPlugs { get; set; }
    }
}
