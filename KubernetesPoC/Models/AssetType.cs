using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AssetType
    {
        public int AssetTypeId { get; set; }
        public int AssetTypeSubType { get; set; }
        public int AssetTypeAssetType { get; set; }
        public string AssetTypeAssetTypeName { get; set; }
        public string AssetTypeSubTypeName { get; set; }
        public string AssetTypeDescription { get; set; }
        public int? AssetTypePrimaryGroup { get; set; }
        public int? AssetTypeDefaultTemplate { get; set; }
        public bool? AssetTypeGeneral { get; set; }
        public bool? AssetTypeAssetInfo { get; set; }
        public bool? AssetTypeAttributes { get; set; }
        public bool? AssetTypePartList { get; set; }
        public bool? AssetTypeDocuments { get; set; }
        public bool? AssetTypeComments { get; set; }
        public bool? AssetTypeAutoTag { get; set; }
        public bool? AssetTypeAttributeHistory { get; set; }
        public bool? AssetTypeUpdateProfiles { get; set; }
        public bool? AssetTypeArsettings { get; set; }
        public bool? AssetTypeAccessories { get; set; }
        public string AssetTypeAssetCategory { get; set; }
        public string AssetTypeDisplayName { get; set; }
    }
}
