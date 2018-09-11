namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// O - Exclude nothing.
    /// 4 - Exclude major issues.
    /// 3 - Exclude major and minor issues.
    /// </summary>
    public enum ExcludedIssues
    {
        ExcludeNothing = 0,
        ExcludeMajorAndMinorIssues = 3,
        ExcludeMajorIssues = 4
    }
}
