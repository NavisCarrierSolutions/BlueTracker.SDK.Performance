namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Charter instructions for parties with consumption cap.
    /// </summary>
    public enum CharterPartyInstruction
    {
        /// <summary>
        /// No instructions (will fallback to single)
        /// </summary>
        Undefined = 0,
        /// <summary>
        /// Single instruction. 
        /// </summary>
        Single = 1,
        /// <summary>
        /// Multiple instructions.
        /// </summary>
        Multiple = 2
    }
}
