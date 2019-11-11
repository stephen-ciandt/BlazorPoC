using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Bin
    {
        public Bin()
        {
            CycleCount = new HashSet<CycleCount>();
            PartInventory = new HashSet<PartInventory>();
        }

        public int BinId { get; set; }
        public string BinName { get; set; }
        public int BinSubLocationId { get; set; }

        public virtual SubLocation BinSubLocation { get; set; }
        public virtual ICollection<CycleCount> CycleCount { get; set; }
        public virtual ICollection<PartInventory> PartInventory { get; set; }
    }
}
