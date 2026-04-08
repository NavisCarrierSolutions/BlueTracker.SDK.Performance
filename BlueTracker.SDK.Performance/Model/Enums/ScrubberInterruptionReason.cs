using System.Runtime.Serialization;

namespace BlueTracker.SDK.Performance.Model.Enums
{
    public enum ScrubberInterruptionReason
    {
        [EnumMember(Value = "scrubberNotInUseAsPerCharter")]
        ScrubberNotInUseAsPerCharter = 0,
        [EnumMember(Value = "scrubberNotInUseToOperational")]
        ScrubberNotInUseToOperational = 1,
        [EnumMember(Value = "scrubberOperationNotAllowed")]
        ScrubberOperationNotAllowed = 2,
        [EnumMember(Value = "technicalIssues")]
        TechnicalIssues = 3,
        [EnumMember(Value = "technicalIssuesClose")]
        TechnicalIssuesClose = 4,
        [EnumMember(Value = "technicalIssuesOpenClose")]
        TechnicalIssuesOpenClose = 5
    }
}
