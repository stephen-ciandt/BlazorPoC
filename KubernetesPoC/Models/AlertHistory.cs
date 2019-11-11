using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AlertHistory
    {
        public int AlertHistoryId { get; set; }
        public int AlertHistoryType { get; set; }
        public int AlertHistoryOverallStatus { get; set; }
        public string AlertHistoryReferenceNumber { get; set; }
        public long AlertHistoryNotifiedDate { get; set; }
        public long AlertHistoryClosedDate { get; set; }
        public int AlertHistoryUserId { get; set; }
    }
}
