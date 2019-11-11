using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoTemplateResourceEstimate
    {
        public int MoTemplateResourceEstimateId { get; set; }
        public int MoTemplateResourceEstimateUserGroupId { get; set; }
        public int? MoTemplateResourceEstimateQuantityNeededInMins { get; set; }
        public int? MoTemplateResourceEstimateUserId { get; set; }
        public int MoTemplateResourceEstimateMoTemplateId { get; set; }

        public virtual MaintenanceOrderTemplate MoTemplateResourceEstimateMoTemplate { get; set; }
        public virtual User MoTemplateResourceEstimateUser { get; set; }
        public virtual UserGroup MoTemplateResourceEstimateUserGroup { get; set; }
    }
}
