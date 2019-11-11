using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class FloorAreaMembers
    {
        public int FloorAreaMembersId { get; set; }
        public int FloorAreaMembersFloorId { get; set; }
        public int FloorAreaMembersAreaId { get; set; }

        public virtual Area FloorAreaMembersArea { get; set; }
        public virtual Floor FloorAreaMembersFloor { get; set; }
    }
}
