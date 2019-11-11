using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentGroup
    {
        public EquipmentGroup()
        {
            CertificationCheckListCertificationCheckListPrimaryGroup = new HashSet<CertificationCheckList>();
            CertificationCheckListCertificationCheckListSecondaryGroup = new HashSet<CertificationCheckList>();
            CertificationCheckListCertificationCheckListSubGroup = new HashSet<CertificationCheckList>();
            DocumentDocumentPrimaryGroup = new HashSet<Document>();
            DocumentDocumentSecondaryGroup = new HashSet<Document>();
            DocumentDocumentSubGroup = new HashSet<Document>();
            EquipmentEquipmentPrimaryGroup = new HashSet<Equipment>();
            EquipmentEquipmentSecondaryGroup = new HashSet<Equipment>();
            EquipmentEquipmentSubGroup = new HashSet<Equipment>();
            EquipmentGroupAssociation = new HashSet<EquipmentGroupAssociation>();
            ModelModelPrimaryGroup = new HashSet<Model>();
            ModelModelSecondaryGroup = new HashSet<Model>();
            ModelModelSubGroup = new HashSet<Model>();
            PreCompiledCheckListPreCompiledChecklistPrimaryGroup = new HashSet<PreCompiledCheckList>();
            PreCompiledCheckListPreCompiledChecklistSecondaryGroup = new HashSet<PreCompiledCheckList>();
            PreCompiledCheckListPreCompiledChecklistSubGroup = new HashSet<PreCompiledCheckList>();
            SoftwareSoftwarePrimaryGroup = new HashSet<Software>();
            SoftwareSoftwareSecondaryGroup = new HashSet<Software>();
            SoftwareSoftwareSubGroup = new HashSet<Software>();
        }

        public int EquipmentGroupId { get; set; }
        public string EquipmentGroupName { get; set; }
        public int EquipmentGroupTypeId { get; set; }
        public string EquipmentGroupDescription { get; set; }
        public int? EquipmentGroupParentId { get; set; }
        public int? EquipmentGroupChildId { get; set; }
        public int? EquipmentGroupSubId { get; set; }
        public int? Type { get; set; }
        public bool? IsActive { get; set; }
        public Guid? EquipmentGroupReferenceId { get; set; }

        public virtual ICollection<CertificationCheckList> CertificationCheckListCertificationCheckListPrimaryGroup { get; set; }
        public virtual ICollection<CertificationCheckList> CertificationCheckListCertificationCheckListSecondaryGroup { get; set; }
        public virtual ICollection<CertificationCheckList> CertificationCheckListCertificationCheckListSubGroup { get; set; }
        public virtual ICollection<Document> DocumentDocumentPrimaryGroup { get; set; }
        public virtual ICollection<Document> DocumentDocumentSecondaryGroup { get; set; }
        public virtual ICollection<Document> DocumentDocumentSubGroup { get; set; }
        public virtual ICollection<Equipment> EquipmentEquipmentPrimaryGroup { get; set; }
        public virtual ICollection<Equipment> EquipmentEquipmentSecondaryGroup { get; set; }
        public virtual ICollection<Equipment> EquipmentEquipmentSubGroup { get; set; }
        public virtual ICollection<EquipmentGroupAssociation> EquipmentGroupAssociation { get; set; }
        public virtual ICollection<Model> ModelModelPrimaryGroup { get; set; }
        public virtual ICollection<Model> ModelModelSecondaryGroup { get; set; }
        public virtual ICollection<Model> ModelModelSubGroup { get; set; }
        public virtual ICollection<PreCompiledCheckList> PreCompiledCheckListPreCompiledChecklistPrimaryGroup { get; set; }
        public virtual ICollection<PreCompiledCheckList> PreCompiledCheckListPreCompiledChecklistSecondaryGroup { get; set; }
        public virtual ICollection<PreCompiledCheckList> PreCompiledCheckListPreCompiledChecklistSubGroup { get; set; }
        public virtual ICollection<Software> SoftwareSoftwarePrimaryGroup { get; set; }
        public virtual ICollection<Software> SoftwareSoftwareSecondaryGroup { get; set; }
        public virtual ICollection<Software> SoftwareSoftwareSubGroup { get; set; }
    }
}
