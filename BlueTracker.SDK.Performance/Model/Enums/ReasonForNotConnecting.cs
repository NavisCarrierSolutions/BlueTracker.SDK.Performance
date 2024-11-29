namespace BlueTracker.SDK.Performance.Model.Enums
{
    public enum ReasonForNotConnecting
    {

        /// <summary>
        /// Unspecified
        /// </summary>
        Unspecified = 0,

        /// <summary>
        /// Short stay (less than 2 hours)
        /// </summary>
        ShortStay = 1,

        /// <summary>
        /// Zero-Emission Technology used
        /// </summary>
        ZeroEmissionTech = 2,

        /// <summary>
        /// Emergency Stop
        /// </summary>
        EmergencyStop = 3,

        /// <summary>
        /// Insufficient available shore power (network limitations)
        /// </summary>
        NetworkLimitations = 4,

        /// <summary>
        /// Incompatibility of OPS
        /// </summary>
        IncompOPS = 5,

        /// <summary>
        /// Onboard Generator required (due to emergency)
        /// </summary>
        OnBoardGenRequired = 6,

        /// <summary>
        /// Maintanance and functional tests carried out
        /// </summary>
        FunctionalTest = 7,

        /// <summary>
        /// Survey or inspection
        /// </summary>
        SurveyInspection = 8,
    }
}
