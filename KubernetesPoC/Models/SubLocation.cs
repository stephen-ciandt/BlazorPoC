using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SubLocation
    {
        public SubLocation()
        {
            Bin = new HashSet<Bin>();
            CycleCount = new HashSet<CycleCount>();
            PartInventory = new HashSet<PartInventory>();
        }

        public int SubLocationId { get; set; }
        public string SubLocationName { get; set; }
        public int SubLocationLocationId { get; set; }

        public virtual Location SubLocationLocation { get; set; }
        public virtual ICollection<Bin> Bin { get; set; }
        public virtual ICollection<CycleCount> CycleCount { get; set; }
        public virtual ICollection<PartInventory> PartInventory { get; set; }
    }
}
