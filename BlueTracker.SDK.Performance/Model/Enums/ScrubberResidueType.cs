using System.Runtime.Serialization;

namespace BlueTracker.SDK.Performance.Model.Enums
{
    public enum ScrubberResidueType
    {
        [EnumMember(Value = "solid")]
        Solid = 0,
        [EnumMember(Value = "liquid")]
        Liquid = 1
    }
}
