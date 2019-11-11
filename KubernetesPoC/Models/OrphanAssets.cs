using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class OrphanAssets
    {
        public decimal OrphanAssetId { get; set; }
        public decimal? OrphanAssetThirdpartyid { get; set; }
        public string OrphanAssetName { get; set; }
        public string OrphanAssetSerialno { get; set; }
        public int? OrphanAssetAssetType { get; set; }
        public string OrphanAssetBarcode { get; set; }
        public decimal? OrphanAssetBirthdate { get; set; }
        public decimal? OrphanAssetOrphanedDate { get; set; }
    }
}
