using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ActiveMoresources
    {
        public int? MoResourcesUserId { get; set; }
        public int MoResourcesUserGroupId { get; set; }
        public long? MoResourcesScanOnDateTime { get; set; }
        public long? MoResourcesScanOffDateTime { get; set; }
        public int MoResourcesMaintenanceOrderId { get; set; }
    }
}
