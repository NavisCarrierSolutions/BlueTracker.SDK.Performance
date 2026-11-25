// ReSharper disable InconsistentNaming
namespace BlueTracker.SDK.Performance.Model.Enums
{
    /// <summary>
    /// Known fuel types.
    /// </summary>
    public enum FuelKindOptions
    {
        /// <summary>
        /// Undefined
        /// </summary>
        Undef,

        /// <summary>
        /// HFO (Heavy Fuel Oil)
        /// </summary>
        HFO,

        /// <summary>
        /// HFOHS (Heavy Fuel Oil Heavy Sulphur)
        /// </summary>
        HFOHS,

        /// <summary>
        /// HFOLS (Heavy Fuel Oil Low Sulphur)
        /// </summary>
        HFOLS,

        /// <summary>
        /// HFOLLS (Heavy Fuel Oil Low Low Sulphur)
        /// </summary>
        HFOLLS,

        /// <summary>
        /// LFO (Light Fuel Oil (RMA30,RMB30,RMD80))
        /// </summary>
        LFO,

        /// <summary>
        /// Marine Diesel Oil
        /// </summary>
        MDO,

        /// <summary>
        /// Marine Diesel Oil Heavy Sulphur
        /// </summary>
        MDOHS,

        /// <summary>
        /// Marine Diesel Oil Low Sulphur
        /// </summary>
        MDOLS,

        /// <summary>
        /// Marine Diesel Oil Low Low Sulphur
        /// </summary>
        MDOLLS,

        /// <summary>
        /// Marine Gasoil
        /// </summary>
        MGO,

        /// <summary>
        /// Marine Gasoil Low Sulphur
        /// </summary>
        MGOLS,

        /// <summary>
        /// Marine Gasoil Low Low Sulphur
        /// </summary>
        MGOLLS,

        /// <summary>
        /// Liquefied Natural Gase
        /// </summary>
        LNG,

        /// <summary>
        /// Liquefied Petroleum Gas (Propane)
        /// </summary>
        Propane,

        /// <summary>
        /// Liquefied Petroleum Gas (Butane)
        /// </summary>
        Butane,

        /// <summary>
        /// Methanol
        /// </summary>
        Methanol,

        /// <summary>
        /// Ethanol
        /// </summary>
        Ethanol,

        /// <summary>
        /// Biomass To Liquid
        /// </summary>
        BTL,    // Biomass To Liquid

        /// <summary>
        /// Fatty Acid Methyl Ester
        /// </summary>
        FAME,   // Fatty Acid Methyl Ester

        /// <summary>
        /// Hydrogen Vegetable Oil
        /// </summary>
        HVO,

        /// <summary>
        /// Bio fuel blended with fossil fuel.
        /// </summary>
        BioFuelBlend,

        /// <summary>
        /// LFO Low Sulphur
        /// </summary>
        LFOLS,

        /// <summary>
        /// LFO Low Low Sulphur
        /// </summary>
        LFOLLS,

        /// <summary>
        /// Bio methanol
        /// </summary>
        BioMethanol,

        /// <summary>
        /// Methanol (produced by electricity from renewable sources).
        /// </summary>
        EMethanol,

        /// <summary>
        /// Bio LNG
        /// </summary>
        BioLNG,

        /// <summary>
        /// LNG (produced by electricity from renewable sources).
        /// </summary>
        ELNG,

        /// <summary>
        /// LPG (Liquid petroleum gas)
        /// </summary>
        LPG,

        /// <summary>
        /// Blue LNG (low carbon Liquefied Natural Gas)
        /// </summary>
        BlueLNG,

        /// <summary>
        /// Bio LPG
        /// </summary>
        BioLPG,

        /// <summary>
        /// RDME (Renewable DiMethyl Ether)
        /// </summary>
        RDME,

        /// <summary>
        /// RDME Blend (Renewable DiMethyl Ether Blend)
        /// </summary>
        RDMEBlend,

        /// <summary>
        /// Blue Methanol (low carbon Methanol)
        /// </summary>
        BlueMethanol,

        /// <summary>
        /// Bio Ethanol
        /// </summary>
        BioEthanol,

        /// <summary>
        /// NH3 (Ammonia)
        /// </summary>
        NH3,

        /// <summary>
        /// Blue NH3 (low carbon Ammonia)
        /// </summary>
        BlueNH3,

        /// <summary>
        /// Bio NH3 (Bio Ammonia)
        /// </summary>
        BioNH3,

        /// <summary>
        /// NH3 (synthetic Ammonia)
        /// </summary>
        ENH3,

        /// <summary>
        /// H2 (Hydrogen)
        /// </summary>
        H2,

        /// <summary>
        /// Blue H2 (low carbon Hydrogen)
        /// </summary>
        BlueH2,

        /// <summary>
        /// H2 (synthetic Hydrogen)
        /// </summary>
        EH2,

        /// <summary>
        /// Bio H2 (bio Hydrogen)
        /// </summary>
        BioH2
    }
}