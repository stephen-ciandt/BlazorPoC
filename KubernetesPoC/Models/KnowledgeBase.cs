using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class KnowledgeBase
    {
        public KnowledgeBase()
        {
            KnowledgeBaseCheckList = new HashSet<KnowledgeBaseCheckList>();
            KnowledgeBaseDocument = new HashSet<KnowledgeBaseDocument>();
            KnowledgeBaseEquipment = new HashSet<KnowledgeBaseEquipment>();
            KnowledgeBaseMaintenanceOrder = new HashSet<KnowledgeBaseMaintenanceOrder>();
            KnowledgeBaseMultiMedia = new HashSet<KnowledgeBaseMultiMedia>();
            KnowledgeBaseRepairTicket = new HashSet<KnowledgeBaseRepairTicket>();
            KnowledgeBaseSparePart = new HashSet<KnowledgeBaseSparePart>();
        }

        public int KnowledgeBaseId { get; set; }
        public string KnowledgeBaseTitle { get; set; }
        public int KnowledgeBasePrimaryGroupId { get; set; }
        public int KnowledgeBaseSecondaryGroupId { get; set; }
        public int KnowledgeBaseSubGroupId { get; set; }
        public string KnowledgeBaseSummary { get; set; }
        public string KnowledgeBaseDetailedDescription { get; set; }
        public string KnowledgeBaseSearchContent { get; set; }
        public string KnowledgeBaseImage { get; set; }
        public bool KnowledgeBaseIsDeleted { get; set; }
        public int KnowledgeBaseControlFlag { get; set; }
        public Guid? KnowledgeBaseReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<KnowledgeBaseCheckList> KnowledgeBaseCheckList { get; set; }
        public virtual ICollection<KnowledgeBaseDocument> KnowledgeBaseDocument { get; set; }
        public virtual ICollection<KnowledgeBaseEquipment> KnowledgeBaseEquipment { get; set; }
        public virtual ICollection<KnowledgeBaseMaintenanceOrder> KnowledgeBaseMaintenanceOrder { get; set; }
        public virtual ICollection<KnowledgeBaseMultiMedia> KnowledgeBaseMultiMedia { get; set; }
        public virtual ICollection<KnowledgeBaseRepairTicket> KnowledgeBaseRepairTicket { get; set; }
        public virtual ICollection<KnowledgeBaseSparePart> KnowledgeBaseSparePart { get; set; }
    }
}
