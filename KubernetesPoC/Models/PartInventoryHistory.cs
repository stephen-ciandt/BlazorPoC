using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartInventoryHistory
    {
        public int PartInventoryHistoryId { get; set; }
        public int PartInventoryHistoryPartId { get; set; }
        public int PartInventoryHistoryClosingQoH { get; set; }
        public long PartInventoryHistoryDate { get; set; }
    }
}
