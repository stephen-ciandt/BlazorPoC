using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class KnowledgeBaseDocument
    {
        public int KnowledgeBaseDocumentId { get; set; }
        public int KnowledgeBaseId { get; set; }
        public int DocumentId { get; set; }

        public virtual Document Document { get; set; }
        public virtual KnowledgeBase KnowledgeBase { get; set; }
    }
}
