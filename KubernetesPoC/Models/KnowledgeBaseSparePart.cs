using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class KnowledgeBaseSparePart
    {
        public int KnowledgeBaseSparePartId { get; set; }
        public int KnowledgeBaseId { get; set; }
        public int SparePartId { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }
        public virtual Part SparePart { get; set; }
    }
}
