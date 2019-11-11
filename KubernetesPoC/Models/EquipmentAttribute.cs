using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentAttribute
    {
        public int EquipmentAttributeId { get; set; }
        public int EquipmentAttributeAttributeId { get; set; }
        public int EquipmentAttributeEquipmentId { get; set; }
        public string EquipmentAttributeValue { get; set; }
        public long? EquipmentAttributeUpdatedDate { get; set; }
        public int? EquipmentAttributeUpdatedBy { get; set; }

        public virtual Attribute EquipmentAttributeAttribute { get; set; }
        public virtual Equipment EquipmentAttributeEquipment { get; set; }
    }
}
