using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Area
    {
        public Area()
        {
            AreaAttribute = new HashSet<AreaAttribute>();
            AreaEquipmentMembers = new HashSet<AreaEquipmentMembers>();
            AreaLocation = new HashSet<AreaLocation>();
            AreaNotificationEmailConfiguration = new HashSet<AreaNotificationEmailConfiguration>();
            AreaNotificationUserGroupMembers = new HashSet<AreaNotificationUserGroupMembers>();
            AreaPicture = new HashSet<AreaPicture>();
            AssetMonitorArea = new HashSet<AssetMonitorArea>();
            AuditNotificationMailConfiguration = new HashSet<AuditNotificationMailConfiguration>();
            AuditNotificationUserGroups = new HashSet<AuditNotificationUserGroups>();
            CycleCount = new HashSet<CycleCount>();
            CycleCountAssets = new HashSet<CycleCountAssets>();
            Equipment = new HashSet<Equipment>();
            FloorAreaMembers = new HashSet<FloorAreaMembers>();
            LineDashboardConfig = new HashSet<LineDashboardConfig>();
            PartInventory = new HashSet<PartInventory>();
            Pmschedule = new HashSet<Pmschedule>();
            RepairTicketSummary = new HashSet<RepairTicketSummary>();
            SoftwareTargets = new HashSet<SoftwareTargets>();
            SoftwareUpgradeSchedule = new HashSet<SoftwareUpgradeSchedule>();
            StockingNotificationMailConfiguration = new HashSet<StockingNotificationMailConfiguration>();
            StockingNotificationUserGroups = new HashSet<StockingNotificationUserGroups>();
            UserCertAreaAssociation = new HashSet<UserCertAreaAssociation>();
        }

        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public string AreaDescription { get; set; }
        public string AreaCreatedBy { get; set; }
        public long AreaCreatedDate { get; set; }
        public bool AreaIsArEnabled { get; set; }
        public string AreaImage { get; set; }
        public bool? AreaIsStockingAreaNotification { get; set; }
        public int? AreaCccancellationReasonCodeGroupId { get; set; }
        public bool AreaIsAuditAreaNotification { get; set; }
        public int AreaControlFlag { get; set; }
        public bool AreaIsDeleted { get; set; }
        public Guid? AreaReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<AreaAttribute> AreaAttribute { get; set; }
        public virtual ICollection<AreaEquipmentMembers> AreaEquipmentMembers { get; set; }
        public virtual ICollection<AreaLocation> AreaLocation { get; set; }
        public virtual ICollection<AreaNotificationEmailConfiguration> AreaNotificationEmailConfiguration { get; set; }
        public virtual ICollection<AreaNotificationUserGroupMembers> AreaNotificationUserGroupMembers { get; set; }
        public virtual ICollection<AreaPicture> AreaPicture { get; set; }
        public virtual ICollection<AssetMonitorArea> AssetMonitorArea { get; set; }
        public virtual ICollection<AuditNotificationMailConfiguration> AuditNotificationMailConfiguration { get; set; }
        public virtual ICollection<AuditNotificationUserGroups> AuditNotificationUserGroups { get; set; }
        public virtual ICollection<CycleCount> CycleCount { get; set; }
        public virtual ICollection<CycleCountAssets> CycleCountAssets { get; set; }
        public virtual ICollection<Equipment> Equipment { get; set; }
        public virtual ICollection<FloorAreaMembers> FloorAreaMembers { get; set; }
        public virtual ICollection<LineDashboardConfig> LineDashboardConfig { get; set; }
        public virtual ICollection<PartInventory> PartInventory { get; set; }
        public virtual ICollection<Pmschedule> Pmschedule { get; set; }
        public virtual ICollection<RepairTicketSummary> RepairTicketSummary { get; set; }
        public virtual ICollection<SoftwareTargets> SoftwareTargets { get; set; }
        public virtual ICollection<SoftwareUpgradeSchedule> SoftwareUpgradeSchedule { get; set; }
        public virtual ICollection<StockingNotificationMailConfiguration> StockingNotificationMailConfiguration { get; set; }
        public virtual ICollection<StockingNotificationUserGroups> StockingNotificationUserGroups { get; set; }
        public virtual ICollection<UserCertAreaAssociation> UserCertAreaAssociation { get; set; }
    }
}
