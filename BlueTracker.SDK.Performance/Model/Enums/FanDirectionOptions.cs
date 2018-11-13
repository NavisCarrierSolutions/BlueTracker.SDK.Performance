namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Direction of fan operation (exhaust/supply).
    /// </summary>
    public enum FanDirectionOptions
    {
        /// <summary>
        /// Unspecified operation mode.
        /// </summary>
        Unspecified,

        /// <summary>
        /// Fan is operated in supply mode (blowing).
        /// </summary>
        Supply,

        /// <summary>
        /// Fan is operated in exhaust mode (sucking).
        /// </summary>
        Exhaust
    }
}