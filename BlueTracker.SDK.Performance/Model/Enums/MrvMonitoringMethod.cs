namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// MRV monitoring methods
    /// </summary>
    public enum MrvMonitoringMethod
    {
        /// <summary>
        /// BDN periodic stock takes
        /// </summary>
        BdnPeriodicStocktakes = 0,

        /// <summary>
        /// Fuel tank monitoring
        /// </summary>
        FuelTankMonitoring = 1,

        /// <summary>
        /// Flow meter measurement
        /// </summary>
        FlowMeterMeasurement = 2,
        /// <summary>
        /// Method D (DirectCo2Measurement) is not supported and not certified
        /// </summary>
        DirectCo2Measurement = 3
    }
}
