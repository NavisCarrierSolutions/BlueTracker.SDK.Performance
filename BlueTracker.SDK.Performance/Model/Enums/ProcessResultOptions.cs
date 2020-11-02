namespace BlueTracker.SDK.Performance.Model.Enums
{
    public enum ProcessResultOptions
    {
        /// <summary>
        /// Processing failed due to an internal error.
        /// </summary>
        Failed,

        /// <summary>
        /// Processing failed due to missing input values.
        /// </summary>
        DataMissing,

        /// <summary>
        /// Processing completed successfully.
        /// </summary>
        Success,

        /// <summary>
        /// Processing completed successfully, however the value is based on an estimation.
        /// </summary>
        Estimation,

        /// <summary>
        /// Processing completed successfully, however the value is assumed due to missing input values.
        /// </summary>
        Assumption,

        /// <summary>
        /// Calculation yielded an invalid result (e.g. NaN or infinity).
        /// </summary>
        Invalid
    }
}