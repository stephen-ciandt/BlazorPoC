using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MaintenanceOrderTemplate
    {
        public MaintenanceOrderTemplate()
        {
            AutoTagSchedule = new HashSet<AutoTagSchedule>();
            BusinessRule = new HashSet<BusinessRule>();
            MaintenanceOrder = new HashSet<MaintenanceOrder>();
            MaintenanceOrderTemplateAttribute = new HashSet<MaintenanceOrderTemplateAttribute>();
            MoTemplateCertificationCheckList = new HashSet<MoTemplateCertificationCheckList>();
            MoTemplateCheckList = new HashSet<MoTemplateCheckList>();
            MoTemplateDocument = new HashSet<MoTemplateDocument>();
            MoTemplatePartEstimate = new HashSet<MoTemplatePartEstimate>();
            MoTemplateResourceEstimate = new HashSet<MoTemplateResourceEstimate>();
            Pmschedule = new HashSet<Pmschedule>();
            PmscheduleEquipment = new HashSet<PmscheduleEquipment>();
        }

        public int MaintenanceOrderTemplateId { get; set; }
        public string MaintenanceOrderTemplateNumber { get; set; }
        public string MaintenanceOrderTemplateTitle { get; set; }
        public int? MaintenanceOrderTemplateEquipmentId { get; set; }
        public int MaintenanceOrderTemplatePriority { get; set; }
        public int MaintenanceOrderTemplateReasonCodeId { get; set; }
        public int? MaintenanceOrderTemplateCostCenterId { get; set; }
        public string MaintenanceOrderTemplateDescription { get; set; }
        public int MaintenanceOrderTemplateMaintenanceEventTypeId { get; set; }
        public int MaintenanceOrderTemplateEstimatedOutageInMins { get; set; }
        public long MaintenanceOrderTemplateCreatedDate { get; set; }
        public int? MaintenanceOrderTemplateCreatedUser { get; set; }
        public bool? MaintenanceOrderTemplateIsActive { get; set; }
        public int MaintenanceOrderTemplateControlFlag { get; set; }
        public Guid? MaintenanceOrderTemplateReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual CostCenter MaintenanceOrderTemplateCostCenter { get; set; }
        public virtual User MaintenanceOrderTemplateCreatedUserNavigation { get; set; }
        public virtual Equipment MaintenanceOrderTemplateEquipment { get; set; }
        public virtual MaintenanceEventType MaintenanceOrderTemplateMaintenanceEventType { get; set; }
        public virtual ReasonCode MaintenanceOrderTemplateReasonCode { get; set; }
        public virtual ICollection<AutoTagSchedule> AutoTagSchedule { get; set; }
        public virtual ICollection<BusinessRule> BusinessRule { get; set; }
        public virtual ICollection<MaintenanceOrder> MaintenanceOrder { get; set; }
        public virtual ICollection<MaintenanceOrderTemplateAttribute> MaintenanceOrderTemplateAttribute { get; set; }
        public virtual ICollection<MoTemplateCertificationCheckList> MoTemplateCertificationCheckList { get; set; }
        public virtual ICollection<MoTemplateCheckList> MoTemplateCheckList { get; set; }
        public virtual ICollection<MoTemplateDocument> MoTemplateDocument { get; set; }
        public virtual ICollection<MoTemplatePartEstimate> MoTemplatePartEstimate { get; set; }
        public virtual ICollection<MoTemplateResourceEstimate> MoTemplateResourceEstimate { get; set; }
        public virtual ICollection<Pmschedule> Pmschedule { get; set; }
        public virtual ICollection<PmscheduleEquipment> PmscheduleEquipment { get; set; }
    }
}
