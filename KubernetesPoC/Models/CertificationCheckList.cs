using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CertificationCheckList
    {
        public CertificationCheckList()
        {
            CertificationCheckListStep = new HashSet<CertificationCheckListStep>();
            MoCertificationCheckList = new HashSet<MoCertificationCheckList>();
            MoTemplateCertificationCheckList = new HashSet<MoTemplateCertificationCheckList>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public int? EquipmentId { get; set; }
        public string Description { get; set; }
        public int? DocumentVersionId { get; set; }
        public int? CertificationCheckListPrimaryGroupId { get; set; }
        public int? CertificationCheckListSecondaryGroupId { get; set; }
        public int? CertificationCheckListSubGroupId { get; set; }
        public int CertificationCheckListControlFlag { get; set; }
        public bool CertificationCheckListIsDeleted { get; set; }
        public Guid? CertificationCheckListReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual EquipmentGroup CertificationCheckListPrimaryGroup { get; set; }
        public virtual EquipmentGroup CertificationCheckListSecondaryGroup { get; set; }
        public virtual EquipmentGroup CertificationCheckListSubGroup { get; set; }
        public virtual DocumentVersion DocumentVersion { get; set; }
        public virtual Equipment Equipment { get; set; }
        public virtual ICollection<CertificationCheckListStep> CertificationCheckListStep { get; set; }
        public virtual ICollection<MoCertificationCheckList> MoCertificationCheckList { get; set; }
        public virtual ICollection<MoTemplateCertificationCheckList> MoTemplateCertificationCheckList { get; set; }
    }
}
