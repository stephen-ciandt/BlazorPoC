using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoComment
    {
        public int MoCommentId { get; set; }
        public string MoCommentComment { get; set; }
        public long MoCommentCommentCreatedDate { get; set; }
        public int MoCommentCommentAddedByUserId { get; set; }
        public string MoCommentFileName { get; set; }
        public int MoCommentMaintenanceOrderId { get; set; }

        public virtual User MoCommentCommentAddedByUser { get; set; }
        public virtual MaintenanceOrder MoCommentMaintenanceOrder { get; set; }
    }
}
