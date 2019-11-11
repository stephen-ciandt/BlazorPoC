using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Software
    {
        public Software()
        {
            SoftwareAppliesTo = new HashSet<SoftwareAppliesTo>();
            SoftwareTargets = new HashSet<SoftwareTargets>();
            SoftwareUpgradeSchedule = new HashSet<SoftwareUpgradeSchedule>();
            SoftwareVersion = new HashSet<SoftwareVersion>();
        }

        public int SoftwareId { get; set; }
        public string SoftwareName { get; set; }
        public int? SoftwarePrimaryGroupId { get; set; }
        public int? SoftwareSecondaryGroupId { get; set; }
        public int? SoftwareSubGroupId { get; set; }
        public string SoftwareCreatedBy { get; set; }
        public long SoftwareCreatedDate { get; set; }
        public string SoftwareDescription { get; set; }
        public string SoftwareVersionNumber { get; set; }
        public bool? SoftwareActive { get; set; }
        public int SoftwareControlFlag { get; set; }
        public bool SoftwareIsDeleted { get; set; }
        public Guid? SoftwareReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual EquipmentGroup SoftwarePrimaryGroup { get; set; }
        public virtual EquipmentGroup SoftwareSecondaryGroup { get; set; }
        public virtual EquipmentGroup SoftwareSubGroup { get; set; }
        public virtual ICollection<SoftwareAppliesTo> SoftwareAppliesTo { get; set; }
        public virtual ICollection<SoftwareTargets> SoftwareTargets { get; set; }
        public virtual ICollection<SoftwareUpgradeSchedule> SoftwareUpgradeSchedule { get; set; }
        public virtual ICollection<SoftwareVersion> SoftwareVersion { get; set; }
    }
}
