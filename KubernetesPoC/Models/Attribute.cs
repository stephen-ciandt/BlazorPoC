using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Attribute
    {
        public Attribute()
        {
            AreaAttribute = new HashSet<AreaAttribute>();
            AttributeAppliesTo = new HashSet<AttributeAppliesTo>();
            AttributeValues = new HashSet<AttributeValues>();
            BusinessRuleAttribute = new HashSet<BusinessRuleAttribute>();
            EquipmentAttribute = new HashSet<EquipmentAttribute>();
            MaintenanceOrderAttribute = new HashSet<MaintenanceOrderAttribute>();
            MaintenanceOrderTemplateAttribute = new HashSet<MaintenanceOrderTemplateAttribute>();
            SiteAttribute = new HashSet<SiteAttribute>();
        }

        public int AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeDescription { get; set; }
        public string AttributeType { get; set; }
        public int? Type { get; set; }
        public bool IsMandatory { get; set; }
        public int AttributeControlFlag { get; set; }
        public bool AttributeIsDeleted { get; set; }
        public Guid? AttributeReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public string AttributeAbbreviation { get; set; }
        public bool? IsValueMandatory { get; set; }
        public bool AttributeIsSystem { get; set; }

        public virtual ICollection<AreaAttribute> AreaAttribute { get; set; }
        public virtual ICollection<AttributeAppliesTo> AttributeAppliesTo { get; set; }
        public virtual ICollection<AttributeValues> AttributeValues { get; set; }
        public virtual ICollection<BusinessRuleAttribute> BusinessRuleAttribute { get; set; }
        public virtual ICollection<EquipmentAttribute> EquipmentAttribute { get; set; }
        public virtual ICollection<MaintenanceOrderAttribute> MaintenanceOrderAttribute { get; set; }
        public virtual ICollection<MaintenanceOrderTemplateAttribute> MaintenanceOrderTemplateAttribute { get; set; }
        public virtual ICollection<SiteAttribute> SiteAttribute { get; set; }
    }
}
