using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class InventoryTurnLevel
    {
        public InventoryTurnLevel()
        {
            Part = new HashSet<Part>();
        }

        public int Id { get; set; }
        public string Level { get; set; }
        public int TimeHorizon { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Part> Part { get; set; }
    }
}
