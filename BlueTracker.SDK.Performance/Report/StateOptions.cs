using System.Runtime.Serialization;

namespace BlueTracker.SDK.Performance.Report
{
    /// <summary>
    /// Operation state of the vessel.
    /// </summary>
    public enum StateOptions
    {
        /// <summary>
        /// Undefined state.
        /// </summary>
        [EnumMember(Value = "undefined")]
        Undefined = 0,

        /// <summary>
        /// Vessel is at sea and sailing/steaming.
        /// </summary>
        [EnumMember(Value = "atSea")]
        AtSea = 1,

        /// <summary>
        /// Vessel is at sea and sailing/steaming.
        /// </summary>
        [EnumMember(Value = "inPort")]
        InPort = 2,

        /// <summary>
        /// Vessel is in manoeuvring.
        /// </summary>
        [EnumMember(Value = "manoeuvring")]
        Manoeuvring = 3,

        /// <summary>
        /// Vessel is at anchor.
        /// </summary>
        [EnumMember(Value = "atAnchor")]
        AtAnchor = 4,

        /// <summary>
        /// Vessel is drifting.
        /// </summary>
        [EnumMember(Value = "drifting")]
        Drifting = 5
    }
}