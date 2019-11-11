using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            AreaArZone = new HashSet<AreaArZone>();
            AreaEquipmentMembers = new HashSet<AreaEquipmentMembers>();
            AutoTagSchedule = new HashSet<AutoTagSchedule>();
            CertificationCheckList = new HashSet<CertificationCheckList>();
            CycleCountAssets = new HashSet<CycleCountAssets>();
            EquipmentArMarker = new HashSet<EquipmentArMarker>();
            EquipmentArXmlConfig = new HashSet<EquipmentArXmlConfig>();
            EquipmentAssignation = new HashSet<EquipmentAssignation>();
            EquipmentAttribute = new HashSet<EquipmentAttribute>();
            EquipmentBusinessRule = new HashSet<EquipmentBusinessRule>();
            EquipmentComment = new HashSet<EquipmentComment>();
            EquipmentCostCenterHistory = new HashSet<EquipmentCostCenterHistory>();
            EquipmentCurrentState = new HashSet<EquipmentCurrentState>();
            EquipmentDocumentMembers = new HashSet<EquipmentDocumentMembers>();
            EquipmentFeederEquipmentFeederEquipment = new HashSet<EquipmentFeeder>();
            EquipmentFeederEquipmentFeederFeeder = new HashSet<EquipmentFeeder>();
            EquipmentLocationHistory = new HashSet<EquipmentLocationHistory>();
            EquipmentMeter = new HashSet<EquipmentMeter>();
            EquipmentPartGroupMembers = new HashSet<EquipmentPartGroupMembers>();
            EquipmentPicture = new HashSet<EquipmentPicture>();
            EquipmentReasonCodeGroupMembers = new HashSet<EquipmentReasonCodeGroupMembers>();
            InverseEquipmentFeederEquipment = new HashSet<Equipment>();
            KnowledgeBaseEquipment = new HashSet<KnowledgeBaseEquipment>();
            MaintenanceOrder = new HashSet<MaintenanceOrder>();
            MaintenanceOrderTemplate = new HashSet<MaintenanceOrderTemplate>();
            Pmschedule = new HashSet<Pmschedule>();
            PmscheduleEquipment = new HashSet<PmscheduleEquipment>();
            PreCompiledCheckList = new HashSet<PreCompiledCheckList>();
            RepairTicket = new HashSet<RepairTicket>();
            RepairTicketSummary = new HashSet<RepairTicketSummary>();
            RepairTicketTemplate = new HashSet<RepairTicketTemplate>();
            SoftwareUpgradeScheduleEquipment = new HashSet<SoftwareUpgradeScheduleEquipment>();
        }

        public int EquipmentId { get; set; }
        public bool EquipmentActive { get; set; }
        public int? EquipmentSubGroupId { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentModelNumber { get; set; }
        public int? EquipmentLocationId { get; set; }
        public string EquipmentSerialNumber { get; set; }
        public string EquipmentBarCode { get; set; }
        public long? EquipmentNextPmdue { get; set; }
        public long? EquipmentDob { get; set; }
        public long? EquipmentInstallDate { get; set; }
        public string EquipmentAssetTag { get; set; }
        public string EquipmentMachineCounter { get; set; }
        public bool EquipmentRequiresAirSupply { get; set; }
        public string EquipmentVoltageReq { get; set; }
        public string EquipmentHostName { get; set; }
        public string EquipmentIpaddress { get; set; }
        public int? EquipmentCostCenterId { get; set; }
        public int? EquipmentPrimaryGroupId { get; set; }
        public int? EquipmentSecondaryGroupId { get; set; }
        public int? EquipmentTemplateId { get; set; }
        public bool EquipmentIsTemplate { get; set; }
        public int? EquipmentPrimaryAreaId { get; set; }
        public string EquipmentCreatedBy { get; set; }
        public long EquipmentCreatedDate { get; set; }
        public decimal? EquipmentCapitalCost { get; set; }
        public decimal? EquipmentAvgLaborRate { get; set; }
        public double? EquipmentExpectedLifeCycle { get; set; }
        public decimal? EquipmentContractPrice { get; set; }
        public int EquipmentStatus { get; set; }
        public decimal? EquipmentTotalBudget { get; set; }
        public int? EquipmentDefaultPriority { get; set; }
        public int Type { get; set; }
        public string PartNumber { get; set; }
        public bool? IsPneumatic { get; set; }
        public bool? IsCutter { get; set; }
        public decimal? Rcount { get; set; }
        public decimal? RlifetimeCount { get; set; }
        public decimal? Lcount { get; set; }
        public decimal? LlifetimeCount { get; set; }
        public decimal? TotalCount { get; set; }
        public bool? EquipmentIncludeInOmeCalculation { get; set; }
        public int? EquipmentFeederEquipmentId { get; set; }
        public int? EquipmentSubType { get; set; }
        public int EquipmentControlFlag { get; set; }
        public bool EquipmentIsDeleted { get; set; }
        public Guid? EquipmentReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public string EquipmentSoftwareVersion { get; set; }
        public string EquipmentFirmwareVersion { get; set; }
        public string EquipmentMountedLocation { get; set; }
        public long? EquipmentRegistrationDate { get; set; }
        public long? EquipmentPingTestPass { get; set; }
        public int? AssetCondition { get; set; }

        public virtual CostCenter EquipmentCostCenter { get; set; }
        public virtual Equipment EquipmentFeederEquipment { get; set; }
        public virtual Location EquipmentLocation { get; set; }
        public virtual Area EquipmentPrimaryArea { get; set; }
        public virtual EquipmentGroup EquipmentPrimaryGroup { get; set; }
        public virtual EquipmentGroup EquipmentSecondaryGroup { get; set; }
        public virtual EquipmentGroup EquipmentSubGroup { get; set; }
        public virtual ICollection<AreaArZone> AreaArZone { get; set; }
        public virtual ICollection<AreaEquipmentMembers> AreaEquipmentMembers { get; set; }
        public virtual ICollection<AutoTagSchedule> AutoTagSchedule { get; set; }
        public virtual ICollection<CertificationCheckList> CertificationCheckList { get; set; }
        public virtual ICollection<CycleCountAssets> CycleCountAssets { get; set; }
        public virtual ICollection<EquipmentArMarker> EquipmentArMarker { get; set; }
        public virtual ICollection<EquipmentArXmlConfig> EquipmentArXmlConfig { get; set; }
        public virtual ICollection<EquipmentAssignation> EquipmentAssignation { get; set; }
        public virtual ICollection<EquipmentAttribute> EquipmentAttribute { get; set; }
        public virtual ICollection<EquipmentBusinessRule> EquipmentBusinessRule { get; set; }
        public virtual ICollection<EquipmentComment> EquipmentComment { get; set; }
        public virtual ICollection<EquipmentCostCenterHistory> EquipmentCostCenterHistory { get; set; }
        public virtual ICollection<EquipmentCurrentState> EquipmentCurrentState { get; set; }
        public virtual ICollection<EquipmentDocumentMembers> EquipmentDocumentMembers { get; set; }
        public virtual ICollection<EquipmentFeeder> EquipmentFeederEquipmentFeederEquipment { get; set; }
        public virtual ICollection<EquipmentFeeder> EquipmentFeederEquipmentFeederFeeder { get; set; }
        public virtual ICollection<EquipmentLocationHistory> EquipmentLocationHistory { get; set; }
        public virtual ICollection<EquipmentMeter> EquipmentMeter { get; set; }
        public virtual ICollection<EquipmentPartGroupMembers> EquipmentPartGroupMembers { get; set; }
        public virtual ICollection<EquipmentPicture> EquipmentPicture { get; set; }
        public virtual ICollection<EquipmentReasonCodeGroupMembers> EquipmentReasonCodeGroupMembers { get; set; }
        public virtual ICollection<Equipment> InverseEquipmentFeederEquipment { get; set; }
        public virtual ICollection<KnowledgeBaseEquipment> KnowledgeBaseEquipment { get; set; }
        public virtual ICollection<MaintenanceOrder> MaintenanceOrder { get; set; }
        public virtual ICollection<MaintenanceOrderTemplate> MaintenanceOrderTemplate { get; set; }
        public virtual ICollection<Pmschedule> Pmschedule { get; set; }
        public virtual ICollection<PmscheduleEquipment> PmscheduleEquipment { get; set; }
        public virtual ICollection<PreCompiledCheckList> PreCompiledCheckList { get; set; }
        public virtual ICollection<RepairTicket> RepairTicket { get; set; }
        public virtual ICollection<RepairTicketSummary> RepairTicketSummary { get; set; }
        public virtual ICollection<RepairTicketTemplate> RepairTicketTemplate { get; set; }
        public virtual ICollection<SoftwareUpgradeScheduleEquipment> SoftwareUpgradeScheduleEquipment { get; set; }
    }
}
