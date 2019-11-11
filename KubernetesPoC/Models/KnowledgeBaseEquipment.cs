using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class KnowledgeBaseEquipment
    {
        public int KnowledgeBaseEquipmentId { get; set; }
        public int KnowledgeBaseId { get; set; }
        public int EquipmentId { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual KnowledgeBase KnowledgeBase { get; set; }
    }
}
