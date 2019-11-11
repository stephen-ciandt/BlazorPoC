using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PreCompiledCheckList
    {
        public PreCompiledCheckList()
        {
            CheckListZoneMapping = new HashSet<CheckListZoneMapping>();
            EquipmentArZonePreCompiledCheckList = new HashSet<EquipmentArZonePreCompiledCheckList>();
            MoPreCompiledCheckList = new HashSet<MoPreCompiledCheckList>();
            MoTemplateCheckList = new HashSet<MoTemplateCheckList>();
            PreCompiledCheckListStep = new HashSet<PreCompiledCheckListStep>();
            PreCompiledCheckListUserGroup = new HashSet<PreCompiledCheckListUserGroup>();
        }

        public int PreCompiledCheckListId { get; set; }
        public string PreCompiledCheckListNumber { get; set; }
        public string PreCompiledCheckListName { get; set; }
        public int? PreCompiledCheckListEquipmentId { get; set; }
        public string PreCompiledCheckListDescription { get; set; }
        public int? PreCompiledCheckListDocumentVersionId { get; set; }
        public string PreCompiledCheckListCreatedBy { get; set; }
        public long PreCompiledCheckListCreatedDate { get; set; }
        public bool PreCompiledCheckListIsArEnabled { get; set; }
        public int? PreCompiledChecklistPrimaryGroupId { get; set; }
        public int? PreCompiledChecklistSecondaryGroupId { get; set; }
        public int? PreCompiledChecklistSubGroupId { get; set; }
        public int? PreCompiledCheckListEstimatedOutageInMins { get; set; }
        public int? PrecompiledCheckListChapterVersionId { get; set; }
        public int PreCompiledCheckListControlFlag { get; set; }
        public bool PreCompiledCheckListIsDeleted { get; set; }
        public Guid? PreCompiledCheckListReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual DocumentVersion PreCompiledCheckListDocumentVersion { get; set; }
        public virtual Equipment PreCompiledCheckListEquipment { get; set; }
        public virtual EquipmentGroup PreCompiledChecklistPrimaryGroup { get; set; }
        public virtual EquipmentGroup PreCompiledChecklistSecondaryGroup { get; set; }
        public virtual EquipmentGroup PreCompiledChecklistSubGroup { get; set; }
        public virtual ICollection<CheckListZoneMapping> CheckListZoneMapping { get; set; }
        public virtual ICollection<EquipmentArZonePreCompiledCheckList> EquipmentArZonePreCompiledCheckList { get; set; }
        public virtual ICollection<MoPreCompiledCheckList> MoPreCompiledCheckList { get; set; }
        public virtual ICollection<MoTemplateCheckList> MoTemplateCheckList { get; set; }
        public virtual ICollection<PreCompiledCheckListStep> PreCompiledCheckListStep { get; set; }
        public virtual ICollection<PreCompiledCheckListUserGroup> PreCompiledCheckListUserGroup { get; set; }
    }
}
