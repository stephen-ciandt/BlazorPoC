using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class LocationType
    {
        public LocationType()
        {
            Location = new HashSet<Location>();
        }

        public int LocationTypeId { get; set; }
        public string LocationTypeName { get; set; }
        public string LocationTypeDescription { get; set; }
        public int LocationTypeControlFlag { get; set; }
        public bool LocationTypeIsDeleted { get; set; }
        public Guid? LocationTypeReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<Location> Location { get; set; }
    }
}
