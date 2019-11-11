using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class DocumentVersion
    {
        public DocumentVersion()
        {
            CertificationCheckList = new HashSet<CertificationCheckList>();
            EquipmentDocumentMembers = new HashSet<EquipmentDocumentMembers>();
            MoCertificationCheckList = new HashSet<MoCertificationCheckList>();
            MoDocuments = new HashSet<MoDocuments>();
            MoTemplateDocument = new HashSet<MoTemplateDocument>();
            PreCompiledCheckList = new HashSet<PreCompiledCheckList>();
        }

        public int DocumentVersionId { get; set; }
        public int DocumentVersionDocumentId { get; set; }
        public bool DocumentVersionActive { get; set; }
        public string DocumentVersionVersionNumber { get; set; }
        public string DocumentVersionFileName { get; set; }
        public bool DocumentVersionIsUrl { get; set; }
        public string DocumentVersionCreatedBy { get; set; }
        public long DocumentVersionCreatedDate { get; set; }

        public virtual Document DocumentVersionDocument { get; set; }
        public virtual ICollection<CertificationCheckList> CertificationCheckList { get; set; }
        public virtual ICollection<EquipmentDocumentMembers> EquipmentDocumentMembers { get; set; }
        public virtual ICollection<MoCertificationCheckList> MoCertificationCheckList { get; set; }
        public virtual ICollection<MoDocuments> MoDocuments { get; set; }
        public virtual ICollection<MoTemplateDocument> MoTemplateDocument { get; set; }
        public virtual ICollection<PreCompiledCheckList> PreCompiledCheckList { get; set; }
    }
}
