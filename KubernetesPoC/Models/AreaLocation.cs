using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AreaLocation
    {
        public long Id { get; set; }
        public int AreaId { get; set; }
        public int LocationId { get; set; }
        public bool IsStockLocation { get; set; }

        public virtual Area Area { get; set; }
        public virtual Location Location { get; set; }
    }
}
