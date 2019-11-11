using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PanaCimmapping
    {
        public int PanaCimmappingId { get; set; }
        public int PanaCimId { get; set; }
        public string PanaCimBarCode { get; set; }
        public int MmsId { get; set; }
        public int Type { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public int? PanaCimmappingIntegrationId { get; set; }
    }
}
