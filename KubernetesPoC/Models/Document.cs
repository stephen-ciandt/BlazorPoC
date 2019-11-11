using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Document
    {
        public Document()
        {
            DocumentVersion = new HashSet<DocumentVersion>();
            KnowledgeBaseDocument = new HashSet<KnowledgeBaseDocument>();
            KnowledgeBaseMultiMedia = new HashSet<KnowledgeBaseMultiMedia>();
        }

        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public int? DocumentPrimaryGroupId { get; set; }
        public int? DocumentSecondaryGroupId { get; set; }
        public int? DocumentSubGroupId { get; set; }
        public string DocumentCurrentRevision { get; set; }
        public string DocumentCreatedBy { get; set; }
        public long DocumentCreatedDate { get; set; }
        public int? Type { get; set; }
        public string DocumentDescription { get; set; }
        public bool IsChapter { get; set; }
        public long? DocumentPublishedDate { get; set; }
        public string DocumentVersionNumber { get; set; }
        public int? DocumentParentDocumentId { get; set; }
        public bool? DocumentActive { get; set; }
        public int DocumentControlFlag { get; set; }
        public bool DocumentIsDeleted { get; set; }
        public Guid? DocumentReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual EquipmentGroup DocumentPrimaryGroup { get; set; }
        public virtual EquipmentGroup DocumentSecondaryGroup { get; set; }
        public virtual EquipmentGroup DocumentSubGroup { get; set; }
        public virtual ICollection<DocumentVersion> DocumentVersion { get; set; }
        public virtual ICollection<KnowledgeBaseDocument> KnowledgeBaseDocument { get; set; }
        public virtual ICollection<KnowledgeBaseMultiMedia> KnowledgeBaseMultiMedia { get; set; }
    }
}
