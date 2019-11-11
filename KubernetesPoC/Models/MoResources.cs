using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoResources
    {
        public int MoResourcesId { get; set; }
        public int MoResourcesUserGroupId { get; set; }
        public int? MoResourcesUserId { get; set; }
        public int? MoResourcesQuantityNeededInMins { get; set; }
        public int? MoResourcesQuantityUsedInMins { get; set; }
        public long? MoResourcesScanOnDateTime { get; set; }
        public long? MoResourcesScanOffDateTime { get; set; }
        public int MoResourcesMaintenanceOrderId { get; set; }

        public virtual MaintenanceOrder MoResourcesMaintenanceOrder { get; set; }
        public virtual User MoResourcesUser { get; set; }
        public virtual UserGroup MoResourcesUserGroup { get; set; }
    }
}
