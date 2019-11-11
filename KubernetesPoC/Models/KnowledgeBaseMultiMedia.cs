using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class KnowledgeBaseMultiMedia
    {
        public int KnowledgeBaseMultiMediaId { get; set; }
        public int KnowledgeBaseId { get; set; }
        public int MultiMediaFileId { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }
        public virtual Document MultiMediaFile { get; set; }
    }
}
