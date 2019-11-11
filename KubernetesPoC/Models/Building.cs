using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Building
    {
        public Building()
        {
            Floor = new HashSet<Floor>();
        }

        public int BuildingId { get; set; }
        public string BuildingName { get; set; }
        public int BuildingSiteId { get; set; }

        public virtual Site BuildingSite { get; set; }
        public virtual ICollection<Floor> Floor { get; set; }
    }
}
