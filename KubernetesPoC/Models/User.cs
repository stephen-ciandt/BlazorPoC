using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class User
    {
        public User()
        {
            Audit = new HashSet<Audit>();
            AuditNotificationUser = new HashSet<AuditNotificationUser>();
            AutoTagSchedule = new HashSet<AutoTagSchedule>();
            CycleCountCreatedByNavigation = new HashSet<CycleCount>();
            CycleCountResources = new HashSet<CycleCountResources>();
            CycleCountUserExecutingNavigation = new HashSet<CycleCount>();
            DeliveryRequestDeliveredByNavigation = new HashSet<DeliveryRequest>();
            DeliveryRequestResquestedByNavigation = new HashSet<DeliveryRequest>();
            EquipmentAssignation = new HashSet<EquipmentAssignation>();
            EquipmentComment = new HashSet<EquipmentComment>();
            EscalationNotificationUserGroupMembers = new HashSet<EscalationNotificationUserGroupMembers>();
            InventorySchedulesInventoryScheduleCreatedUserNavigation = new HashSet<InventorySchedules>();
            InventorySchedulesInventoryScheduleLastUpdatedByNavigation = new HashSet<InventorySchedules>();
            MaintenanceOrder = new HashSet<MaintenanceOrder>();
            MaintenanceOrderTemplate = new HashSet<MaintenanceOrderTemplate>();
            MoCertificationCheckListStep = new HashSet<MoCertificationCheckListStep>();
            MoComment = new HashSet<MoComment>();
            MoHistory = new HashSet<MoHistory>();
            MoParts = new HashSet<MoParts>();
            MoPreCompiledCheckListStep = new HashSet<MoPreCompiledCheckListStep>();
            MoResources = new HashSet<MoResources>();
            MoTemplateResourceEstimate = new HashSet<MoTemplateResourceEstimate>();
            PartStore = new HashSet<PartStore>();
            PartTransaction = new HashSet<PartTransaction>();
            Pmschedule = new HashSet<Pmschedule>();
            RepairTicket = new HashSet<RepairTicket>();
            RepairTicketClosedNotification = new HashSet<RepairTicketClosedNotification>();
            RepairTicketComment = new HashSet<RepairTicketComment>();
            RepairTicketHistory = new HashSet<RepairTicketHistory>();
            RepairTicketTemplate = new HashSet<RepairTicketTemplate>();
            RepairTicketTemplateClosedNotification = new HashSet<RepairTicketTemplateClosedNotification>();
            StockingNotificationUser = new HashSet<StockingNotificationUser>();
            UserCertAssignedUserList = new HashSet<UserCertAssignedUserList>();
            UserCertNotificationMapping = new HashSet<UserCertNotificationMapping>();
            UserCertTrainerUserList = new HashSet<UserCertTrainerUserList>();
            UserCertificationResultsPerformedUser = new HashSet<UserCertificationResults>();
            UserCertificationResultsRecordedUser = new HashSet<UserCertificationResults>();
            UserGroupMembers = new HashSet<UserGroupMembers>();
            UserLoginHistory = new HashSet<UserLoginHistory>();
            UserPreference = new HashSet<UserPreference>();
        }

        public int UserId { get; set; }
        public string UserLoginId { get; set; }
        public string UserPassword { get; set; }
        public string UserFirstName { get; set; }
        public bool? UserIsActive { get; set; }
        public string UserDescription { get; set; }
        public string UserEmailId { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserLastName { get; set; }
        public int? UserPrimaryGroupId { get; set; }
        public string UserCreatedBy { get; set; }
        public long UserCreatedDate { get; set; }
        public int? UserExtension { get; set; }
        public bool UserIsPasswordReset { get; set; }
        public int UserControlFlag { get; set; }
        public bool UserIsDeleted { get; set; }
        public Guid? UserReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public int? UserInvalidAttempts { get; set; }
        public long? UserUnLockTimeStamp { get; set; }
        public int? UserDefaultLanguage { get; set; }

        public virtual AppLanguage UserDefaultLanguageNavigation { get; set; }
        public virtual UserGroup UserPrimaryGroup { get; set; }
        public virtual ICollection<Audit> Audit { get; set; }
        public virtual ICollection<AuditNotificationUser> AuditNotificationUser { get; set; }
        public virtual ICollection<AutoTagSchedule> AutoTagSchedule { get; set; }
        public virtual ICollection<CycleCount> CycleCountCreatedByNavigation { get; set; }
        public virtual ICollection<CycleCountResources> CycleCountResources { get; set; }
        public virtual ICollection<CycleCount> CycleCountUserExecutingNavigation { get; set; }
        public virtual ICollection<DeliveryRequest> DeliveryRequestDeliveredByNavigation { get; set; }
        public virtual ICollection<DeliveryRequest> DeliveryRequestResquestedByNavigation { get; set; }
        public virtual ICollection<EquipmentAssignation> EquipmentAssignation { get; set; }
        public virtual ICollection<EquipmentComment> EquipmentComment { get; set; }
        public virtual ICollection<EscalationNotificationUserGroupMembers> EscalationNotificationUserGroupMembers { get; set; }
        public virtual ICollection<InventorySchedules> InventorySchedulesInventoryScheduleCreatedUserNavigation { get; set; }
        public virtual ICollection<InventorySchedules> InventorySchedulesInventoryScheduleLastUpdatedByNavigation { get; set; }
        public virtual ICollection<MaintenanceOrder> MaintenanceOrder { get; set; }
        public virtual ICollection<MaintenanceOrderTemplate> MaintenanceOrderTemplate { get; set; }
        public virtual ICollection<MoCertificationCheckListStep> MoCertificationCheckListStep { get; set; }
        public virtual ICollection<MoComment> MoComment { get; set; }
        public virtual ICollection<MoHistory> MoHistory { get; set; }
        public virtual ICollection<MoParts> MoParts { get; set; }
        public virtual ICollection<MoPreCompiledCheckListStep> MoPreCompiledCheckListStep { get; set; }
        public virtual ICollection<MoResources> MoResources { get; set; }
        public virtual ICollection<MoTemplateResourceEstimate> MoTemplateResourceEstimate { get; set; }
        public virtual ICollection<PartStore> PartStore { get; set; }
        public virtual ICollection<PartTransaction> PartTransaction { get; set; }
        public virtual ICollection<Pmschedule> Pmschedule { get; set; }
        public virtual ICollection<RepairTicket> RepairTicket { get; set; }
        public virtual ICollection<RepairTicketClosedNotification> RepairTicketClosedNotification { get; set; }
        public virtual ICollection<RepairTicketComment> RepairTicketComment { get; set; }
        public virtual ICollection<RepairTicketHistory> RepairTicketHistory { get; set; }
        public virtual ICollection<RepairTicketTemplate> RepairTicketTemplate { get; set; }
        public virtual ICollection<RepairTicketTemplateClosedNotification> RepairTicketTemplateClosedNotification { get; set; }
        public virtual ICollection<StockingNotificationUser> StockingNotificationUser { get; set; }
        public virtual ICollection<UserCertAssignedUserList> UserCertAssignedUserList { get; set; }
        public virtual ICollection<UserCertNotificationMapping> UserCertNotificationMapping { get; set; }
        public virtual ICollection<UserCertTrainerUserList> UserCertTrainerUserList { get; set; }
        public virtual ICollection<UserCertificationResults> UserCertificationResultsPerformedUser { get; set; }
        public virtual ICollection<UserCertificationResults> UserCertificationResultsRecordedUser { get; set; }
        public virtual ICollection<UserGroupMembers> UserGroupMembers { get; set; }
        public virtual ICollection<UserLoginHistory> UserLoginHistory { get; set; }
        public virtual ICollection<UserPreference> UserPreference { get; set; }
    }
}
