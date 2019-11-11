using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MaintenanceOrder
    {
        public MaintenanceOrder()
        {
            DeliveryRequest = new HashSet<DeliveryRequest>();
            KnowledgeBaseMaintenanceOrder = new HashSet<KnowledgeBaseMaintenanceOrder>();
            MaintenanceOrderAttribute = new HashSet<MaintenanceOrderAttribute>();
            MoCertificationCheckList = new HashSet<MoCertificationCheckList>();
            MoComment = new HashSet<MoComment>();
            MoDocuments = new HashSet<MoDocuments>();
            MoHistory = new HashSet<MoHistory>();
            MoParts = new HashSet<MoParts>();
            MoPreCompiledCheckList = new HashSet<MoPreCompiledCheckList>();
            MoRepairRequests = new HashSet<MoRepairRequests>();
            MoResources = new HashSet<MoResources>();
            PartTransaction = new HashSet<PartTransaction>();
        }

        public int MaintenanceOrderId { get; set; }
        public int MaintenanceOrderEquipmentId { get; set; }
        public long MaintenanceOrderPlannedDueDate { get; set; }
        public long? MaintenanceOrderScheduledDate { get; set; }
        public int MaintenanceOrderReasonCodeId { get; set; }
        public int? MaintenanceOrderCancelReasonCodeId { get; set; }
        public int? MaintenanceOrderTemplateId { get; set; }
        public int MaintenanceOrderEstimatedOutageInMins { get; set; }
        public int MaintenanceOrderPriority { get; set; }
        public string MaintenanceOrderDescription { get; set; }
        public int? MaintenanceOrderCostCenterId { get; set; }
        public string MaintenanceOrderTitle { get; set; }
        public int MaintenanceOrderMaintenanceEventTypeId { get; set; }
        public int MaintenanceOrderStatus { get; set; }
        public string MaintenanceOrderNumber { get; set; }
        public int? MaintenanceOrderRepairTicketId { get; set; }
        public int MaintenanceOrderCreatedByUserId { get; set; }
        public bool MaintenanceOrderIsModified { get; set; }
        public long MaintenanceOrderCreatedDate { get; set; }
        public int? MaintenanceOrderScheduleId { get; set; }
        public long? MaintenanceOrderCompletedDate { get; set; }
        public Guid? MaintenanceOrderReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public int? MaintenanceOrderBusinessRuleId { get; set; }

        public virtual ReasonCode MaintenanceOrderCancelReasonCode { get; set; }
        public virtual CostCenter MaintenanceOrderCostCenter { get; set; }
        public virtual User MaintenanceOrderCreatedByUser { get; set; }
        public virtual Equipment MaintenanceOrderEquipment { get; set; }
        public virtual MaintenanceEventType MaintenanceOrderMaintenanceEventType { get; set; }
        public virtual ReasonCode MaintenanceOrderReasonCode { get; set; }
        public virtual RepairTicket MaintenanceOrderRepairTicket { get; set; }
        public virtual Pmschedule MaintenanceOrderSchedule { get; set; }
        public virtual MaintenanceOrderTemplate MaintenanceOrderTemplate { get; set; }
        public virtual ICollection<DeliveryRequest> DeliveryRequest { get; set; }
        public virtual ICollection<KnowledgeBaseMaintenanceOrder> KnowledgeBaseMaintenanceOrder { get; set; }
        public virtual ICollection<MaintenanceOrderAttribute> MaintenanceOrderAttribute { get; set; }
        public virtual ICollection<MoCertificationCheckList> MoCertificationCheckList { get; set; }
        public virtual ICollection<MoComment> MoComment { get; set; }
        public virtual ICollection<MoDocuments> MoDocuments { get; set; }
        public virtual ICollection<MoHistory> MoHistory { get; set; }
        public virtual ICollection<MoParts> MoParts { get; set; }
        public virtual ICollection<MoPreCompiledCheckList> MoPreCompiledCheckList { get; set; }
        public virtual ICollection<MoRepairRequests> MoRepairRequests { get; set; }
        public virtual ICollection<MoResources> MoResources { get; set; }
        public virtual ICollection<PartTransaction> PartTransaction { get; set; }
    }
}
