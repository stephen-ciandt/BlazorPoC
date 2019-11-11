using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CycleCountAssets
    {
        public int CycleCountAssetId { get; set; }
        public long CycleCountAssetCycleCountId { get; set; }
        public int CycleCountAssetAssetId { get; set; }
        public int CycleCountAssetAssetCondition { get; set; }
        public int CycleCountAssetCycleCountState { get; set; }
        public int CylceCountAssetAssetAreaId { get; set; }
        public int? CycleCountAssetAssetLocationId { get; set; }
        public string CycleCountAssetAssetComment { get; set; }
        public double? CycleCountAssetAssetCounterValue { get; set; }
        public int? CycleCountAssetCostCenterId { get; set; }

        public virtual Equipment CycleCountAssetAsset { get; set; }
        public virtual Location CycleCountAssetAssetLocation { get; set; }
        public virtual CostCenter CycleCountAssetCostCenter { get; set; }
        public virtual CycleCount CycleCountAssetCycleCount { get; set; }
        public virtual Area CylceCountAssetAssetArea { get; set; }
    }
}
