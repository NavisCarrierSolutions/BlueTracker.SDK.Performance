using BlueTracker.SDK.Performance.Model.Enums;

namespace BlueTracker.SDK.Performance.Model.Basic.Sample
{
    /// <summary>
    ///     Tank for lub oil
    /// </summary>
    public class LubOilTank : Tank
    {
        /// <summary>
        ///     Kind of lub oil
        /// </summary>
        public LubOilKindOptions LubOilType { get; set; }
    }
}