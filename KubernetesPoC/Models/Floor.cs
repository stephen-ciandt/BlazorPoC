using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Floor
    {
        public Floor()
        {
            FloorAreaMembers = new HashSet<FloorAreaMembers>();
        }

        public int FloorId { get; set; }
        public int FloorLevel { get; set; }
        public int FloorBuildingId { get; set; }

        public virtual Building FloorBuilding { get; set; }
        public virtual ICollection<FloorAreaMembers> FloorAreaMembers { get; set; }
    }
}
