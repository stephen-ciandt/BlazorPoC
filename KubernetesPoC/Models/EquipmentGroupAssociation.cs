using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentGroupAssociation
    {
        public int EquipmentGroupAssociationId { get; set; }
        public int EquipmentGroupAssociationEquipmentGroupId { get; set; }
        public int EquipmentGroupAssociationAssociatedParentId { get; set; }

        public virtual EquipmentGroup EquipmentGroupAssociationEquipmentGroup { get; set; }
    }
}
