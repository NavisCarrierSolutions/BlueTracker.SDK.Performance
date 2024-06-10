using BlueTracker.SDK.Performance.Model.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace BlueTracker.SDK.Performance.DTO.Query
{
    /// <summary>
    ///     Performance report summary.
    /// </summary>
    public class PerformanceReportSummary
    {
        /// <summary>
        ///     Total FOC AB HFO
        /// </summary>
        public double? AbHfoFoc { get; set; }

        /// <summary>
        ///     Boiler HFO kinematic viscosity (cSt).
        /// </summary>
        public double? AbHfoKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler HFO LCV (kJ/kg).
        /// </summary>
        public double? AbHfoLcv { get; set; }

        /// <summary>
        ///     Boiler HFO sulphur content (%).
        /// </summary>
        public double? AbHfoSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler HFO HS (metric tons).
        /// </summary>
        public double? AbHfoHsFoc { get; set; }

        /// <summary>
        ///     Boiler HFO HS kinematic viscosity (cSt).
        /// </summary>
        public double? AbHfoHsKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler HFO HS LCV (kJ/kg).
        /// </summary>
        public double? AbHfoHsLcv { get; set; }

        /// <summary>
        ///     Boiler HFO HS sulphur content (%).
        /// </summary>
        public double? AbHfoHsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler HFO LLS (metric tons).
        /// </summary>
        public double? AbHfoLlsFoc { get; set; }

        /// <summary>
        ///     Boiler HFO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? AbHfoLlsKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler HFO LLS LCV (kJ/kg).
        /// </summary>
        public double? AbHfoLlsLcv { get; set; }

        /// <summary>
        ///     Boiler HFO LLS sulphur content (%).
        /// </summary>
        public double? AbHfoLlsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler HFO LS (metric tons).
        /// </summary>
        public double? AbHfoLsFoc { get; set; }

        /// <summary>
        ///     Boiler HFO LS kinematic viscosity (cSt).
        /// </summary>
        public double? AbHfoLsKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler HFO LS LCV (kJ/kg).
        /// </summary>
        public double? AbHfoLsLcv { get; set; }

        /// <summary>
        ///     Boiler HFO LS sulphur content (%).
        /// </summary>
        public double? AbHfoLsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler LFO (metric tons).
        /// </summary>
        public double? AbLfoFoc { get; set; }

        /// <summary>
        ///     Boiler LFO kinematic viscosity (cSt).
        /// </summary>
        public double? AbLfoKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler LFO LCV (kJ/kg).
        /// </summary>
        public double? AbLfoLcv { get; set; }

        /// <summary>
        ///     Boiler LFO sulphur content (%).
        /// </summary>
        public double? AbLfoSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler MDO (metric tons).
        /// </summary>
        public double? AbMdoFoc { get; set; }

        /// <summary>
        ///     Boiler MDO kinematic viscosity (cSt).
        /// </summary>
        public double? AbMdoKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler MDO LCV (kJ/kg).
        /// </summary>
        public double? AbMdoLcv { get; set; }

        /// <summary>
        ///     Boiler MDO sulphur content (%).
        /// </summary>
        public double? AbMdoSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler MDO HS (metric tons).
        /// </summary>
        public double? AbMdoHsFoc { get; set; }

        /// <summary>
        ///     Boiler MDO HS kinematic viscosity (cSt).
        /// </summary>
        public double? AbMdoHsKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler MDO HS LCV (kJ/kg).
        /// </summary>
        public double? AbMdoHsLcv { get; set; }

        /// <summary>
        ///     Boiler MDO HS sulphur content (%).
        /// </summary>
        public double? AbMdoHsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler MDO LLS (metric tons).
        /// </summary>
        public double? AbMdoLlsFoc { get; set; }

        /// <summary>
        /// Boiler MDO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? AbMdoLlsKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler MDO LLS LCV (kJ/kg).
        /// </summary>
        public double? AbMdoLlsLcv { get; set; }

        /// <summary>
        ///     Boiler MDO LLS sulphur content (%).
        /// </summary>
        public double? AbMdoLlsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler MDO LS (metric tons).
        /// </summary>
        public double? AbMdoLsFoc { get; set; }

        /// <summary>
        /// Boiler MDO LS kinematic viscosity (cSt).
        /// </summary>
        public double? AbMdoLsKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler MDO LS LCV (kJ/kg).
        /// </summary>
        public double? AbMdoLsLcv { get; set; }

        /// <summary>
        ///     Boiler MDO LS sulphur content (%).
        /// </summary>
        public double? AbMdoLsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler MGO (metric tons).
        /// </summary>
        public double? AbMgoFoc { get; set; }

        /// <summary>
        /// Boiler MGO kinematic viscosity (cSt).
        /// </summary>
        public double? AbMgoKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler MGO LCV (kJ/kg).
        /// </summary>
        public double? AbMgoLcv { get; set; }

        /// <summary>
        ///     Boiler MGO sulphur content (%).
        /// </summary>
        public double? AbMgoSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler MGO LLS (metric tons).
        /// </summary>
        public double? AbMgoLlsFoc { get; set; }

        /// <summary>
        /// Boiler MGO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? AbMgoLlsKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler MGO LLS LCV (kJ/kg).
        /// </summary>
        public double? AbMgoLlsLcv { get; set; }

        /// <summary>
        ///     Boiler MGO LLS sulphur content (%).
        /// </summary>
        public double? AbMgoLlsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler MGO LS (metric tons).
        /// </summary>
        public double? AbMgoLsFoc { get; set; }

        /// <summary>
        /// Boiler MGO LS kinematic viscosity (cSt).
        /// </summary>
        public double? AbMgoLsKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler MGO LS LCV (kJ/kg).
        /// </summary>
        public double? AbMgoLsLcv { get; set; }

        /// <summary>
        ///     Boiler MGO LS sulphur content (%).
        /// </summary>
        public double? AbMgoLsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler Methanol (metric tons).
        /// </summary>
        public double? AbMethanolFoc { get; set; }

        /// <summary>
        /// Boiler Methanol kinematic viscosity (cSt).
        /// </summary>
        public double? AbMethanolKinematicViscosity { get; set; }

        /// <summary>
        /// Boiler Ethanol kinematic viscosity (cSt).
        /// </summary>
        public double? AbEthanolKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler Methanol LCV (kJ/kg).
        /// </summary>
        public double? AbMethanolLcv { get; set; }

        /// <summary>
        ///     Boiler Methanol sulphur content (%).
        /// </summary>
        public double? AbMethanolSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler LNG (metric tons).
        /// </summary>
        public double? AbLngFoc { get; set; }

        /// <summary>
        /// Boiler LNG kinematic viscosity (cSt).
        /// </summary>
        public double? AbLngKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler LNG LCV (kJ/kg).
        /// </summary>
        public double? AbLngLcv { get; set; }

        /// <summary>
        ///     Boiler LNG sulphur content (%).
        /// </summary>
        public double? AbLngSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler BTL (metric tons).
        /// </summary>
        public double? AbBtlFoc { get; set; }

        /// <summary>
        /// Boiler BTL kinematic viscosity (cSt).
        /// </summary>
        public double? AbBtlKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler BTL LCV (kJ/kg).
        /// </summary>
        public double? AbBtlLcv { get; set; }

        /// <summary>
        ///     Boiler BTL sulphur content (%).
        /// </summary>
        public double? AbBtlSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler FAME (metric tons).
        /// </summary>
        public double? AbFameFoc { get; set; }

        /// <summary>
        /// Boiler FAME kinematic viscosity (cSt).
        /// </summary>
        public double? AbFameKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler FAME LCV (kJ/kg).
        /// </summary>
        public double? AbFameLcv { get; set; }

        /// <summary>
        ///     Boiler FAME sulphur content (%).
        /// </summary>
        public double? AbFameSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler HVO (metric tons).
        /// </summary>
        public double? AbHvoFoc { get; set; }

        /// <summary>
        /// Boiler HVO kinematic viscosity (cSt).
        /// </summary>
        public double? AbHvoKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler HVO LCV (kJ/kg).
        /// </summary>
        public double? AbHvoLcv { get; set; }

        /// <summary>
        ///     Boiler HVO sulphur content (%).
        /// </summary>
        public double? AbHvoSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC Boiler Bio Fuel Blend (metric tons).
        /// </summary>
        public double? AbBioFuelBlendFoc { get; set; }

        /// <summary>
        /// Boiler Bio Fuel Blend kinematic viscosity (cSt).
        /// </summary>
        public double? AbBioFuelBlendKinematicViscosity { get; set; }

        /// <summary>
        ///     Boiler Bio Fuel Blend LCV (kJ/kg).
        /// </summary>
        public double? AbBioFuelBlendLcv { get; set; }

        /// <summary>
        ///     Boiler Bio Fuel Blend sulphur content (%).
        /// </summary>
        public double? AbBioFuelBlendSulphurContent { get; set; }

        /// <summary>
        ///     Boiler average percentage of Bio Fuel in Blend (%).
        /// </summary>
        public double? AbAveragePercentageOfBioFuelInBlend { get; set; }

        /// <summary>
        ///     Most occuring Bio Fuel Kind in Boiler Bio Fuel Blends.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public BioBlendOptions? AbMostOccurringBioFuelKindInBlend { get; set; }

        /// <summary>
        ///     Most occuring Fossil Fuel Kind in Boiler Bio Fuel Blends.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public FossilBlendOptions? AbMostOccurringFossilFuelKindInBlend { get; set; }

        /// <summary>
        ///     Total FOC AE HFO (metric tons).
        /// </summary>
        public double? AeHfoFoc { get; set; }

        /// <summary>
        /// AE HFO kinematic viscosity (cSt).
        /// </summary>
        public double? AeHfoKinematicViscosity { get; set; }

        /// <summary>
        /// AE HFO LCV (kJ/kg).
        /// </summary>
        public double? AeHfoLcv { get; set; }

        /// <summary>
        ///     AE HFO sulphur content (%).
        /// </summary>
        public double? AeHfoSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC AE HFO HS (metric tons).
        /// </summary>
        public double? AeHfoHsFoc { get; set; }

        /// <summary>
        /// AE HFO HS kinematic viscosity (cSt).
        /// </summary>
        public double? AeHfoHsKinematicViscosity { get; set; }

        /// <summary>
        /// AE HFO HS LCV (kJ/kg).
        /// </summary>
        public double? AeHfoHsLcv { get; set; }

        /// <summary>
        ///     AE HFO HS sulphur content (%).
        /// </summary>
        public double? AeHfoHsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC AE HFO LLS (metric tons).
        /// </summary>
        public double? AeHfoLlsFoc { get; set; }

        /// <summary>
        /// AE HFO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? AeHfoLlsKinematicViscosity { get; set; }

        /// <summary>
        /// AE HFO LLS LCV (kJ/kg).
        /// </summary>
        public double? AeHfoLlsLcv { get; set; }

        /// <summary>
        ///     AE HFO LLS sulphur content (%).
        /// </summary>
        public double? AeHfoLlsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC AE HFO LS (metric tons).
        /// </summary>
        public double? AeHfoLsFoc { get; set; }

        /// <summary>
        /// AE HFO LS kinematic viscosity (cSt).
        /// </summary>
        public double? AeHfoLsKinematicViscosity { get; set; }

        /// <summary>
        /// AE HFO LS LCV (kJ/kg).
        /// </summary>
        public double? AeHfoLsLcv { get; set; }

        /// <summary>
        /// AE HFO LS sulphur content (%).
        /// </summary>
        public double? AeHfoLsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC AE LFO (metric tons).
        /// </summary>
        public double? AeLfoFoc { get; set; }

        /// <summary>
        /// AE LFO kinematic viscosity (cSt).
        /// </summary>
        public double? AeLfoKinematicViscosity { get; set; }

        /// <summary>
        /// AE LFO LCV (kJ/kg).
        /// </summary>
        public double? AeLfoLcv { get; set; }

        /// <summary>
        /// AE LFO sulphur content (%).
        /// </summary>
        public double? AeLfoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE MDO (metric tons).
        /// </summary>
        public double? AeMdoFoc { get; set; }

        /// <summary>
        /// AE MDO kinematic viscosity (cSt).
        /// </summary>
        public double? AeMdoKinematicViscosity { get; set; }

        /// <summary>
        /// AE MDO LCV (kJ/kg).
        /// </summary>
        public double? AeMdoLcv { get; set; }

        /// <summary>
        /// AE MDO sulphur content (%).
        /// </summary>
        public double? AeMdoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE MDO HS (metric tons).
        /// </summary>
        public double? AeMdoHsFoc { get; set; }

        /// <summary>
        /// AE MDO HS kinematic viscosity (cSt).
        /// </summary>
        public double? AeMdoHsKinematicViscosity { get; set; }

        /// <summary>
        /// AE MDO HS LCV (kJ/kg).
        /// </summary>
        public double? AeMdoHsLcv { get; set; }

        /// <summary>
        /// AE MDO HS sulphur content (%).
        /// </summary>
        public double? AeMdoHsSulphurContent { get; set; }

        /// <summary>
        ///     Total FOC AE MDO LLS (metric tons).
        /// </summary>
        public double? AeMdoLlsFoc { get; set; }

        /// <summary>
        /// AE MDO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? AeMdoLlsKinematicViscosity { get; set; }

        /// <summary>
        /// AE MDO LLS LCV (kJ/kg).
        /// </summary>
        public double? AeMdoLlsLcv { get; set; }

        /// <summary>
        /// AE MDO LLS sulphur content (%).
        /// </summary>
        public double? AeMdoLlsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE MDO LS (metric tons).
        /// </summary>
        public double? AeMdoLsFoc { get; set; }

        /// <summary>
        /// AE MDO LS kinematic viscosity (cSt).
        /// </summary>
        public double? AeMdoLsKinematicViscosity { get; set; }

        /// <summary>
        /// AE MDO LS LCV (kJ/kg).
        /// </summary>
        public double? AeMdoLsLcv { get; set; }

        /// <summary>
        /// AE MDO LS sulphur content (%).
        /// </summary>
        public double? AeMdoLsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE MGO (metric tons).
        /// </summary>
        public double? AeMgoFoc { get; set; }

        /// <summary>
        /// AE MGO kinematic viscosity (cSt).
        /// </summary>
        public double? AeMgoKinematicViscosity { get; set; }

        /// <summary>
        /// AE MGO LCV (kJ/kg).
        /// </summary>
        public double? AeMgoLcv { get; set; }

        /// <summary>
        /// AE MGO sulphur content (%).
        /// </summary>
        public double? AeMgoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE MGO LLS (metric tons).
        /// </summary>
        public double? AeMgoLlsFoc { get; set; }

        /// <summary>
        /// AE MGO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? AeMgoLlsKinematicViscosity { get; set; }

        /// <summary>
        /// AE MGO LLS LCV (kJ/kg).
        /// </summary>
        public double? AeMgoLlsLcv { get; set; }

        /// <summary>
        /// AE MGO LLS sulphur content (%).
        /// </summary>
        public double? AeMgoLlsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE MGO LS (metric tons).
        /// </summary>
        public double? AeMgoLsFoc { get; set; }

        /// <summary>
        /// AE MGO LS kinematic viscosity (cSt).
        /// </summary>
        public double? AeMgoLsKinematicViscosity { get; set; }

        /// <summary>
        /// AE MGO LS LCV (kJ/kg).
        /// </summary>
        public double? AeMgoLsLcv { get; set; }

        /// <summary>
        /// AE MGO LS sulphur content (%).
        /// </summary>
        public double? AeMgoLsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE Methanol (metric tons).
        /// </summary>
        public double? AeMethanolFoc { get; set; }

        /// <summary>
        /// AE Methanol kinematic viscosity (cSt).
        /// </summary>
        public double? AeMethanolKinematicViscosity { get; set; }

        /// <summary>
        /// AE Ethanol kinematic viscosity (cSt).
        /// </summary>
        public double? AeEthanolKinematicViscosity { get; set; }

        /// <summary>
        /// AE Methanol LCV (kJ/kg).
        /// </summary>
        public double? AeMethanolLcv { get; set; }

        /// <summary>
        /// AE Methanol sulphur content (%).
        /// </summary>
        public double? AeMethanolSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE LNG (metric tons).
        /// </summary>
        public double? AeLngFoc { get; set; }

        /// <summary>
        /// AE LNG kinematic viscosity (cSt).
        /// </summary>
        public double? AeLngKinematicViscosity { get; set; }

        /// <summary>
        /// AE LNG LCV (kJ/kg).
        /// </summary>
        public double? AeLngLcv { get; set; }

        /// <summary>
        /// AE LNG sulphur content (%).
        /// </summary>
        public double? AeLngSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE BTL (metric tons). 
        /// </summary>
        public double? AeBtlFoc { get; set; }

        /// <summary>
        /// AE BTL kinematic viscosity (cSt).
        /// </summary>
        public double? AeBtlKinematicViscosity { get; set; }

        /// <summary>
        /// AE BTL LCV (kJ/kg).
        /// </summary>
        public double? AeBtlLcv { get; set; }

        /// <summary>
        /// AE BTL sulphur content (%).
        /// </summary>
        public double? AeBtlSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE FAME (metric tons).
        /// </summary>
        public double? AeFameFoc { get; set; }

        /// <summary>
        /// AE FAME kinematic viscosity (cSt).
        /// </summary>
        public double? AeFameKinematicViscosity { get; set; }

        /// <summary>
        /// AE FAME LCV (kJ/kg).
        /// </summary>
        public double? AeFameLcv { get; set; }

        /// <summary>
        /// AE FAME sulphur content (%).
        /// </summary>
        public double? AeFameSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE HVO (metric tons).
        /// </summary>
        public double? AeHvoFoc { get; set; }

        /// <summary>
        /// AE HVO kinematic viscosity (cSt).
        /// </summary>
        public double? AeHvoKinematicViscosity { get; set; }

        /// <summary>
        /// AE HVO LCV (kJ/kg).
        /// </summary>
        public double? AeHvoLcv { get; set; }

        /// <summary>
        /// AE HVO sulphur content (%).
        /// </summary>
        public double? AeHvoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC AE Bio Fuel Blend (metric tons).
        /// </summary>
        public double? AeBioFuelBlendFoc { get; set; }

        /// <summary>
        /// AE LNG kinematic viscosity (cSt).
        /// </summary>
        public double? AeBioFuelBlendKinematicViscosity { get; set; }

        /// <summary>
        /// AE Bio Fuel Blend LCV (kJ/kg).
        /// </summary>
        public double? AeBioFuelBlendLcv { get; set; }

        /// <summary>
        /// AE Bio Fuel Blend sulphur content (%).
        /// </summary>
        public double? AeBioFuelBlendSulphurContent { get; set; }

        /// <summary>
        /// AE average percentage of bio fuel in blend.
        /// </summary>
        public double? AeAveragePercentageOfBioFuelInBlend { get; set; }

        /// <summary>
        /// AE most occurring bio fuel in blend.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public BioBlendOptions? AeMostOccurringBioFuelKindInBlend { get; set; }

        /// <summary>
        /// AE most occuring fossil fuel in blend.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public FossilBlendOptions? AeMostOccurringFossilFuelKindInBlend { get; set; }

        /// <summary>
        ///     Annual efficiency ratio (AER).
        /// </summary>
        public double? Aer { get; set; }

        public AggregationDetails AggregationDetails { get; set; }

        /// <summary>
        ///     Outside air pressure. (hPa)
        /// </summary>
        public double? AirPress { get; set; }

        /// <summary>
        ///     Outside air temperature. (°C)
        /// </summary>
        public double? AirTemp { get; set; }

        /// <summary>
        ///     Average relative aux engine generator power. (%)
        /// </summary>
        public double? AverageRelativeAeGeneratorPower { get; set; }

        /// <summary>
        ///     Average relative aux engine power. (%)
        /// </summary>
        public double? AverageRelativeAePower { get; set; }

        /// <summary>
        ///     Average relative main engine power. (%)
        /// </summary>
        public double? AverageRelativeMePower { get; set; }

        /// <summary>
        ///     Average shaft RPM. (1/min)
        /// </summary>
        public double? AverageShaftRpm { get; set; }

        /// <summary>
        ///     Average slip through water. (%)
        /// </summary>
        public double? AverageSlip { get; set; }

        /// <summary>
        ///     Average slip over ground. (%)
        /// </summary>
        public double? AverageSlipOverGround { get; set; }

        /// <summary>
        ///     Average speed over ground. (knots)
        /// </summary>
        public double? AverageSpeedOverGround { get; set; }

        /// <summary>
        ///     Average speed through water. (knots)
        /// </summary>
        public double? AverageSpeedThroughWater { get; set; }

        /// <summary>
        ///     Ballast water weight. (tons)
        /// </summary>
        public double? BallastWeight { get; set; }

        /// <summary>
        ///     Bunker fresh water bunkered. (cubic meters)
        /// </summary>
        public double? BunkerFreshWaterBunkered { get; set; }

        /// <summary>
        ///     Bunker fresh water produced. (cubic meters)
        /// </summary>
        public double? BunkerFreshWaterProduced { get; set; }

        /// <summary>
        ///     Fuel oil butane bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelButane { get; set; }

        /// <summary>
        ///     Fuel oil ethanol bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelEthanol { get; set; }

        /// <summary>
        ///     Heavy fuel oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHfo { get; set; }

        /// <summary>
        ///     Heavy fuel oil high sulphur bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHfoHs { get; set; }

        /// <summary>
        ///     Heavy fuel oil ultra low sulphur bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHfoLls { get; set; }

        /// <summary>
        ///     Heavy fuel oil low sulphur bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHfoLs { get; set; }

        /// <summary>
        ///     Light fuel oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelLfo { get; set; }

        /// <summary>
        ///     Fuel oil LNG bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelLng { get; set; }

        /// <summary>
        ///     Marine diesel oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelMdo { get; set; }

        /// <summary>
        ///     Fuel oil methanol bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelMethanol { get; set; }

        /// <summary>
        ///     Biomass To Liquid bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelBtl { get; set; }

        /// <summary>
        ///     Fatty Acid Methyl Ester bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelFame { get; set; }

        /// <summary>
        ///     Fuel oil Bio Fuel Blend bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelBioFuelBlend { get; set; }

        /// <summary>
        ///     Hydrogen Vegetable Oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelHvo { get; set; }

        /// <summary>
        ///     Marine gas oil bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelMgo { get; set; }

        /// <summary>
        ///     Fuel oil propane bunkered. (metric tons).
        /// </summary>
        public double? BunkerFuelPropane { get; set; }

        /// <summary>
        ///     Circulation lub oil auxiliary engines bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCirculationAe { get; set; }

        /// <summary>
        ///     Circulation lub oil main engines bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCirculationMe { get; set; }

        /// <summary>
        ///     Circulation lub oil of undefined source bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCirculationUndef { get; set; }

        /// <summary>
        ///     Cylinder lub oil bunkered. (litres).
        /// </summary>
        public double? BunkerLubOilCylinder { get; set; }

        /// <summary>
        ///     Cylinder high sulphur lub oil bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCylinderHs { get; set; }

        /// <summary>
        ///     Cylinder low sulphur lub oil bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilCylinderLs { get; set; }

        /// <summary>
        ///     Undefined lub oil bunkered. (litres)
        /// </summary>
        public double? BunkerLubOilUndef { get; set; }

        /// <summary>
        ///     Name of captain.
        /// </summary>
        public string Captain { get; set; }

        /// <summary>
        ///     Number of passengers.
        /// </summary>
        public int? CargoPassengers { get; set; }

        /// <summary>
        ///     Number of reefers.
        /// </summary>
        public int? CargoReefers { get; set; }

        /// <summary>
        ///     Consumed Reefer Energy (kWh)
        /// </summary>
        public double? CargoReeferEnergy { get; set; }

        /// <summary>
        ///     Number of empty TEU.
        /// </summary>
        public double? CargoTeuEmpty { get; set; }

        /// <summary>
        ///     Number of full TEU.
        /// </summary>
        public double? CargoTeuFull { get; set; }

        /// <summary>
        ///     Cargo volume. (cubic meters)
        /// </summary>
        public double? CargoVolume { get; set; }

        /// <summary>
        ///     Total cargo weight. (tons)
        /// </summary>
        public double? CargoWeight { get; set; }

        /// <summary>
        ///     Charter speed instruction.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterSpeedInstruction? CharterSpeedInstruction { get; set; }

        /// <summary>
        ///     Charter speed instruction (knots).
        /// </summary>
        public double? CharterSpeedInstructionKnots { get; set; }

        /// <summary>
        ///     Charter voyage status.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CharterVoyageStatus? CharterVoyageStatus { get; set; }

        /// <summary>
        ///     Name of chief engineer.
        /// </summary>
        public string ChiefEng { get; set; }

        /// <summary>
        /// CII of this report (g/t-nm CO2).
        /// </summary>
        public double? CurrentCii { get; set; }

        /// <summary>
        /// CII corrected of this report (g/t-nm CO2).
        /// </summary>
        public double? CurrentCiiCorrected { get; set; }

        /// <summary>
        /// Required CII as per the year of the report, ship type and deadweight of ship (g/t-nm CO2).
        /// </summary>
        public double? CiiRequired { get; set; }

        /// <summary>
        /// Rating for the CII of this report (one of [A,B,C,D,E]).
        /// </summary>
        public string CiiRating { get; set; }

        /// <summary>
        /// Rating for the corrected CII of this report (one of [A,B,C,D,E]).
        /// </summary>
        public string CiiRatingCorrected { get; set; }

        /// <summary>
        /// Attained CII year to date (g/t-nm CO2).
        /// </summary>
        public double? CiiAttained { get; set; }

        /// <summary>
        /// Attained CII year to date (g/t-nm CO2).
        /// </summary>
        public double? CiiAttainedCorrected { get; set; }

        /// <summary>
        /// Rating for the attained year to date CII (one of [A,B,C,D,E]).
        /// </summary>
        public string CiiAttainedRating { get; set; }

        /// <summary>
        /// Rating for the attained year to date corrected CII (one of [A,B,C,D,E]).
        /// </summary>
        public string CiiAttainedRatingCorrected { get; set; }

        /// <summary>
        /// Average CII for the ship and the month of this report (g/t-nm CO2).
        /// </summary>
        public double? MonthlyCii { get; set; }

        /// <summary>
        /// Average corrected CII for the ship and the month of this report (g/t-nm CO2).
        /// </summary>
        public double? MonthlyCiiCorrected { get; set; }

        /// <summary>
        /// Rating of the CII value for the current month [A, B, C, D or E].
        /// </summary>
        public string MonthlyCiiRating { get; set; }

        /// <summary>
        /// Rating of the CII corrected value for the current month [A, B, C, D or E].
        /// </summary>
        public string MonthlyCiiCorrectedRating { get; set; }

        /// <summary>
        ///     Completeness score. (%)
        /// </summary>
        public double? CompletenessScore { get; set; }

        /// <summary>
        ///     Temperature of LT cooling water. (°C)
        /// </summary>
        public double? CoolingWaterTemp { get; set; }

        /// <summary>
        ///     Course made good of ship. (degrees)
        /// </summary>
        public double? CourseMadeGood { get; set; }


        public double? CurrentFactor { get; set; }

        /// <summary>
        ///     CustomId of Report
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        ///     Daily fuel oil consumption of auxiliary boilers. (t/d)
        /// </summary>
        public double? DailyAbFoc { get; set; }

        /// <summary>
        ///     Daily fuel oil consumption of auxiliary engines. (t/d)
        /// </summary>
        public double? DailyAeFoc { get; set; }

        /// <summary>
        ///     Daily fuel oil consumption of main engines. (t/d)
        /// </summary>
        public double? DailyMeFoc { get; set; }

        /// <summary>
        ///     Daily fuel oil consumption of all engines and boilers. (t/d)
        /// </summary>
        public double? DailyTotalFoc { get; set; }

        /// <summary>
        ///     Delivered power corrected by environmental factors. (kW)
        /// </summary>
        public double? DeliveredPowerCorrected { get; set; }

        /// <summary>
        ///     Displacement (metric tons).
        /// </summary>
        public double? Displacement { get; set; }

        /// <summary>
        ///     Douglas sea scale. (Douglas)
        /// </summary>
        public int? DouglasSeaScale { get; set; }

        /// <summary>
        ///     Draft aft. (meters)
        /// </summary>
        public double? DraftAft { get; set; }

        /// <summary>
        ///     Draft forward. (meters)
        /// </summary>
        public double? DraftFwd { get; set; }

        /// <summary>
        ///     Draft midships. (meters)
        /// </summary>
        public double? DraftMid { get; set; }

        /// <summary>
        ///     EEOI by TEU. (Grams CO2 per TEU and mile)
        /// </summary>
        public double? EeoiTeu { get; set; }

        /// <summary>
        ///     EEOI by cargo weight. (Grams CO2 per cargo ton and mile)
        /// </summary>
        public double? EeoiWeight { get; set; }

        /// <summary>
        ///     Total main engine distance (nautical miles).
        /// </summary>
        public double? EngineDistance { get; set; }

        /// <summary>
        ///     Engine room temperature. (°C)
        /// </summary>
        public double? EngineRoomTemp { get; set; }

        /// <summary>
        ///     Estimation score. (%)
        /// </summary>
        public double? EstimationScore { get; set; }

        public string EventCustomId { get; set; }

        public string EventName { get; set; }
        public string EventShortName { get; set; }
        public EventType EventType { get; set; }

        /// <summary>
        ///     Fuel oil butane gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelButane { get; set; }

        /// <summary>
        ///     Fuel oil ethanol gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelEthanol { get; set; }

        /// <summary>
        ///     Heavy fuel oil gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelHfo { get; set; }

        /// <summary>
        ///     Heavy fuel oil high sulphur gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelHfoHs { get; set; }

        /// <summary>
        ///     Heavy fuel oil ultra low sulphur gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelHfoLls { get; set; }

        /// <summary>
        ///     Heavy fuel oil low sulphur gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelHfoLs { get; set; }

        /// <summary>
        ///     Light fuel oil high gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelLfo { get; set; }

        /// <summary>
        ///     Fuel oil LNG gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelLng { get; set; }

        /// <summary>
        ///     Marine diesel oil gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelMdo { get; set; }

        /// <summary>
        ///     Fuel oil methanol gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelMethanol { get; set; }

        /// <summary>
        ///     Biomass To Liquid gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelBtl { get; set; }

        /// <summary>
        ///    Fatty Acid Methyl Ester gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelFame { get; set; }

        /// <summary>
        ///    Hydrogen Vegetable Oil gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelHvo { get; set; }

        /// <summary>
        ///     Marine gas oil gain/loss. (metric tons)
        /// </summary>
        public double? GainLossFuelMgo { get; set; }

        /// <summary>
        ///     Fuel oil propane gain/loss. (metric tons).
        /// </summary>
        public double? GainLossFuelPropane { get; set; }

        /// <summary>
        ///     Circulation lub oil auxiliary engines gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCirculationAe { get; set; }

        /// <summary>
        ///     Circulation lub oil main engines gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCirculationMe { get; set; }

        /// <summary>
        ///     Circulation lub oil of undefined source gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCirculationUndef { get; set; }

        /// <summary>
        ///     Cylinder lub oul gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCylinder { get; set; }

        /// <summary>
        ///     Cylinder high sulphur lub oil gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCylinderHs { get; set; }

        /// <summary>
        ///     Cylinder low sulphur lub oil gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilCylinderLs { get; set; }

        /// <summary>
        ///     Undefined lub oil gain/loss. (litres)
        /// </summary>
        public double? GainLossLubOilUndef { get; set; }

        /// <summary>
        /// BTL average GHG intensity value 'E' (gCO2eq/MJ) represents greenhouse gas emissions per unit of energy for biofuels and e-fuels.
        /// </summary>
        public double? BunkerGhgIntensityBtl { get; set; }

        /// <summary>
        /// FAME average GHG intensity value 'E' (gCO2eq/MJ) represents greenhouse gas emissions per unit of energy for biofuels and e-fuels.
        /// </summary>
        public double? BunkerGhgIntensityFame { get; set; }

        /// <summary>
        /// HVO average GHG intensity value 'E' (gCO2eq/MJ) represents greenhouse gas emissions per unit of energy for biofuels and e-fuels.
        /// </summary>
        public double? BunkerGhgIntensityHvo { get; set; }

        /// <summary>
        /// Bio fuel blend average GHG intensity value 'E' (gCO2eq/MJ) represents greenhouse gas emissions per unit of energy for biofuels and e-fuels.
        /// </summary>
        public double? BunkerGhgIntensityBioFuelBlend { get; set; }

        /// <summary>
        ///     Average heading of ship. (degrees)
        /// </summary>
        public double? Heading { get; set; }

        /// <summary>
        ///     ID of report result.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Is engine in combinator mode?
        /// </summary>
        public bool? IsCombinatorMode { get; set; }

        /// <summary>
        ///     Is ship running the scrubber in operation.
        /// </summary>
        public bool? IsOnScrubberMode { get; set; }

        /// <summary>
        ///     Is ship on shore power supply?
        /// </summary>
        public bool? IsOnShorePowerSupply { get; set; }

        /// <summary>
        ///     Shore energy supplied - electrical energy from shore (kWh)
        /// </summary>
        public double? ShoreEnergyReceived { get; set; }

        /// <summary>
        ///     Is ship operated in slow steaming?
        /// </summary>
        public bool? IsSlowSteaming { get; set; }

        /// <summary>
        ///     Is turbo charger cut out?
        /// </summary>
        public bool? IsTcCutout { get; set; }

        /// <summary>
        ///     LegEventId
        /// </summary>
        public int? LegEventId { get; set; }

        /// <summary>
        ///     Master's estimated time of arrival (including UTC offset).
        /// </summary>
        public DateTimeOffset? MastersEta
        {
            get
            {
                if (MastersEtaLocal != null && MastersEtaUtc != null)
                {
                    var offset = MastersEtaLocal.Value - MastersEtaUtc.Value;
                    return new DateTimeOffset(DateTime.SpecifyKind(MastersEtaLocal.Value, DateTimeKind.Unspecified),
                        offset);
                }

                return null;
            }
            set
            {
                MastersEtaUtc = value?.UtcDateTime;
                MastersEtaLocal = value?.DateTime;
            }
        }

        /// <summary>
        ///     Masters estimated time of arrival (Local).
        /// </summary>
        [JsonIgnore]
        public DateTime? MastersEtaLocal { get; set; }

        /// <summary>
        ///     Masters estimated time of arrival (UTC).
        /// </summary>
        [JsonIgnore]
        public DateTime? MastersEtaUtc { get; set; }

        /// <summary>
        ///     Mean draft. (meters)
        /// </summary>
        public double? MeanDraft { get; set; }

        /// <summary>
        ///     Total FOC ME HFO (metric tons).
        /// </summary>
        public double? MeHfoFoc { get; set; }

        /// <summary>
        /// ME HFO kinematic viscosity (cSt).
        /// </summary>
        public double? MeHfoKinematicViscosity { get; set; }

        /// <summary>
        /// ME HFO LCV (kJ/kg).
        /// </summary>
        public double? MeHfoLcv { get; set; }

        /// <summary>
        /// ME HFO sulphur content (%).
        /// </summary>
        public double? MeHfoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME HFO HS (metric tons).
        /// </summary>
        public double? MeHfoHsFoc { get; set; }

        /// <summary>
        /// ME HFO HS kinematic viscosity (cSt).
        /// </summary>
        public double? MeHfoHsKinematicViscosity { get; set; }

        /// <summary>
        /// ME HFO HS LCV (kJ/kg).
        /// </summary>
        public double? MeHfoHsLcv { get; set; }

        /// <summary>
        /// ME HFO HS sulphur content (%).
        /// </summary>
        public double? MeHfoHsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME HFO LLS (metric tons).
        /// </summary>
        public double? MeHfoLlsFoc { get; set; }

        /// <summary>
        /// ME HFO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? MeHfoLlsKinematicViscosity { get; set; }

        /// <summary>
        /// ME HFO LLS LCV (kJ/kg).
        /// </summary>
        public double? MeHfoLlsLcv { get; set; }

        /// <summary>
        /// ME HFO LLS sulphur content (%).
        /// </summary>
        public double? MeHfoLlsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME HFO LS (metric tons).
        /// </summary>
        public double? MeHfoLsFoc { get; set; }

        /// <summary>
        /// ME HFO LS kinematic viscosity (cSt).
        /// </summary>
        public double? MeHfoLsKinematicViscosity { get; set; }

        /// <summary>
        /// ME HFO LS LCV (kJ/kg).
        /// </summary>
        public double? MeHfoLsLcv { get; set; }

        /// <summary>
        /// ME HFO LS sulphur content (%).
        /// </summary>
        public double? MeHfoLsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME LFO (metric tons).
        /// </summary>
        public double? MeLfoFoc { get; set; }

        /// <summary>
        /// ME LFO kinematic viscosity (cSt).
        /// </summary>
        public double? MeLfoKinematicViscosity { get; set; }

        /// <summary>
        /// ME LFO LCV (kJ/kg).
        /// </summary>
        public double? MeLfoLcv { get; set; }

        /// <summary>
        /// ME LFO sulphur content (%).
        /// </summary>
        public double? MeLfoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME MDO (metric tons).
        /// </summary>
        public double? MeMdoFoc { get; set; }

        /// <summary>
        /// ME MDO kinematic viscosity (cSt).
        /// </summary>
        public double? MeMdoKinematicViscosity { get; set; }

        /// <summary>
        /// ME MDO LCV (kJ/kg).
        /// </summary>
        public double? MeMdoLcv { get; set; }

        /// <summary>
        /// ME MDO sulphur content (%).
        /// </summary>
        public double? MeMdoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME MDO HS (metric tons).
        /// </summary>
        public double? MeMdoHsFoc { get; set; }

        /// <summary>
        /// ME MDO HS kinematic viscosity (cSt).
        /// </summary>
        public double? MeMdoHsKinematicViscosity { get; set; }

        /// <summary>
        /// ME MDO HS LCV (kJ/kg).
        /// </summary>
        public double? MeMdoHsLcv { get; set; }

        /// <summary>
        /// ME MDO HS sulphur content (%).
        /// </summary>
        public double? MeMdoHsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME MDO LLS (metric tons).
        /// </summary>
        public double? MeMdoLlsFoc { get; set; }

        /// <summary>
        /// ME MDO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? MeMdoLlsKinematicViscosity { get; set; }

        /// <summary>
        /// ME MDO LLS LCV (kJ/kg).
        /// </summary>
        public double? MeMdoLlsLcv { get; set; }

        /// <summary>
        /// ME MDO LLS sulphur content (%).
        /// </summary>
        public double? MeMdoLlsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME MDO LS (metric tons).
        /// </summary>
        public double? MeMdoLsFoc { get; set; }

        /// <summary>
        /// ME MDO LS kinematic viscosity (cSt).
        /// </summary>
        public double? MeMdoLsKinematicViscosity { get; set; }

        /// <summary>
        /// ME MDO LS LCV (kJ/kg).
        /// </summary>

        public double? MeMdoLsLcv { get; set; }

        /// <summary>
        /// ME MDO LS sulphur content (%).
        /// </summary>
        public double? MeMdoLsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME MGO (metric tons).
        /// </summary>
        public double? MeMgoFoc { get; set; }

        /// <summary>
        /// ME MGO kinematic viscosity (cSt).
        /// </summary>
        public double? MeMgoKinematicViscosity { get; set; }

        /// <summary>
        /// ME MGO LCV (kJ/kg).
        /// </summary>
        public double? MeMgoLcv { get; set; }

        /// <summary>
        /// ME MGO sulphur content (%).
        /// </summary>
        public double? MeMgoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME MGO LLS (metric tons).
        /// </summary>
        public double? MeMgoLlsFoc { get; set; }

        /// <summary>
        /// ME MGO LLS kinematic viscosity (cSt).
        /// </summary>
        public double? MeMgoLlsKinematicViscosity { get; set; }

        /// <summary>
        /// ME MGO LLS LCV (kJ/kg).
        /// </summary>
        public double? MeMgoLlsLcv { get; set; }

        /// <summary>
        /// ME MGO LLS sulphur content (%).
        /// </summary>
        public double? MeMgoLlsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME MGO LS (metric tons).
        /// </summary>
        public double? MeMgoLsFoc { get; set; }

        /// <summary>
        /// ME MGO LS kinematic viscosity (cSt).
        /// </summary>
        public double? MeMgoLsKinematicViscosity { get; set; }

        /// <summary>
        /// ME MGO LS LCV (kJ/kg).
        /// </summary>
        public double? MeMgoLsLcv { get; set; }

        /// <summary>
        /// ME MGO LS sulphur content (%).
        /// </summary>
        public double? MeMgoLsSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME Methanol (metric tons).
        /// </summary>
        public double? MeMethanolFoc { get; set; }

        /// <summary>
        /// ME Methanol kinematic viscosity (cSt).
        /// </summary>
        public double? MeMethanolKinematicViscosity { get; set; }

        /// <summary>
        /// ME Ethanol kinematic viscosity (cSt).
        /// </summary>
        public double? MeEthanolKinematicViscosity { get; set; }

        /// <summary>
        /// ME Methanol LCV (kJ/kg).
        /// </summary>
        public double? MeMethanolLcv { get; set; }

        /// <summary>
        /// ME Methanol sulphur content (%).
        /// </summary>
        public double? MeMethanolSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME LNG (metric tons).
        /// </summary>
        public double? MeLngFoc { get; set; }

        /// <summary>
        /// ME LNG kinematic viscosity (cSt).
        /// </summary>
        public double? MeLngKinematicViscosity { get; set; }

        /// <summary>
        /// ME LNG LCV (kJ/kg).
        /// </summary>
        public double? MeLngLcv { get; set; }

        /// <summary>
        /// ME LNG sulphur content (%).
        /// </summary>
        public double? MeLngSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME BTL (metric tons).
        /// </summary>
        public double? MeBtlFoc { get; set; }

        /// <summary>
        /// ME BTL kinematic viscosity (cSt).
        /// </summary>
        public double? MeBtlKinematicViscosity { get; set; }

        /// <summary>
        /// ME BTL LCV (kJ/kg).
        /// </summary>
        public double? MeBtlLcv { get; set; }

        /// <summary>
        /// ME BTL sulphur content (%).
        /// </summary>
        public double? MeBtlSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME FAME (metric tons).
        /// </summary>
        public double? MeFameFoc { get; set; }

        /// <summary>
        /// ME FAME kinematic viscosity (cSt).
        /// </summary>
        public double? MeFameKinematicViscosity { get; set; }

        /// <summary>
        /// ME FAME LCV (kJ/kg).
        /// </summary>
        public double? MeFameLcv { get; set; }

        /// <summary>
        /// ME FAME sulphur content (%).
        /// </summary>
        public double? MeFameSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME HVO (metric tons).
        /// </summary>
        public double? MeHvoFoc { get; set; }

        /// <summary>
        /// ME HVO kinematic viscosity (cSt).
        /// </summary>
        public double? MeHvoKinematicViscosity { get; set; }

        /// <summary>
        /// ME HVO LCV (kJ/kg).
        /// </summary>
        public double? MeHvoLcv { get; set; }

        /// <summary>
        /// ME HVO sulphur content (%).
        /// </summary>
        public double? MeHvoSulphurContent { get; set; }

        /// <summary>
        /// Total FOC ME Bio Fuel Blend (metric tons).
        /// </summary>
        public double? MeBioFuelBlendFoc { get; set; }

        /// <summary>
        /// ME MGO kinematic viscosity (cSt).
        /// </summary>
        public double? MeBioFuelBlendKinematicViscosity { get; set; }

        /// <summary>
        /// ME Bio Fuel Blend LCV (kJ/kg).
        /// </summary>
        public double? MeBioFuelBlendLcv { get; set; }

        /// <summary>
        /// ME Bio Fuel Blend sulphur content (%).
        /// </summary>
        public double? MeBioFuelBlendSulphurContent { get; set; }

        /// <summary>
        /// ME average percentage of bio fuel in blend.
        /// </summary>
        public double? MeAveragePercentageOfBioFuelInBlend { get; set; }

        /// <summary>
        /// ME most occurring Bio Fuel in blend.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public BioBlendOptions? MeMostOccurringBioFuelKindInBlend { get; set; }

        /// <summary>
        /// ME most occurring Fossil Fuel in blend.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public FossilBlendOptions? MeMostOccurringFossilFuelKindInBlend { get; set; }

        /// <summary>
        ///     Boiler NOx Emissions (t).
        /// </summary>
        public double? NoxEmissionsAb { get; set; }

        /// <summary>
        ///     AE NOx Emissions (t).
        /// </summary>
        public double? NoxEmissionsAe { get; set; }

        /// <summary>
        ///     ME NOx Emissions (t).
        /// </summary>
        public double? NoxEmissionsMe { get; set; }

        /// <summary>
        ///     Reporting period or duration. (hours)
        /// </summary>
        public double? Period { get; set; }

        /// <summary>
        ///     Plausibility count: Fine
        /// </summary>
        public int PlausibilityCountFine { get; set; }

        /// <summary>
        ///     Plausibility Count: Major issue
        /// </summary>
        public int PlausibilityCountMajor { get; set; }

        /// <summary>
        ///     Plausibility count: Minor issue
        /// </summary>
        public int PlausibilityCountMinor { get; set; }

        /// <summary>
        ///     Plausibility count: Values not available.
        /// </summary>
        public int PlausibilityCountNotSet { get; set; }

        /// <summary>
        ///     Plausibility score. (%)
        /// </summary>
        public double? PlausibilityScore { get; set; }

        /// <summary>
        ///     Position latitude. (degrees)
        /// </summary>
        public double? PosLat { get; set; }

        /// <summary>
        ///     Position longitude. (degrees)
        /// </summary>
        public double? PosLng { get; set; }

        /// <summary>
        /// Bunker delivery note numbers comma separated. (All of them - Fuel and Lub oil)
        /// </summary>
        public string BdnNumbers { get; set; }

        /// <summary>
        /// BDNs Fuel only
        /// </summary>
        public string BdnNumbersFuel { get; set; }

        /// <summary>
        /// BDNs LubOil only
        /// </summary>
        public string BdnNumbersLubOil { get; set; }

        /// <summary>
        /// Proof of Sustainability numbers comma separated.
        /// </summary>
        public string PosNumbers { get; set; }

        /// <summary>
        ///     Id of report
        /// </summary>
        public int ReportId { get; set; }

        /// <summary>
        ///     Power added or reduced by wind. (kW)
        /// </summary>
        public double? ResistanceByWind { get; set; }

        /// <summary>
        ///     Fresh water distilled remain on board. (cubic meters).
        /// </summary>
        public double? RobFreshWaterDistilled { get; set; }

        /// <summary>
        ///     Fresh water drinking remain on board. (cubic meters).
        /// </summary>
        public double? RobFreshWaterDrinking { get; set; }

        /// <summary>
        ///     Fresh water undefined remain on board. (cubic meters).
        /// </summary>
        public double? RobFreshWaterUndef { get; set; }

        /// <summary>
        ///     Fuel oil butane remain on board. (metric tons)
        /// </summary>
        public double? RobFuelButane { get; set; }

        /// <summary>
        ///     Fuel oil ethanol remain on board. (metric tons)
        /// </summary>
        public double? RobFuelEthanol { get; set; }

        /// <summary>
        ///     Heavy fuel oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHfo { get; set; }

        /// <summary>
        ///     Heavy fuel oil high sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHfoHs { get; set; }

        /// <summary>
        ///     Heavy fuel oil ultra low sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHfoLls { get; set; }

        /// <summary>
        ///     Heavy fuel oil low sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHfoLs { get; set; }

        /// <summary>
        ///     Light fuel oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelLfo { get; set; }

        /// <summary>
        ///     Fuel oil LNG remain on board. (metric tons)
        /// </summary>
        public double? RobFuelLng { get; set; }

        /// <summary>
        ///     Marine diesel oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMdo { get; set; }

        /// <summary>
        ///     Marine diesel oil high sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMdoHs { get; set; }

        /// <summary>
        ///     Marine diesel oil low sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMdoLs { get; set; }

        /// <summary>
        ///     Marine diesel oil ultra low sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMdoLls { get; set; }

        /// <summary>
        ///     Fuel oil methanol remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMethanol { get; set; }

        /// <summary>
        ///     Biomass To Liquid remain on board. (metric tons)
        /// </summary>
        public double? RobFuelBtl { get; set; }

        /// <summary>
        ///    Fatty Acid Methyl Ester remain on board. (metric tons)
        /// </summary>
        public double? RobFuelFame { get; set; }

        /// <summary>
        ///     Hydrogen Vegetable Oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelHvo { get; set; }

        /// <summary>
        ///     Marine gas oil remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMgo { get; set; }

        /// <summary>
        ///     Marine gas oil low sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMgoLs { get; set; }

        /// <summary>
        ///     Marine gas oil ultra low sulphur remain on board. (metric tons)
        /// </summary>
        public double? RobFuelMgoLls { get; set; }

        /// <summary>
        ///     Fuel oil propane remain on board. (metric tons)
        /// </summary>
        public double? RobFuelPropane { get; set; }

        /// <summary>
        ///     Circulation lub oil auxiliary engines remain on board. (litres)
        /// </summary>
        public double? RobLubOilCirculationAe { get; set; }

        /// <summary>
        ///     Circulation lub oil main engines remain on board. (litres)
        /// </summary>
        public double? RobLubOilCirculationMe { get; set; }

        /// <summary>
        ///     Circulation lub oil of undefined source remain on board. (litres)
        /// </summary>
        public double? RobLubOilCirculationUndef { get; set; }

        /// <summary>
        ///     Cylinder lub oil remain on board. (litres)
        /// </summary>
        public double? RobLubOilCylinder { get; set; }

        /// <summary>
        ///     Cylinder lub oil high sulphur remain on board. (litres)
        /// </summary>
        public double? RobLubOilCylinderHs { get; set; }

        /// <summary>
        ///     Cylinder lub oil low sulphur remain on board. (litres)
        /// </summary>
        public double? RobLubOilCylinderLs { get; set; }

        /// <summary>
        ///     Undefined lub oil remain on board. (litres)
        /// </summary>
        public double? RobLubOilUndef { get; set; }

        /// <summary>
        ///     Sailed distance over ground. (miles)
        /// </summary>
        public double? SailedDistanceOverGround { get; set; }

        /// <summary>
        ///     Sailed distance through water. (miles)
        /// </summary>
        public double? SailedDistanceThroughWater { get; set; }

        /// <summary>
        ///     Duration ship was sailing. (hours)
        /// </summary>
        public double? SailingTime { get; set; }

        /// <summary>
        ///     Sea state. (Beaufort scale)
        /// </summary>
        public int? SeaState { get; set; }

        /// <summary>
        ///     Sea water temperature. (°C)
        /// </summary>
        public double? SeaWaterTemp { get; set; }

        /// <summary>
        ///     Ship info.
        /// </summary>
        public virtual ShipShort Ship { get; set; }

        /// <summary>
        ///     Boiler SOx Emissions (t).
        /// </summary>
        public double? SoxEmissionsAb { get; set; }

        /// <summary>
        ///     AE SOx Emissions (t).
        /// </summary>
        public double? SoxEmissionsAe { get; set; }

        /// <summary>
        ///     ME SOx Emissions (t).
        /// </summary>
        public double? SoxEmissionsMe { get; set; }

        /// <summary>
        ///     Loss of vessel speed compared to active hull model. (%)
        /// </summary>
        public double? SpeedLoss { get; set; }

        /// <summary>
        ///     Loss of vessel speed compared to active hull model. (%)
        /// </summary>
        public double? SpeedLossUncorrected { get; set; }

        /// <summary>
        /// Power increase due to hull fowling (%).
        /// </summary>
        public double? PowerIncrease { get; set; }

        /// <summary>
        ///     Operational state of ship.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public StateOptions State { get; set; }

        /// <summary>
        ///     Swell direction. (degrees rel. to north)
        /// </summary>
        public double? SwellDirection { get; set; }

        /// <summary>
        ///     Swell geight. (meters)
        /// </summary>
        public double? SwellHeight { get; set; }

        /// <summary>
        ///     Time stamp of report (including UTC offset).
        /// </summary>
        public DateTimeOffset TimeStamp
        {
            get
            {
                var offset = TimeStampLocal - TimeStampUtc;
                return new DateTimeOffset(DateTime.SpecifyKind(TimeStampLocal, DateTimeKind.Unspecified), offset);
            }
            set
            {
                TimeStampUtc = value.UtcDateTime;
                TimeStampLocal = value.DateTime;
            }
        }

        /// <summary>
        ///     Time stamp of report (Local).
        /// </summary>
        [JsonIgnore]
        public DateTime TimeStampLocal { get; set; }

        /// <summary>
        ///     Time stamp of report (UTC).
        /// </summary>
        [JsonIgnore]
        public DateTime TimeStampUtc { get; set; }

        /// <summary>
        ///     Sum of average aux engine power. (kW)
        /// </summary>
        public double? TotalAverageAePower { get; set; }

        /// <summary>
        ///     Total average electrical power. (kW)
        /// </summary>
        public double? TotalAverageElectricalPower { get; set; }

        /// <summary>
        ///     Sum of average main engine power. (kW)
        /// </summary>
        public double? TotalAverageMePower { get; set; }

        /// <summary>
        ///     Total average shaft power (delivered power). (kW)
        /// </summary>
        public double? TotalAverageShaftPower { get; set; }

        /// <summary>
        ///     Total average shaft power (delivered power, corrected). (kW)
        /// </summary>
        public double? TotalAverageShaftPowerCorrected { get; set; }

        /// <summary>
        ///     Total fuel oil bunkered. (metric tons).
        /// </summary>
        public double? TotalBunkerFuelOil { get; set; }

        /// <summary>
        /// Total amount of biofuel bunkered. (metric tons)
        /// </summary>
        public double? TotalBunkerBioFuelAmount { get; set; }

        /// <summary>
        /// Total amount of fossil fuel bunkered. (metric tons)
        /// </summary>
        public double? TotalBunkerFossilFuelAmount { get; set; }

        /// <summary>
        ///     Total circulation oil bunkered. (litres)
        /// </summary>
        public double? TotalBunkerLubOilCirculation { get; set; }

        /// <summary>
        ///     Total aux engine circulation lub oil consumption (litres).
        /// </summary>
        public double? TotalCirculationLubOilAeConsumption { get; set; }

        /// <summary>
        ///     Total main engine circulation lub oil consumption (litres).
        /// </summary>
        public double? TotalCirculationLubOilMeConsumption { get; set; }

        /// <summary>
        ///     Total CO2 emission. (tons)
        /// </summary>
        public double? TotalCo2 { get; set; }

        /// <summary>
        ///     Total CO2 emission aux boilers. (tons)
        /// </summary>
        public double? TotalCo2Ab { get; set; }

        /// <summary>
        ///     Total CO2 emission aux engines. (tons)
        /// </summary>
        public double? TotalCo2Ae { get; set; }

        /// <summary>
        ///     Total CO2 emission inert gas system. (tons)
        /// </summary>
        public double? TotalCo2Igs { get; set; }

        /// <summary>
        ///     Total CO2 emission incinerator. (tons)
        /// </summary>
        public double? TotalCo2Inc { get; set; }

        /// <summary>
        ///     Total CO2 emission main engines. (tons)
        /// </summary>
        public double? TotalCo2Me { get; set; }

        /// <summary>
        ///     Total CO2 emission of undefined source. (tons)
        /// </summary>
        public double? TotalCo2Undef { get; set; }

        /// <summary>
        ///     Total cylinder high-sulphur lub oil consumption (litres).
        /// </summary>
        public double? TotalCylinderHsLubOilConsumption { get; set; }

        /// <summary>
        ///     Total cylinder low-sulphur lub oil consumption (litres).
        /// </summary>
        public double? TotalCylinderLsLubOilConsumption { get; set; }

        /// <summary>
        ///     Total cylinder lub oil consumption (litres).
        /// </summary>
        public double? TotalCylinderOilConsumption { get; set; }

        /// <summary>
        ///     Total fuel oil consumption. (tons)
        /// </summary>
        public double? TotalFoc { get; set; }

        /// <summary>
        ///     Total fuel oil consumption aux boilers. (tons)
        /// </summary>
        public double? TotalFocAb { get; set; }

        /// <summary>
        ///     Total fuel oil consumption aux boilers (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocAbIso { get; set; }

        /// <summary>
        ///     Total fuel oil consumption aux engines. (tons)
        /// </summary>
        public double? TotalFocAe { get; set; }

        /// <summary>
        ///     Total fuel oil consumption aux engines (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocAeIso { get; set; }

        /// <summary>
        ///     Total fuel oil consumption butane. (metric tons)
        /// </summary>
        public double? TotalFocButane { get; set; }

        /// <summary>
        ///     Total fuel oil consumption ethanol. (metric tons)
        /// </summary>
        public double? TotalFocEthanol { get; set; }

        /// <summary>
        ///     Total heavy fuel oil consumption. (metric tons)
        /// </summary>
        public double? TotalFocHfo { get; set; }

        /// <summary>
        ///     Total heavy fuel oil consumption high sulphur. (metric tons)
        /// </summary>
        public double? TotalFocHfoHs { get; set; }

        /// <summary>
        ///     Total heavy fuel oil consumption ultra low sulphur. (metric tons)
        /// </summary>
        public double? TotalFocHfoLls { get; set; }

        /// <summary>
        ///     Total heavy fuel oil consumption low sulphur. (metric tons)
        /// </summary>
        public double? TotalFocHfoLs { get; set; }

        /// <summary>
        ///     Total fuel oil consumption inert gas system. (metric tons)
        /// </summary>
        public double? TotalFocIgs { get; set; }

        /// <summary>
        ///     Total fuel oil consumption inert gas system (ISO corrected). (metric tons)
        /// </summary>
        public double? TotalFocIgsIso { get; set; }

        /// <summary>
        ///     Total fuel oil consumption incinerator. (metric tons)
        /// </summary>
        public double? TotalFocInc { get; set; }

        /// <summary>
        ///     Total fuel oil consumption incinerator (ISO corrected). (metric tons)
        /// </summary>
        public double? TotalFocIncIso { get; set; }

        /// <summary>
        ///     Total fuel oil consumption (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocIso { get; set; }

        /// <summary>
        ///     Total light fuel oil consumption. (metric tons)
        /// </summary>
        public double? TotalFocLfo { get; set; }

        /// <summary>
        ///     Total fuel oil consumption LNG. (metric tons)
        /// </summary>
        public double? TotalFocLng { get; set; }

        /// <summary>
        ///     Total fuel oil consumption marine diesel oil. (metric tons)
        /// </summary>
        public double? TotalFocMdo { get; set; }

        /// <summary>
        ///     Total fuel oil consumption of main engines. (tons)
        /// </summary>
        public double? TotalFocMe { get; set; }

        /// <summary>
        ///     Total fuel oil consumption of main engines (ISO corrected). (tons)
        /// </summary>
        public double? TotalFocMeIso { get; set; }

        /// <summary>
        ///     Total fuel oil consumption methanol. (metric tons)
        /// </summary>
        public double? TotalFocMethanol { get; set; }

        /// <summary>
        ///     Total fuel oil consumption Biomass To Liquid. (metric tons)
        /// </summary>
        public double? TotalFocBtl { get; set; }

        /// <summary>
        ///     Total fuel oil consumption Fatty Acid Methyl Ester. (metric tons)
        /// </summary>
        public double? TotalFocFame { get; set; }

        /// <summary>
        ///     Total fuel oil consumption Hydrogen Vegetable Oil. (metric tons)
        /// </summary>
        public double? TotalFocHvo { get; set; }

        /// <summary>
        ///     Total fuel oil consumption marine gas oil. (metric tons)
        /// </summary>
        public double? TotalFocMgo { get; set; }

        /// <summary>
        ///     Total fuel oil consumption propane. (metric tons)
        /// </summary>
        public double? TotalFocPropane { get; set; }

        /// <summary>
        ///     Total fuel oil consumption of undefined source or type. (metric tons)
        /// </summary>
        public double? TotalFocUndef { get; set; }

        /// <summary>
        ///     Total boiler fresh water consumption (cubic meters).
        /// </summary>
        public double? TotalFreshWaterConsumptionBoiler { get; set; }

        /// <summary>
        ///     Total domestic fresh water consumption (cubic meters).
        /// </summary>
        public double? TotalFreshWaterConsumptionDomestic { get; set; }

        /// <summary>
        ///     Total fresh water consumption with an undefined usage (cubic meters).
        /// </summary>
        public double? TotalFreshWaterConsumptionUndef { get; set; }

        /// <summary>
        ///     Total fresh water consumption by washing (cubic meters).
        /// </summary>
        public double? TotalFreshWaterConsumptionWashing { get; set; }

        /// <summary>
        ///     Total fuel oil gain/loss. (metric tons)
        /// </summary>
        public double? TotalGainLossFuelOil { get; set; }

        /// <summary>
        ///     Total circulation lub oil gain/loss. (litres)
        /// </summary>
        public double? TotalGainLossLubOilCirculation { get; set; }

        /// <summary>
        ///     Total generated aux engine energy. (kWh)
        /// </summary>
        public double? TotalGeneratedAeEnergy { get; set; }

        /// <summary>
        ///     Total generated electrical energy. (kWh)
        /// </summary>
        public double? TotalGeneratedElectricalEnergy { get; set; }

        /// <summary>
        ///     Total generated main engine energy. (kWh)
        /// </summary>
        public double? TotalGeneratedMeEnergy { get; set; }

        /// <summary>
        ///     Total generated shaft energy (delivered energy). (kWh)
        /// </summary>
        public double? TotalGeneratedShaftEnergy { get; set; }

        /// <summary>
        ///     Total NOx Emissions (t).
        /// </summary>
        public double? TotalNoxEmissions { get; set; }

        /// <summary>
        ///     Total oily water discharged via an undefined method (cubic meters).
        /// </summary>
        public double? TotalOilyWaterDischargeUndef { get; set; }

        /// <summary>
        ///     Total oily water discharged via an oil discharge monitoring equipment (cubic meters).
        /// </summary>
        public double? TotalOilyWaterDischargeViaOdme { get; set; }

        /// <summary>
        ///     Total oily water discharged via an oily water separator (cubic meters).
        /// </summary>
        public double? TotalOilyWaterDischargeViaOws { get; set; }

        /// <summary>
        ///     Total fresh water remain on board. (cubic meters)
        /// </summary>
        public double? TotalRobFreshWater { get; set; }

        /// <summary>
        ///     Total fuel oil remain on board. (metric tons)
        /// </summary>
        public double? TotalRobFuelOil { get; set; }

        /// <summary>
        ///     Total circulation lub oil remain on board. (litres)
        /// </summary>
        public double? TotalRobLubOilCirculation { get; set; }

        /// <summary>
        ///     Total main engine running hours.
        /// </summary>
        public double? TotalRunningHoursMe { get; set; }

        /// <summary>
        ///     Specific Cylinder Oil consumption SCOC (g/kWh)
        /// </summary>
        public double? TotalScocMe { get; set; }

        /// <summary>
        ///     Total specific fuel oil consumption of aux engines. (g/kWh)
        /// </summary>
        public double? TotalSfocAe { get; set; }

        /// <summary>
        ///     Total specific fuel oil consumption of aux engines (ISO corrected). (g/kWh)
        /// </summary>
        public double? TotalSfocAeIso { get; set; }

        /// <summary>
        ///     Total specific fuel oil consumption of main engines. (g/kWh)
        /// </summary>
        public double? TotalSfocMe { get; set; }

        /// <summary>
        ///     Total specific fuel oil consumption of main engines (ISO corrected). (g/kWh)
        /// </summary>
        public double? TotalSfocMeIso { get; set; }

        /// <summary>
        ///     Total SOx Emissions (t).
        /// </summary>
        public double? TotalSoxEmissions { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category A plastic. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryAPlastic { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category B food waste. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryBFoodWaste { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category C domestic waste. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryCDomesticWaste { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category D cooking oil. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryDCookingOil { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category E incinerator ash. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryEIncineratorAsh { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category F operational waste. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryFOperationalWaste { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category G animal carcass. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryGAnimalCarcass { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category H fishing gear (m3).
        /// </summary>
        public double? TotalWasteDisposalCategoryHFishingGear { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category I electronic waste. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryIElectronicWaste { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category J cargo residues (non HME). (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryJCargoResidueNonHme { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of category K cargo residues (HME). (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryKCargoResidueHme { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of sludge and oil residues. (m3)
        /// </summary>
        public double? TotalWasteDisposalSludgeAndOilResidue { get; set; }

        /// <summary>
        /// Total volume of waste disposal of sewage. (m3)
        /// </summary>
        public double? TotalWasteDisposalSewage { get; set; }

        /// <summary>
        /// Total volume of waste disposal of exhaust gas cleaning residues. (m3)
        /// </summary>
        public double? TotalWasteDisposalExhaustGasCleaningResidues { get; set; }

        /// <summary>
        ///     Total volume of waste disposal of undefined origin. (m3)
        /// </summary>
        public double? TotalWasteDisposalUndef { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category A plastic DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryAPlasticDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category B food waste DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryBFoodWasteDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category C domestic waste DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryCDomesticWasteDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category D cooking oil DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryDCookingOilDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category E incinerator ash DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryEIncineratorAshDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category F operational waste DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryFOperationalWasteDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category G animal carcass DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryGAnimalCarcassDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category H fishing gear DisposalDistance Unspecified (m3).
        /// </summary>
        public double? TotalWasteDisposalCategoryHFishingGearDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category I electronic waste DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryIElectronicWasteDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category J cargo residues (non HME) DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryJCargoResidueNonHmeDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category K cargo residues (HME) DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryKCargoResidueHmeDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of sludge and oil residues DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalSludgeAndOilResidueDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of sewage DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalSewageDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of exhaust gas cleaning residues DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalExhaustGasCleaningResiduesDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of undefined origin DisposalDistance Unspecified. (m3)
        /// </summary>
        public double? TotalWasteDisposalUndefDistanceUnspecified { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category A plastic DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryAPlasticDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category B food waste DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryBFoodWasteDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category C domestic waste DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryCDomesticWasteDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category D cooking oil DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryDCookingOilDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category E incinerator ash DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryEIncineratorAshDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category F operational waste DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryFOperationalWasteDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category G animal carcass DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryGAnimalCarcassDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category H fishing gear DisposalDistance ThreeNauticalMiles (m3).
        /// </summary>
        public double? TotalWasteDisposalCategoryHFishingGearDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category I electronic waste DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryIElectronicWasteDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category J cargo residues (non HME) DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryJCargoResidueNonHmeDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category K cargo residues (HME) DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryKCargoResidueHmeDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of sludge and oil residues DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalSludgeAndOilResidueDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of sewage DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalSewageDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of exhaust gas cleaning residues DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalExhaustGasCleaningResiduesDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of undefined origin DisposalDistance ThreeNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalUndefDistance3nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category A plastic DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryAPlasticDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category B food waste DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryBFoodWasteDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category C domestic waste DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryCDomesticWasteDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category D cooking oil DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryDCookingOilDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category E incinerator ash DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryEIncineratorAshDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category F operational waste DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryFOperationalWasteDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category G animal carcass DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryGAnimalCarcassDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category H fishing gear (m3) DisposalDistance TwelveNauticalMiles.
        /// </summary>
        public double? TotalWasteDisposalCategoryHFishingGearDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category I electronic waste DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryIElectronicWasteDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category J cargo residues (non HME) DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryJCargoResidueNonHmeDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of category K cargo residues (HME) DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalCategoryKCargoResidueHmeDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of sludge and oil residues DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalSludgeAndOilResidueDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of sewage DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalSewageDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of exhaust gas cleaning residues DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalExhaustGasCleaningResiduesDistance12nm { get; set; }

        /// <summary>
        /// Total volume of waste disposal of undefined origin DisposalDistance TwelveNauticalMiles. (m3)
        /// </summary>
        public double? TotalWasteDisposalUndefDistance12nm { get; set; }

        /// <summary>
        ///     Transport efficiency. (Grams of fuel oil per cargo ton and mile)
        /// </summary>
        public double? TransportEfficiency { get; set; }

        /// <summary>
        ///     Trim (DraftFwd - DraftAft) (meters).
        /// </summary>
        public double? Trim { get; set; }

        /// <summary>
        ///     Version Stamp when the leg was created or changed.
        /// </summary>
        public long VersionStamp { get; set; }

        /// <summary>
        ///     Water depth (meters).
        /// </summary>
        public double? WaterDepth { get; set; }

        /// <summary>
        ///     Water depth below keel (meters).
        /// </summary>
        public double? WaterDepthBelowKeel { get; set; }

        /// <summary>
        ///     Wave direction. (degrees rel. to north)
        /// </summary>
        public double? WaveDirection { get; set; }

        /// <summary>
        ///     Wave height. (meters)
        /// </summary>
        public double? WaveHeight { get; set; }

        /// <summary>
        ///     Relative wind direction. (degrees rel. to ship)
        /// </summary>
        public double? WindDirRel { get; set; }

        /// <summary>
        ///     True wind direction. (degrees rel. to north)
        /// </summary>

        public double? WindDirTrue { get; set; }

        /// <summary>
        ///     Wind force. (Beaufort scale)
        /// </summary>
        public int? WindForce { get; set; }

        /// <summary>
        ///     Relative wind speed. (m/s rel. to ship)
        /// </summary>
        public double? WindSpeedRel { get; set; }

        /// <summary>
        ///     Relative wind speed. (kn rel. to ship)
        /// </summary>
        public double? WindSpeedRelKnots { get; set; }

        /// <summary>
        ///     True wind speed. (m/s) rel. to north)
        /// </summary>
        public double? WindSpeedTrue { get; set; }

        /// <summary>
        ///     True wind speed. (kn rel. to north)
        /// </summary>
        public double? WindSpeedTrueKnots { get; set; }
    }
}