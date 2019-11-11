using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentDocumentMembers
    {
        public int EquipmentDocumentMembersId { get; set; }
        public int EquipmentDocumentMembersDocumentVersionId { get; set; }
        public int EquipmentDocumentMembersEquipmentId { get; set; }

        public virtual DocumentVersion EquipmentDocumentMembersDocumentVersion { get; set; }
        public virtual Equipment EquipmentDocumentMembersEquipment { get; set; }
    }
}
