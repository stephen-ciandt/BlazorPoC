using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class KnowledgeBaseCheckList
    {
        public int KnowledgeBaseCheckListId { get; set; }
        public int KnowledgeBaseId { get; set; }
        public int CheckListId { get; set; }
        public int CheckListType { get; set; }

        public virtual KnowledgeBase KnowledgeBase { get; set; }
    }
}
