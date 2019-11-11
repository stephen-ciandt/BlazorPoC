using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Location
    {
        public Location()
        {
            AreaLocation = new HashSet<AreaLocation>();
            CycleCount = new HashSet<CycleCount>();
            CycleCountAssets = new HashSet<CycleCountAssets>();
            Equipment = new HashSet<Equipment>();
            EquipmentLocationHistory = new HashSet<EquipmentLocationHistory>();
            Part = new HashSet<Part>();
            PartDelivery = new HashSet<PartDelivery>();
            PartInventory = new HashSet<PartInventory>();
            PartTransaction = new HashSet<PartTransaction>();
            SubLocation = new HashSet<SubLocation>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int LocationLocationTypeId { get; set; }
        public string LocationDescription { get; set; }
        public int LocationControlFlag { get; set; }
        public bool LocationIsDeleted { get; set; }
        public Guid? LocationReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual LocationType LocationLocationType { get; set; }
        public virtual ICollection<AreaLocation> AreaLocation { get; set; }
        public virtual ICollection<CycleCount> CycleCount { get; set; }
        public virtual ICollection<CycleCountAssets> CycleCountAssets { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual ICollection<EquipmentLocationHistory> EquipmentLocationHistory { get; set; }
        public virtual ICollection<Part> Part { get; set; }
        public virtual ICollection<PartDelivery> PartDelivery { get; set; }
        public virtual ICollection<PartInventory> PartInventory { get; set; }
        public virtual ICollection<PartTransaction> PartTransaction { get; set; }
        public virtual ICollection<SubLocation> SubLocation { get; set; }
    }
}
