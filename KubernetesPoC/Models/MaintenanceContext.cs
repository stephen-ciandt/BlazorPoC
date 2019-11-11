using Microsoft.EntityFrameworkCore;

namespace KubernetesPoC.Models
{
	public partial class MaintenanceContext : DbContext
	{
		public MaintenanceContext()
		{
		}

		public MaintenanceContext(DbContextOptions<MaintenanceContext> options)
			: base(options)
		{
		}

		public virtual DbSet<ActiveMaintenanceOrders> ActiveMaintenanceOrders { get; set; }
		public virtual DbSet<ActiveMoresources> ActiveMoresources { get; set; }
		public virtual DbSet<ActiveRepairTickets> ActiveRepairTickets { get; set; }
		public virtual DbSet<Alert> Alert { get; set; }
		public virtual DbSet<AlertDetails> AlertDetails { get; set; }
		public virtual DbSet<AlertHistory> AlertHistory { get; set; }
		public virtual DbSet<AllMaintenanceOrders> AllMaintenanceOrders { get; set; }
		public virtual DbSet<AllMoresources> AllMoresources { get; set; }
		public virtual DbSet<AllRepairTickets> AllRepairTickets { get; set; }
		public virtual DbSet<AppLanguage> AppLanguage { get; set; }
		public virtual DbSet<AppSetting> AppSetting { get; set; }
		public virtual DbSet<Area> Area { get; set; }
		public virtual DbSet<AreaArZone> AreaArZone { get; set; }
		public virtual DbSet<AreaAttribute> AreaAttribute { get; set; }
		public virtual DbSet<AreaEquipmentMembers> AreaEquipmentMembers { get; set; }
		public virtual DbSet<AreaLocation> AreaLocation { get; set; }
		public virtual DbSet<AreaNotificationEmailConfiguration> AreaNotificationEmailConfiguration { get; set; }
		public virtual DbSet<AreaNotificationUserGroupMembers> AreaNotificationUserGroupMembers { get; set; }
		public virtual DbSet<AreaPicture> AreaPicture { get; set; }
		public virtual DbSet<AssetMonitor> AssetMonitor { get; set; }
		public virtual DbSet<AssetMonitorArea> AssetMonitorArea { get; set; }
		public virtual DbSet<AssetMonitorColumns> AssetMonitorColumns { get; set; }
		public virtual DbSet<AssetMonitorFilters> AssetMonitorFilters { get; set; }
		public virtual DbSet<AssetMonitorOrderingColumn> AssetMonitorOrderingColumn { get; set; }
		public virtual DbSet<AssetMonitorThreshold> AssetMonitorThreshold { get; set; }
		public virtual DbSet<AssetMonitors> AssetMonitors { get; set; }
		public virtual DbSet<AssetType> AssetType { get; set; }
		public virtual DbSet<Attribute> Attribute { get; set; }
		public virtual DbSet<AttributeAppliesTo> AttributeAppliesTo { get; set; }
		public virtual DbSet<AttributeValues> AttributeValues { get; set; }
		public virtual DbSet<Audit> Audit { get; set; }
		public virtual DbSet<AuditNotification> AuditNotification { get; set; }
		public virtual DbSet<AuditNotificationMailConfiguration> AuditNotificationMailConfiguration { get; set; }
		public virtual DbSet<AuditNotificationUser> AuditNotificationUser { get; set; }
		public virtual DbSet<AuditNotificationUserGroups> AuditNotificationUserGroups { get; set; }
		public virtual DbSet<AutoAssetCycleCountConfig> AutoAssetCycleCountConfig { get; set; }
		public virtual DbSet<AutoAssetTypeCcconfig> AutoAssetTypeCcconfig { get; set; }
		public virtual DbSet<AutoCycleCountConfig> AutoCycleCountConfig { get; set; }
		public virtual DbSet<AutoGenCycleCountConfig> AutoGenCycleCountConfig { get; set; }
		public virtual DbSet<AutoGenValue> AutoGenValue { get; set; }
		public virtual DbSet<AutoTagSchedule> AutoTagSchedule { get; set; }
		public virtual DbSet<BackupConfig> BackupConfig { get; set; }
		public virtual DbSet<BackupStatus> BackupStatus { get; set; }
		public virtual DbSet<BarcodeConfiguration> BarcodeConfiguration { get; set; }
		public virtual DbSet<BarcodeFields> BarcodeFields { get; set; }
		public virtual DbSet<BarcodeLabels> BarcodeLabels { get; set; }
		public virtual DbSet<Bin> Bin { get; set; }
		public virtual DbSet<Building> Building { get; set; }
		public virtual DbSet<BusinessRule> BusinessRule { get; set; }
		public virtual DbSet<BusinessRuleAttribute> BusinessRuleAttribute { get; set; }
		public virtual DbSet<BusinessRuleGroup> BusinessRuleGroup { get; set; }
		public virtual DbSet<BusinessRuleResult> BusinessRuleResult { get; set; }
		public virtual DbSet<BusinessRuleResultArchive> BusinessRuleResultArchive { get; set; }
		public virtual DbSet<CcheckListStepTranslation> CcheckListStepTranslation { get; set; }
		public virtual DbSet<CertificationCheckList> CertificationCheckList { get; set; }
		public virtual DbSet<CertificationCheckListStep> CertificationCheckListStep { get; set; }
		public virtual DbSet<CheckListZoneMapping> CheckListZoneMapping { get; set; }
		public virtual DbSet<ClaimMaster> ClaimMaster { get; set; }
		public virtual DbSet<CostCenter> CostCenter { get; set; }
		public virtual DbSet<Country> Country { get; set; }
		public virtual DbSet<CycleCount> CycleCount { get; set; }
		public virtual DbSet<CycleCountAssets> CycleCountAssets { get; set; }
		public virtual DbSet<CycleCountNotification> CycleCountNotification { get; set; }
		public virtual DbSet<CycleCountPart> CycleCountPart { get; set; }
		public virtual DbSet<CycleCountPartList> CycleCountPartList { get; set; }
		public virtual DbSet<CycleCountResources> CycleCountResources { get; set; }
		public virtual DbSet<CycleCountSerialPart> CycleCountSerialPart { get; set; }
		public virtual DbSet<DataWarehouseSetting> DataWarehouseSetting { get; set; }
		public virtual DbSet<DeliveryRequest> DeliveryRequest { get; set; }
		public virtual DbSet<DeliveryRequestNotification> DeliveryRequestNotification { get; set; }
		public virtual DbSet<Document> Document { get; set; }
		public virtual DbSet<DocumentVersion> DocumentVersion { get; set; }
		public virtual DbSet<Equipment> Equipment { get; set; }
		public virtual DbSet<EquipmentArMarker> EquipmentArMarker { get; set; }
		public virtual DbSet<EquipmentArXmlConfig> EquipmentArXmlConfig { get; set; }
		public virtual DbSet<EquipmentArZone> EquipmentArZone { get; set; }
		public virtual DbSet<EquipmentArZonePreCompiledCheckList> EquipmentArZonePreCompiledCheckList { get; set; }
		public virtual DbSet<EquipmentAssignation> EquipmentAssignation { get; set; }
		public virtual DbSet<EquipmentAssignationHistory> EquipmentAssignationHistory { get; set; }
		public virtual DbSet<EquipmentAttribute> EquipmentAttribute { get; set; }
		public virtual DbSet<EquipmentAttributeHistory> EquipmentAttributeHistory { get; set; }
		public virtual DbSet<EquipmentBusinessRule> EquipmentBusinessRule { get; set; }
		public virtual DbSet<EquipmentComment> EquipmentComment { get; set; }
		public virtual DbSet<EquipmentCostCenterHistory> EquipmentCostCenterHistory { get; set; }
		public virtual DbSet<EquipmentCurrentState> EquipmentCurrentState { get; set; }
		public virtual DbSet<EquipmentDocumentMembers> EquipmentDocumentMembers { get; set; }
		public virtual DbSet<EquipmentFeeder> EquipmentFeeder { get; set; }
		public virtual DbSet<EquipmentGroup> EquipmentGroup { get; set; }
		public virtual DbSet<EquipmentGroupAssociation> EquipmentGroupAssociation { get; set; }
		public virtual DbSet<EquipmentLocationHistory> EquipmentLocationHistory { get; set; }
		public virtual DbSet<EquipmentMeter> EquipmentMeter { get; set; }
		public virtual DbSet<EquipmentMeterHistory> EquipmentMeterHistory { get; set; }
		public virtual DbSet<EquipmentMeterHistoryArchive> EquipmentMeterHistoryArchive { get; set; }
		public virtual DbSet<EquipmentPartGroupMembers> EquipmentPartGroupMembers { get; set; }
		public virtual DbSet<EquipmentPicture> EquipmentPicture { get; set; }
		public virtual DbSet<EquipmentReasonCodeGroupMembers> EquipmentReasonCodeGroupMembers { get; set; }
		public virtual DbSet<EquipmentState> EquipmentState { get; set; }
		public virtual DbSet<EquipmentStateHistory> EquipmentStateHistory { get; set; }
		public virtual DbSet<EscalationLevel> EscalationLevel { get; set; }
		public virtual DbSet<EscalationNotificationUserGroupMembers> EscalationNotificationUserGroupMembers { get; set; }
		public virtual DbSet<EscalationProcess> EscalationProcess { get; set; }
		public virtual DbSet<EscalationProcessLevel> EscalationProcessLevel { get; set; }
		public virtual DbSet<ExtfeederParameters> ExtfeederParameters { get; set; }
		public virtual DbSet<Extu20nozzleCleanUnit> Extu20nozzleCleanUnit { get; set; }
		public virtual DbSet<Extu20nozzleImage> Extu20nozzleImage { get; set; }
		public virtual DbSet<Extu20nozzleInspectionUnit> Extu20nozzleInspectionUnit { get; set; }
		public virtual DbSet<Extu20nozzleVacuum> Extu20nozzleVacuum { get; set; }
		public virtual DbSet<FactoryCalendar> FactoryCalendar { get; set; }
		public virtual DbSet<FactoryHour> FactoryHour { get; set; }
		public virtual DbSet<FeederGroup> FeederGroup { get; set; }
		public virtual DbSet<FeederMonitor> FeederMonitor { get; set; }
		public virtual DbSet<FeederTagConfiguration> FeederTagConfiguration { get; set; }
		public virtual DbSet<Floor> Floor { get; set; }
		public virtual DbSet<FloorAreaMembers> FloorAreaMembers { get; set; }
		public virtual DbSet<Gridcolumnmapping> Gridcolumnmapping { get; set; }
		public virtual DbSet<ImportData> ImportData { get; set; }
		public virtual DbSet<ImportLog> ImportLog { get; set; }
		public virtual DbSet<IntIntegrationServer> IntIntegrationServer { get; set; }
		public virtual DbSet<IntIntegrationServerRuleConfiguration> IntIntegrationServerRuleConfiguration { get; set; }
		public virtual DbSet<IntPublishHost> IntPublishHost { get; set; }
		public virtual DbSet<IntPublishList> IntPublishList { get; set; }
		public virtual DbSet<IntPublishListAction> IntPublishListAction { get; set; }
		public virtual DbSet<IntRuleConfiguration> IntRuleConfiguration { get; set; }
		public virtual DbSet<IntRuleConfigurationAdapters> IntRuleConfigurationAdapters { get; set; }
		public virtual DbSet<IntRuleConfigurationDependentAssemblies> IntRuleConfigurationDependentAssemblies { get; set; }
		public virtual DbSet<IntRuleConfigurationParameters> IntRuleConfigurationParameters { get; set; }
		public virtual DbSet<Integration> Integration { get; set; }
		public virtual DbSet<IntegrationAttribute> IntegrationAttribute { get; set; }
		public virtual DbSet<IntegrationImportEntites> IntegrationImportEntites { get; set; }
		public virtual DbSet<InventorySchedules> InventorySchedules { get; set; }
		public virtual DbSet<InventoryTurnLevel> InventoryTurnLevel { get; set; }
		public virtual DbSet<KnowledgeBase> KnowledgeBase { get; set; }
		public virtual DbSet<KnowledgeBaseCheckList> KnowledgeBaseCheckList { get; set; }
		public virtual DbSet<KnowledgeBaseDocument> KnowledgeBaseDocument { get; set; }
		public virtual DbSet<KnowledgeBaseEquipment> KnowledgeBaseEquipment { get; set; }
		public virtual DbSet<KnowledgeBaseMaintenanceOrder> KnowledgeBaseMaintenanceOrder { get; set; }
		public virtual DbSet<KnowledgeBaseMultiMedia> KnowledgeBaseMultiMedia { get; set; }
		public virtual DbSet<KnowledgeBaseRepairTicket> KnowledgeBaseRepairTicket { get; set; }
		public virtual DbSet<KnowledgeBaseSparePart> KnowledgeBaseSparePart { get; set; }
		public virtual DbSet<LicenseDetails> LicenseDetails { get; set; }
		public virtual DbSet<LineDashboardConfig> LineDashboardConfig { get; set; }
		public virtual DbSet<Literal> Literal { get; set; }
		public virtual DbSet<Location> Location { get; set; }
		public virtual DbSet<LocationType> LocationType { get; set; }
		public virtual DbSet<MaintenanceEventType> MaintenanceEventType { get; set; }
		public virtual DbSet<MaintenanceOrder> MaintenanceOrder { get; set; }
		public virtual DbSet<MaintenanceOrderAttribute> MaintenanceOrderAttribute { get; set; }
		public virtual DbSet<MaintenanceOrderTemplate> MaintenanceOrderTemplate { get; set; }
		public virtual DbSet<MaintenanceOrderTemplateAttribute> MaintenanceOrderTemplateAttribute { get; set; }
		public virtual DbSet<MaterialMovement> MaterialMovement { get; set; }
		public virtual DbSet<Mmsintsall> Mmsintsall { get; set; }
		public virtual DbSet<MoCertificationCheckList> MoCertificationCheckList { get; set; }
		public virtual DbSet<MoCertificationCheckListStep> MoCertificationCheckListStep { get; set; }
		public virtual DbSet<MoComment> MoComment { get; set; }
		public virtual DbSet<MoDocuments> MoDocuments { get; set; }
		public virtual DbSet<MoHistory> MoHistory { get; set; }
		public virtual DbSet<MoParts> MoParts { get; set; }
		public virtual DbSet<MoPreCompiledCheckList> MoPreCompiledCheckList { get; set; }
		public virtual DbSet<MoPreCompiledCheckListStep> MoPreCompiledCheckListStep { get; set; }
		public virtual DbSet<MoPreCompiledCheckListStepPart> MoPreCompiledCheckListStepPart { get; set; }
		public virtual DbSet<MoRepairRequests> MoRepairRequests { get; set; }
		public virtual DbSet<MoResources> MoResources { get; set; }
		public virtual DbSet<MoTemplateCertificationCheckList> MoTemplateCertificationCheckList { get; set; }
		public virtual DbSet<MoTemplateCheckList> MoTemplateCheckList { get; set; }
		public virtual DbSet<MoTemplateDocument> MoTemplateDocument { get; set; }
		public virtual DbSet<MoTemplatePartEstimate> MoTemplatePartEstimate { get; set; }
		public virtual DbSet<MoTemplateResourceEstimate> MoTemplateResourceEstimate { get; set; }
		public virtual DbSet<MobileAppVersion> MobileAppVersion { get; set; }
		public virtual DbSet<Model> Model { get; set; }
		public virtual DbSet<OrphanAssets> OrphanAssets { get; set; }
		public virtual DbSet<PanaCimmapping> PanaCimmapping { get; set; }
		public virtual DbSet<PanaCimserviceLog> PanaCimserviceLog { get; set; }
		public virtual DbSet<PanacimRuleSettings> PanacimRuleSettings { get; set; }
		public virtual DbSet<PanacimSetting> PanacimSetting { get; set; }
		public virtual DbSet<Part> Part { get; set; }
		public virtual DbSet<PartDelivery> PartDelivery { get; set; }
		public virtual DbSet<PartGroup> PartGroup { get; set; }
		public virtual DbSet<PartGroupMembers> PartGroupMembers { get; set; }
		public virtual DbSet<PartInformationDocuments> PartInformationDocuments { get; set; }
		public virtual DbSet<PartInformationImages> PartInformationImages { get; set; }
		public virtual DbSet<PartInventory> PartInventory { get; set; }
		public virtual DbSet<PartInventoryHistory> PartInventoryHistory { get; set; }
		public virtual DbSet<PartNotification> PartNotification { get; set; }
		public virtual DbSet<PartSerialNumber> PartSerialNumber { get; set; }
		public virtual DbSet<PartStore> PartStore { get; set; }
		public virtual DbSet<PartSubstitute> PartSubstitute { get; set; }
		public virtual DbSet<PartTransaction> PartTransaction { get; set; }
		public virtual DbSet<PccheckListStepTranslation> PccheckListStepTranslation { get; set; }
		public virtual DbSet<Pmschedule> Pmschedule { get; set; }
		public virtual DbSet<PmscheduleEquipment> PmscheduleEquipment { get; set; }
		public virtual DbSet<PreCompiledCheckList> PreCompiledCheckList { get; set; }
		public virtual DbSet<PreCompiledCheckListStep> PreCompiledCheckListStep { get; set; }
		public virtual DbSet<PreCompiledCheckListStepPart> PreCompiledCheckListStepPart { get; set; }
		public virtual DbSet<PreCompiledCheckListStepSkipMot> PreCompiledCheckListStepSkipMot { get; set; }
		public virtual DbSet<PreCompiledCheckListUserGroup> PreCompiledCheckListUserGroup { get; set; }
		public virtual DbSet<ReasonCode> ReasonCode { get; set; }
		public virtual DbSet<ReasonCodeGroup> ReasonCodeGroup { get; set; }
		public virtual DbSet<ReasonCodeGroupMembers> ReasonCodeGroupMembers { get; set; }
		public virtual DbSet<RepairTicket> RepairTicket { get; set; }
		public virtual DbSet<RepairTicketClosedNotification> RepairTicketClosedNotification { get; set; }
		public virtual DbSet<RepairTicketComment> RepairTicketComment { get; set; }
		public virtual DbSet<RepairTicketHistory> RepairTicketHistory { get; set; }
		public virtual DbSet<RepairTicketSummary> RepairTicketSummary { get; set; }
		public virtual DbSet<RepairTicketTemplate> RepairTicketTemplate { get; set; }
		public virtual DbSet<RepairTicketTemplateClosedNotification> RepairTicketTemplateClosedNotification { get; set; }
		public virtual DbSet<ReplenishStock> ReplenishStock { get; set; }
		public virtual DbSet<ReportFilter> ReportFilter { get; set; }
		public virtual DbSet<ReportFilterOption> ReportFilterOption { get; set; }
		public virtual DbSet<ReportFilterType> ReportFilterType { get; set; }
		public virtual DbSet<ReportMaster> ReportMaster { get; set; }
		public virtual DbSet<SerialPartTransaction> SerialPartTransaction { get; set; }
		public virtual DbSet<SerialToolKitTransaction> SerialToolKitTransaction { get; set; }
		public virtual DbSet<Site> Site { get; set; }
		public virtual DbSet<SiteAttribute> SiteAttribute { get; set; }
		public virtual DbSet<Software> Software { get; set; }
		public virtual DbSet<SoftwareAppliesTo> SoftwareAppliesTo { get; set; }
		public virtual DbSet<SoftwareTargets> SoftwareTargets { get; set; }
		public virtual DbSet<SoftwareUpgradeSchedule> SoftwareUpgradeSchedule { get; set; }
		public virtual DbSet<SoftwareUpgradeScheduleEquipment> SoftwareUpgradeScheduleEquipment { get; set; }
		public virtual DbSet<SoftwareUpgradeStatus> SoftwareUpgradeStatus { get; set; }
		public virtual DbSet<SoftwareVersion> SoftwareVersion { get; set; }
		public virtual DbSet<StockingNotification> StockingNotification { get; set; }
		public virtual DbSet<StockingNotificationMailConfiguration> StockingNotificationMailConfiguration { get; set; }
		public virtual DbSet<StockingNotificationUser> StockingNotificationUser { get; set; }
		public virtual DbSet<StockingNotificationUserGroups> StockingNotificationUserGroups { get; set; }
		public virtual DbSet<SubLocation> SubLocation { get; set; }
		public virtual DbSet<ToolKit> ToolKit { get; set; }
		public virtual DbSet<ToolKitSerialPart> ToolKitSerialPart { get; set; }
		public virtual DbSet<ToolKitTransaction> ToolKitTransaction { get; set; }
		public virtual DbSet<UnitOfCost> UnitOfCost { get; set; }
		public virtual DbSet<UnitOfMeasure> UnitOfMeasure { get; set; }
		public virtual DbSet<User> User { get; set; }
		public virtual DbSet<UserCertAreaAssociation> UserCertAreaAssociation { get; set; }
		public virtual DbSet<UserCertAssignedUserList> UserCertAssignedUserList { get; set; }
		public virtual DbSet<UserCertNotificationMapping> UserCertNotificationMapping { get; set; }
		public virtual DbSet<UserCertTrainerExternalMailList> UserCertTrainerExternalMailList { get; set; }
		public virtual DbSet<UserCertTrainerUserList> UserCertTrainerUserList { get; set; }
		public virtual DbSet<UserCertificationList> UserCertificationList { get; set; }
		public virtual DbSet<UserCertificationResultStepList> UserCertificationResultStepList { get; set; }
		public virtual DbSet<UserCertificationResults> UserCertificationResults { get; set; }
		public virtual DbSet<UserCertificationStepList> UserCertificationStepList { get; set; }
		public virtual DbSet<UserGroup> UserGroup { get; set; }
		public virtual DbSet<UserGroupClaim> UserGroupClaim { get; set; }
		public virtual DbSet<UserGroupMembers> UserGroupMembers { get; set; }
		public virtual DbSet<UserLoginHistory> UserLoginHistory { get; set; }
		public virtual DbSet<UserPreference> UserPreference { get; set; }
		public virtual DbSet<UserPreferenceMaster> UserPreferenceMaster { get; set; }
		public virtual DbSet<Vendor> Vendor { get; set; }
		public virtual DbSet<VendorContact> VendorContact { get; set; }
		public virtual DbSet<WipSetting> WipSetting { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer("Server=(local);Database=Maintenance;Uid=sa;pwd=Welcome@123;");
			}
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ActiveMaintenanceOrders>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("ActiveMaintenanceOrders");

				entity.Property(e => e.EquipmentName)
					.IsRequired()
					.HasMaxLength(80);

				entity.Property(e => e.MoNumber).HasMaxLength(50);

				entity.Property(e => e.PrimaryAreaName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ReasonCodeName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<ActiveMoresources>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("ActiveMOResources");

				entity.Property(e => e.MoResourcesMaintenanceOrderId).HasColumnName("MoResources_MaintenanceOrderId");

				entity.Property(e => e.MoResourcesScanOffDateTime).HasColumnName("MoResources_ScanOffDateTime");

				entity.Property(e => e.MoResourcesScanOnDateTime).HasColumnName("MoResources_ScanOnDateTime");

				entity.Property(e => e.MoResourcesUserGroupId).HasColumnName("MoResources_UserGroupId");

				entity.Property(e => e.MoResourcesUserId).HasColumnName("MoResources_UserId");
			});

			modelBuilder.Entity<ActiveRepairTickets>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("ActiveRepairTickets");

				entity.Property(e => e.EquipmentName)
					.IsRequired()
					.HasMaxLength(80);

				entity.Property(e => e.MoNumber).HasMaxLength(50);

				entity.Property(e => e.PrimaryAreaName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ReasonCodeName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(512);
			});

			modelBuilder.Entity<Alert>(entity =>
			{
				entity.HasIndex(e => new { e.AlertId, e.AlertNotifiedDate, e.AlertReferenceNumber, e.AlertOverallStatus, e.AlertType })
					.HasName("INDX_Alert_Status_RefNum_Type");

				entity.Property(e => e.AlertId)
					.HasColumnName("Alert_Id")
					.HasComment("Auto generated sequence number, This table is used to store Notifications");

				entity.Property(e => e.AlertNotifiedDate)
					.HasColumnName("Alert_NotifiedDate")
					.HasComment("Notification sent date");

				entity.Property(e => e.AlertOverallStatus)
					.HasColumnName("Alert_OverallStatus")
					.HasComment("Describes the Types of Notification - Notify, Level1, Level2, Level3");

				entity.Property(e => e.AlertReferenceNumber)
					.IsRequired()
					.HasColumnName("Alert_ReferenceNumber")
					.HasMaxLength(50)
					.HasComment("MaintenanceOrder or RepairTicket number for user reference");

				entity.Property(e => e.AlertType)
					.HasColumnName("Alert_Type")
					.HasComment("Describes the Notification Type - MaintenanceOrder or RepairTicket or NewResourceAssigned");
			});

			modelBuilder.Entity<AlertDetails>(entity =>
			{
				entity.HasIndex(e => new { e.AlertDetailsAlertId, e.AlertDetailsUserId, e.AlertDetailsUserActionStatus })
					.HasName("INDX_AlertDetails_AlertDetails_UserId_AlertDetails_UserActionStatus");

				entity.Property(e => e.AlertDetailsId)
					.HasColumnName("AlertDetails_Id")
					.HasComment("Auto generated sequence number, This table is used to store Notification details for every AlertId and UserId");

				entity.Property(e => e.AlertDetailsActionDate)
					.HasColumnName("AlertDetails_ActionDate")
					.HasComment("User action date against notification");

				entity.Property(e => e.AlertDetailsAlertId).HasColumnName("AlertDetails_AlertId");

				entity.Property(e => e.AlertDetailsUserActionStatus)
					.HasColumnName("AlertDetails_UserActionStatus")
					.HasComment("Describes the User action status - SENT, IGNORED, CLOSED");

				entity.Property(e => e.AlertDetailsUserId).HasColumnName("AlertDetails_UserId");

				entity.HasOne(d => d.AlertDetailsAlert)
					.WithMany(p => p.AlertDetails)
					.HasForeignKey(d => d.AlertDetailsAlertId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AlertDetails_Alert");
			});

			modelBuilder.Entity<AlertHistory>(entity =>
			{
				entity.Property(e => e.AlertHistoryId)
					.HasColumnName("AlertHistory_Id")
					.HasComment("Auto generated sequence number, This table is used to maintain history of Alert and Alert details table");

				entity.Property(e => e.AlertHistoryClosedDate).HasColumnName("AlertHistory_ClosedDate");

				entity.Property(e => e.AlertHistoryNotifiedDate).HasColumnName("AlertHistory_NotifiedDate");

				entity.Property(e => e.AlertHistoryOverallStatus).HasColumnName("AlertHistory_OverallStatus");

				entity.Property(e => e.AlertHistoryReferenceNumber)
					.IsRequired()
					.HasColumnName("AlertHistory_ReferenceNumber")
					.HasMaxLength(50);

				entity.Property(e => e.AlertHistoryType).HasColumnName("AlertHistory_Type");

				entity.Property(e => e.AlertHistoryUserId).HasColumnName("AlertHistory_UserId");
			});

			modelBuilder.Entity<AllMaintenanceOrders>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("AllMaintenanceOrders");

				entity.Property(e => e.EquipmentName)
					.IsRequired()
					.HasMaxLength(80);

				entity.Property(e => e.MoNumber).HasMaxLength(50);

				entity.Property(e => e.PrimaryAreaName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ReasonCodeName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<AllMoresources>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("AllMOResources");

				entity.Property(e => e.MoResourcesMaintenanceOrderId).HasColumnName("MoResources_MaintenanceOrderId");

				entity.Property(e => e.MoResourcesScanOffDateTime).HasColumnName("MoResources_ScanOffDateTime");

				entity.Property(e => e.MoResourcesScanOnDateTime).HasColumnName("MoResources_ScanOnDateTime");

				entity.Property(e => e.MoResourcesUserGroupId).HasColumnName("MoResources_UserGroupId");

				entity.Property(e => e.MoResourcesUserId).HasColumnName("MoResources_UserId");
			});

			modelBuilder.Entity<AllRepairTickets>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("AllRepairTickets");

				entity.Property(e => e.EquipmentName)
					.IsRequired()
					.HasMaxLength(80);

				entity.Property(e => e.MoNumber).HasMaxLength(50);

				entity.Property(e => e.PrimaryAreaName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ReasonCodeName)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Title)
					.IsRequired()
					.HasMaxLength(512);
			});

			modelBuilder.Entity<AppLanguage>(entity =>
			{
				entity.Property(e => e.AppLanguageId)
					.HasColumnName("AppLanguage_Id")
					.ValueGeneratedNever();

				entity.Property(e => e.AppLanguageAbbreviation)
					.HasColumnName("AppLanguage_Abbreviation")
					.HasMaxLength(10);

				entity.Property(e => e.AppLanguageCountryName)
					.HasColumnName("AppLanguage_CountryName")
					.HasMaxLength(50);

				entity.Property(e => e.AppLanguageCultureCode)
					.HasColumnName("AppLanguage_CultureCode")
					.HasMaxLength(10);

				entity.Property(e => e.AppLanguageName)
					.IsRequired()
					.HasColumnName("AppLanguage_Name")
					.HasMaxLength(50);

				entity.Property(e => e.AppLanguageRegion)
					.HasColumnName("AppLanguage_Region")
					.HasMaxLength(50);

				entity.Property(e => e.AppLanguageStatus).HasColumnName("AppLanguage_Status");
			});

			modelBuilder.Entity<AppSetting>(entity =>
			{
				entity.Property(e => e.AppSettingId)
					.HasColumnName("AppSetting_Id")
					.HasComment("Note:-  The description to display on the UI about every preference should be stored in resource file for localization");

				entity.Property(e => e.AppSettingCategory)
					.IsRequired()
					.HasColumnName("AppSetting_Category")
					.HasMaxLength(50);

				entity.Property(e => e.AppSettingControlFlag).HasColumnName("AppSetting_ControlFlag");

				entity.Property(e => e.AppSettingName)
					.IsRequired()
					.HasColumnName("AppSetting_Name")
					.HasMaxLength(50)
					.HasComment("Unique Identifies a Setting");

				entity.Property(e => e.AppSettingReference)
					.HasColumnName("AppSetting_Reference")
					.HasMaxLength(255)
					.HasComment("If Reference Type, which object and property to refer to.  For Example.  ReasonCode_Name");

				entity.Property(e => e.AppSettingType)
					.IsRequired()
					.HasColumnName("AppSetting_Type")
					.HasMaxLength(50)
					.HasComment("Value Type or Reference Type");

				entity.Property(e => e.AppSettingValue)
					.HasColumnName("AppSetting_Value")
					.HasMaxLength(4000)
					.HasComment("Value to be held.  Only Single Value allowed right now.");
			});

			modelBuilder.Entity<Area>(entity =>
			{
				entity.Property(e => e.AreaId)
					.HasColumnName("Area_Id")
					.HasComment("Note: Area is a logical grouping of equipments. Ex:  All ovens could be grouped as one Area, All back end equipments could be grouped as one area, All equipments with Lazer in it could be grouped as one area,  even one line could be grouped as one area");

				entity.Property(e => e.AreaCccancellationReasonCodeGroupId).HasColumnName("Area_CCCancellationReasonCodeGroupId");

				entity.Property(e => e.AreaControlFlag).HasColumnName("Area_ControlFlag");

				entity.Property(e => e.AreaCreatedBy)
					.IsRequired()
					.HasColumnName("Area_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.AreaCreatedDate).HasColumnName("Area_CreatedDate");

				entity.Property(e => e.AreaDescription)
					.HasColumnName("Area_Description")
					.HasMaxLength(255)
					.HasComment("Description of the Area, Just to give some information. Notes.");

				entity.Property(e => e.AreaImage)
					.HasColumnName("Area_Image")
					.HasMaxLength(255);

				entity.Property(e => e.AreaIsArEnabled).HasColumnName("Area_IsArEnabled");

				entity.Property(e => e.AreaIsAuditAreaNotification).HasColumnName("Area_IsAuditAreaNotification");

				entity.Property(e => e.AreaIsDeleted).HasColumnName("Area_IsDeleted");

				entity.Property(e => e.AreaIsStockingAreaNotification)
					.HasColumnName("Area_IsStockingAreaNotification")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.AreaName)
					.IsRequired()
					.HasColumnName("Area_Name")
					.HasMaxLength(50)
					.HasComment("Name of the Area");

				entity.Property(e => e.AreaReferenceId).HasColumnName("Area_ReferenceId");
			});

			modelBuilder.Entity<AreaArZone>(entity =>
			{
				entity.Property(e => e.AreaArZoneId).HasColumnName("AreaArZone_Id");

				entity.Property(e => e.AreaArZoneAreaPictureId).HasColumnName("AreaArZone_AreaPictureId");

				entity.Property(e => e.AreaArZoneEquipmentId).HasColumnName("AreaArZone_EquipmentId");

				entity.Property(e => e.AreaArZoneHeight).HasColumnName("AreaArZone_Height");

				entity.Property(e => e.AreaArZoneWidth).HasColumnName("AreaArZone_Width");

				entity.Property(e => e.AreaArZoneXpos).HasColumnName("AreaArZone_Xpos");

				entity.Property(e => e.AreaArZoneYpos).HasColumnName("AreaArZone_Ypos");

				entity.HasOne(d => d.AreaArZoneAreaPicture)
					.WithMany(p => p.AreaArZone)
					.HasForeignKey(d => d.AreaArZoneAreaPictureId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaArZone_AreaPictureId");

				entity.HasOne(d => d.AreaArZoneEquipment)
					.WithMany(p => p.AreaArZone)
					.HasForeignKey(d => d.AreaArZoneEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaArZone_Equipment");
			});

			modelBuilder.Entity<AreaAttribute>(entity =>
			{
				entity.Property(e => e.AreaAttributeId).HasColumnName("AreaAttribute_Id");

				entity.Property(e => e.AreaAttributeAreaId).HasColumnName("AreaAttribute_AreaId");

				entity.Property(e => e.AreaAttributeAttributeId).HasColumnName("AreaAttribute_AttributeId");

				entity.Property(e => e.AreaAttributeValue)
					.HasColumnName("AreaAttribute_Value")
					.HasMaxLength(255);

				entity.HasOne(d => d.AreaAttributeArea)
					.WithMany(p => p.AreaAttribute)
					.HasForeignKey(d => d.AreaAttributeAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaAttribute_Area");

				entity.HasOne(d => d.AreaAttributeAttribute)
					.WithMany(p => p.AreaAttribute)
					.HasForeignKey(d => d.AreaAttributeAttributeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaAttribute_Attribute");
			});

			modelBuilder.Entity<AreaEquipmentMembers>(entity =>
			{
				entity.Property(e => e.AreaEquipmentMembersId)
					.HasColumnName("AreaEquipmentMembers_Id")
					.HasComment("Notes: Area, Equipment many many mapping table");

				entity.Property(e => e.AreaEquipmentMembersAreaId)
					.HasColumnName("AreaEquipmentMembers_AreaId")
					.HasComment("Area id of the area thats being configured");

				entity.Property(e => e.AreaEquipmentMembersEquipmentId)
					.HasColumnName("AreaEquipmentMembers_EquipmentId")
					.HasComment("Equipment Id of the equipment that belongs to this group");

				entity.Property(e => e.AreaEquipmentMembersSequenceNumber).HasColumnName("AreaEquipmentMembers_SequenceNumber");

				entity.HasOne(d => d.AreaEquipmentMembersArea)
					.WithMany(p => p.AreaEquipmentMembers)
					.HasForeignKey(d => d.AreaEquipmentMembersAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaEquipmentMembers_Area");

				entity.HasOne(d => d.AreaEquipmentMembersEquipment)
					.WithMany(p => p.AreaEquipmentMembers)
					.HasForeignKey(d => d.AreaEquipmentMembersEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaEquipmentMembers_Equipment");
			});

			modelBuilder.Entity<AreaLocation>(entity =>
			{
				entity.HasOne(d => d.Area)
					.WithMany(p => p.AreaLocation)
					.HasForeignKey(d => d.AreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaLocation_Area_Id");

				entity.HasOne(d => d.Location)
					.WithMany(p => p.AreaLocation)
					.HasForeignKey(d => d.LocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaLocation_Location_Id");
			});

			modelBuilder.Entity<AreaNotificationEmailConfiguration>(entity =>
			{
				entity.HasKey(e => e.AreaNotificationUserGroupEmailConfigId);

				entity.Property(e => e.AreaNotificationUserGroupEmailConfigId).HasColumnName("AreaNotificationUserGroupEmailConfig_Id");

				entity.Property(e => e.AreaNotificationUserGroupEmail)
					.HasMaxLength(1000)
					.IsUnicode(false);

				entity.Property(e => e.AreaNotificationUserGroupMembersAreaId).HasColumnName("AreaNotificationUserGroupMembers_AreaId");

				entity.Property(e => e.AreaNotificationUserGroupMembersPriority).HasColumnName("AreaNotificationUserGroupMembers_Priority");

				entity.HasOne(d => d.AreaNotificationUserGroupMembersArea)
					.WithMany(p => p.AreaNotificationEmailConfiguration)
					.HasForeignKey(d => d.AreaNotificationUserGroupMembersAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaNotificationEmailConfiguration_Area");
			});

			modelBuilder.Entity<AreaNotificationUserGroupMembers>(entity =>
			{
				entity.Property(e => e.AreaNotificationUserGroupMembersId)
					.HasColumnName("AreaNotificationUserGroupMembers_Id")
					.HasComment("Auto generated sequence number, This table is used to store notification usergroup settings for every Area");

				entity.Property(e => e.AreaNotificationUserGroupMembersAreaId).HasColumnName("AreaNotificationUserGroupMembers_AreaId");

				entity.Property(e => e.AreaNotificationUserGroupMembersPriority)
					.HasColumnName("AreaNotificationUserGroupMembers_Priority")
					.HasComment("Describes Priority - Critical, High, Medium, Low");

				entity.Property(e => e.AreaNotificationUserGroupMembersUserGroupId).HasColumnName("AreaNotificationUserGroupMembers_UserGroupId");

				entity.HasOne(d => d.AreaNotificationUserGroupMembersArea)
					.WithMany(p => p.AreaNotificationUserGroupMembers)
					.HasForeignKey(d => d.AreaNotificationUserGroupMembersAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaNotificationUserGroupMembers_Area");

				entity.HasOne(d => d.AreaNotificationUserGroupMembersUserGroup)
					.WithMany(p => p.AreaNotificationUserGroupMembers)
					.HasForeignKey(d => d.AreaNotificationUserGroupMembersUserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaNotificationUserGroupMembers_UserGroup");
			});

			modelBuilder.Entity<AreaPicture>(entity =>
			{
				entity.Property(e => e.AreaPictureId).HasColumnName("AreaPicture_Id");

				entity.Property(e => e.AreaPictureAreaId).HasColumnName("AreaPicture_AreaId");

				entity.Property(e => e.AreaPictureHeight).HasColumnName("AreaPicture_Height");

				entity.Property(e => e.AreaPictureImage)
					.HasColumnName("AreaPicture_Image")
					.HasMaxLength(255);

				entity.Property(e => e.AreaPictureWidth).HasColumnName("AreaPicture_Width");

				entity.HasOne(d => d.AreaPictureArea)
					.WithMany(p => p.AreaPicture)
					.HasForeignKey(d => d.AreaPictureAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AreaPicture_AreaId");
			});

			modelBuilder.Entity<AssetMonitor>(entity =>
			{
				entity.Property(e => e.AssetMonitorId).HasColumnName("AssetMonitor_Id");

				entity.Property(e => e.AssetMonitorAssetSubTypeId).HasColumnName("AssetMonitor_AssetSubTypeId");

				entity.Property(e => e.AssetMonitorControlFlag).HasColumnName("AssetMonitor_ControlFlag");

				entity.Property(e => e.AssetMonitorIsDeleted).HasColumnName("AssetMonitor_IsDeleted");

				entity.Property(e => e.AssetMonitorIsTemplate).HasColumnName("AssetMonitor_IsTemplate");

				entity.Property(e => e.AssetMonitorName)
					.HasColumnName("AssetMonitor_Name")
					.HasMaxLength(50);

				entity.Property(e => e.AssetMonitorReferenceId).HasColumnName("AssetMonitor_ReferenceId");

				entity.Property(e => e.AssetMonitorTemplateId).HasColumnName("AssetMonitor_TemplateId");

				entity.Property(e => e.AssetMonitorView)
					.HasColumnName("AssetMonitor_View")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<AssetMonitorArea>(entity =>
			{
				entity.Property(e => e.AssetMonitorAreaId).HasColumnName("AssetMonitorArea_Id");

				entity.Property(e => e.AssetMonitorAreaAreaId).HasColumnName("AssetMonitorArea_AreaId");

				entity.Property(e => e.AssetMonitorAreaAssetMonitorId).HasColumnName("AssetMonitorArea_AssetMonitorId");

				entity.HasOne(d => d.AssetMonitorAreaArea)
					.WithMany(p => p.AssetMonitorArea)
					.HasForeignKey(d => d.AssetMonitorAreaAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AssetMonitorArea_Area");

				entity.HasOne(d => d.AssetMonitorAreaAssetMonitor)
					.WithMany(p => p.AssetMonitorArea)
					.HasForeignKey(d => d.AssetMonitorAreaAssetMonitorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AssetMonitorArea_AssetMonitor");
			});

			modelBuilder.Entity<AssetMonitorColumns>(entity =>
			{
				entity.Property(e => e.AssetMonitorColumnsId).HasColumnName("AssetMonitorColumns_Id");

				entity.Property(e => e.AssetMonitorColumnsAssetMonitorId).HasColumnName("AssetMonitorColumns_AssetMonitorId");

				entity.Property(e => e.AssetMonitorColumnsColumnDataType)
					.IsRequired()
					.HasColumnName("AssetMonitorColumns_ColumnDataType")
					.HasMaxLength(20);

				entity.Property(e => e.AssetMonitorColumnsColumnName)
					.IsRequired()
					.HasColumnName("AssetMonitorColumns_ColumnName")
					.HasMaxLength(50);

				entity.Property(e => e.AssetMonitorColumnsColumnType)
					.IsRequired()
					.HasColumnName("AssetMonitorColumns_ColumnType")
					.HasMaxLength(10);

				entity.Property(e => e.AssetMonitorColumnsIsDisplay).HasColumnName("AssetMonitorColumns_IsDisplay");

				entity.Property(e => e.AssetMonitorColumnsIsFilterable).HasColumnName("AssetMonitorColumns_IsFilterable");

				entity.Property(e => e.AssetMonitorColumnsSequence).HasColumnName("AssetMonitorColumns_Sequence");

				entity.Property(e => e.AssetMonitorColumnsViewColumn)
					.IsRequired()
					.HasColumnName("AssetMonitorColumns_ViewColumn");

				entity.Property(e => e.AssetMonitorColumnsViewName)
					.HasColumnName("AssetMonitorColumns_ViewName")
					.HasMaxLength(50);

				entity.HasOne(d => d.AssetMonitorColumnsAssetMonitor)
					.WithMany(p => p.AssetMonitorColumns)
					.HasForeignKey(d => d.AssetMonitorColumnsAssetMonitorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AssetMonitorColumns_AssetMonitor");
			});

			modelBuilder.Entity<AssetMonitorFilters>(entity =>
			{
				entity.Property(e => e.AssetMonitorFiltersId).HasColumnName("AssetMonitorFilters_Id");

				entity.Property(e => e.AssetMonitorFiltersAssetMonitorColumnsId).HasColumnName("AssetMonitorFilters_AssetMonitorColumnsId");

				entity.Property(e => e.AssetMonitorFiltersAssetMonitorId).HasColumnName("AssetMonitorFilters_AssetMonitorId");

				entity.Property(e => e.AssetMonitorFiltersValue)
					.IsRequired()
					.HasColumnName("AssetMonitorFilters_Value")
					.HasMaxLength(50);

				entity.HasOne(d => d.AssetMonitorFiltersAssetMonitorColumns)
					.WithMany(p => p.AssetMonitorFilters)
					.HasForeignKey(d => d.AssetMonitorFiltersAssetMonitorColumnsId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AssetMonitorFilters_AssetMonitorColumns");

				entity.HasOne(d => d.AssetMonitorFiltersAssetMonitor)
					.WithMany(p => p.AssetMonitorFilters)
					.HasForeignKey(d => d.AssetMonitorFiltersAssetMonitorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AssetMonitorFilters_AssetMonitor");
			});

			modelBuilder.Entity<AssetMonitorOrderingColumn>(entity =>
			{
				entity.Property(e => e.AssetMonitorOrderingColumnId).HasColumnName("AssetMonitorOrderingColumn_ID");

				entity.Property(e => e.AssetMonitorOrderingColumnAssetMonitorColumnsColumnName)
					.HasColumnName("AssetMonitorOrderingColumn_AssetMonitorColumnsColumnName")
					.HasMaxLength(100);

				entity.Property(e => e.AssetMonitorOrderingColumnAssetSubTypeId).HasColumnName("AssetMonitorOrderingColumn_AssetSubTypeId");

				entity.Property(e => e.AssetMonitorOrderingColumnIsAscending).HasColumnName("AssetMonitorOrderingColumn_IsAscending");

				entity.Property(e => e.AssetMonitorOrderingColumnSequence).HasColumnName("AssetMonitorOrderingColumn_Sequence");
			});

			modelBuilder.Entity<AssetMonitorThreshold>(entity =>
			{
				entity.Property(e => e.AssetMonitorThresholdId).HasColumnName("AssetMonitorThreshold_Id");

				entity.Property(e => e.AssetMonitorThresholdEnabled).HasColumnName("AssetMonitorThreshold_Enabled");

				entity.Property(e => e.AssetMonitorThresholdLowerLimit)
					.HasColumnName("AssetMonitorThreshold_LowerLimit")
					.HasColumnType("numeric(18, 2)");

				entity.Property(e => e.AssetMonitorThresholdName)
					.IsRequired()
					.HasColumnName("AssetMonitorThreshold_Name")
					.HasMaxLength(255);

				entity.Property(e => e.AssetMonitorThresholdUpperLimit)
					.HasColumnName("AssetMonitorThreshold_UpperLimit")
					.HasColumnType("numeric(18, 2)");
			});

			modelBuilder.Entity<AssetMonitors>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("AssetMonitors");

				entity.Property(e => e.AlertOverallStatus)
					.HasColumnName("Alert_OverallStatus")
					.HasMaxLength(34);

				entity.Property(e => e.AreaEquipmentMembersSequenceNumber).HasColumnName("AreaEquipmentMembers_SequenceNumber");

				entity.Property(e => e.AreaId).HasColumnName("Area_Id");

				entity.Property(e => e.AreaName)
					.IsRequired()
					.HasColumnName("Area_Name")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentId).HasColumnName("Equipment_Id");

				entity.Property(e => e.EquipmentMachineCounter)
					.HasColumnName("Equipment_MachineCounter")
					.HasMaxLength(30);

				entity.Property(e => e.EquipmentMeterName)
					.IsRequired()
					.HasColumnName("EquipmentMeter_Name")
					.HasMaxLength(100);

				entity.Property(e => e.EquipmentName)
					.IsRequired()
					.HasColumnName("Equipment_Name")
					.HasMaxLength(80);

				entity.Property(e => e.EquipmentSerialNumber)
					.HasColumnName("Equipment_SerialNumber")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentSubType).HasColumnName("Equipment_SubType");

				entity.Property(e => e.HiddenTimeTillSchedDate)
					.HasColumnName("Hidden_TimeTillSchedDate")
					.HasColumnType("numeric(38, 14)");

				entity.Property(e => e.MaintenanceEventTypeName)
					.IsRequired()
					.HasColumnName("MaintenanceEventType_Name")
					.HasMaxLength(50);

				entity.Property(e => e.MaintenanceOrderNumber)
					.HasColumnName("MaintenanceOrder_Number")
					.HasMaxLength(50);

				entity.Property(e => e.MaintenanceOrderPlannedDueDate).HasColumnName("MaintenanceOrder_PlannedDueDate");

				entity.Property(e => e.MaintenanceOrderScheduledDate).HasColumnName("MaintenanceOrder_ScheduledDate");

				entity.Property(e => e.MaintenanceOrderTitle)
					.IsRequired()
					.HasColumnName("MaintenanceOrder_Title")
					.HasMaxLength(1)
					.IsUnicode(false);

				entity.Property(e => e.MoResourcesScanOnDateTime).HasColumnName("MoResources_ScanOnDateTime");

				entity.Property(e => e.NozzleSize)
					.HasColumnName("Nozzle_Size")
					.HasMaxLength(50);

				entity.Property(e => e.NozzleType)
					.HasColumnName("Nozzle_type")
					.HasMaxLength(50);

				entity.Property(e => e.Ordercol).HasColumnName("ordercol");

				entity.Property(e => e.Priority)
					.HasMaxLength(8)
					.IsUnicode(false);

				entity.Property(e => e.ReasonCodeName)
					.IsRequired()
					.HasColumnName("ReasonCode_Name")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketNumber)
					.HasColumnName("RepairTicket_Number")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketTitle)
					.IsRequired()
					.HasColumnName("RepairTicket_Title")
					.HasMaxLength(512);

				entity.Property(e => e.Status)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.TicketsDisplayed)
					.IsRequired()
					.HasColumnName("Tickets_Displayed")
					.HasMaxLength(21)
					.IsUnicode(false);

				entity.Property(e => e.TimeScheduledDueDate).HasColumnName("Time_ScheduledDueDate");

				entity.Property(e => e.TotalPickupCount)
					.HasColumnName("Total_Pickup_count")
					.HasColumnType("numeric(19, 0)");
			});

			modelBuilder.Entity<AssetType>(entity =>
			{
				entity.Property(e => e.AssetTypeId).HasColumnName("AssetType_Id");

				entity.Property(e => e.AssetTypeAccessories)
					.IsRequired()
					.HasColumnName("AssetType_Accessories")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypeArsettings)
					.IsRequired()
					.HasColumnName("AssetType_ARSettings")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypeAssetCategory)
					.HasColumnName("AssetType_AssetCategory")
					.HasMaxLength(100);

				entity.Property(e => e.AssetTypeAssetInfo)
					.IsRequired()
					.HasColumnName("AssetType_AssetInfo")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypeAssetType).HasColumnName("AssetType_AssetType");

				entity.Property(e => e.AssetTypeAssetTypeName)
					.IsRequired()
					.HasColumnName("AssetType_AssetTypeName")
					.HasMaxLength(100);

				entity.Property(e => e.AssetTypeAttributeHistory)
					.IsRequired()
					.HasColumnName("AssetType_AttributeHistory")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypeAttributes)
					.IsRequired()
					.HasColumnName("AssetType_Attributes")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypeAutoTag)
					.IsRequired()
					.HasColumnName("AssetType_AutoTag")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypeComments)
					.IsRequired()
					.HasColumnName("AssetType_Comments")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypeDefaultTemplate)
					.HasColumnName("AssetType_DefaultTemplate")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.AssetTypeDescription)
					.HasColumnName("AssetType_Description")
					.HasMaxLength(1000);

				entity.Property(e => e.AssetTypeDisplayName)
					.HasColumnName("AssetType_DisplayName")
					.HasMaxLength(100);

				entity.Property(e => e.AssetTypeDocuments)
					.IsRequired()
					.HasColumnName("AssetType_Documents")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypeGeneral)
					.IsRequired()
					.HasColumnName("AssetType_General")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypePartList)
					.IsRequired()
					.HasColumnName("AssetType_PartList")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AssetTypePrimaryGroup)
					.HasColumnName("AssetType_PrimaryGroup")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.AssetTypeSubType).HasColumnName("AssetType_SubType");

				entity.Property(e => e.AssetTypeSubTypeName)
					.IsRequired()
					.HasColumnName("AssetType_SubTypeName")
					.HasMaxLength(100);

				entity.Property(e => e.AssetTypeUpdateProfiles)
					.IsRequired()
					.HasColumnName("AssetType_UpdateProfiles")
					.HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<Attribute>(entity =>
			{
				entity.Property(e => e.AttributeId)
					.HasColumnName("Attribute_Id")
					.HasComment("Note:- Set of all attributes.  Equipments will use which ever is applicable to them.");

				entity.Property(e => e.AttributeAbbreviation)
					.HasColumnName("Attribute_Abbreviation")
					.HasMaxLength(40);

				entity.Property(e => e.AttributeControlFlag).HasColumnName("Attribute_ControlFlag");

				entity.Property(e => e.AttributeDescription)
					.HasColumnName("Attribute_Description")
					.HasMaxLength(255);

				entity.Property(e => e.AttributeIsDeleted).HasColumnName("Attribute_IsDeleted");

				entity.Property(e => e.AttributeIsSystem).HasColumnName("Attribute_IsSystem");

				entity.Property(e => e.AttributeName)
					.IsRequired()
					.HasColumnName("Attribute_Name")
					.HasMaxLength(100);

				entity.Property(e => e.AttributeReferenceId).HasColumnName("Attribute_ReferenceId");

				entity.Property(e => e.AttributeType)
					.IsRequired()
					.HasColumnName("Attribute_Type")
					.HasMaxLength(50);

				entity.Property(e => e.IsValueMandatory).HasDefaultValueSql("((0))");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<AttributeAppliesTo>(entity =>
			{
				entity.ToTable("Attribute_AppliesTo");

				entity.Property(e => e.AttributeAppliesToId).HasColumnName("Attribute_AppliesTo_Id");

				entity.Property(e => e.AttributeAppliesToAttributeId).HasColumnName("Attribute_AppliesTo_AttributeId");

				entity.Property(e => e.AttributeAppliesToValue).HasColumnName("Attribute_AppliesTo_Value");

				entity.HasOne(d => d.AttributeAppliesToAttribute)
					.WithMany(p => p.AttributeAppliesTo)
					.HasForeignKey(d => d.AttributeAppliesToAttributeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Attribute_AppliesTo_Attribute");
			});

			modelBuilder.Entity<AttributeValues>(entity =>
			{
				entity.HasKey(e => e.AttributeValueId)
					.HasName("PK_Attribute_Value");

				entity.ToTable("Attribute_Values");

				entity.Property(e => e.AttributeValueId).HasColumnName("Attribute_Value_Id");

				entity.Property(e => e.AttributeIsDefault).HasColumnName("Attribute_IsDefault");

				entity.Property(e => e.AttributeMaximumValue)
					.HasColumnName("Attribute_Maximum_Value")
					.HasColumnType("decimal(10, 2)");

				entity.Property(e => e.AttributeMinimumValue)
					.HasColumnName("Attribute_Minimum_Value")
					.HasColumnType("decimal(10, 2)");

				entity.Property(e => e.AttributeValue)
					.HasColumnName("Attribute_Value")
					.HasMaxLength(255);

				entity.Property(e => e.AttributeValueAttributeId).HasColumnName("Attribute_Value_AttributeId");

				entity.HasOne(d => d.AttributeValueAttribute)
					.WithMany(p => p.AttributeValues)
					.HasForeignKey(d => d.AttributeValueAttributeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Attribute_Values_Attribute");
			});

			modelBuilder.Entity<Audit>(entity =>
			{
				entity.Property(e => e.DateTime)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");

				entity.Property(e => e.Description)
					.IsRequired()
					.HasMaxLength(50);

				entity.HasOne(d => d.User)
					.WithMany(p => p.Audit)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Audit_User");
			});

			modelBuilder.Entity<AuditNotificationMailConfiguration>(entity =>
			{
				entity.Property(e => e.AuditNotificationMailConfigurationId).HasColumnName("AuditNotificationMailConfiguration_Id");

				entity.Property(e => e.AuditNotificationMailConfigurationAreaId).HasColumnName("AuditNotificationMailConfiguration_AreaId");

				entity.Property(e => e.AuditNotificationMailConfigurationEmail)
					.HasColumnName("AuditNotificationMailConfiguration_Email")
					.HasMaxLength(1000)
					.IsUnicode(false);

				entity.HasOne(d => d.AuditNotificationMailConfigurationArea)
					.WithMany(p => p.AuditNotificationMailConfiguration)
					.HasForeignKey(d => d.AuditNotificationMailConfigurationAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AuditNotificationMailConfiguration_Area");
			});

			modelBuilder.Entity<AuditNotificationUser>(entity =>
			{
				entity.Property(e => e.AuditNotificationUserId).HasColumnName("AuditNotificationUser_Id");

				entity.HasOne(d => d.AuditNotification)
					.WithMany(p => p.AuditNotificationUser)
					.HasForeignKey(d => d.AuditNotificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AuditNotificationUser_AuditNotification");

				entity.HasOne(d => d.User)
					.WithMany(p => p.AuditNotificationUser)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AuditNotificationUser_User");
			});

			modelBuilder.Entity<AuditNotificationUserGroups>(entity =>
			{
				entity.Property(e => e.AuditNotificationUserGroupsId).HasColumnName("AuditNotificationUserGroups_Id");

				entity.Property(e => e.AuditNotificationUserGroupsAreaId).HasColumnName("AuditNotificationUserGroups_AreaId");

				entity.Property(e => e.AuditNotificationUserGroupsUserGroupId).HasColumnName("AuditNotificationUserGroups_UserGroupId");

				entity.HasOne(d => d.AuditNotificationUserGroupsArea)
					.WithMany(p => p.AuditNotificationUserGroups)
					.HasForeignKey(d => d.AuditNotificationUserGroupsAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AuditNotificationUserGroups_Area");

				entity.HasOne(d => d.AuditNotificationUserGroupsUserGroup)
					.WithMany(p => p.AuditNotificationUserGroups)
					.HasForeignKey(d => d.AuditNotificationUserGroupsUserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AuditNotificationUserGroups_UserGroup");
			});

			modelBuilder.Entity<AutoAssetTypeCcconfig>(entity =>
			{
				entity.ToTable("AutoAssetTypeCCConfig");

				entity.Property(e => e.AutoAssetTypeCcconfigAppSettingId).HasColumnName("AutoAssetTypeCCConfig_AppSettingId");

				entity.Property(e => e.AutoAssetTypeCcconfigSelectedAssetType).HasColumnName("AutoAssetTypeCCConfig_SelectedAssetType");
			});

			modelBuilder.Entity<AutoCycleCountConfig>(entity =>
			{
				entity.Property(e => e.AutoCycleCountConfigControlFlag).HasColumnName("AutoCycleCountConfig_ControlFlag");

				entity.Property(e => e.PartClass)
					.IsRequired()
					.HasMaxLength(20);
			});

			modelBuilder.Entity<AutoGenCycleCountConfig>(entity =>
			{
				entity.Property(e => e.AutoGenCycleCountConfigControlFlag).HasColumnName("AutoGenCycleCountConfig_ControlFlag");
			});

			modelBuilder.Entity<AutoGenValue>(entity =>
			{
				entity.Property(e => e.AutoGenNumber)
					.IsRequired()
					.IsUnicode(false);
			});

			modelBuilder.Entity<AutoTagSchedule>(entity =>
			{
				entity.Property(e => e.AutoTagScheduleId).HasColumnName("AutoTagSchedule_Id");

				entity.Property(e => e.AutoTagScheduleControlFlag).HasColumnName("AutoTagSchedule_ControlFlag");

				entity.Property(e => e.AutoTagScheduleCreatedDate).HasColumnName("AutoTagSchedule_CreatedDate");

				entity.Property(e => e.AutoTagScheduleCreatedUser).HasColumnName("AutoTagSchedule_CreatedUser");

				entity.Property(e => e.AutoTagScheduleCurrentMaintenanceOrderDueDate).HasColumnName("AutoTagSchedule_CurrentMaintenanceOrderDueDate");

				entity.Property(e => e.AutoTagScheduleEndBy).HasColumnName("AutoTagSchedule_EndBy");

				entity.Property(e => e.AutoTagScheduleEquipmentId).HasColumnName("AutoTagSchedule_EquipmentId");

				entity.Property(e => e.AutoTagScheduleEveryNthTime).HasColumnName("AutoTagSchedule_EveryNthTime");

				entity.Property(e => e.AutoTagScheduleFirstDue).HasColumnName("AutoTagSchedule_FirstDue");

				entity.Property(e => e.AutoTagScheduleIsActive)
					.IsRequired()
					.HasColumnName("AutoTagSchedule_IsActive")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.AutoTagScheduleIsDeleted).HasColumnName("AutoTagSchedule_IsDeleted");

				entity.Property(e => e.AutoTagScheduleMoTemplateId).HasColumnName("AutoTagSchedule_MoTemplateId");

				entity.Property(e => e.AutoTagScheduleMonthlyDate).HasColumnName("AutoTagSchedule_MonthlyDate");

				entity.Property(e => e.AutoTagScheduleRecurrenceType).HasColumnName("AutoTagSchedule_RecurrenceType");

				entity.Property(e => e.AutoTagScheduleScheduleTimeOfDay).HasColumnName("AutoTagSchedule_ScheduleTimeOfDay");

				entity.Property(e => e.AutoTagScheduleWeeklyDay).HasColumnName("AutoTagSchedule_WeeklyDay");

				entity.Property(e => e.AutoTagScheduleYearlyDay).HasColumnName("AutoTagSchedule_YearlyDay");

				entity.Property(e => e.AutoTagScheduleYearlyMonth).HasColumnName("AutoTagSchedule_YearlyMonth");

				entity.HasOne(d => d.AutoTagScheduleCreatedUserNavigation)
					.WithMany(p => p.AutoTagSchedule)
					.HasForeignKey(d => d.AutoTagScheduleCreatedUser)
					.HasConstraintName("FK_AutoTagSchedule_User");

				entity.HasOne(d => d.AutoTagScheduleEquipment)
					.WithMany(p => p.AutoTagSchedule)
					.HasForeignKey(d => d.AutoTagScheduleEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AutoTagSchedule_Equipment");

				entity.HasOne(d => d.AutoTagScheduleMoTemplate)
					.WithMany(p => p.AutoTagSchedule)
					.HasForeignKey(d => d.AutoTagScheduleMoTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_AutoTagSchedule_MaintenanceOrderTemplate");
			});

			modelBuilder.Entity<BackupConfig>(entity =>
			{
				entity.Property(e => e.BackupConfigId).HasColumnName("BackupConfig_Id");

				entity.Property(e => e.BackupConfigBackupPath)
					.IsRequired()
					.HasColumnName("BackupConfig_BackupPath")
					.HasMaxLength(1000);

				entity.Property(e => e.BackupConfigBackupTime).HasColumnName("BackupConfig_BackupTime");

				entity.Property(e => e.BackupConfigEmailAddress)
					.HasColumnName("BackupConfig_EmailAddress")
					.HasMaxLength(100);

				entity.Property(e => e.BackupConfigIsRemoteServer).HasColumnName("BackupConfig_IsRemoteServer");

				entity.Property(e => e.BackupConfigPurgeInDays).HasColumnName("BackupConfig_PurgeInDays");

				entity.Property(e => e.BackupConfigSharedLocationPassword).HasColumnName("BackupConfig_SharedLocationPassword");

				entity.Property(e => e.BackupConfigSharedLocationPath).HasColumnName("BackupConfig_SharedLocationPath");

				entity.Property(e => e.BackupConfigSharedLocationUserName).HasColumnName("BackupConfig_SharedLocationUserName");
			});

			modelBuilder.Entity<BackupStatus>(entity =>
			{
				entity.Property(e => e.BackupStatusId).HasColumnName("BackupStatus_Id");

				entity.Property(e => e.BackupStatusBackupConfigType)
					.IsRequired()
					.HasColumnName("BackupStatus_BackupConfigType")
					.HasMaxLength(50);

				entity.Property(e => e.BackupStatusBackupType)
					.IsRequired()
					.HasColumnName("BackupStatus_BackupType")
					.HasMaxLength(50);

				entity.Property(e => e.BackupStatusLogInformation).HasColumnName("BackupStatus_LogInformation");

				entity.Property(e => e.BackupStatusStatus)
					.IsRequired()
					.HasColumnName("BackupStatus_Status")
					.HasMaxLength(50);

				entity.Property(e => e.BackupStatusTimestamp).HasColumnName("BackupStatus_Timestamp");
			});

			modelBuilder.Entity<BarcodeConfiguration>(entity =>
			{
				entity.Property(e => e.BarcodeConfigurationId).HasColumnName("BarcodeConfiguration_Id");

				entity.Property(e => e.BarcodeConfigurationEntityName)
					.IsRequired()
					.HasColumnName("BarcodeConfiguration_EntityName")
					.HasMaxLength(100)
					.HasComment("Hold the entity name such as “Part”, “Equipment”, “User” etc..");

				entity.Property(e => e.BarcodeconfigurationIdentifier)
					.HasColumnName("Barcodeconfiguration_Identifier")
					.HasComment("Hold the existing field_type enum value like 0,1, 2 etc");
			});

			modelBuilder.Entity<BarcodeFields>(entity =>
			{
				entity.Property(e => e.BarcodeFieldsId).HasColumnName("BarcodeFields_Id");

				entity.Property(e => e.BarcodeFieldsExpression)
					.HasColumnName("BarcodeFields_Expression")
					.HasMaxLength(200);

				entity.Property(e => e.BarcodeFieldsField).HasColumnName("BarcodeFields_Field");

				entity.Property(e => e.BarcodeFieldsLabelId)
					.HasColumnName("BarcodeFields_LabelId")
					.HasDefaultValueSql("((1))");

				entity.HasOne(d => d.BarcodeFieldsLabel)
					.WithMany(p => p.BarcodeFields)
					.HasForeignKey(d => d.BarcodeFieldsLabelId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BarcodeFields_Label");
			});

			modelBuilder.Entity<BarcodeLabels>(entity =>
			{
				entity.Property(e => e.BarcodeLabelsId).HasColumnName("BarcodeLabels_Id");

				entity.Property(e => e.BarcodeLabelsExpression)
					.HasColumnName("BarcodeLabels_Expression")
					.HasMaxLength(200);

				entity.Property(e => e.BarcodeLabelsName)
					.IsRequired()
					.HasColumnName("BarcodeLabels_Name")
					.HasMaxLength(100);

				entity.Property(e => e.BarcodeLabelsType).HasColumnName("BarcodeLabels_Type");

				entity.Property(e => e.BarcodeLabelsWeight).HasColumnName("BarcodeLabels_Weight");
			});

			modelBuilder.Entity<Bin>(entity =>
			{
				entity.Property(e => e.BinId).HasColumnName("Bin_Id");

				entity.Property(e => e.BinName)
					.IsRequired()
					.HasColumnName("Bin_Name")
					.HasMaxLength(50);

				entity.Property(e => e.BinSubLocationId).HasColumnName("Bin_SubLocationId");

				entity.HasOne(d => d.BinSubLocation)
					.WithMany(p => p.Bin)
					.HasForeignKey(d => d.BinSubLocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Bin_Bin");
			});

			modelBuilder.Entity<Building>(entity =>
			{
				entity.Property(e => e.BuildingId).HasColumnName("Building_Id");

				entity.Property(e => e.BuildingName)
					.HasColumnName("Building_Name")
					.HasMaxLength(100);

				entity.Property(e => e.BuildingSiteId).HasColumnName("Building_SiteId");

				entity.HasOne(d => d.BuildingSite)
					.WithMany(p => p.Building)
					.HasForeignKey(d => d.BuildingSiteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Building_Site");
			});

			modelBuilder.Entity<BusinessRule>(entity =>
			{
				entity.Property(e => e.BusinessRuleId).HasColumnName("BusinessRule_Id");

				entity.Property(e => e.BusinessRuleAssetSubType).HasColumnName("BusinessRule_AssetSubType");

				entity.Property(e => e.BusinessRuleControlFlag).HasColumnName("BusinessRule_ControlFlag");

				entity.Property(e => e.BusinessRuleEvaluationTime)
					.HasColumnName("BusinessRule_EvaluationTime")
					.HasMaxLength(50);

				entity.Property(e => e.BusinessRuleEvaluationType).HasColumnName("BusinessRule_EvaluationType");

				entity.Property(e => e.BusinessRuleExpectedResult).HasColumnName("BusinessRule_ExpectedResult");

				entity.Property(e => e.BusinessRuleIsDeleted).HasColumnName("BusinessRule_IsDeleted");

				entity.Property(e => e.BusinessRuleMoTemplateId).HasColumnName("BusinessRule_MoTemplateId");

				entity.Property(e => e.BusinessRuleName)
					.IsRequired()
					.HasColumnName("BusinessRule_Name")
					.HasMaxLength(50);

				entity.Property(e => e.BusinessRuleReferenceId).HasColumnName("BusinessRule_ReferenceId");

				entity.Property(e => e.BusinessRuleRtTemplateId).HasColumnName("BusinessRule_RtTemplateId");

				entity.Property(e => e.BusinessRuleStatement).HasColumnName("BusinessRule_Statement");

				entity.HasOne(d => d.BusinessRuleMoTemplate)
					.WithMany(p => p.BusinessRule)
					.HasForeignKey(d => d.BusinessRuleMoTemplateId)
					.HasConstraintName("FK_BusinessRule_MaintenanceOrderTemplate");

				entity.HasOne(d => d.BusinessRuleRtTemplate)
					.WithMany(p => p.BusinessRule)
					.HasForeignKey(d => d.BusinessRuleRtTemplateId)
					.HasConstraintName("FK_BusinessRule_RepairTicketTemplate");
			});

			modelBuilder.Entity<BusinessRuleAttribute>(entity =>
			{
				entity.Property(e => e.BusinessRuleAttributeId).HasColumnName("BusinessRuleAttribute_Id");

				entity.Property(e => e.BusinessRuleAttributeAttributeId).HasColumnName("BusinessRuleAttribute_AttributeId");

				entity.Property(e => e.BusinessRuleAttributeBusinessRuleId).HasColumnName("BusinessRuleAttribute_BusinessRuleId");

				entity.HasOne(d => d.BusinessRuleAttributeAttribute)
					.WithMany(p => p.BusinessRuleAttribute)
					.HasForeignKey(d => d.BusinessRuleAttributeAttributeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BusinessRuleAttribute_Attribute");

				entity.HasOne(d => d.BusinessRuleAttributeBusinessRule)
					.WithMany(p => p.BusinessRuleAttribute)
					.HasForeignKey(d => d.BusinessRuleAttributeBusinessRuleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BusinessRuleAttribute_BusinessRule");
			});

			modelBuilder.Entity<BusinessRuleGroup>(entity =>
			{
				entity.Property(e => e.BusinessRuleGroupId).HasColumnName("BusinessRuleGroup_Id");

				entity.Property(e => e.BusinessRuleGroupBusinessRuleId).HasColumnName("BusinessRuleGroup_BusinessRuleId");

				entity.Property(e => e.BusinessRuleGroupExpressionJson).HasColumnName("BusinessRuleGroup_ExpressionJson");

				entity.Property(e => e.BusinessRuleGroupExpressionQuery).HasColumnName("BusinessRuleGroup_ExpressionQuery");

				entity.Property(e => e.BusinessRuleGroupIsEnabled).HasColumnName("BusinessRuleGroup_IsEnabled");

				entity.Property(e => e.BusinessRuleGroupOperator)
					.HasColumnName("BusinessRuleGroup_Operator")
					.HasMaxLength(20);

				entity.Property(e => e.BusinessRuleGroupSequence).HasColumnName("BusinessRuleGroup_Sequence");

				entity.HasOne(d => d.BusinessRuleGroupBusinessRule)
					.WithMany(p => p.BusinessRuleGroup)
					.HasForeignKey(d => d.BusinessRuleGroupBusinessRuleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_BusinessRuleGroup_BusinessRule");
			});

			modelBuilder.Entity<BusinessRuleResult>(entity =>
			{
				entity.Property(e => e.BusinessRuleResultId).HasColumnName("BusinessRuleResult_Id");

				entity.Property(e => e.BusinessRuleResultBusinessRuleId).HasColumnName("BusinessRuleResult_BusinessRuleId");

				entity.Property(e => e.BusinessRuleResultEquipmentId).HasColumnName("BusinessRuleResult_EquipmentId");

				entity.Property(e => e.BusinessRuleResultEvaluationResult).HasColumnName("BusinessRuleResult_EvaluationResult");

				entity.Property(e => e.BusinessRuleResultIgnoreResult).HasColumnName("BusinessRuleResult_IgnoreResult");
			});

			modelBuilder.Entity<BusinessRuleResultArchive>(entity =>
			{
				entity.Property(e => e.BusinessRuleResultArchiveId).HasColumnName("BusinessRuleResultArchive_Id");

				entity.Property(e => e.BusinessRuleResultArchiveBusinessRuleId).HasColumnName("BusinessRuleResultArchive_BusinessRuleId");

				entity.Property(e => e.BusinessRuleResultArchiveBusinessRuleResultId).HasColumnName("BusinessRuleResultArchive_BusinessRuleResultId");

				entity.Property(e => e.BusinessRuleResultArchiveEquipmentId).HasColumnName("BusinessRuleResultArchive_EquipmentId");

				entity.Property(e => e.BusinessRuleResultArchiveEvaluationResult).HasColumnName("BusinessRuleResultArchive_EvaluationResult");

				entity.Property(e => e.BusinessRuleResultArchiveIgnoreResult).HasColumnName("BusinessRuleResultArchive_IgnoreResult");
			});

			modelBuilder.Entity<CcheckListStepTranslation>(entity =>
			{
				entity.ToTable("CCheckListStepTranslation");

				entity.Property(e => e.CcheckListStepTranslationId).HasColumnName("CCheckListStepTranslation_Id");

				entity.Property(e => e.CcheckListStepTranslationAppLangId).HasColumnName("CCheckListStepTranslation_AppLangId");

				entity.Property(e => e.CcheckListStepTranslationStepDescription)
					.HasColumnName("CCheckListStepTranslation_StepDescription")
					.HasMaxLength(2048);

				entity.Property(e => e.CcheckListStepTranslationStepId).HasColumnName("CCheckListStepTranslation_StepId");

				entity.HasOne(d => d.CcheckListStepTranslationAppLang)
					.WithMany(p => p.CcheckListStepTranslation)
					.HasForeignKey(d => d.CcheckListStepTranslationAppLangId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CCheckListStepTranslation_AppLanguage");

				entity.HasOne(d => d.CcheckListStepTranslationStep)
					.WithMany(p => p.CcheckListStepTranslation)
					.HasForeignKey(d => d.CcheckListStepTranslationStepId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CCheckListStepTranslation_CertificationCheckListStep");
			});

			modelBuilder.Entity<CertificationCheckList>(entity =>
			{
				entity.Property(e => e.CertificationCheckListControlFlag).HasColumnName("CertificationCheckList_ControlFlag");

				entity.Property(e => e.CertificationCheckListIsDeleted).HasColumnName("CertificationCheckList_IsDeleted");

				entity.Property(e => e.CertificationCheckListPrimaryGroupId).HasColumnName("CertificationCheckList_PrimaryGroupId");

				entity.Property(e => e.CertificationCheckListReferenceId).HasColumnName("CertificationCheckList_ReferenceId");

				entity.Property(e => e.CertificationCheckListSecondaryGroupId).HasColumnName("CertificationCheckList_SecondaryGroupId");

				entity.Property(e => e.CertificationCheckListSubGroupId).HasColumnName("CertificationCheckList_SubGroupId");

				entity.Property(e => e.Description).HasMaxLength(255);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(80);

				entity.Property(e => e.Number).HasMaxLength(50);

				entity.HasOne(d => d.CertificationCheckListPrimaryGroup)
					.WithMany(p => p.CertificationCheckListCertificationCheckListPrimaryGroup)
					.HasForeignKey(d => d.CertificationCheckListPrimaryGroupId)
					.HasConstraintName("FK_CertificationCheckList_EquipmentGroupPrimary");

				entity.HasOne(d => d.CertificationCheckListSecondaryGroup)
					.WithMany(p => p.CertificationCheckListCertificationCheckListSecondaryGroup)
					.HasForeignKey(d => d.CertificationCheckListSecondaryGroupId)
					.HasConstraintName("FK_CertificationCheckList_EquipmentGroupSecondary");

				entity.HasOne(d => d.CertificationCheckListSubGroup)
					.WithMany(p => p.CertificationCheckListCertificationCheckListSubGroup)
					.HasForeignKey(d => d.CertificationCheckListSubGroupId)
					.HasConstraintName("FK_CertificationCheckList_EquipmentGroupSubGroup");

				entity.HasOne(d => d.DocumentVersion)
					.WithMany(p => p.CertificationCheckList)
					.HasForeignKey(d => d.DocumentVersionId)
					.HasConstraintName("FK_CertificationCheckList_DocumentVersion");

				entity.HasOne(d => d.Equipment)
					.WithMany(p => p.CertificationCheckList)
					.HasForeignKey(d => d.EquipmentId)
					.HasConstraintName("FK_CertificationCheckList_Equipment");
			});

			modelBuilder.Entity<CertificationCheckListStep>(entity =>
			{
				entity.Property(e => e.MaxValue).HasMaxLength(50);

				entity.Property(e => e.MinValue).HasMaxLength(50);

				entity.Property(e => e.StepDescription)
					.IsRequired()
					.HasMaxLength(1024);

				entity.HasOne(d => d.CheckList)
					.WithMany(p => p.CertificationCheckListStep)
					.HasForeignKey(d => d.CheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CertificationCheckListStep_CertificationCheckListStep");
			});

			modelBuilder.Entity<CheckListZoneMapping>(entity =>
			{
				entity.Property(e => e.CheckListZoneMappingId).HasColumnName("CheckListZoneMapping_Id");

				entity.Property(e => e.CheckListZoneMappingCheckListId).HasColumnName("CheckListZoneMapping_CheckListId");

				entity.Property(e => e.CheckListZoneMappingZoneId).HasColumnName("CheckListZoneMapping_ZoneId");

				entity.HasOne(d => d.CheckListZoneMappingCheckList)
					.WithMany(p => p.CheckListZoneMapping)
					.HasForeignKey(d => d.CheckListZoneMappingCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CheckListZoneMapping_PreCompiledCheckList");

				entity.HasOne(d => d.CheckListZoneMappingZone)
					.WithMany(p => p.CheckListZoneMapping)
					.HasForeignKey(d => d.CheckListZoneMappingZoneId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CheckListZoneMapping_EquipmentArZone");
			});

			modelBuilder.Entity<ClaimMaster>(entity =>
			{
				entity.Property(e => e.ClaimMasterId).HasColumnName("ClaimMaster_Id");

				entity.Property(e => e.ClaimMasterCategory)
					.IsRequired()
					.HasColumnName("ClaimMaster_Category")
					.HasMaxLength(50);

				entity.Property(e => e.ClaimMasterClaim)
					.IsRequired()
					.HasColumnName("ClaimMaster_Claim")
					.HasMaxLength(255)
					.HasComment("Claims for Authroization.");
			});

			modelBuilder.Entity<CostCenter>(entity =>
			{
				entity.Property(e => e.CostCenterId)
					.HasColumnName("CostCenter_Id")
					.HasComment("Note:-  Universe of all cost centers in the system");

				entity.Property(e => e.CostCenterControlFlag).HasColumnName("CostCenter_ControlFlag");

				entity.Property(e => e.CostCenterDescription)
					.HasColumnName("CostCenter_Description")
					.HasMaxLength(255);

				entity.Property(e => e.CostCenterIsDeleted).HasColumnName("CostCenter_IsDeleted");

				entity.Property(e => e.CostCenterName)
					.IsRequired()
					.HasColumnName("CostCenter_Name")
					.HasMaxLength(50);

				entity.Property(e => e.CostCenterReferenceId).HasColumnName("CostCenter_ReferenceId");
			});

			modelBuilder.Entity<Country>(entity =>
			{
				entity.Property(e => e.CountryId)
					.HasColumnName("Country_Id")
					.HasComment("Note: We could have just 1 country list and handle localization through resource files");

				entity.Property(e => e.CountryCountryId)
					.HasColumnName("Country_CountryId")
					.HasComment("Uniquely identifies a country irrespective of the locale");

				entity.Property(e => e.CountryCountryName)
					.IsRequired()
					.HasColumnName("Country_CountryName")
					.HasMaxLength(50);

				entity.Property(e => e.CountryLocale)
					.HasColumnName("Country_Locale")
					.HasMaxLength(255)
					.HasComment("Base Country Locale will be empty, Each locale will have one set of country list(translated)");
			});

			modelBuilder.Entity<CycleCount>(entity =>
			{
				entity.Property(e => e.CycleCountCategory)
					.HasColumnName("CycleCount_Category")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.CycleCountScheduleId).HasColumnName("CycleCount_ScheduleId");

				entity.Property(e => e.CycleCountSiteId).HasColumnName("CycleCount_SiteId");

				entity.Property(e => e.CycleCountTitle)
					.HasColumnName("CycleCount_Title")
					.HasMaxLength(100);

				entity.Property(e => e.Description).HasMaxLength(1000);

				entity.Property(e => e.DueDate).HasColumnType("datetime");

				entity.Property(e => e.RefNumber).HasMaxLength(50);

				entity.HasOne(d => d.Area)
					.WithMany(p => p.CycleCount)
					.HasForeignKey(d => d.AreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCount_Area");

				entity.HasOne(d => d.Bin)
					.WithMany(p => p.CycleCount)
					.HasForeignKey(d => d.BinId)
					.HasConstraintName("FK_CycleCount_Bin");

				entity.HasOne(d => d.CancelReasonCode)
					.WithMany(p => p.CycleCount)
					.HasForeignKey(d => d.CancelReasonCodeId)
					.HasConstraintName("FK_CycleCount_ReasonCode");

				entity.HasOne(d => d.CreatedByNavigation)
					.WithMany(p => p.CycleCountCreatedByNavigation)
					.HasForeignKey(d => d.CreatedBy)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCount_User");

				entity.HasOne(d => d.CycleCountSite)
					.WithMany(p => p.CycleCount)
					.HasForeignKey(d => d.CycleCountSiteId)
					.HasConstraintName("FK_CycleCount_Site");

				entity.HasOne(d => d.Location)
					.WithMany(p => p.CycleCount)
					.HasForeignKey(d => d.LocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCount_Location");

				entity.HasOne(d => d.SubLocation)
					.WithMany(p => p.CycleCount)
					.HasForeignKey(d => d.SubLocationId)
					.HasConstraintName("FK_CycleCount_SubLocation");

				entity.HasOne(d => d.UserExecutingNavigation)
					.WithMany(p => p.CycleCountUserExecutingNavigation)
					.HasForeignKey(d => d.UserExecuting);
			});

			modelBuilder.Entity<CycleCountAssets>(entity =>
			{
				entity.HasKey(e => e.CycleCountAssetId);

				entity.Property(e => e.CycleCountAssetId).HasColumnName("CycleCountAsset_Id");

				entity.Property(e => e.CycleCountAssetAssetComment)
					.HasColumnName("CycleCountAsset_AssetComment")
					.HasMaxLength(4000);

				entity.Property(e => e.CycleCountAssetAssetCondition).HasColumnName("CycleCountAsset_AssetCondition");

				entity.Property(e => e.CycleCountAssetAssetCounterValue).HasColumnName("CycleCountAsset_AssetCounterValue");

				entity.Property(e => e.CycleCountAssetAssetId).HasColumnName("CycleCountAsset_AssetId");

				entity.Property(e => e.CycleCountAssetAssetLocationId).HasColumnName("CycleCountAsset_AssetLocationId");

				entity.Property(e => e.CycleCountAssetCostCenterId).HasColumnName("CycleCountAsset_CostCenterId");

				entity.Property(e => e.CycleCountAssetCycleCountId).HasColumnName("CycleCountAsset_CycleCountId");

				entity.Property(e => e.CycleCountAssetCycleCountState).HasColumnName("CycleCountAsset_CycleCountState");

				entity.Property(e => e.CylceCountAssetAssetAreaId).HasColumnName("CylceCountAsset_AssetAreaId");

				entity.HasOne(d => d.CycleCountAssetAsset)
					.WithMany(p => p.CycleCountAssets)
					.HasForeignKey(d => d.CycleCountAssetAssetId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountAssets_Equipment");

				entity.HasOne(d => d.CycleCountAssetAssetLocation)
					.WithMany(p => p.CycleCountAssets)
					.HasForeignKey(d => d.CycleCountAssetAssetLocationId)
					.HasConstraintName("FK_CycleCountAssets_Location");

				entity.HasOne(d => d.CycleCountAssetCostCenter)
					.WithMany(p => p.CycleCountAssets)
					.HasForeignKey(d => d.CycleCountAssetCostCenterId)
					.HasConstraintName("FK_CycleCountAssets_CostCenter");

				entity.HasOne(d => d.CycleCountAssetCycleCount)
					.WithMany(p => p.CycleCountAssets)
					.HasForeignKey(d => d.CycleCountAssetCycleCountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountAssets_CycleCount");

				entity.HasOne(d => d.CylceCountAssetAssetArea)
					.WithMany(p => p.CycleCountAssets)
					.HasForeignKey(d => d.CylceCountAssetAssetAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountAssets_Area");
			});

			modelBuilder.Entity<CycleCountNotification>(entity =>
			{
				entity.HasOne(d => d.CycleCount)
					.WithMany(p => p.CycleCountNotification)
					.HasForeignKey(d => d.CycleCountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountNotification_CycleCount");

				entity.HasOne(d => d.Notification)
					.WithMany(p => p.CycleCountNotification)
					.HasForeignKey(d => d.NotificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountNotification_StockingNotification");
			});

			modelBuilder.Entity<CycleCountPart>(entity =>
			{
				entity.HasIndex(e => new { e.PartId, e.CycleCountId })
					.HasName("INDX_CycleCountPart_PartId_CycleCountId");

				entity.HasOne(d => d.CycleCount)
					.WithMany(p => p.CycleCountPart)
					.HasForeignKey(d => d.CycleCountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountPart_CycleCount_Id");

				entity.HasOne(d => d.Part)
					.WithMany(p => p.CycleCountPart)
					.HasForeignKey(d => d.PartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountPart_Part_Id");
			});

			modelBuilder.Entity<CycleCountPartList>(entity =>
			{
				entity.HasKey(e => new { e.CycleCountId, e.PartId });

				entity.HasOne(d => d.CycleCount)
					.WithMany(p => p.CycleCountPartList)
					.HasForeignKey(d => d.CycleCountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountPartList_CycleCount");

				entity.HasOne(d => d.Part)
					.WithMany(p => p.CycleCountPartList)
					.HasForeignKey(d => d.PartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountPartList_Part");
			});

			modelBuilder.Entity<CycleCountResources>(entity =>
			{
				entity.HasOne(d => d.CycleCount)
					.WithMany(p => p.CycleCountResources)
					.HasForeignKey(d => d.CycleCountId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountResources_CycleCount");

				entity.HasOne(d => d.UserGroup)
					.WithMany(p => p.CycleCountResources)
					.HasForeignKey(d => d.UserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountResources_UserGroup");

				entity.HasOne(d => d.User)
					.WithMany(p => p.CycleCountResources)
					.HasForeignKey(d => d.UserId)
					.HasConstraintName("FK_CycleCountResources_User");
			});

			modelBuilder.Entity<CycleCountSerialPart>(entity =>
			{
				entity.Property(e => e.CycleCountSerialPartId).HasColumnName("CycleCountSerialPart_Id");

				entity.Property(e => e.CycleCountSerialPartCycleCountPartId).HasColumnName("CycleCountSerialPart_CycleCountPartId");

				entity.Property(e => e.CycleCountSerialPartPartSerialNumber)
					.HasColumnName("CycleCountSerialPart_PartSerialNumber")
					.HasMaxLength(50);

				entity.Property(e => e.CycleCountSerialPartPartSerialNumberId).HasColumnName("CycleCountSerialPart_PartSerialNumberId");

				entity.HasOne(d => d.CycleCountSerialPartCycleCountPart)
					.WithMany(p => p.CycleCountSerialPart)
					.HasForeignKey(d => d.CycleCountSerialPartCycleCountPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_CycleCountSerialPart_CycleCountPart");

				entity.HasOne(d => d.CycleCountSerialPartPartSerialNumberNavigation)
					.WithMany(p => p.CycleCountSerialPart)
					.HasForeignKey(d => d.CycleCountSerialPartPartSerialNumberId)
					.HasConstraintName("FK_CycleCountSerialPart_PartSerialNumber");
			});

			modelBuilder.Entity<DataWarehouseSetting>(entity =>
			{
				entity.Property(e => e.DataWarehouseSettingId).HasColumnName("DataWarehouseSetting_ID");

				entity.Property(e => e.DataWarehouseSettingIntegrationId).HasColumnName("DataWarehouseSetting_IntegrationID");

				entity.Property(e => e.DataWarehouseSettingIntegrationServerId).HasColumnName("DataWarehouseSetting_IntegrationServerID");

				entity.Property(e => e.DataWarehouseSettingIsIntegrated).HasColumnName("DataWarehouseSetting_IsIntegrated");

				entity.Property(e => e.DataWarehouseSettingServiceUrl)
					.IsRequired()
					.HasColumnName("DataWarehouseSetting_ServiceURL");

				entity.HasOne(d => d.DataWarehouseSettingIntegration)
					.WithMany(p => p.DataWarehouseSetting)
					.HasForeignKey(d => d.DataWarehouseSettingIntegrationId)
					.HasConstraintName("FK_DataWarehouseSetting_IntegrationID");

				entity.HasOne(d => d.DataWarehouseSettingIntegrationServer)
					.WithMany(p => p.DataWarehouseSetting)
					.HasForeignKey(d => d.DataWarehouseSettingIntegrationServerId)
					.OnDelete(DeleteBehavior.Cascade)
					.HasConstraintName("FK_DataWarehouseSetting_IntegrationServerID");
			});

			modelBuilder.Entity<DeliveryRequest>(entity =>
			{
				entity.HasOne(d => d.DeliveredByNavigation)
					.WithMany(p => p.DeliveryRequestDeliveredByNavigation)
					.HasForeignKey(d => d.DeliveredBy)
					.HasConstraintName("FK_DeliveryRequest_DeliveredBy");

				entity.HasOne(d => d.MaintenanceOrder)
					.WithMany(p => p.DeliveryRequest)
					.HasForeignKey(d => d.MaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequest_MaintenanceOrderId");

				entity.HasOne(d => d.ResquestedByNavigation)
					.WithMany(p => p.DeliveryRequestResquestedByNavigation)
					.HasForeignKey(d => d.ResquestedBy)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequest_RequestedBy");
			});

			modelBuilder.Entity<DeliveryRequestNotification>(entity =>
			{
				entity.HasOne(d => d.DeliveryRequest)
					.WithMany(p => p.DeliveryRequestNotification)
					.HasForeignKey(d => d.DeliveryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequestNotification_DeliveryRequestId");

				entity.HasOne(d => d.StockingNotification)
					.WithMany(p => p.DeliveryRequestNotification)
					.HasForeignKey(d => d.StockingNotificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DeliveryRequestNotification_StockingNotificationId");
			});

			modelBuilder.Entity<Document>(entity =>
			{
				entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

				entity.Property(e => e.DocumentActive)
					.HasColumnName("Document_Active")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.DocumentControlFlag).HasColumnName("Document_ControlFlag");

				entity.Property(e => e.DocumentCreatedBy)
					.IsRequired()
					.HasColumnName("Document_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.DocumentCreatedDate).HasColumnName("Document_CreatedDate");

				entity.Property(e => e.DocumentCurrentRevision)
					.HasColumnName("Document_CurrentRevision")
					.HasMaxLength(50);

				entity.Property(e => e.DocumentDescription)
					.HasColumnName("Document_Description")
					.HasMaxLength(255);

				entity.Property(e => e.DocumentIsDeleted).HasColumnName("Document_IsDeleted");

				entity.Property(e => e.DocumentName)
					.HasColumnName("Document_Name")
					.HasMaxLength(80);

				entity.Property(e => e.DocumentParentDocumentId).HasColumnName("Document_ParentDocumentId");

				entity.Property(e => e.DocumentPrimaryGroupId).HasColumnName("Document_PrimaryGroupId");

				entity.Property(e => e.DocumentPublishedDate).HasColumnName("Document_PublishedDate");

				entity.Property(e => e.DocumentReferenceId).HasColumnName("Document_ReferenceId");

				entity.Property(e => e.DocumentSecondaryGroupId).HasColumnName("Document_SecondaryGroupId");

				entity.Property(e => e.DocumentSubGroupId).HasColumnName("Document_SubGroupId");

				entity.Property(e => e.DocumentVersionNumber)
					.HasColumnName("Document_VersionNumber")
					.HasMaxLength(25)
					.IsFixedLength();

				entity.Property(e => e.IsChapter).HasColumnName("Is_Chapter");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.DocumentPrimaryGroup)
					.WithMany(p => p.DocumentDocumentPrimaryGroup)
					.HasForeignKey(d => d.DocumentPrimaryGroupId)
					.HasConstraintName("FK_Document_EquipmentGroupPrimary");

				entity.HasOne(d => d.DocumentSecondaryGroup)
					.WithMany(p => p.DocumentDocumentSecondaryGroup)
					.HasForeignKey(d => d.DocumentSecondaryGroupId)
					.HasConstraintName("FK_Document_EquipmentGroupSecondary");

				entity.HasOne(d => d.DocumentSubGroup)
					.WithMany(p => p.DocumentDocumentSubGroup)
					.HasForeignKey(d => d.DocumentSubGroupId)
					.HasConstraintName("FK_Document_EquipmentGroupSubGroup");
			});

			modelBuilder.Entity<DocumentVersion>(entity =>
			{
				entity.Property(e => e.DocumentVersionId).HasColumnName("DocumentVersion_Id");

				entity.Property(e => e.DocumentVersionActive).HasColumnName("DocumentVersion_Active");

				entity.Property(e => e.DocumentVersionCreatedBy)
					.IsRequired()
					.HasColumnName("DocumentVersion_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.DocumentVersionCreatedDate).HasColumnName("DocumentVersion_CreatedDate");

				entity.Property(e => e.DocumentVersionDocumentId).HasColumnName("DocumentVersion_DocumentId");

				entity.Property(e => e.DocumentVersionFileName)
					.IsRequired()
					.HasColumnName("DocumentVersion_FileName")
					.HasMaxLength(255);

				entity.Property(e => e.DocumentVersionIsUrl).HasColumnName("DocumentVersion_IsUrl");

				entity.Property(e => e.DocumentVersionVersionNumber)
					.HasColumnName("DocumentVersion_VersionNumber")
					.HasMaxLength(50);

				entity.HasOne(d => d.DocumentVersionDocument)
					.WithMany(p => p.DocumentVersion)
					.HasForeignKey(d => d.DocumentVersionDocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_DocumentVersion_Document");
			});

			modelBuilder.Entity<Equipment>(entity =>
			{
				entity.HasIndex(e => new { e.EquipmentAssetTag, e.Type })
					.HasName("INDX_Equipment_Equipment_AssetTag_Type");

				entity.HasIndex(e => new { e.EquipmentName, e.EquipmentId })
					.HasName("INDX_Equipment_ID");

				entity.HasIndex(e => new { e.EquipmentName, e.Type })
					.HasName("INDX_Equipment_Equipment_Name_Type");

				entity.HasIndex(e => new { e.EquipmentId, e.EquipmentPrimaryAreaId, e.Type })
					.HasName("INDX_Equipment_Type");

				entity.HasIndex(e => new { e.EquipmentIsTemplate, e.Type, e.EquipmentStatus })
					.HasName("INDX_Equipment_Equipment_IsTemplate_Type_Equipment_Status");

				entity.HasIndex(e => new { e.EquipmentIsTemplate, e.Type, e.EquipmentName, e.EquipmentStatus })
					.HasName("INDX_Equipment_Equipment_IsTemplate_Type_Equipment_Name_Equipment_Status");

				entity.HasIndex(e => new { e.EquipmentId, e.EquipmentActive, e.EquipmentSubGroupId, e.EquipmentName, e.EquipmentModelNumber, e.EquipmentSerialNumber, e.EquipmentBarCode, e.EquipmentNextPmdue, e.EquipmentDob, e.EquipmentInstallDate, e.EquipmentAssetTag, e.EquipmentMachineCounter, e.EquipmentRequiresAirSupply, e.EquipmentVoltageReq, e.EquipmentHostName, e.EquipmentIpaddress, e.EquipmentCostCenterId, e.EquipmentPrimaryGroupId, e.EquipmentSecondaryGroupId, e.EquipmentTemplateId, e.EquipmentPrimaryAreaId, e.EquipmentCreatedBy, e.EquipmentCreatedDate, e.EquipmentCapitalCost, e.EquipmentAvgLaborRate, e.EquipmentExpectedLifeCycle, e.EquipmentContractPrice, e.EquipmentTotalBudget, e.EquipmentDefaultPriority, e.PartNumber, e.IsPneumatic, e.IsCutter, e.Rcount, e.RlifetimeCount, e.Lcount, e.LlifetimeCount, e.TotalCount, e.EquipmentLocationId, e.EquipmentIsTemplate, e.EquipmentStatus, e.Type })
					.HasName("INDX_Equipment_Equipment_LocationId_Equipment_IsTemplate_Equipment_Status_Type");

				entity.Property(e => e.EquipmentId).HasColumnName("Equipment_Id");

				entity.Property(e => e.EquipmentActive)
					.HasColumnName("Equipment_Active")
					.HasComment("Is the Equipmnet Active?  This is one way not to segregate un used equipments and not to display the equipment in the UI");

				entity.Property(e => e.EquipmentAssetTag)
					.HasColumnName("Equipment_AssetTag")
					.HasMaxLength(40)
					.HasComment("Asset Tag as per factory standards");

				entity.Property(e => e.EquipmentAvgLaborRate)
					.HasColumnName("Equipment_AvgLaborRate")
					.HasColumnType("decimal(10, 2)");

				entity.Property(e => e.EquipmentBarCode)
					.HasColumnName("Equipment_BarCode")
					.HasMaxLength(50)
					.HasComment("Equipment Bar Code");

				entity.Property(e => e.EquipmentCapitalCost)
					.HasColumnName("Equipment_CapitalCost")
					.HasColumnType("decimal(10, 2)");

				entity.Property(e => e.EquipmentContractPrice)
					.HasColumnName("Equipment_ContractPrice")
					.HasColumnType("decimal(10, 2)");

				entity.Property(e => e.EquipmentControlFlag).HasColumnName("Equipment_ControlFlag");

				entity.Property(e => e.EquipmentCostCenterId)
					.HasColumnName("Equipment_CostCenterId")
					.HasComment("Cost center this equipment belogs to");

				entity.Property(e => e.EquipmentCreatedBy)
					.IsRequired()
					.HasColumnName("Equipment_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentCreatedDate).HasColumnName("Equipment_CreatedDate");

				entity.Property(e => e.EquipmentDefaultPriority).HasColumnName("Equipment_DefaultPriority");

				entity.Property(e => e.EquipmentDob)
					.HasColumnName("Equipment_DOB")
					.HasComment("First Receiving date at the facility,  Could be an old date as well(if its refurbished equipment)");

				entity.Property(e => e.EquipmentExpectedLifeCycle).HasColumnName("Equipment_ExpectedLifeCycle");

				entity.Property(e => e.EquipmentFeederEquipmentId).HasColumnName("Equipment_FeederEquipmentId");

				entity.Property(e => e.EquipmentFirmwareVersion)
					.HasColumnName("Equipment_FirmwareVersion")
					.HasMaxLength(100);

				entity.Property(e => e.EquipmentHostName)
					.HasColumnName("Equipment_HostName")
					.HasMaxLength(100)
					.HasComment("Host Name of the equipment");

				entity.Property(e => e.EquipmentIncludeInOmeCalculation)
					.IsRequired()
					.HasColumnName("Equipment_IncludeInOmeCalculation")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.EquipmentInstallDate)
					.HasColumnName("Equipment_InstallDate")
					.HasComment("Installation date at the current Factory.");

				entity.Property(e => e.EquipmentIpaddress)
					.HasColumnName("Equipment_IPAddress")
					.HasMaxLength(100)
					.HasComment("IPAddress of the equipment");

				entity.Property(e => e.EquipmentIsDeleted).HasColumnName("Equipment_IsDeleted");

				entity.Property(e => e.EquipmentIsTemplate)
					.HasColumnName("Equipment_IsTemplate")
					.HasComment("Same table is used for storing equipment templates.  Y=This is a template, N= Not a template.");

				entity.Property(e => e.EquipmentLocationId)
					.HasColumnName("Equipment_LocationId")
					.HasComment("Location of the equipment.");

				entity.Property(e => e.EquipmentMachineCounter)
					.HasColumnName("Equipment_MachineCounter")
					.HasMaxLength(40);

				entity.Property(e => e.EquipmentModelNumber)
					.HasColumnName("Equipment_ModelNumber")
					.HasMaxLength(255)
					.HasComment("Model Number of the equipment");

				entity.Property(e => e.EquipmentMountedLocation)
					.HasColumnName("Equipment_MountedLocation")
					.HasMaxLength(100);

				entity.Property(e => e.EquipmentName)
					.IsRequired()
					.HasColumnName("Equipment_Name")
					.HasMaxLength(80)
					.HasComment("Name of the equipment.  There could be multiple Ovens in thhe equipment.  But this will be unique name for each oven.");

				entity.Property(e => e.EquipmentNextPmdue)
					.HasColumnName("Equipment_NextPMDue")
					.HasComment("There could be multiple PM configured on an equipment.  This column will be updated to have next PM due.  For easy access.");

				entity.Property(e => e.EquipmentPingTestPass).HasColumnName("Equipment_PingTestPass");

				entity.Property(e => e.EquipmentPrimaryAreaId)
					.HasColumnName("Equipment_PrimaryAreaId")
					.HasComment("Primary AreaId of the equipment.  Equipment could be part of multiple Area.");

				entity.Property(e => e.EquipmentPrimaryGroupId)
					.HasColumnName("Equipment_PrimaryGroupId")
					.HasComment("Group Categorization -  Primary Group Id");

				entity.Property(e => e.EquipmentReferenceId).HasColumnName("Equipment_ReferenceId");

				entity.Property(e => e.EquipmentRegistrationDate).HasColumnName("Equipment_RegistrationDate");

				entity.Property(e => e.EquipmentRequiresAirSupply).HasColumnName("Equipment_RequiresAirSupply");

				entity.Property(e => e.EquipmentSecondaryGroupId)
					.HasColumnName("Equipment_SecondaryGroupId")
					.HasComment("Group Categorization - Secondary Group Id");

				entity.Property(e => e.EquipmentSerialNumber)
					.HasColumnName("Equipment_SerialNumber")
					.HasMaxLength(50)
					.HasComment("Serial Number of the equipment.");

				entity.Property(e => e.EquipmentSoftwareVersion)
					.HasColumnName("Equipment_SoftwareVersion")
					.HasMaxLength(10);

				entity.Property(e => e.EquipmentStatus)
					.HasColumnName("Equipment_Status")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.EquipmentSubGroupId)
					.HasColumnName("Equipment_SubGroupId")
					.HasComment("Which sub group this equipment belongs to");

				entity.Property(e => e.EquipmentSubType).HasColumnName("Equipment_SubType");

				entity.Property(e => e.EquipmentTemplateId)
					.HasColumnName("Equipment_TemplateId")
					.HasComment("Template Id of the eqiupment template from which this equipment has been created.  This will be used for configuration change pushes in the future.");

				entity.Property(e => e.EquipmentTotalBudget)
					.HasColumnName("Equipment_TotalBudget")
					.HasColumnType("decimal(10, 2)");

				entity.Property(e => e.EquipmentVoltageReq)
					.HasColumnName("Equipment_VoltageReq")
					.HasMaxLength(50);

				entity.Property(e => e.IsCutter).HasDefaultValueSql("((0))");

				entity.Property(e => e.IsPneumatic).HasDefaultValueSql("((0))");

				entity.Property(e => e.Lcount)
					.HasColumnName("LCount")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.LlifetimeCount)
					.HasColumnName("LLifetimeCount")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.PartNumber).HasMaxLength(50);

				entity.Property(e => e.Rcount)
					.HasColumnName("RCount")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.RlifetimeCount)
					.HasColumnName("RLifetimeCount")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.TotalCount).HasColumnType("numeric(18, 0)");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.EquipmentCostCenter)
					.WithMany(p => p.Equipment)
					.HasForeignKey(d => d.EquipmentCostCenterId)
					.HasConstraintName("FK_Equipment_CostCenter");

				entity.HasOne(d => d.EquipmentFeederEquipment)
					.WithMany(p => p.InverseEquipmentFeederEquipment)
					.HasForeignKey(d => d.EquipmentFeederEquipmentId)
					.HasConstraintName("FK_Equipment_FeederEquipmentId");

				entity.HasOne(d => d.EquipmentLocation)
					.WithMany(p => p.Equipment)
					.HasForeignKey(d => d.EquipmentLocationId)
					.HasConstraintName("FK_Equipment_Location");

				entity.HasOne(d => d.EquipmentPrimaryArea)
					.WithMany(p => p.Equipment)
					.HasForeignKey(d => d.EquipmentPrimaryAreaId)
					.HasConstraintName("FK_Equipment_Area");

				entity.HasOne(d => d.EquipmentPrimaryGroup)
					.WithMany(p => p.EquipmentEquipmentPrimaryGroup)
					.HasForeignKey(d => d.EquipmentPrimaryGroupId)
					.HasConstraintName("FK_Equipment_EquipmentGroupPrimary");

				entity.HasOne(d => d.EquipmentSecondaryGroup)
					.WithMany(p => p.EquipmentEquipmentSecondaryGroup)
					.HasForeignKey(d => d.EquipmentSecondaryGroupId)
					.HasConstraintName("FK_Equipment_EquipmentGroupSecondary");

				entity.HasOne(d => d.EquipmentSubGroup)
					.WithMany(p => p.EquipmentEquipmentSubGroup)
					.HasForeignKey(d => d.EquipmentSubGroupId)
					.HasConstraintName("FK_Equipment_EquipmentGroupSubGroup");
			});

			modelBuilder.Entity<EquipmentArMarker>(entity =>
			{
				entity.Property(e => e.EquipmentArMarkerId)
					.HasColumnName("EquipmentArMarker_Id")
					.ValueGeneratedNever();

				entity.Property(e => e.EquipmentArMarkerAngle).HasColumnName("EquipmentArMarker_Angle");

				entity.Property(e => e.EquipmentArMarkerEquipmentId).HasColumnName("EquipmentArMarker_EquipmentId");

				entity.Property(e => e.EquipmentArMarkerImage)
					.HasColumnName("EquipmentArMarker_Image")
					.HasMaxLength(255);

				entity.Property(e => e.EquipmentArMarkerXpos).HasColumnName("EquipmentArMarker_Xpos");

				entity.Property(e => e.EquipmentArMarkerYpos).HasColumnName("EquipmentArMarker_Ypos");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.EquipmentArMarkerEquipment)
					.WithMany(p => p.EquipmentArMarker)
					.HasForeignKey(d => d.EquipmentArMarkerEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentArMarker_EquipmentId");
			});

			modelBuilder.Entity<EquipmentArXmlConfig>(entity =>
			{
				entity.Property(e => e.EquipmentArXmlConfigId).HasColumnName("EquipmentArXmlConfig_Id");

				entity.Property(e => e.EquipmentArXmlConfigEquipmentId).HasColumnName("EquipmentArXmlConfig_EquipmentId");

				entity.Property(e => e.EquipmentArXmlConfigName)
					.IsRequired()
					.HasColumnName("EquipmentArXmlConfig_Name")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.EquipmentArXmlConfigPath)
					.HasColumnName("EquipmentArXmlConfig_Path")
					.HasMaxLength(255)
					.IsUnicode(false);

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.EquipmentArXmlConfigEquipment)
					.WithMany(p => p.EquipmentArXmlConfig)
					.HasForeignKey(d => d.EquipmentArXmlConfigEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentArXmlConfig_EquipmentId");
			});

			modelBuilder.Entity<EquipmentArZone>(entity =>
			{
				entity.Property(e => e.EquipmentArZoneId).HasColumnName("EquipmentArZone_Id");

				entity.Property(e => e.EquipmentArZoneEquipmentPictureId).HasColumnName("EquipmentArZone_EquipmentPictureId");

				entity.Property(e => e.EquipmentArZoneIcon)
					.HasColumnName("EquipmentArZone_Icon")
					.HasMaxLength(255);

				entity.Property(e => e.EquipmentArZoneName)
					.IsRequired()
					.HasColumnName("EquipmentArZone_Name")
					.HasMaxLength(50)
					.IsUnicode(false);

				entity.Property(e => e.EquipmentArZoneXpos).HasColumnName("EquipmentArZone_Xpos");

				entity.Property(e => e.EquipmentArZoneYpos).HasColumnName("EquipmentArZone_Ypos");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.EquipmentArZoneEquipmentPicture)
					.WithMany(p => p.EquipmentArZone)
					.HasForeignKey(d => d.EquipmentArZoneEquipmentPictureId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentArZone_EquipmentPictureId");
			});

			modelBuilder.Entity<EquipmentArZonePreCompiledCheckList>(entity =>
			{
				entity.Property(e => e.EquipmentArZonePreCompiledCheckListId).HasColumnName("EquipmentArZonePreCompiledCheckList_Id");

				entity.Property(e => e.EquipmentArZonePreCompiledCheckListEquipmentArZoneId).HasColumnName("EquipmentArZonePreCompiledCheckList_EquipmentArZoneId");

				entity.Property(e => e.EquipmentArZonePreCompiledCheckListPreCompiledCheckListId).HasColumnName("EquipmentArZonePreCompiledCheckList_PreCompiledCheckListId");

				entity.HasOne(d => d.EquipmentArZonePreCompiledCheckListEquipmentArZone)
					.WithMany(p => p.EquipmentArZonePreCompiledCheckList)
					.HasForeignKey(d => d.EquipmentArZonePreCompiledCheckListEquipmentArZoneId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentArZonePreCompiledCheckList_EquipmentArZoneId");

				entity.HasOne(d => d.EquipmentArZonePreCompiledCheckListPreCompiledCheckList)
					.WithMany(p => p.EquipmentArZonePreCompiledCheckList)
					.HasForeignKey(d => d.EquipmentArZonePreCompiledCheckListPreCompiledCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentArZonePreCompiledCheckList_PreCompiledCheckListId");
			});

			modelBuilder.Entity<EquipmentAssignation>(entity =>
			{
				entity.Property(e => e.EquipmentAssignationId).HasColumnName("EquipmentAssignation_Id");

				entity.Property(e => e.EquipmentAssignationEquipmentId).HasColumnName("EquipmentAssignation_EquipmentId");

				entity.Property(e => e.EquipmentAssignationEquipmentName)
					.IsRequired()
					.HasColumnName("EquipmentAssignation_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentAssignationUserId).HasColumnName("EquipmentAssignation_UserId");

				entity.Property(e => e.EquipmentAssignationUserName)
					.HasColumnName("EquipmentAssignation_UserName")
					.HasMaxLength(50);

				entity.HasOne(d => d.EquipmentAssignationEquipment)
					.WithMany(p => p.EquipmentAssignation)
					.HasForeignKey(d => d.EquipmentAssignationEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentAssignation_EquipmentId");

				entity.HasOne(d => d.EquipmentAssignationUser)
					.WithMany(p => p.EquipmentAssignation)
					.HasForeignKey(d => d.EquipmentAssignationUserId)
					.HasConstraintName("FK_EquipmentAssignation_UserId");
			});

			modelBuilder.Entity<EquipmentAssignationHistory>(entity =>
			{
				entity.Property(e => e.EquipmentAssignationHistoryId).HasColumnName("EquipmentAssignationHistory_Id");

				entity.Property(e => e.EquipmentAssignationHistoryEndDate).HasColumnName("EquipmentAssignationHistory_EndDate");

				entity.Property(e => e.EquipmentAssignationHistoryEquipmentName)
					.IsRequired()
					.HasColumnName("EquipmentAssignationHistory_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentAssignationHistoryStartDate).HasColumnName("EquipmentAssignationHistory_StartDate");

				entity.Property(e => e.EquipmentAssignationHistoryUserName)
					.HasColumnName("EquipmentAssignationHistory_UserName")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<EquipmentAttribute>(entity =>
			{
				entity.HasIndex(e => new { e.EquipmentAttributeValue, e.EquipmentAttributeEquipmentId, e.EquipmentAttributeId, e.EquipmentAttributeAttributeId })
					.HasName("INDX_EquipmentAttribute_EqpId_Id_AttributeId");

				entity.Property(e => e.EquipmentAttributeId).HasColumnName("EquipmentAttribute_Id");

				entity.Property(e => e.EquipmentAttributeAttributeId).HasColumnName("EquipmentAttribute_AttributeId");

				entity.Property(e => e.EquipmentAttributeEquipmentId).HasColumnName("EquipmentAttribute_EquipmentId");

				entity.Property(e => e.EquipmentAttributeUpdatedBy).HasColumnName("EquipmentAttribute_UpdatedBy");

				entity.Property(e => e.EquipmentAttributeUpdatedDate).HasColumnName("EquipmentAttribute_UpdatedDate");

				entity.Property(e => e.EquipmentAttributeValue)
					.HasColumnName("EquipmentAttribute_Value")
					.HasMaxLength(255);

				entity.HasOne(d => d.EquipmentAttributeAttribute)
					.WithMany(p => p.EquipmentAttribute)
					.HasForeignKey(d => d.EquipmentAttributeAttributeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentAttribute_Attribute");

				entity.HasOne(d => d.EquipmentAttributeEquipment)
					.WithMany(p => p.EquipmentAttribute)
					.HasForeignKey(d => d.EquipmentAttributeEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentAttribute_Equipment");
			});

			modelBuilder.Entity<EquipmentAttributeHistory>(entity =>
			{
				entity.Property(e => e.EquipmentAttributeHistoryId).HasColumnName("EquipmentAttributeHistory_Id");

				entity.Property(e => e.EquipmentAttributeHistoryAttributeId).HasColumnName("EquipmentAttributeHistory_AttributeId");

				entity.Property(e => e.EquipmentAttributeHistoryAttributeName)
					.IsRequired()
					.HasColumnName("EquipmentAttributeHistory_AttributeName")
					.HasMaxLength(250);

				entity.Property(e => e.EquipmentAttributeHistoryEquipmentId).HasColumnName("EquipmentAttributeHistory_EquipmentId");

				entity.Property(e => e.EquipmentAttributeHistoryEquipmentName)
					.IsRequired()
					.HasColumnName("EquipmentAttributeHistory_EquipmentName")
					.HasMaxLength(250);

				entity.Property(e => e.EquipmentAttributeHistoryLastUpdatedBy).HasColumnName("EquipmentAttributeHistory_LastUpdatedBy");

				entity.Property(e => e.EquipmentAttributeHistoryTimestamp).HasColumnName("EquipmentAttributeHistory_Timestamp");

				entity.Property(e => e.EquipmentAttributeHistoryValue)
					.HasColumnName("EquipmentAttributeHistory_Value")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<EquipmentBusinessRule>(entity =>
			{
				entity.Property(e => e.EquipmentBusinessRuleId).HasColumnName("EquipmentBusinessRule_Id");

				entity.Property(e => e.EquipmentBusinessRuleBusinessRuleId).HasColumnName("EquipmentBusinessRule_BusinessRuleId");

				entity.Property(e => e.EquipmentBusinessRuleEquipmentId).HasColumnName("EquipmentBusinessRule_EquipmentId");

				entity.HasOne(d => d.EquipmentBusinessRuleBusinessRule)
					.WithMany(p => p.EquipmentBusinessRule)
					.HasForeignKey(d => d.EquipmentBusinessRuleBusinessRuleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentBusinessRule_BusinessRule");

				entity.HasOne(d => d.EquipmentBusinessRuleEquipment)
					.WithMany(p => p.EquipmentBusinessRule)
					.HasForeignKey(d => d.EquipmentBusinessRuleEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentBusinessRule_Equipment");
			});

			modelBuilder.Entity<EquipmentComment>(entity =>
			{
				entity.Property(e => e.EquipmentCommentId).HasColumnName("EquipmentComment_Id");

				entity.Property(e => e.EquipmentCommentComment)
					.IsRequired()
					.HasColumnName("EquipmentComment_Comment")
					.HasMaxLength(4000);

				entity.Property(e => e.EquipmentCommentCommentAddedByUserId).HasColumnName("EquipmentComment_CommentAddedByUserId");

				entity.Property(e => e.EquipmentCommentCommentCreatedDate).HasColumnName("EquipmentComment_CommentCreatedDate");

				entity.Property(e => e.EquipmentCommentEquipmentId).HasColumnName("EquipmentComment_EquipmentId");

				entity.Property(e => e.EquipmentCommentFileName)
					.HasColumnName("EquipmentComment_FileName")
					.HasMaxLength(255);

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.EquipmentCommentCommentAddedByUser)
					.WithMany(p => p.EquipmentComment)
					.HasForeignKey(d => d.EquipmentCommentCommentAddedByUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentComment_User");

				entity.HasOne(d => d.EquipmentCommentEquipment)
					.WithMany(p => p.EquipmentComment)
					.HasForeignKey(d => d.EquipmentCommentEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentComment_Equipment");
			});

			modelBuilder.Entity<EquipmentCostCenterHistory>(entity =>
			{
				entity.Property(e => e.EquipmentCostCenterHistoryId).HasColumnName("EquipmentCostCenterHistory_Id");

				entity.Property(e => e.EquipmentCostCenterHistoryByUser)
					.HasColumnName("EquipmentCostCenterHistory_ByUser")
					.HasMaxLength(100);

				entity.Property(e => e.EquipmentCostCenterHistoryCostCenterId).HasColumnName("EquipmentCostCenterHistory_CostCenterId");

				entity.Property(e => e.EquipmentCostCenterHistoryEquipmentId).HasColumnName("EquipmentCostCenterHistory_EquipmentId");

				entity.Property(e => e.EquipmentCostCenterHistoryUpdateTime).HasColumnName("EquipmentCostCenterHistory_UpdateTime");

				entity.HasOne(d => d.EquipmentCostCenterHistoryCostCenter)
					.WithMany(p => p.EquipmentCostCenterHistory)
					.HasForeignKey(d => d.EquipmentCostCenterHistoryCostCenterId)
					.HasConstraintName("FK_EquipmentCostCenterHistory_CostCenter");

				entity.HasOne(d => d.EquipmentCostCenterHistoryEquipment)
					.WithMany(p => p.EquipmentCostCenterHistory)
					.HasForeignKey(d => d.EquipmentCostCenterHistoryEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentCostCenterHistory_Equipment");
			});

			modelBuilder.Entity<EquipmentCurrentState>(entity =>
			{
				entity.Property(e => e.EquipmentCurrentStateId).HasColumnName("EquipmentCurrentState_Id");

				entity.Property(e => e.EquipmentCurrentStateEquipmentId).HasColumnName("EquipmentCurrentState_EquipmentId");

				entity.Property(e => e.EquipmentCurrentStateEquipmentName)
					.IsRequired()
					.HasColumnName("EquipmentCurrentState_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentCurrentStateState)
					.HasColumnName("EquipmentCurrentState_State")
					.HasMaxLength(50);

				entity.HasOne(d => d.EquipmentCurrentStateEquipment)
					.WithMany(p => p.EquipmentCurrentState)
					.HasForeignKey(d => d.EquipmentCurrentStateEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentCurrentState_EquipmentId");
			});

			modelBuilder.Entity<EquipmentDocumentMembers>(entity =>
			{
				entity.Property(e => e.EquipmentDocumentMembersId).HasColumnName("EquipmentDocumentMembers_Id");

				entity.Property(e => e.EquipmentDocumentMembersDocumentVersionId).HasColumnName("EquipmentDocumentMembers_DocumentVersionId");

				entity.Property(e => e.EquipmentDocumentMembersEquipmentId).HasColumnName("EquipmentDocumentMembers_EquipmentId");

				entity.HasOne(d => d.EquipmentDocumentMembersDocumentVersion)
					.WithMany(p => p.EquipmentDocumentMembers)
					.HasForeignKey(d => d.EquipmentDocumentMembersDocumentVersionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentDocumentMembers_DocumentVersion");

				entity.HasOne(d => d.EquipmentDocumentMembersEquipment)
					.WithMany(p => p.EquipmentDocumentMembers)
					.HasForeignKey(d => d.EquipmentDocumentMembersEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentDocumentMembers_Equipment");
			});

			modelBuilder.Entity<EquipmentFeeder>(entity =>
			{
				entity.Property(e => e.EquipmentFeederId).HasColumnName("EquipmentFeeder_Id");

				entity.Property(e => e.EquipmentFeederEquipmentId).HasColumnName("EquipmentFeeder_EquipmentId");

				entity.Property(e => e.EquipmentFeederFeederId).HasColumnName("EquipmentFeeder_FeederId");

				entity.HasOne(d => d.EquipmentFeederEquipment)
					.WithMany(p => p.EquipmentFeederEquipmentFeederEquipment)
					.HasForeignKey(d => d.EquipmentFeederEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentFeeder_EquipmentId");

				entity.HasOne(d => d.EquipmentFeederFeeder)
					.WithMany(p => p.EquipmentFeederEquipmentFeederFeeder)
					.HasForeignKey(d => d.EquipmentFeederFeederId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentFeeder_FeederId");
			});

			modelBuilder.Entity<EquipmentGroup>(entity =>
			{
				entity.Property(e => e.EquipmentGroupId).HasColumnName("EquipmentGroup_Id");

				entity.Property(e => e.EquipmentGroupChildId).HasColumnName("EquipmentGroup_ChildId");

				entity.Property(e => e.EquipmentGroupDescription)
					.HasColumnName("EquipmentGroup_Description")
					.HasMaxLength(255);

				entity.Property(e => e.EquipmentGroupName)
					.IsRequired()
					.HasColumnName("EquipmentGroup_Name")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentGroupParentId).HasColumnName("EquipmentGroup_Parent_Id");

				entity.Property(e => e.EquipmentGroupReferenceId).HasColumnName("EquipmentGroup_ReferenceId");

				entity.Property(e => e.EquipmentGroupSubId).HasColumnName("EquipmentGroup_SubId");

				entity.Property(e => e.EquipmentGroupTypeId).HasColumnName("EquipmentGroup_TypeId");

				entity.Property(e => e.IsActive)
					.IsRequired()
					.HasColumnName("Is_Active")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<EquipmentGroupAssociation>(entity =>
			{
				entity.Property(e => e.EquipmentGroupAssociationId).HasColumnName("EquipmentGroupAssociation_Id");

				entity.Property(e => e.EquipmentGroupAssociationAssociatedParentId).HasColumnName("EquipmentGroupAssociation_AssociatedParentId");

				entity.Property(e => e.EquipmentGroupAssociationEquipmentGroupId).HasColumnName("EquipmentGroupAssociation_EquipmentGroupId");

				entity.HasOne(d => d.EquipmentGroupAssociationEquipmentGroup)
					.WithMany(p => p.EquipmentGroupAssociation)
					.HasForeignKey(d => d.EquipmentGroupAssociationEquipmentGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentGroupAssociation_EquipmentGroup");
			});

			modelBuilder.Entity<EquipmentLocationHistory>(entity =>
			{
				entity.Property(e => e.EquipmentLocationHistoryId).HasColumnName("EquipmentLocationHistory_Id");

				entity.Property(e => e.EquipmentLocationHistoryByUser)
					.HasColumnName("EquipmentLocationHistory_ByUser")
					.HasMaxLength(100);

				entity.Property(e => e.EquipmentLocationHistoryEquipmentId).HasColumnName("EquipmentLocationHistory_EquipmentId");

				entity.Property(e => e.EquipmentLocationHistoryLocationId).HasColumnName("EquipmentLocationHistory_LocationId");

				entity.Property(e => e.EquipmentLocationHistoryUpdateTime).HasColumnName("EquipmentLocationHistory_UpdateTime");

				entity.HasOne(d => d.EquipmentLocationHistoryEquipment)
					.WithMany(p => p.EquipmentLocationHistory)
					.HasForeignKey(d => d.EquipmentLocationHistoryEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentLocationHistory_Equipment");

				entity.HasOne(d => d.EquipmentLocationHistoryLocation)
					.WithMany(p => p.EquipmentLocationHistory)
					.HasForeignKey(d => d.EquipmentLocationHistoryLocationId)
					.HasConstraintName("FK_EquipmentLocationHistory_Location");
			});

			modelBuilder.Entity<EquipmentMeter>(entity =>
			{
				entity.HasIndex(e => new { e.EquipmentMeterEquipmentId, e.EquipmentMeterName })
					.HasName("UK_EquipmentMeter_EquipmentId_Name")
					.IsUnique();

				entity.Property(e => e.EquipmentMeterId).HasColumnName("EquipmentMeter_Id");

				entity.Property(e => e.EquipmentMeterAvgRocInTime).HasColumnName("EquipmentMeter_AvgRocInTime");

				entity.Property(e => e.EquipmentMeterAvgRocInValue).HasColumnName("EquipmentMeter_AvgRocInValue");

				entity.Property(e => e.EquipmentMeterEquipmentId).HasColumnName("EquipmentMeter_EquipmentId");

				entity.Property(e => e.EquipmentMeterLastReading).HasColumnName("EquipmentMeter_LastReading");

				entity.Property(e => e.EquipmentMeterLastReadingTimeStamp).HasColumnName("EquipmentMeter_LastReadingTimeStamp");

				entity.Property(e => e.EquipmentMeterMaxValue).HasColumnName("EquipmentMeter_MaxValue");

				entity.Property(e => e.EquipmentMeterMinValue).HasColumnName("EquipmentMeter_MinValue");

				entity.Property(e => e.EquipmentMeterName)
					.IsRequired()
					.HasColumnName("EquipmentMeter_Name")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentMeterParameters).HasColumnName("EquipmentMeter_Parameters");

				entity.Property(e => e.EquipmentMeterTotalNumberOfReadings).HasColumnName("EquipmentMeter_TotalNumberOfReadings");

				entity.Property(e => e.EquipmentMeterType).HasColumnName("EquipmentMeter_Type");

				entity.Property(e => e.EquipmentMeterUom)
					.HasColumnName("EquipmentMeter_UOM")
					.HasMaxLength(20);

				entity.Property(e => e.EquipmentMeterValue).HasColumnName("EquipmentMeter_Value");

				entity.HasOne(d => d.EquipmentMeterEquipment)
					.WithMany(p => p.EquipmentMeter)
					.HasForeignKey(d => d.EquipmentMeterEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentMeter_EquipmentId");
			});

			modelBuilder.Entity<EquipmentMeterHistory>(entity =>
			{
				entity.HasIndex(e => new { e.EquipmentMeterHistoryMeterId, e.EquipmentMeterHistoryValue })
					.HasName("INDX_EquipmentMeterHistory_MeterId_value");

				entity.Property(e => e.EquipmentMeterHistoryId).HasColumnName("EquipmentMeterHistory_Id");

				entity.Property(e => e.EquipmentMeterHistoryAvgRocInTime).HasColumnName("EquipmentMeterHistory_AvgRocInTime");

				entity.Property(e => e.EquipmentMeterHistoryAvgRocInValue).HasColumnName("EquipmentMeterHistory_AvgRocInValue");

				entity.Property(e => e.EquipmentMeterHistoryLastReading).HasColumnName("EquipmentMeterHistory_LastReading");

				entity.Property(e => e.EquipmentMeterHistoryLastReadingTimeStamp).HasColumnName("EquipmentMeterHistory_LastReadingTimeStamp");

				entity.Property(e => e.EquipmentMeterHistoryMaxValue).HasColumnName("EquipmentMeterHistory_MaxValue");

				entity.Property(e => e.EquipmentMeterHistoryMeterId).HasColumnName("EquipmentMeterHistory_MeterId");

				entity.Property(e => e.EquipmentMeterHistoryMinValue).HasColumnName("EquipmentMeterHistory_MinValue");

				entity.Property(e => e.EquipmentMeterHistoryName)
					.IsRequired()
					.HasColumnName("EquipmentMeterHistory_Name")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentMeterHistoryParameters).HasColumnName("EquipmentMeterHistory_Parameters");

				entity.Property(e => e.EquipmentMeterHistoryTimeStamp).HasColumnName("EquipmentMeterHistory_TimeStamp");

				entity.Property(e => e.EquipmentMeterHistoryTotalNumberOfReadings).HasColumnName("EquipmentMeterHistory_TotalNumberOfReadings");

				entity.Property(e => e.EquipmentMeterHistoryType).HasColumnName("EquipmentMeterHistory_Type");

				entity.Property(e => e.EquipmentMeterHistoryUom)
					.HasColumnName("EquipmentMeterHistory_UOM")
					.HasMaxLength(20);

				entity.Property(e => e.EquipmentMeterHistoryValue).HasColumnName("EquipmentMeterHistory_Value");

				entity.HasOne(d => d.EquipmentMeterHistoryMeter)
					.WithMany(p => p.EquipmentMeterHistory)
					.HasForeignKey(d => d.EquipmentMeterHistoryMeterId)
					.HasConstraintName("FK_EquipmentMeterHistory_MeterId");
			});

			modelBuilder.Entity<EquipmentMeterHistoryArchive>(entity =>
			{
				entity.ToTable("EquipmentMeterHistory_Archive");

				entity.Property(e => e.EquipmentMeterHistoryArchiveId).HasColumnName("EquipmentMeterHistory_Archive_Id");

				entity.Property(e => e.EquipmentMeterHistoryArchiveAvgRocInTime).HasColumnName("EquipmentMeterHistory_Archive_AvgRocInTime");

				entity.Property(e => e.EquipmentMeterHistoryArchiveAvgRocInValue).HasColumnName("EquipmentMeterHistory_Archive_AvgRocInValue");

				entity.Property(e => e.EquipmentMeterHistoryArchiveLastReading).HasColumnName("EquipmentMeterHistory_Archive_LastReading");

				entity.Property(e => e.EquipmentMeterHistoryArchiveLastReadingTimeStamp).HasColumnName("EquipmentMeterHistory_Archive_LastReadingTimeStamp");

				entity.Property(e => e.EquipmentMeterHistoryArchiveMaxValue).HasColumnName("EquipmentMeterHistory_Archive_MaxValue");

				entity.Property(e => e.EquipmentMeterHistoryArchiveMeterId).HasColumnName("EquipmentMeterHistory_Archive_MeterId");

				entity.Property(e => e.EquipmentMeterHistoryArchiveMinValue).HasColumnName("EquipmentMeterHistory_Archive_MinValue");

				entity.Property(e => e.EquipmentMeterHistoryArchiveName)
					.IsRequired()
					.HasColumnName("EquipmentMeterHistory_Archive_Name")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentMeterHistoryArchiveParameters).HasColumnName("EquipmentMeterHistory_Archive_Parameters");

				entity.Property(e => e.EquipmentMeterHistoryArchiveTimeStamp).HasColumnName("EquipmentMeterHistory_Archive_TimeStamp");

				entity.Property(e => e.EquipmentMeterHistoryArchiveTotalNumberOfReadings).HasColumnName("EquipmentMeterHistory_Archive_TotalNumberOfReadings");

				entity.Property(e => e.EquipmentMeterHistoryArchiveType).HasColumnName("EquipmentMeterHistory_Archive_Type");

				entity.Property(e => e.EquipmentMeterHistoryArchiveUom)
					.HasColumnName("EquipmentMeterHistory_Archive_UOM")
					.HasMaxLength(20);

				entity.Property(e => e.EquipmentMeterHistoryArchiveValue).HasColumnName("EquipmentMeterHistory_Archive_Value");
			});

			modelBuilder.Entity<EquipmentPartGroupMembers>(entity =>
			{
				entity.Property(e => e.EquipmentPartGroupMembersId).HasColumnName("EquipmentPartGroupMembers_Id");

				entity.Property(e => e.EquipmentPartGroupMembersEquipmentId).HasColumnName("EquipmentPartGroupMembers_EquipmentId");

				entity.Property(e => e.EquipmentPartGroupMembersPartGroupId).HasColumnName("EquipmentPartGroupMembers_PartGroupId");

				entity.HasOne(d => d.EquipmentPartGroupMembersEquipment)
					.WithMany(p => p.EquipmentPartGroupMembers)
					.HasForeignKey(d => d.EquipmentPartGroupMembersEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentPartGroupMembers_Equipment");

				entity.HasOne(d => d.EquipmentPartGroupMembersPartGroup)
					.WithMany(p => p.EquipmentPartGroupMembers)
					.HasForeignKey(d => d.EquipmentPartGroupMembersPartGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentPartGroupMembers_PartGroup");
			});

			modelBuilder.Entity<EquipmentPicture>(entity =>
			{
				entity.Property(e => e.EquipmentPictureId).HasColumnName("EquipmentPicture_Id");

				entity.Property(e => e.EquipmentPictureAngle).HasColumnName("EquipmentPicture_Angle");

				entity.Property(e => e.EquipmentPictureEquipmentId).HasColumnName("EquipmentPicture_EquipmentId");

				entity.Property(e => e.EquipmentPictureHeight).HasColumnName("EquipmentPicture_Height");

				entity.Property(e => e.EquipmentPictureImage)
					.HasColumnName("EquipmentPicture_Image")
					.HasMaxLength(255);

				entity.Property(e => e.EquipmentPictureWidth).HasColumnName("EquipmentPicture_Width");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");

				entity.HasOne(d => d.EquipmentPictureEquipment)
					.WithMany(p => p.EquipmentPicture)
					.HasForeignKey(d => d.EquipmentPictureEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentPicture_EquipmentId");
			});

			modelBuilder.Entity<EquipmentReasonCodeGroupMembers>(entity =>
			{
				entity.HasIndex(e => new { e.EquipmentReasonCodeGroupMembersEquipmentId, e.EquipmentReasonCodeGroupMembersRcgfor, e.EquipmentReasonCodeGroupMembersRcgid })
					.HasName("INDX_EquipmentReasonCodeGroupMembers_RCG");

				entity.Property(e => e.EquipmentReasonCodeGroupMembersId)
					.HasColumnName("EquipmentReasonCodeGroupMembers_Id")
					.HasComment("Note:-  This table will allow multiple reason code groups to be selected for different Screens");

				entity.Property(e => e.EquipmentReasonCodeGroupMembersEquipmentId).HasColumnName("EquipmentReasonCodeGroupMembers_EquipmentId");

				entity.Property(e => e.EquipmentReasonCodeGroupMembersRcgfor)
					.HasColumnName("EquipmentReasonCodeGroupMembers_RCGFor")
					.HasComment("New MO, Cancel MO, New RT, Cancel MT - Reason Code Group to be displayed during Maintenance order Creation, cancellation, Repair Ticket Creation & cancellation");

				entity.Property(e => e.EquipmentReasonCodeGroupMembersRcgid)
					.HasColumnName("EquipmentReasonCodeGroupMembers_RCGId")
					.HasComment("Reason Code Group");

				entity.HasOne(d => d.EquipmentReasonCodeGroupMembersEquipment)
					.WithMany(p => p.EquipmentReasonCodeGroupMembers)
					.HasForeignKey(d => d.EquipmentReasonCodeGroupMembersEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentReasonCodeGroupMembers_Equipment");

				entity.HasOne(d => d.EquipmentReasonCodeGroupMembersRcg)
					.WithMany(p => p.EquipmentReasonCodeGroupMembers)
					.HasForeignKey(d => d.EquipmentReasonCodeGroupMembersRcgid)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EquipmentReasonCodeGroupMembers_ReasonCodeGroup");
			});

			modelBuilder.Entity<EquipmentState>(entity =>
			{
				entity.Property(e => e.EquipmentStateId).HasColumnName("EquipmentState_Id");

				entity.Property(e => e.EquipmentStateDescription)
					.HasColumnName("EquipmentState_Description")
					.HasMaxLength(255);

				entity.Property(e => e.EquipmentStateName)
					.IsRequired()
					.HasColumnName("EquipmentState_Name")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<EquipmentStateHistory>(entity =>
			{
				entity.Property(e => e.EquipmentStateHistoryId).HasColumnName("EquipmentStateHistory_Id");

				entity.Property(e => e.EquipmentStateHistoryEndDate).HasColumnName("EquipmentStateHistory_EndDate");

				entity.Property(e => e.EquipmentStateHistoryEquipmentName)
					.IsRequired()
					.HasColumnName("EquipmentStateHistory_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentStateHistoryStartDate).HasColumnName("EquipmentStateHistory_StartDate");

				entity.Property(e => e.EquipmentStateHistoryState)
					.HasColumnName("EquipmentStateHistory_State")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<EscalationLevel>(entity =>
			{
				entity.Property(e => e.EscalationLevelId).HasColumnName("EscalationLevel_Id");

				entity.Property(e => e.EscalationLevelIsActive).HasColumnName("EscalationLevel_IsActive");

				entity.Property(e => e.EscalationLevelName)
					.IsRequired()
					.HasColumnName("EscalationLevel_Name")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<EscalationNotificationUserGroupMembers>(entity =>
			{
				entity.Property(e => e.EscalationNotificationUserGroupMembersId)
					.HasColumnName("EscalationNotificationUserGroupMembers_Id")
					.HasComment("Auto generated sequence number, This table is used to store  escalation notification and usergroup settings for every User");

				entity.Property(e => e.EscalationNotificationUserGroupMembersCreatedBy)
					.IsRequired()
					.HasColumnName("EscalationNotificationUserGroupMembers_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.EscalationNotificationUserGroupMembersCreatedDate).HasColumnName("EscalationNotificationUserGroupMembers_CreatedDate");

				entity.Property(e => e.EscalationNotificationUserGroupMembersEscalationLevel)
					.HasColumnName("EscalationNotificationUserGroupMembers_EscalationLevel")
					.HasComment("Describes levels of escalation - 1 : Level1, 2 : Level2, 3 : Level3");

				entity.Property(e => e.EscalationNotificationUserGroupMembersGroupId).HasColumnName("EscalationNotificationUserGroupMembers_GroupId");

				entity.Property(e => e.EscalationNotificationUserGroupMembersIsNotify)
					.HasColumnName("EscalationNotificationUserGroupMembers_IsNotify")
					.HasComment("Whether Notification to be sent or not to particular User - Y or N");

				entity.Property(e => e.EscalationNotificationUserGroupMembersUserId).HasColumnName("EscalationNotificationUserGroupMembers_UserId");

				entity.HasOne(d => d.EscalationNotificationUserGroupMembersGroup)
					.WithMany(p => p.EscalationNotificationUserGroupMembers)
					.HasForeignKey(d => d.EscalationNotificationUserGroupMembersGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EscalationNotificationUserGroupMembers_UserGroup");

				entity.HasOne(d => d.EscalationNotificationUserGroupMembersUser)
					.WithMany(p => p.EscalationNotificationUserGroupMembers)
					.HasForeignKey(d => d.EscalationNotificationUserGroupMembersUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EscalationNotificationUserGroupMembers_User");
			});

			modelBuilder.Entity<EscalationProcess>(entity =>
			{
				entity.Property(e => e.EscalationProcessId).HasColumnName("EscalationProcess_Id");

				entity.Property(e => e.EscalationProcessName)
					.HasColumnName("EscalationProcess_Name")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<EscalationProcessLevel>(entity =>
			{
				entity.Property(e => e.EscalationProcessLevelId)
					.HasColumnName("EscalationProcessLevel_Id")
					.ValueGeneratedNever();

				entity.Property(e => e.EscalationProcessLevelEscalationLevelId).HasColumnName("EscalationProcessLevel_EscalationLevelId");

				entity.Property(e => e.EscalationProcessLevelEscalationProcessId).HasColumnName("EscalationProcessLevel_EscalationProcessId");

				entity.Property(e => e.EscalationProcessLevelEscalationTime)
					.HasColumnName("EscalationProcessLevel_EscalationTime")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.EscalationProcessLevelIsNotify).HasColumnName("EscalationProcessLevel_IsNotify");

				entity.HasOne(d => d.EscalationProcessLevelEscalationLevel)
					.WithMany(p => p.EscalationProcessLevel)
					.HasForeignKey(d => d.EscalationProcessLevelEscalationLevelId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EscalationProcessLevel_EscalationLevel");

				entity.HasOne(d => d.EscalationProcessLevelEscalationProcess)
					.WithMany(p => p.EscalationProcessLevel)
					.HasForeignKey(d => d.EscalationProcessLevelEscalationProcessId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_EscalationProcessLevel_EscalationProcess");
			});

			modelBuilder.Entity<ExtfeederParameters>(entity =>
			{
				entity.ToTable("EXTFeederParameters");

				entity.Property(e => e.ExtfeederParametersId).HasColumnName("EXTFeederParameters_Id");

				entity.Property(e => e.ExtfeederParametersMeterHistoryId).HasColumnName("EXTFeederParameters_MeterHistoryId");

				entity.Property(e => e.ExtfeederParametersPickupError).HasColumnName("EXTFeederParameters_Pickup_Error");

				entity.Property(e => e.ExtfeederParametersPickupMiss).HasColumnName("EXTFeederParameters_Pickup_Miss");

				entity.Property(e => e.ExtfeederParametersPlacementCount).HasColumnName("EXTFeederParameters_Placement_Count");

				entity.Property(e => e.ExtfeederParametersRecognitionError).HasColumnName("EXTFeederParameters_Recognition_Error");

				entity.Property(e => e.ExtfeederParametersShapeError).HasColumnName("EXTFeederParameters_Shape_Error");

				entity.HasOne(d => d.ExtfeederParametersMeterHistory)
					.WithMany(p => p.ExtfeederParameters)
					.HasForeignKey(d => d.ExtfeederParametersMeterHistoryId)
					.HasConstraintName("FK_EXTFeederParameters_MeterHistoryID");
			});

			modelBuilder.Entity<Extu20nozzleCleanUnit>(entity =>
			{
				entity.ToTable("EXTU20NozzleCleanUnit");

				entity.Property(e => e.Extu20nozzleCleanUnitId).HasColumnName("EXTU20NozzleCleanUnit_Id");

				entity.Property(e => e.Extu20nozzleCleanUnitCleanStatus).HasColumnName("EXTU20NozzleCleanUnit_CleanStatus");

				entity.Property(e => e.Extu20nozzleCleanUnitEquipmentId).HasColumnName("EXTU20NozzleCleanUnit_EquipmentId");

				entity.Property(e => e.Extu20nozzleCleanUnitEquipmentName)
					.HasColumnName("EXTU20NozzleCleanUnit_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleCleanUnitMoId).HasColumnName("EXTU20NozzleCleanUnit_MoId");

				entity.Property(e => e.Extu20nozzleCleanUnitMoNumber)
					.HasColumnName("EXTU20NozzleCleanUnit_MoNumber")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleCleanUnitNozzleType)
					.HasColumnName("EXTU20NozzleCleanUnit_NozzleType")
					.HasMaxLength(10);

				entity.Property(e => e.Extu20nozzleCleanUnitRecordedDate).HasColumnName("EXTU20NozzleCleanUnit_RecordedDate");

				entity.Property(e => e.Extu20nozzleCleanUnitSerialNumber)
					.HasColumnName("EXTU20NozzleCleanUnit_SerialNumber")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleCleanUnitTestUnitSerialNumber)
					.HasColumnName("EXTU20NozzleCleanUnit_TestUnitSerialNumber")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleCleanUnitUnitUsageTime)
					.HasColumnName("EXTU20NozzleCleanUnit_UnitUsageTime")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<Extu20nozzleImage>(entity =>
			{
				entity.ToTable("EXTU20NozzleImage");

				entity.Property(e => e.Extu20nozzleImageId).HasColumnName("EXTU20NozzleImage_Id");

				entity.Property(e => e.Extu20nozzleImageEquipmentId).HasColumnName("EXTU20NozzleImage_EquipmentId");

				entity.Property(e => e.Extu20nozzleImageEquipmentName)
					.HasColumnName("EXTU20NozzleImage_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleImageInspectionStatus).HasColumnName("EXTU20NozzleImage_InspectionStatus");

				entity.Property(e => e.Extu20nozzleImageMoId).HasColumnName("EXTU20NozzleImage_MoId");

				entity.Property(e => e.Extu20nozzleImageMoNumber)
					.HasColumnName("EXTU20NozzleImage_MoNumber")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleImageRecordedDate).HasColumnName("EXTU20NozzleImage_RecordedDate");

				entity.Property(e => e.Extu20nozzleImageSerialNumber)
					.HasColumnName("EXTU20NozzleImage_SerialNumber")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<Extu20nozzleInspectionUnit>(entity =>
			{
				entity.ToTable("EXTU20NozzleInspectionUnit");

				entity.Property(e => e.Extu20nozzleInspectionUnitId).HasColumnName("EXTU20NozzleInspectionUnit_Id");

				entity.Property(e => e.Extu20nozzleInspectionUnitEquipmentId).HasColumnName("EXTU20NozzleInspectionUnit_EquipmentId");

				entity.Property(e => e.Extu20nozzleInspectionUnitEquipmentName)
					.HasColumnName("EXTU20NozzleInspectionUnit_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleInspectionUnitMoId).HasColumnName("EXTU20NozzleInspectionUnit_MoId");

				entity.Property(e => e.Extu20nozzleInspectionUnitMoNumber)
					.HasColumnName("EXTU20NozzleInspectionUnit_MoNumber")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleInspectionUnitNozzleStatus).HasColumnName("EXTU20NozzleInspectionUnit_NozzleStatus");

				entity.Property(e => e.Extu20nozzleInspectionUnitNozzleType)
					.HasColumnName("EXTU20NozzleInspectionUnit_NozzleType")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleInspectionUnitRecordedDate).HasColumnName("EXTU20NozzleInspectionUnit_RecordedDate");

				entity.Property(e => e.Extu20nozzleInspectionUnitSerialNumber)
					.HasColumnName("EXTU20NozzleInspectionUnit_SerialNumber")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleInspectionUnitTestUnitSerialNumber)
					.HasColumnName("EXTU20NozzleInspectionUnit_TestUnitSerialNumber")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleInspectionUnitUnitUsageTime)
					.HasColumnName("EXTU20NozzleInspectionUnit_UnitUsageTime")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<Extu20nozzleVacuum>(entity =>
			{
				entity.ToTable("EXTU20NozzleVacuum");

				entity.Property(e => e.Extu20nozzleVacuumId).HasColumnName("EXTU20NozzleVacuum_Id");

				entity.Property(e => e.Extu20nozzleVacuumAirLeakStatus)
					.HasColumnName("EXTU20NozzleVacuum_AirLeakStatus")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.Extu20nozzleVacuumAirLeakThreshold)
					.HasColumnName("EXTU20NozzleVacuum_AirLeakThreshold")
					.HasColumnType("numeric(18, 2)");

				entity.Property(e => e.Extu20nozzleVacuumAirLeakValue)
					.HasColumnName("EXTU20NozzleVacuum_AirLeakValue")
					.HasColumnType("numeric(18, 2)");

				entity.Property(e => e.Extu20nozzleVacuumAirStuffStatus)
					.HasColumnName("EXTU20NozzleVacuum_AirStuffStatus")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.Extu20nozzleVacuumAirStuffThreshold)
					.HasColumnName("EXTU20NozzleVacuum_AirStuffThreshold")
					.HasColumnType("numeric(18, 2)");

				entity.Property(e => e.Extu20nozzleVacuumAirStuffValue)
					.HasColumnName("EXTU20NozzleVacuum_AirStuffValue")
					.HasColumnType("numeric(18, 2)");

				entity.Property(e => e.Extu20nozzleVacuumEquipmentId).HasColumnName("EXTU20NozzleVacuum_EquipmentId");

				entity.Property(e => e.Extu20nozzleVacuumEquipmentName)
					.HasColumnName("EXTU20NozzleVacuum_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleVacuumMoId).HasColumnName("EXTU20NozzleVacuum_MoId");

				entity.Property(e => e.Extu20nozzleVacuumMoNumber)
					.HasColumnName("EXTU20NozzleVacuum_MoNumber")
					.HasMaxLength(50);

				entity.Property(e => e.Extu20nozzleVacuumRecordedDate).HasColumnName("EXTU20NozzleVacuum_RecordedDate");

				entity.Property(e => e.Extu20nozzleVacuumSerialNumber)
					.HasColumnName("EXTU20NozzleVacuum_SerialNumber")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<FactoryCalendar>(entity =>
			{
				entity.Property(e => e.AreaId).HasColumnName("AreaID");

				entity.Property(e => e.EndTime)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.Event)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.EventColor)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.EventDescription).HasMaxLength(100);

				entity.Property(e => e.Reason)
					.IsRequired()
					.HasMaxLength(100);

				entity.Property(e => e.StartTime)
					.IsRequired()
					.HasMaxLength(100);
			});

			modelBuilder.Entity<FactoryHour>(entity =>
			{
				entity.Property(e => e.FactoryHourId).HasColumnName("FactoryHour_Id");
			});

			modelBuilder.Entity<FeederGroup>(entity =>
			{
				entity.Property(e => e.FeederStartsWithText).HasMaxLength(50);
			});

			modelBuilder.Entity<FeederMonitor>(entity =>
			{
				entity.HasNoKey();

				entity.ToView("FeederMonitor");

				entity.Property(e => e.AlertOverallStatus)
					.HasColumnName("Alert_OverallStatus")
					.HasMaxLength(34);

				entity.Property(e => e.AreaEquipmentMembersSequenceNumber).HasColumnName("AreaEquipmentMembers_SequenceNumber");

				entity.Property(e => e.AreaId).HasColumnName("Area_Id");

				entity.Property(e => e.AreaName)
					.IsRequired()
					.HasColumnName("Area_Name")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentId).HasColumnName("Equipment_Id");

				entity.Property(e => e.EquipmentMachineCounter)
					.HasColumnName("Equipment_MachineCounter")
					.HasMaxLength(30);

				entity.Property(e => e.EquipmentMeterName)
					.IsRequired()
					.HasColumnName("EquipmentMeter_Name")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentName)
					.IsRequired()
					.HasColumnName("Equipment_Name")
					.HasMaxLength(80);

				entity.Property(e => e.EquipmentSerialNumber)
					.HasColumnName("Equipment_SerialNumber")
					.HasMaxLength(50);

				entity.Property(e => e.EquipmentSubType).HasColumnName("Equipment_SubType");

				entity.Property(e => e.HiddenTimeTillSchedDate)
					.HasColumnName("Hidden_TimeTillSchedDate")
					.HasColumnType("numeric(38, 14)");

				entity.Property(e => e.MaintenanceEventTypeName)
					.HasColumnName("MaintenanceEventType_Name")
					.HasMaxLength(50);

				entity.Property(e => e.MaintenanceOrderNumber)
					.HasColumnName("MaintenanceOrder_Number")
					.HasMaxLength(50);

				entity.Property(e => e.MaintenanceOrderPlannedDueDate).HasColumnName("MaintenanceOrder_PlannedDueDate");

				entity.Property(e => e.MaintenanceOrderScheduledDate).HasColumnName("MaintenanceOrder_ScheduledDate");

				entity.Property(e => e.MaintenanceOrderTitle)
					.HasColumnName("MaintenanceOrder_Title")
					.HasMaxLength(100);

				entity.Property(e => e.MoResourcesScanOnDateTime).HasColumnName("MoResources_ScanOnDateTime");

				entity.Property(e => e.NozzleSize)
					.HasColumnName("Nozzle_Size")
					.HasMaxLength(50);

				entity.Property(e => e.NozzleType)
					.HasColumnName("Nozzle_type")
					.HasMaxLength(50);

				entity.Property(e => e.Ordercol).HasColumnName("ordercol");

				entity.Property(e => e.Priority)
					.HasMaxLength(8)
					.IsUnicode(false);

				entity.Property(e => e.ReasonCodeName)
					.HasColumnName("ReasonCode_Name")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketNumber)
					.HasColumnName("RepairTicket_Number")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketTitle)
					.HasColumnName("RepairTicket_Title")
					.HasMaxLength(512);

				entity.Property(e => e.Status)
					.HasMaxLength(10)
					.IsUnicode(false);

				entity.Property(e => e.TicketsDisplayed)
					.IsRequired()
					.HasColumnName("Tickets_Displayed")
					.HasMaxLength(21)
					.IsUnicode(false);

				entity.Property(e => e.TimeScheduledDueDate).HasColumnName("Time_ScheduledDueDate");

				entity.Property(e => e.TotalPickupCount)
					.HasColumnName("Total_Pickup_count")
					.HasMaxLength(30);
			});

			modelBuilder.Entity<FeederTagConfiguration>(entity =>
			{
				entity.Property(e => e.AttrType).HasColumnName("Attr_Type");

				entity.Property(e => e.EnableCount).HasColumnName("Enable_Count");

				entity.Property(e => e.EnableTime).HasColumnName("Enable_Time");

				entity.Property(e => e.MahinceFamily).HasColumnName("Mahince_Family");

				entity.Property(e => e.TagCondition)
					.HasColumnName("Tag_Condition")
					.HasColumnType("decimal(18, 0)");

				entity.Property(e => e.TagCount).HasColumnName("Tag_Count");

				entity.Property(e => e.TagPickupErrorRatio)
					.HasColumnName("Tag_Pickup_Error_Ratio")
					.HasColumnType("decimal(18, 2)");

				entity.Property(e => e.TagPickupMissRatio)
					.HasColumnName("Tag_Pickup_Miss_Ratio")
					.HasColumnType("decimal(18, 2)");

				entity.Property(e => e.TagPlacementCountRatio)
					.HasColumnName("Tag_Placement_Count_Ratio")
					.HasColumnType("decimal(18, 2)");

				entity.Property(e => e.TagRecognitionErrorRatio)
					.HasColumnName("Tag_Recognition_Error_Ratio")
					.HasColumnType("decimal(18, 2)");

				entity.Property(e => e.TagShapeErrorRatio)
					.HasColumnName("Tag_Shape_Error_Ratio")
					.HasColumnType("decimal(18, 2)");

				entity.Property(e => e.TagTime)
					.HasColumnName("Tag_Time")
					.HasColumnType("decimal(18, 2)");
			});

			modelBuilder.Entity<Floor>(entity =>
			{
				entity.Property(e => e.FloorId).HasColumnName("Floor_Id");

				entity.Property(e => e.FloorBuildingId).HasColumnName("Floor_BuildingId");

				entity.Property(e => e.FloorLevel).HasColumnName("Floor_Level");

				entity.HasOne(d => d.FloorBuilding)
					.WithMany(p => p.Floor)
					.HasForeignKey(d => d.FloorBuildingId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Floor_Building");
			});

			modelBuilder.Entity<FloorAreaMembers>(entity =>
			{
				entity.Property(e => e.FloorAreaMembersId).HasColumnName("FloorAreaMembers_Id");

				entity.Property(e => e.FloorAreaMembersAreaId).HasColumnName("FloorAreaMembers_AreaId");

				entity.Property(e => e.FloorAreaMembersFloorId).HasColumnName("FloorAreaMembers_FloorId");

				entity.HasOne(d => d.FloorAreaMembersArea)
					.WithMany(p => p.FloorAreaMembers)
					.HasForeignKey(d => d.FloorAreaMembersAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_FloorAreaMembers_Area");

				entity.HasOne(d => d.FloorAreaMembersFloor)
					.WithMany(p => p.FloorAreaMembers)
					.HasForeignKey(d => d.FloorAreaMembersFloorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_FloorAreaMembers_Floor");
			});

			modelBuilder.Entity<Gridcolumnmapping>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("gridcolumnmapping");

				entity.Property(e => e.GridcolumnmappingColumndisplayname)
					.IsRequired()
					.HasColumnName("gridcolumnmapping_columndisplayname")
					.HasMaxLength(50);

				entity.Property(e => e.GridcolumnmappingColumnname)
					.IsRequired()
					.HasColumnName("gridcolumnmapping_columnname")
					.HasMaxLength(50);

				entity.Property(e => e.GridcolumnmappingGridname)
					.IsRequired()
					.HasColumnName("gridcolumnmapping_gridname")
					.HasMaxLength(50);

				entity.Property(e => e.GridcolumnmappingId)
					.HasColumnName("gridcolumnmapping_id")
					.ValueGeneratedOnAdd();

				entity.Property(e => e.GridcolumnmappingSelected).HasColumnName("gridcolumnmapping_selected");

				entity.Property(e => e.GridcolumnmappingType)
					.IsRequired()
					.HasColumnName("gridcolumnmapping_type")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<ImportData>(entity =>
			{
				entity.Property(e => e.ImportDataId).HasColumnName("ImportData_Id");

				entity.Property(e => e.ImportDataEntityType).HasColumnName("ImportData_EntityType");

				entity.Property(e => e.ImportDataFileName)
					.IsRequired()
					.HasColumnName("ImportData_FileName")
					.HasMaxLength(100);

				entity.Property(e => e.ImportDataState)
					.IsRequired()
					.HasColumnName("ImportData_State")
					.HasMaxLength(20);

				entity.Property(e => e.ImportDataTimeStamp).HasColumnName("ImportData_TimeStamp");

				entity.Property(e => e.ImportDataUser)
					.IsRequired()
					.HasColumnName("ImportData_User")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<ImportLog>(entity =>
			{
				entity.Property(e => e.ImportLogId).HasColumnName("ImportLog_ID");

				entity.Property(e => e.ImportLogEntityType).HasColumnName("ImportLog_EntityType");

				entity.Property(e => e.ImportLogErrorDetails).HasColumnName("ImportLog_ErrorDetails");

				entity.Property(e => e.ImportLogFileName).HasColumnName("ImportLog_FileName");

				entity.Property(e => e.ImportLogImportedRecords).HasColumnName("ImportLog_ImportedRecords");

				entity.Property(e => e.ImportLogIntegrationId).HasColumnName("ImportLog_IntegrationId");

				entity.Property(e => e.ImportLogLastRun).HasColumnName("ImportLog_LastRun");

				entity.Property(e => e.ImportLogRun).HasColumnName("ImportLog_Run");

				entity.Property(e => e.ImportLogStatus)
					.IsRequired()
					.HasColumnName("ImportLog_Status")
					.HasMaxLength(20);

				entity.Property(e => e.ImportLogTotalRecords).HasColumnName("ImportLog_TotalRecords");

				entity.Property(e => e.ImportLogUser)
					.IsRequired()
					.HasColumnName("ImportLog_User")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<IntIntegrationServer>(entity =>
			{
				entity.Property(e => e.IntIntegrationServerId).HasColumnName("IntIntegrationServer_Id");

				entity.Property(e => e.IntIntegrationServerDescription)
					.HasColumnName("IntIntegrationServer_Description")
					.HasMaxLength(255);

				entity.Property(e => e.IntIntegrationServerMessageQueueHostName)
					.HasColumnName("IntIntegrationServer_MessageQueueHostName")
					.HasMaxLength(50);

				entity.Property(e => e.IntIntegrationServerName)
					.IsRequired()
					.HasColumnName("IntIntegrationServer_Name")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<IntIntegrationServerRuleConfiguration>(entity =>
			{
				entity.Property(e => e.IntIntegrationServerRuleConfigurationId).HasColumnName("IntIntegrationServerRuleConfiguration_Id");

				entity.Property(e => e.IntIntegrationServerRuleConfigurationIntIntegrationServerId).HasColumnName("IntIntegrationServerRuleConfiguration_IntIntegrationServerId");

				entity.Property(e => e.IntIntegrationServerRuleConfigurationIntRuleConfigurationId).HasColumnName("IntIntegrationServerRuleConfiguration_IntRuleConfigurationId");

				entity.HasOne(d => d.IntIntegrationServerRuleConfigurationIntIntegrationServer)
					.WithMany(p => p.IntIntegrationServerRuleConfiguration)
					.HasForeignKey(d => d.IntIntegrationServerRuleConfigurationIntIntegrationServerId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_IntIntegrationServerRuleConfiguration_IntIntegrationServerId");

				entity.HasOne(d => d.IntIntegrationServerRuleConfigurationIntRuleConfiguration)
					.WithMany(p => p.IntIntegrationServerRuleConfiguration)
					.HasForeignKey(d => d.IntIntegrationServerRuleConfigurationIntRuleConfigurationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_IntIntegrationServerRuleConfiguration_IntRuleConfigurationId");
			});

			modelBuilder.Entity<IntPublishHost>(entity =>
			{
				entity.Property(e => e.IntPublishHostId).HasColumnName("IntPublishHost_Id");

				entity.Property(e => e.IntPublishHostHostName)
					.IsRequired()
					.HasColumnName("IntPublishHost_HostName")
					.HasMaxLength(50);

				entity.Property(e => e.IntPublishHostPort)
					.HasColumnName("IntPublishHost_Port")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<IntPublishList>(entity =>
			{
				entity.Property(e => e.IntPublishListId).HasColumnName("IntPublishList_Id");

				entity.Property(e => e.IntPublishListDescription)
					.HasColumnName("IntPublishList_Description")
					.HasMaxLength(255);

				entity.Property(e => e.IntPublishListName)
					.IsRequired()
					.HasColumnName("IntPublishList_Name")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<IntPublishListAction>(entity =>
			{
				entity.Property(e => e.IntPublishListActionId).HasColumnName("IntPublishListAction_Id");

				entity.Property(e => e.IntPublishListActionDescription)
					.HasColumnName("IntPublishListAction_Description")
					.HasMaxLength(255);

				entity.Property(e => e.IntPublishListActionIntPublishListId).HasColumnName("IntPublishListAction_IntPublishListId");

				entity.Property(e => e.IntPublishListActionIsPublished).HasColumnName("IntPublishListAction_IsPublished");

				entity.Property(e => e.IntPublishListActionName)
					.IsRequired()
					.HasColumnName("IntPublishListAction_Name")
					.HasMaxLength(50);

				entity.HasOne(d => d.IntPublishListActionIntPublishList)
					.WithMany(p => p.IntPublishListAction)
					.HasForeignKey(d => d.IntPublishListActionIntPublishListId)
					.HasConstraintName("FK_IntPublishListAction_PublishListId");
			});

			modelBuilder.Entity<IntRuleConfiguration>(entity =>
			{
				entity.Property(e => e.IntRuleConfigurationId).HasColumnName("IntRuleConfiguration_Id");

				entity.Property(e => e.IntRuleConfigurationAssemblyName).HasColumnName("IntRuleConfiguration_AssemblyName");

				entity.Property(e => e.IntRuleConfigurationDescription)
					.HasColumnName("IntRuleConfiguration_Description")
					.HasMaxLength(255);

				entity.Property(e => e.IntRuleConfigurationIntegrationId).HasColumnName("IntRuleConfiguration_IntegrationID");

				entity.Property(e => e.IntRuleConfigurationLogLevels)
					.HasColumnName("IntRuleConfiguration_LogLevels")
					.HasMaxLength(50);

				entity.Property(e => e.IntRuleConfigurationName)
					.IsRequired()
					.HasColumnName("IntRuleConfiguration_Name")
					.HasMaxLength(50);

				entity.Property(e => e.IntRuleConfigurationProduct)
					.HasColumnName("IntRuleConfiguration_Product")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<IntRuleConfigurationAdapters>(entity =>
			{
				entity.Property(e => e.IntRuleConfigurationAdaptersId).HasColumnName("IntRuleConfigurationAdapters_Id");

				entity.Property(e => e.IntRuleConfigurationAdaptersHeartBeatFrequency)
					.HasColumnName("IntRuleConfigurationAdapters_HeartBeatFrequency")
					.HasMaxLength(100)
					.HasDefaultValueSql("((30))");

				entity.Property(e => e.IntRuleConfigurationAdaptersHeartbeat)
					.HasColumnName("IntRuleConfigurationAdapters_Heartbeat")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IntRuleConfigurationAdaptersHostName)
					.HasColumnName("IntRuleConfigurationAdapters_HostName")
					.HasMaxLength(100);

				entity.Property(e => e.IntRuleConfigurationAdaptersIntRuleConfigurationId).HasColumnName("IntRuleConfigurationAdapters_IntRuleConfigurationId");

				entity.Property(e => e.IntRuleConfigurationAdaptersIwait).HasColumnName("IntRuleConfigurationAdapters_Iwait");

				entity.Property(e => e.IntRuleConfigurationAdaptersIwaitEvent)
					.HasColumnName("IntRuleConfigurationAdapters_IwaitEvent")
					.HasMaxLength(100);

				entity.Property(e => e.IntRuleConfigurationAdaptersIwaitType)
					.HasColumnName("IntRuleConfigurationAdapters_IwaitType")
					.HasMaxLength(200);

				entity.Property(e => e.IntRuleConfigurationAdaptersMaptoDrive)
					.HasColumnName("IntRuleConfigurationAdapters_MaptoDrive")
					.HasMaxLength(255);

				entity.Property(e => e.IntRuleConfigurationAdaptersName)
					.IsRequired()
					.HasColumnName("IntRuleConfigurationAdapters_Name")
					.HasMaxLength(100);

				entity.Property(e => e.IntRuleConfigurationAdaptersPassword)
					.HasColumnName("IntRuleConfigurationAdapters_Password")
					.HasMaxLength(100);

				entity.Property(e => e.IntRuleConfigurationAdaptersPort).HasColumnName("IntRuleConfigurationAdapters_Port");

				entity.Property(e => e.IntRuleConfigurationAdaptersProcessbacklog)
					.HasColumnName("IntRuleConfigurationAdapters_Processbacklog")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IntRuleConfigurationAdaptersType).HasColumnName("IntRuleConfigurationAdapters_Type");

				entity.Property(e => e.IntRuleConfigurationAdaptersUserName)
					.HasColumnName("IntRuleConfigurationAdapters_UserName")
					.HasMaxLength(100);

				entity.HasOne(d => d.IntRuleConfigurationAdaptersIntRuleConfiguration)
					.WithMany(p => p.IntRuleConfigurationAdapters)
					.HasForeignKey(d => d.IntRuleConfigurationAdaptersIntRuleConfigurationId)
					.HasConstraintName("FK_IntRuleConfigurationAdapters_IntRuleConfigurationId");
			});

			modelBuilder.Entity<IntRuleConfigurationDependentAssemblies>(entity =>
			{
				entity.Property(e => e.IntRuleConfigurationDependentAssembliesId).HasColumnName("IntRuleConfigurationDependentAssemblies_Id");

				entity.Property(e => e.IntRuleConfigurationDependentAssembliesDependentAssembly).HasColumnName("IntRuleConfigurationDependentAssemblies_DependentAssembly");

				entity.Property(e => e.IntRuleConfigurationDependentAssembliesIntRuleConfigurationId).HasColumnName("IntRuleConfigurationDependentAssemblies_IntRuleConfigurationId");

				entity.HasOne(d => d.IntRuleConfigurationDependentAssembliesIntRuleConfiguration)
					.WithMany(p => p.IntRuleConfigurationDependentAssemblies)
					.HasForeignKey(d => d.IntRuleConfigurationDependentAssembliesIntRuleConfigurationId)
					.OnDelete(DeleteBehavior.Cascade)
					.HasConstraintName("FK_IntRuleConfigurationDependentAssemblies_IntRuleConfigurationId");
			});

			modelBuilder.Entity<IntRuleConfigurationParameters>(entity =>
			{
				entity.Property(e => e.IntRuleConfigurationParametersId).HasColumnName("IntRuleConfigurationParameters_Id");

				entity.Property(e => e.IntRuleConfigurationParametersIntRuleConfigurationId).HasColumnName("IntRuleConfigurationParameters_IntRuleConfigurationId");

				entity.Property(e => e.IntRuleConfigurationParametersMandatory)
					.HasColumnName("IntRuleConfigurationParameters_Mandatory")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.IntRuleConfigurationParametersName)
					.IsRequired()
					.HasColumnName("IntRuleConfigurationParameters_Name")
					.HasMaxLength(100);

				entity.Property(e => e.IntRuleConfigurationParametersValue).HasColumnName("IntRuleConfigurationParameters_Value");

				entity.HasOne(d => d.IntRuleConfigurationParametersIntRuleConfiguration)
					.WithMany(p => p.IntRuleConfigurationParameters)
					.HasForeignKey(d => d.IntRuleConfigurationParametersIntRuleConfigurationId)
					.HasConstraintName("FK_IntRuleConfigurationParameters_IntRuleConfigurationId");
			});

			modelBuilder.Entity<Integration>(entity =>
			{
				entity.Property(e => e.IntegrationId).HasColumnName("Integration_ID");

				entity.Property(e => e.IntegrationName)
					.IsRequired()
					.HasColumnName("Integration_Name")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<IntegrationAttribute>(entity =>
			{
				entity.Property(e => e.IntegrationAttributeId).HasColumnName("IntegrationAttribute_ID");

				entity.Property(e => e.IntegrationAttributeIntegrationId).HasColumnName("IntegrationAttribute_IntegrationID");

				entity.Property(e => e.IntegrationAttributeMandatory)
					.HasColumnName("IntegrationAttribute_Mandatory")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.IntegrationAttributeName)
					.IsRequired()
					.HasColumnName("IntegrationAttribute_Name")
					.HasMaxLength(50);

				entity.Property(e => e.IntegrationAttributeReference)
					.HasColumnName("IntegrationAttribute_Reference")
					.HasMaxLength(255);

				entity.Property(e => e.IntegrationAttributeType).HasColumnName("IntegrationAttribute_Type");

				entity.Property(e => e.IntegrationAttributeValue).HasColumnName("IntegrationAttribute_Value");

				entity.HasOne(d => d.IntegrationAttributeIntegration)
					.WithMany(p => p.IntegrationAttribute)
					.HasForeignKey(d => d.IntegrationAttributeIntegrationId)
					.HasConstraintName("FK_IntegrationAttribute_IntegrationID");
			});

			modelBuilder.Entity<IntegrationImportEntites>(entity =>
			{
				entity.Property(e => e.IntegrationImportEntitesId).HasColumnName("IntegrationImportEntites_ID");

				entity.Property(e => e.IntegrationImportEntitesEntityName)
					.IsRequired()
					.HasColumnName("IntegrationImportEntites_EntityName")
					.HasMaxLength(50);

				entity.Property(e => e.IntegrationImportEntitesEntityType).HasColumnName("IntegrationImportEntites_EntityType");

				entity.Property(e => e.IntegrationImportEntitesIntegrationId).HasColumnName("IntegrationImportEntites_IntegrationID");

				entity.HasOne(d => d.IntegrationImportEntitesIntegration)
					.WithMany(p => p.IntegrationImportEntites)
					.HasForeignKey(d => d.IntegrationImportEntitesIntegrationId)
					.HasConstraintName("FK_IntegrationImportEntites_IntegrationID");
			});

			modelBuilder.Entity<InventorySchedules>(entity =>
			{
				entity.HasKey(e => e.InventoryScheduleId);

				entity.Property(e => e.InventoryScheduleId).HasColumnName("InventorySchedule_Id");

				entity.Property(e => e.InventoryScheduleCreatedDate).HasColumnName("InventorySchedule_CreatedDate");

				entity.Property(e => e.InventoryScheduleCreatedUser).HasColumnName("InventorySchedule_CreatedUser");

				entity.Property(e => e.InventoryScheduleCurrentDueDate).HasColumnName("InventorySchedule_CurrentDueDate");

				entity.Property(e => e.InventoryScheduleCycleCountTmplld).HasColumnName("InventorySchedule_CycleCountTmplld");

				entity.Property(e => e.InventoryScheduleEndBy).HasColumnName("InventorySchedule_EndBy");

				entity.Property(e => e.InventoryScheduleEveryNthTime).HasColumnName("InventorySchedule_EveryNthTime");

				entity.Property(e => e.InventoryScheduleFirstDue).HasColumnName("InventorySchedule_FirstDue");

				entity.Property(e => e.InventoryScheduleIsDeleted).HasColumnName("InventorySchedule_IsDeleted");

				entity.Property(e => e.InventoryScheduleLastUpdatedBy).HasColumnName("InventorySchedule_LastUpdatedBy");

				entity.Property(e => e.InventoryScheduleLastUpdatedTimeStamp).HasColumnName("InventorySchedule_LastUpdatedTimeStamp");

				entity.Property(e => e.InventoryScheduleMonthlyDate).HasColumnName("InventorySchedule_MonthlyDate");

				entity.Property(e => e.InventoryScheduleRecurrenceType).HasColumnName("InventorySchedule_RecurrenceType");

				entity.Property(e => e.InventoryScheduleScheduleTimeOfDay).HasColumnName("InventorySchedule_ScheduleTimeOfDay");

				entity.Property(e => e.InventoryScheduleWeeklyDay).HasColumnName("InventorySchedule_WeeklyDay");

				entity.Property(e => e.InventoryScheduleYearlyDay).HasColumnName("InventorySchedule_YearlyDay");

				entity.Property(e => e.InventoryScheduleYearlyMonth).HasColumnName("InventorySchedule_YearlyMonth");

				entity.HasOne(d => d.InventoryScheduleCreatedUserNavigation)
					.WithMany(p => p.InventorySchedulesInventoryScheduleCreatedUserNavigation)
					.HasForeignKey(d => d.InventoryScheduleCreatedUser)
					.HasConstraintName("FK_InventorySchedules_User");

				entity.HasOne(d => d.InventoryScheduleCycleCountTmplldNavigation)
					.WithMany(p => p.InventorySchedules)
					.HasForeignKey(d => d.InventoryScheduleCycleCountTmplld)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_InventorySchedules_CycleCount");

				entity.HasOne(d => d.InventoryScheduleLastUpdatedByNavigation)
					.WithMany(p => p.InventorySchedulesInventoryScheduleLastUpdatedByNavigation)
					.HasForeignKey(d => d.InventoryScheduleLastUpdatedBy)
					.HasConstraintName("FK_InventorySchedules_LastUpdatedBy");
			});

			modelBuilder.Entity<InventoryTurnLevel>(entity =>
			{
				entity.Property(e => e.Level)
					.IsRequired()
					.HasMaxLength(50);
			});

			modelBuilder.Entity<KnowledgeBase>(entity =>
			{
				entity.Property(e => e.KnowledgeBaseId).HasColumnName("KnowledgeBase_Id");

				entity.Property(e => e.KnowledgeBaseControlFlag).HasColumnName("KnowledgeBase_ControlFlag");

				entity.Property(e => e.KnowledgeBaseDetailedDescription).HasColumnName("KnowledgeBase_DetailedDescription");

				entity.Property(e => e.KnowledgeBaseImage)
					.HasColumnName("KnowledgeBase_Image")
					.HasMaxLength(510);

				entity.Property(e => e.KnowledgeBaseIsDeleted).HasColumnName("KnowledgeBase_IsDeleted");

				entity.Property(e => e.KnowledgeBasePrimaryGroupId).HasColumnName("KnowledgeBase_PrimaryGroupId");

				entity.Property(e => e.KnowledgeBaseReferenceId).HasColumnName("KnowledgeBase_ReferenceId");

				entity.Property(e => e.KnowledgeBaseSearchContent).HasColumnName("KnowledgeBase_SearchContent");

				entity.Property(e => e.KnowledgeBaseSecondaryGroupId).HasColumnName("KnowledgeBase_SecondaryGroupId");

				entity.Property(e => e.KnowledgeBaseSubGroupId).HasColumnName("KnowledgeBase_SubGroupId");

				entity.Property(e => e.KnowledgeBaseSummary)
					.HasColumnName("KnowledgeBase_Summary")
					.HasMaxLength(255);

				entity.Property(e => e.KnowledgeBaseTitle)
					.IsRequired()
					.HasColumnName("KnowledgeBase_Title")
					.HasMaxLength(100);
			});

			modelBuilder.Entity<KnowledgeBaseCheckList>(entity =>
			{
				entity.Property(e => e.KnowledgeBaseCheckListId).HasColumnName("KnowledgeBaseCheckList_Id");

				entity.Property(e => e.CheckListId).HasColumnName("CheckList_Id");

				entity.Property(e => e.CheckListType).HasColumnName("CheckList_Type");

				entity.Property(e => e.KnowledgeBaseId).HasColumnName("KnowledgeBase_Id");

				entity.HasOne(d => d.KnowledgeBase)
					.WithMany(p => p.KnowledgeBaseCheckList)
					.HasForeignKey(d => d.KnowledgeBaseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseCheckList_KnowledgeBase_Id");
			});

			modelBuilder.Entity<KnowledgeBaseDocument>(entity =>
			{
				entity.Property(e => e.KnowledgeBaseDocumentId).HasColumnName("KnowledgeBaseDocument_Id");

				entity.Property(e => e.DocumentId).HasColumnName("Document_Id");

				entity.Property(e => e.KnowledgeBaseId).HasColumnName("KnowledgeBase_Id");

				entity.HasOne(d => d.Document)
					.WithMany(p => p.KnowledgeBaseDocument)
					.HasForeignKey(d => d.DocumentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseDocument_Document_Id");

				entity.HasOne(d => d.KnowledgeBase)
					.WithMany(p => p.KnowledgeBaseDocument)
					.HasForeignKey(d => d.KnowledgeBaseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseDocument_KnowledgeBase_Id");
			});

			modelBuilder.Entity<KnowledgeBaseEquipment>(entity =>
			{
				entity.Property(e => e.KnowledgeBaseEquipmentId).HasColumnName("KnowledgeBaseEquipment_Id");

				entity.Property(e => e.EquipmentId).HasColumnName("Equipment_Id");

				entity.Property(e => e.KnowledgeBaseId).HasColumnName("KnowledgeBase_Id");

				entity.HasOne(d => d.Equipment)
					.WithMany(p => p.KnowledgeBaseEquipment)
					.HasForeignKey(d => d.EquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseEquipment_Equipment_Id");

				entity.HasOne(d => d.KnowledgeBase)
					.WithMany(p => p.KnowledgeBaseEquipment)
					.HasForeignKey(d => d.KnowledgeBaseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseEquipment_KnowledgeBase_Id");
			});

			modelBuilder.Entity<KnowledgeBaseMaintenanceOrder>(entity =>
			{
				entity.Property(e => e.KnowledgeBaseMaintenanceOrderId).HasColumnName("KnowledgeBaseMaintenanceOrder_Id");

				entity.Property(e => e.KnowledgeBaseId).HasColumnName("KnowledgeBase_Id");

				entity.Property(e => e.MaintenanceOrderId).HasColumnName("MaintenanceOrder_Id");

				entity.HasOne(d => d.KnowledgeBase)
					.WithMany(p => p.KnowledgeBaseMaintenanceOrder)
					.HasForeignKey(d => d.KnowledgeBaseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseMaintenanceOrder_KnowledgeBase_Id");

				entity.HasOne(d => d.MaintenanceOrder)
					.WithMany(p => p.KnowledgeBaseMaintenanceOrder)
					.HasForeignKey(d => d.MaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseMaintenanceOrder_MaintenanceOrder_Id");
			});

			modelBuilder.Entity<KnowledgeBaseMultiMedia>(entity =>
			{
				entity.Property(e => e.KnowledgeBaseMultiMediaId).HasColumnName("KnowledgeBaseMultiMedia_Id");

				entity.Property(e => e.KnowledgeBaseId).HasColumnName("KnowledgeBase_Id");

				entity.Property(e => e.MultiMediaFileId).HasColumnName("MultiMediaFile_Id");

				entity.HasOne(d => d.KnowledgeBase)
					.WithMany(p => p.KnowledgeBaseMultiMedia)
					.HasForeignKey(d => d.KnowledgeBaseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseMultiMedia_KnowledgeBase_Id");

				entity.HasOne(d => d.MultiMediaFile)
					.WithMany(p => p.KnowledgeBaseMultiMedia)
					.HasForeignKey(d => d.MultiMediaFileId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseMultiMedia_MultiMediaFile_Id");
			});

			modelBuilder.Entity<KnowledgeBaseRepairTicket>(entity =>
			{
				entity.Property(e => e.KnowledgeBaseRepairTicketId).HasColumnName("KnowledgeBaseRepairTicket_Id");

				entity.Property(e => e.KnowledgeBaseId).HasColumnName("KnowledgeBase_Id");

				entity.Property(e => e.RepairTicketId).HasColumnName("RepairTicket_Id");

				entity.HasOne(d => d.KnowledgeBase)
					.WithMany(p => p.KnowledgeBaseRepairTicket)
					.HasForeignKey(d => d.KnowledgeBaseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseRepairTicket_KnowledgeBase_Id");

				entity.HasOne(d => d.RepairTicket)
					.WithMany(p => p.KnowledgeBaseRepairTicket)
					.HasForeignKey(d => d.RepairTicketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseRepairTicket_RepairTicket_Id");
			});

			modelBuilder.Entity<KnowledgeBaseSparePart>(entity =>
			{
				entity.Property(e => e.KnowledgeBaseSparePartId).HasColumnName("KnowledgeBaseSparePart_Id");

				entity.Property(e => e.KnowledgeBaseId).HasColumnName("KnowledgeBase_Id");

				entity.Property(e => e.SparePartId).HasColumnName("SparePart_Id");

				entity.HasOne(d => d.KnowledgeBase)
					.WithMany(p => p.KnowledgeBaseSparePart)
					.HasForeignKey(d => d.KnowledgeBaseId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseSparePart_KnowledgeBase_Id");

				entity.HasOne(d => d.SparePart)
					.WithMany(p => p.KnowledgeBaseSparePart)
					.HasForeignKey(d => d.SparePartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_KnowledgeBaseSparePart_SparePart_Id");
			});

			modelBuilder.Entity<LicenseDetails>(entity =>
			{
				entity.Property(e => e.LicenseDetailsId).HasColumnName("LicenseDetails_Id");

				entity.Property(e => e.LicenseDetailsAppliedBy).HasColumnName("LicenseDetails_AppliedBy");

				entity.Property(e => e.LicenseDetailsAppliedOn).HasColumnName("LicenseDetails_AppliedOn");

				entity.Property(e => e.LicenseDetailsHostKey)
					.IsRequired()
					.HasColumnName("LicenseDetails_HostKey")
					.HasMaxLength(50);

				entity.Property(e => e.LicenseDetailsLicenseString)
					.IsRequired()
					.HasColumnName("LicenseDetails_LicenseString");

				entity.Property(e => e.LicenseDetailsOrgCode)
					.IsRequired()
					.HasColumnName("LicenseDetails_OrgCode")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<LineDashboardConfig>(entity =>
			{
				entity.Property(e => e.LineDashboardConfigId).HasColumnName("LineDashboardConfig_Id");

				entity.Property(e => e.LineDashboardConfigAreaId).HasColumnName("LineDashboardConfig_AreaId");

				entity.Property(e => e.LineDashboardConfigConfigData)
					.IsRequired()
					.HasColumnName("LineDashboardConfig_ConfigData");

				entity.HasOne(d => d.LineDashboardConfigArea)
					.WithMany(p => p.LineDashboardConfig)
					.HasForeignKey(d => d.LineDashboardConfigAreaId)
					.HasConstraintName("FK_LineDashboardConfig_AreaId");
			});

			modelBuilder.Entity<Literal>(entity =>
			{
				entity.Property(e => e.LiteralId).HasColumnName("Literal_Id");

				entity.Property(e => e.LiteralDescription).HasColumnName("LITERAL_Description");

				entity.Property(e => e.LiteralKey)
					.HasColumnName("LITERAL_KEY")
					.HasMaxLength(500)
					.IsUnicode(false);

				entity.Property(e => e.LiteralLocale)
					.HasColumnName("LITERAL_LOCALE")
					.HasMaxLength(250)
					.IsUnicode(false);

				entity.Property(e => e.LiteralScreenName)
					.HasColumnName("LITERAL_ScreenName")
					.HasMaxLength(200);

				entity.Property(e => e.LiteralValue).HasColumnName("LITERAL_VALUE");
			});

			modelBuilder.Entity<Location>(entity =>
			{
				entity.Property(e => e.LocationId).HasColumnName("Location_Id");

				entity.Property(e => e.LocationControlFlag).HasColumnName("Location_ControlFlag");

				entity.Property(e => e.LocationDescription)
					.HasColumnName("Location_Description")
					.HasMaxLength(255)
					.HasComment("Short description about the location");

				entity.Property(e => e.LocationIsDeleted).HasColumnName("Location_IsDeleted");

				entity.Property(e => e.LocationLocationTypeId)
					.HasColumnName("Location_LocationTypeId")
					.HasComment("Type will refer to Location types created by the user. Reporting can be done based on the location type or Location");

				entity.Property(e => e.LocationName)
					.IsRequired()
					.HasColumnName("Location_Name")
					.HasMaxLength(50)
					.HasComment("Name of the location, Super warehouse, Floor2 Store, Barrel 253, WorkArea store 23");

				entity.Property(e => e.LocationReferenceId).HasColumnName("Location_ReferenceId");

				entity.HasOne(d => d.LocationLocationType)
					.WithMany(p => p.Location)
					.HasForeignKey(d => d.LocationLocationTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Location_LocationType");
			});

			modelBuilder.Entity<LocationType>(entity =>
			{
				entity.Property(e => e.LocationTypeId).HasColumnName("LocationType_Id");

				entity.Property(e => e.LocationTypeControlFlag).HasColumnName("LocationType_ControlFlag");

				entity.Property(e => e.LocationTypeDescription)
					.HasColumnName("LocationType_Description")
					.HasMaxLength(255)
					.HasComment("Description of the location type");

				entity.Property(e => e.LocationTypeIsDeleted).HasColumnName("LocationType_IsDeleted");

				entity.Property(e => e.LocationTypeName)
					.IsRequired()
					.HasColumnName("LocationType_Name")
					.HasMaxLength(50)
					.HasComment("Name of the Location Type.  Customers can create their own location type.  Warehouse, Store, Bin, Barrel");

				entity.Property(e => e.LocationTypeReferenceId).HasColumnName("LocationType_ReferenceId");
			});

			modelBuilder.Entity<MaintenanceEventType>(entity =>
			{
				entity.Property(e => e.MaintenanceEventTypeId)
					.HasColumnName("MaintenanceEventType_Id")
					.HasComment("Note:- Type of the maintenance activitiy.");

				entity.Property(e => e.MaintenanceEventTypeControlFlag).HasColumnName("MaintenanceEventType_ControlFlag");

				entity.Property(e => e.MaintenanceEventTypeDescription)
					.HasColumnName("MaintenanceEventType_Description")
					.HasMaxLength(255);

				entity.Property(e => e.MaintenanceEventTypeIsDeleted).HasColumnName("MaintenanceEventType_IsDeleted");

				entity.Property(e => e.MaintenanceEventTypeName)
					.IsRequired()
					.HasColumnName("MaintenanceEventType_Name")
					.HasMaxLength(50)
					.HasComment("For Ex :Preventive Maintenance, Repair, Production Improvement, Maintenance Improvement");

				entity.Property(e => e.MaintenanceEventTypeReferenceId).HasColumnName("MaintenanceEventType_ReferenceId");
			});

			modelBuilder.Entity<MaintenanceOrder>(entity =>
			{
				entity.HasIndex(e => e.MaintenanceOrderIsModified)
					.HasName("INDX_MaintenanceOrder_ISMODIFIED");

				entity.HasIndex(e => new { e.MaintenanceOrderEquipmentId, e.MaintenanceOrderPlannedDueDate, e.MaintenanceOrderPriority, e.MaintenanceOrderId, e.MaintenanceOrderTitle, e.MaintenanceOrderNumber, e.MaintenanceOrderStatus, e.MaintenanceOrderScheduledDate })
					.HasName("INDX_MaintenanceOrder_ID_TITLE_STATUS_NUM_DATE");

				entity.HasIndex(e => new { e.MaintenanceOrderId, e.MaintenanceOrderScheduledDate, e.MaintenanceOrderPriority, e.MaintenanceOrderTitle, e.MaintenanceOrderRepairTicketId, e.MaintenanceOrderStatus, e.MaintenanceOrderNumber, e.MaintenanceOrderEquipmentId })
					.HasName("INDX_MaintenanceOrder_Staus_Number_EqpId");

				entity.HasIndex(e => new { e.MaintenanceOrderPriority, e.MaintenanceOrderTitle, e.MaintenanceOrderNumber, e.MaintenanceOrderCreatedDate, e.MaintenanceOrderStatus, e.MaintenanceOrderScheduledDate, e.MaintenanceOrderEquipmentId, e.MaintenanceOrderId })
					.HasName("INDX_MaintenanceOrder_ID_EQPID_STATUS_DATE");

				entity.HasIndex(e => new { e.MaintenanceOrderCreatedByUserId, e.MaintenanceOrderIsModified, e.MaintenanceOrderCreatedDate, e.MaintenanceOrderScheduleId, e.MaintenanceOrderCompletedDate, e.MaintenanceOrderEquipmentId, e.MaintenanceOrderId, e.MaintenanceOrderPlannedDueDate, e.MaintenanceOrderScheduledDate, e.MaintenanceOrderReasonCodeId, e.MaintenanceOrderCancelReasonCodeId, e.MaintenanceOrderTemplateId, e.MaintenanceOrderEstimatedOutageInMins, e.MaintenanceOrderPriority, e.MaintenanceOrderDescription, e.MaintenanceOrderCostCenterId, e.MaintenanceOrderTitle, e.MaintenanceOrderMaintenanceEventTypeId, e.MaintenanceOrderStatus, e.MaintenanceOrderNumber, e.MaintenanceOrderRepairTicketId })
					.HasName("INDX_index_MaintenanceOrder_LIST");

				entity.Property(e => e.MaintenanceOrderId).HasColumnName("MaintenanceOrder_Id");

				entity.Property(e => e.MaintenanceOrderBusinessRuleId).HasColumnName("MaintenanceOrder_BusinessRuleId");

				entity.Property(e => e.MaintenanceOrderCancelReasonCodeId).HasColumnName("MaintenanceOrder_CancelReasonCodeId");

				entity.Property(e => e.MaintenanceOrderCompletedDate).HasColumnName("MaintenanceOrder_CompletedDate");

				entity.Property(e => e.MaintenanceOrderCostCenterId).HasColumnName("MaintenanceOrder_CostCenterId");

				entity.Property(e => e.MaintenanceOrderCreatedByUserId)
					.HasColumnName("MaintenanceOrder_CreatedByUserId")
					.HasComment("User created the Maintenance Order");

				entity.Property(e => e.MaintenanceOrderCreatedDate).HasColumnName("MaintenanceOrder_CreatedDate");

				entity.Property(e => e.MaintenanceOrderDescription)
					.HasColumnName("MaintenanceOrder_Description")
					.HasMaxLength(255);

				entity.Property(e => e.MaintenanceOrderEquipmentId)
					.HasColumnName("MaintenanceOrder_EquipmentId")
					.HasComment("Equipment for which this Maintenance Order is created.");

				entity.Property(e => e.MaintenanceOrderEstimatedOutageInMins)
					.HasColumnName("MaintenanceOrder_EstimatedOutageInMins")
					.HasComment("Estimated outage of the equipment.");

				entity.Property(e => e.MaintenanceOrderIsModified)
					.HasColumnName("MaintenanceOrder_IsModified")
					.HasComment("This column will be used for pushing the configuration from a maintenance order template to this maintenance order at a later point of time.  If a MO is modified , the template changes should not be propagated to the MO.");

				entity.Property(e => e.MaintenanceOrderMaintenanceEventTypeId).HasColumnName("MaintenanceOrder_MaintenanceEventTypeId");

				entity.Property(e => e.MaintenanceOrderNumber)
					.HasColumnName("MaintenanceOrder_Number")
					.HasMaxLength(50)
					.HasComment("Autogenerated number MO000021");

				entity.Property(e => e.MaintenanceOrderPlannedDueDate)
					.HasColumnName("MaintenanceOrder_PlannedDueDate")
					.HasComment("Due date by when the maintenance activity should start on this equipment.");

				entity.Property(e => e.MaintenanceOrderPriority)
					.HasColumnName("MaintenanceOrder_Priority")
					.HasComment("Priority of the MO");

				entity.Property(e => e.MaintenanceOrderReasonCodeId)
					.HasColumnName("MaintenanceOrder_ReasonCodeId")
					.HasComment("Reason code for the Maintenance Order.  PM, INSTALL, SETUP");

				entity.Property(e => e.MaintenanceOrderReferenceId).HasColumnName("MaintenanceOrder_ReferenceId");

				entity.Property(e => e.MaintenanceOrderRepairTicketId)
					.HasColumnName("MaintenanceOrder_RepairTicketId")
					.HasComment("Repair ticket id if this MO is created for a Repair Ticket");

				entity.Property(e => e.MaintenanceOrderScheduleId).HasColumnName("MaintenanceOrder_ScheduleId");

				entity.Property(e => e.MaintenanceOrderScheduledDate)
					.HasColumnName("MaintenanceOrder_ScheduledDate")
					.HasComment("Maintenance Supervisor will schedule PM based on the production schedule.  This is a daily activity.  The schedule date will be updated in this column once the MO is scheduled.");

				entity.Property(e => e.MaintenanceOrderStatus)
					.HasColumnName("MaintenanceOrder_Status")
					.HasComment("Status of the Maintenance Order.  New/Planned/Scheduled/Inprogress/Hold/Cancelled/Completed");

				entity.Property(e => e.MaintenanceOrderTemplateId)
					.HasColumnName("MaintenanceOrder_TemplateId")
					.HasComment("MO template id if this MO is created from a template or schedule.");

				entity.Property(e => e.MaintenanceOrderTitle)
					.IsRequired()
					.HasColumnName("MaintenanceOrder_Title")
					.HasMaxLength(100)
					.HasComment("Short title");

				entity.HasOne(d => d.MaintenanceOrderCancelReasonCode)
					.WithMany(p => p.MaintenanceOrderMaintenanceOrderCancelReasonCode)
					.HasForeignKey(d => d.MaintenanceOrderCancelReasonCodeId)
					.HasConstraintName("FK_MaintenanceOrder_CancelReasonCode");

				entity.HasOne(d => d.MaintenanceOrderCostCenter)
					.WithMany(p => p.MaintenanceOrder)
					.HasForeignKey(d => d.MaintenanceOrderCostCenterId)
					.HasConstraintName("FK_MaintenanceOrder_CostCenter");

				entity.HasOne(d => d.MaintenanceOrderCreatedByUser)
					.WithMany(p => p.MaintenanceOrder)
					.HasForeignKey(d => d.MaintenanceOrderCreatedByUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrder_User");

				entity.HasOne(d => d.MaintenanceOrderEquipment)
					.WithMany(p => p.MaintenanceOrder)
					.HasForeignKey(d => d.MaintenanceOrderEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrder_Equipment");

				entity.HasOne(d => d.MaintenanceOrderMaintenanceEventType)
					.WithMany(p => p.MaintenanceOrder)
					.HasForeignKey(d => d.MaintenanceOrderMaintenanceEventTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrder_MaintenanceEventType");

				entity.HasOne(d => d.MaintenanceOrderReasonCode)
					.WithMany(p => p.MaintenanceOrderMaintenanceOrderReasonCode)
					.HasForeignKey(d => d.MaintenanceOrderReasonCodeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrder_ReasonCode");

				entity.HasOne(d => d.MaintenanceOrderRepairTicket)
					.WithMany(p => p.MaintenanceOrder)
					.HasForeignKey(d => d.MaintenanceOrderRepairTicketId)
					.HasConstraintName("FK_MaintenanceOrder_RepairTicket");

				entity.HasOne(d => d.MaintenanceOrderSchedule)
					.WithMany(p => p.MaintenanceOrder)
					.HasForeignKey(d => d.MaintenanceOrderScheduleId)
					.HasConstraintName("FK_MaintenanceOrder_PMSchedule");

				entity.HasOne(d => d.MaintenanceOrderTemplate)
					.WithMany(p => p.MaintenanceOrder)
					.HasForeignKey(d => d.MaintenanceOrderTemplateId)
					.HasConstraintName("FK_MaintenanceOrder_MaintenanceOrderTemplate");
			});

			modelBuilder.Entity<MaintenanceOrderAttribute>(entity =>
			{
				entity.Property(e => e.MaintenanceOrderAttributeId).HasColumnName("MaintenanceOrderAttribute_Id");

				entity.Property(e => e.MaintenanceOrderAttributeAttributeId).HasColumnName("MaintenanceOrderAttribute_AttributeId");

				entity.Property(e => e.MaintenanceOrderAttributeMaintenanceId).HasColumnName("MaintenanceOrderAttribute_MaintenanceId");

				entity.Property(e => e.MaintenanceOrderAttributeValue)
					.HasColumnName("MaintenanceOrderAttribute_Value")
					.HasMaxLength(255);

				entity.HasOne(d => d.MaintenanceOrderAttributeAttribute)
					.WithMany(p => p.MaintenanceOrderAttribute)
					.HasForeignKey(d => d.MaintenanceOrderAttributeAttributeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrderAttribute_Attribute");

				entity.HasOne(d => d.MaintenanceOrderAttributeMaintenance)
					.WithMany(p => p.MaintenanceOrderAttribute)
					.HasForeignKey(d => d.MaintenanceOrderAttributeMaintenanceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrderAttribute_Maintenance");
			});

			modelBuilder.Entity<MaintenanceOrderTemplate>(entity =>
			{
				entity.Property(e => e.MaintenanceOrderTemplateId).HasColumnName("MaintenanceOrderTemplate_Id");

				entity.Property(e => e.MaintenanceOrderTemplateControlFlag).HasColumnName("MaintenanceOrderTemplate_ControlFlag");

				entity.Property(e => e.MaintenanceOrderTemplateCostCenterId)
					.HasColumnName("MaintenanceOrderTemplate_CostCenterId")
					.HasComment("Cost center for this maintenance activity.  This will be populated with the Cost center from the equipment.  Can be changed by the user");

				entity.Property(e => e.MaintenanceOrderTemplateCreatedDate).HasColumnName("MaintenanceOrderTemplate_CreatedDate");

				entity.Property(e => e.MaintenanceOrderTemplateCreatedUser).HasColumnName("MaintenanceOrderTemplate_CreatedUser");

				entity.Property(e => e.MaintenanceOrderTemplateDescription)
					.HasColumnName("MaintenanceOrderTemplate_Description")
					.HasMaxLength(255)
					.HasComment("Short Description of the Maintenance Order template");

				entity.Property(e => e.MaintenanceOrderTemplateEquipmentId)
					.HasColumnName("MaintenanceOrderTemplate_EquipmentId")
					.HasComment("Equipment for which the MOT is being created.  This template will be shared by all the equipments which share the same primary, secondary & subgroup of the equipment configured in this MOT.");

				entity.Property(e => e.MaintenanceOrderTemplateEstimatedOutageInMins)
					.HasColumnName("MaintenanceOrderTemplate_EstimatedOutageInMins")
					.HasComment("Estimated Outage in Mins.");

				entity.Property(e => e.MaintenanceOrderTemplateIsActive)
					.IsRequired()
					.HasColumnName("MaintenanceOrderTemplate_IsActive")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.MaintenanceOrderTemplateMaintenanceEventTypeId)
					.HasColumnName("MaintenanceOrderTemplate_MaintenanceEventTypeId")
					.HasComment("Type of the event.  Possible values could be PM, Repair, Maintenance Improvement, Production Improvement");

				entity.Property(e => e.MaintenanceOrderTemplateNumber)
					.HasColumnName("MaintenanceOrderTemplate_Number")
					.HasMaxLength(50)
					.HasComment("Autogenerated number. Ex : MT00001");

				entity.Property(e => e.MaintenanceOrderTemplatePriority)
					.HasColumnName("MaintenanceOrderTemplate_Priority")
					.HasComment("Priority of the Maintenance Order");

				entity.Property(e => e.MaintenanceOrderTemplateReasonCodeId)
					.HasColumnName("MaintenanceOrderTemplate_ReasonCodeId")
					.HasComment("Reason code for this MO.  Possible values could be INSTALL, SETUP, PROCESS , PM, REPAIR");

				entity.Property(e => e.MaintenanceOrderTemplateReferenceId).HasColumnName("MaintenanceOrderTemplate_ReferenceId");

				entity.Property(e => e.MaintenanceOrderTemplateTitle)
					.IsRequired()
					.HasColumnName("MaintenanceOrderTemplate_Title")
					.HasMaxLength(100)
					.HasComment("Title of the Maintenance Order Template.  \"Weekly PM - Nozzle\"");

				entity.HasOne(d => d.MaintenanceOrderTemplateCostCenter)
					.WithMany(p => p.MaintenanceOrderTemplate)
					.HasForeignKey(d => d.MaintenanceOrderTemplateCostCenterId)
					.HasConstraintName("FK_MaintenanceOrderTemplate_CostCenter");

				entity.HasOne(d => d.MaintenanceOrderTemplateCreatedUserNavigation)
					.WithMany(p => p.MaintenanceOrderTemplate)
					.HasForeignKey(d => d.MaintenanceOrderTemplateCreatedUser)
					.HasConstraintName("FK_MaintenanceOrderTemplate_User");

				entity.HasOne(d => d.MaintenanceOrderTemplateEquipment)
					.WithMany(p => p.MaintenanceOrderTemplate)
					.HasForeignKey(d => d.MaintenanceOrderTemplateEquipmentId)
					.HasConstraintName("FK_MaintenanceOrderTemplate_Equipment");

				entity.HasOne(d => d.MaintenanceOrderTemplateMaintenanceEventType)
					.WithMany(p => p.MaintenanceOrderTemplate)
					.HasForeignKey(d => d.MaintenanceOrderTemplateMaintenanceEventTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrderTemplate_MaintenanceEventType");

				entity.HasOne(d => d.MaintenanceOrderTemplateReasonCode)
					.WithMany(p => p.MaintenanceOrderTemplate)
					.HasForeignKey(d => d.MaintenanceOrderTemplateReasonCodeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrderTemplate_ReasonCode");
			});

			modelBuilder.Entity<MaintenanceOrderTemplateAttribute>(entity =>
			{
				entity.Property(e => e.MaintenanceOrderTemplateAttributeId).HasColumnName("MaintenanceOrderTemplateAttribute_Id");

				entity.Property(e => e.MaintenanceOrderTemplateAttributeAttributeId).HasColumnName("MaintenanceOrderTemplateAttribute_AttributeId");

				entity.Property(e => e.MaintenanceOrderTemplateAttributeMaintenanceId).HasColumnName("MaintenanceOrderTemplateAttribute_MaintenanceId");

				entity.Property(e => e.MaintenanceOrderTemplateAttributeValue)
					.HasColumnName("MaintenanceOrderTemplateAttribute_Value")
					.HasMaxLength(50);

				entity.HasOne(d => d.MaintenanceOrderTemplateAttributeAttribute)
					.WithMany(p => p.MaintenanceOrderTemplateAttribute)
					.HasForeignKey(d => d.MaintenanceOrderTemplateAttributeAttributeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrderTemplateAttribute_Attribute");

				entity.HasOne(d => d.MaintenanceOrderTemplateAttributeMaintenance)
					.WithMany(p => p.MaintenanceOrderTemplateAttribute)
					.HasForeignKey(d => d.MaintenanceOrderTemplateAttributeMaintenanceId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MaintenanceOrderTemplateAttribute_Maintenance");
			});

			modelBuilder.Entity<MaterialMovement>(entity =>
			{
				entity.Property(e => e.MaterialMovementId).HasColumnName("MaterialMovement_Id");

				entity.Property(e => e.MaterialMovementDestinationAreaId).HasColumnName("MaterialMovement_DestinationAreaId");

				entity.Property(e => e.MaterialMovementDestinationBinNo).HasColumnName("MaterialMovement_DestinationBinNo");

				entity.Property(e => e.MaterialMovementDestinationLocationId).HasColumnName("MaterialMovement_DestinationLocationId");

				entity.Property(e => e.MaterialMovementDestinationSubLocationId).HasColumnName("MaterialMovement_DestinationSubLocationId");

				entity.Property(e => e.MaterialMovementPartId).HasColumnName("MaterialMovement_PartId");

				entity.Property(e => e.MaterialMovementQty).HasColumnName("MaterialMovement_Qty");

				entity.Property(e => e.MaterialMovementSourceAreaId).HasColumnName("MaterialMovement_SourceAreaId");

				entity.Property(e => e.MaterialMovementSourceBinNo).HasColumnName("MaterialMovement_SourceBinNo");

				entity.Property(e => e.MaterialMovementSourceLocationId).HasColumnName("MaterialMovement_SourceLocationId");

				entity.Property(e => e.MaterialMovementSourceSubLocationId).HasColumnName("MaterialMovement_SourceSubLocationId");

				entity.Property(e => e.MaterialMovementTransferBy)
					.IsRequired()
					.HasColumnName("MaterialMovement_TransferBy")
					.HasMaxLength(50);

				entity.Property(e => e.MaterialMovementTransferDate).HasColumnName("MaterialMovement_TransferDate");
			});

			modelBuilder.Entity<Mmsintsall>(entity =>
			{
				entity.HasNoKey();

				entity.ToTable("MMSIntsall");

				entity.Property(e => e.InstallDate).HasColumnType("date");

				entity.Property(e => e.InstallId).ValueGeneratedOnAdd();

				entity.Property(e => e.InstallPath).IsRequired();

				entity.Property(e => e.Pguid)
					.IsRequired()
					.HasColumnName("PGUID");

				entity.Property(e => e.ProductVersion).IsRequired();

				entity.Property(e => e.Uguid).HasColumnName("UGUID");
			});

			modelBuilder.Entity<MoCertificationCheckList>(entity =>
			{
				entity.HasOne(d => d.CertificationCheckList)
					.WithMany(p => p.MoCertificationCheckList)
					.HasForeignKey(d => d.CertificationCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoCertificationCheckList_CertificationCheckList");

				entity.HasOne(d => d.DocumentVersion)
					.WithMany(p => p.MoCertificationCheckList)
					.HasForeignKey(d => d.DocumentVersionId)
					.HasConstraintName("FK_MoCertificationCheckList_DocumentVersion");

				entity.HasOne(d => d.MaintenanceOrder)
					.WithMany(p => p.MoCertificationCheckList)
					.HasForeignKey(d => d.MaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoCertificationCheckList_MaintenanceOrder");
			});

			modelBuilder.Entity<MoCertificationCheckListStep>(entity =>
			{
				entity.Property(e => e.CertificationCheckListStepId).HasColumnName("CertificationCheckListStep_Id");

				entity.Property(e => e.MaxValue).HasMaxLength(50);

				entity.Property(e => e.MinValue).HasMaxLength(50);

				entity.Property(e => e.StepDescription)
					.IsRequired()
					.HasMaxLength(1024);

				entity.Property(e => e.Value).HasMaxLength(50);

				entity.HasOne(d => d.CertificationCheckListStep)
					.WithMany(p => p.MoCertificationCheckListStep)
					.HasForeignKey(d => d.CertificationCheckListStepId)
					.HasConstraintName("FK_MoCertificationCheckListStep_CertificationCheckListStep");

				entity.HasOne(d => d.MoCertificationCheckList)
					.WithMany(p => p.MoCertificationCheckListStep)
					.HasForeignKey(d => d.MoCertificationCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoCertificationCheckListStep_MoCertificationCheckList");

				entity.HasOne(d => d.PerformedByUser)
					.WithMany(p => p.MoCertificationCheckListStep)
					.HasForeignKey(d => d.PerformedByUserId)
					.HasConstraintName("FK_MoCertificationCheckListStep_User");
			});

			modelBuilder.Entity<MoComment>(entity =>
			{
				entity.Property(e => e.MoCommentId).HasColumnName("MoComment_Id");

				entity.Property(e => e.MoCommentComment)
					.IsRequired()
					.HasColumnName("MoComment_Comment")
					.HasMaxLength(4000)
					.HasComment("Brief Comment");

				entity.Property(e => e.MoCommentCommentAddedByUserId).HasColumnName("MoComment_CommentAddedByUserId");

				entity.Property(e => e.MoCommentCommentCreatedDate)
					.HasColumnName("MoComment_CommentCreatedDate")
					.HasComment("Date and time by when the comment was added");

				entity.Property(e => e.MoCommentFileName)
					.HasColumnName("MoComment_FileName")
					.HasMaxLength(255);

				entity.Property(e => e.MoCommentMaintenanceOrderId).HasColumnName("MoComment_MaintenanceOrderId");

				entity.HasOne(d => d.MoCommentCommentAddedByUser)
					.WithMany(p => p.MoComment)
					.HasForeignKey(d => d.MoCommentCommentAddedByUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoComment_User");

				entity.HasOne(d => d.MoCommentMaintenanceOrder)
					.WithMany(p => p.MoComment)
					.HasForeignKey(d => d.MoCommentMaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoComment_MaintenanceOrder");
			});

			modelBuilder.Entity<MoDocuments>(entity =>
			{
				entity.Property(e => e.MoDocumentsId).HasColumnName("MoDocuments_Id");

				entity.Property(e => e.MoDocumentsDocumentVersionId)
					.HasColumnName("MoDocuments_DocumentVersionId")
					.HasComment("Document Version to be referred by Technician");

				entity.Property(e => e.MoDocumentsMaintenanceOrderId).HasColumnName("MoDocuments_MaintenanceOrderId");

				entity.HasOne(d => d.MoDocumentsDocumentVersion)
					.WithMany(p => p.MoDocuments)
					.HasForeignKey(d => d.MoDocumentsDocumentVersionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoDocuments_DocumentVersion");

				entity.HasOne(d => d.MoDocumentsMaintenanceOrder)
					.WithMany(p => p.MoDocuments)
					.HasForeignKey(d => d.MoDocumentsMaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoDocuments_MaintenanceOrder");
			});

			modelBuilder.Entity<MoHistory>(entity =>
			{
				entity.Property(e => e.MoHistoryId).HasColumnName("MoHistory_Id");

				entity.Property(e => e.MoHistoryFromState).HasColumnName("MoHistory_FromState");

				entity.Property(e => e.MoHistoryInitiatedByUserId).HasColumnName("MoHistory_InitiatedByUserId");

				entity.Property(e => e.MoHistoryInitiatedDate).HasColumnName("MoHistory_InitiatedDate");

				entity.Property(e => e.MoHistoryMaintenanceOrderId).HasColumnName("MoHistory_MaintenanceOrderId");

				entity.Property(e => e.MoHistoryToState).HasColumnName("MoHistory_ToState");

				entity.HasOne(d => d.MoHistoryInitiatedByUser)
					.WithMany(p => p.MoHistory)
					.HasForeignKey(d => d.MoHistoryInitiatedByUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoHistory_User");

				entity.HasOne(d => d.MoHistoryMaintenanceOrder)
					.WithMany(p => p.MoHistory)
					.HasForeignKey(d => d.MoHistoryMaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoHistory_MaintenanceOrder");
			});

			modelBuilder.Entity<MoParts>(entity =>
			{
				entity.Property(e => e.MoPartsId).HasColumnName("MoParts_Id");

				entity.Property(e => e.MoPartsAreaId).HasColumnName("MoParts_AreaId");

				entity.Property(e => e.MoPartsBinNo).HasColumnName("MoParts_BinNo");

				entity.Property(e => e.MoPartsLocationId).HasColumnName("MoParts_LocationId");

				entity.Property(e => e.MoPartsMaintenanceOrderId).HasColumnName("MoParts_MaintenanceOrderId");

				entity.Property(e => e.MoPartsPartId)
					.HasColumnName("MoParts_PartId")
					.HasComment("Part id of the part estimated/added");

				entity.Property(e => e.MoPartsPartUsedByUserId).HasColumnName("MoParts_PartUsedByUserId");

				entity.Property(e => e.MoPartsQuantityNeeded)
					.HasColumnName("MoParts_QuantityNeeded")
					.HasColumnType("decimal(10, 2)")
					.HasComment("Quantity Needed of the part");

				entity.Property(e => e.MoPartsQuantityUsed)
					.HasColumnName("MoParts_QuantityUsed")
					.HasColumnType("decimal(10, 2)");

				entity.Property(e => e.MoPartsSubLocationId).HasColumnName("MoParts_SubLocationId");

				entity.Property(e => e.MoPartsUnitOfMeasureId)
					.HasColumnName("MoParts_UnitOfMeasureId")
					.HasComment("Unit of measure of the part");

				entity.HasOne(d => d.MoPartsMaintenanceOrder)
					.WithMany(p => p.MoParts)
					.HasForeignKey(d => d.MoPartsMaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoParts_MaintenanceOrder");

				entity.HasOne(d => d.MoPartsPart)
					.WithMany(p => p.MoParts)
					.HasForeignKey(d => d.MoPartsPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoParts_Part");

				entity.HasOne(d => d.MoPartsPartUsedByUser)
					.WithMany(p => p.MoParts)
					.HasForeignKey(d => d.MoPartsPartUsedByUserId)
					.HasConstraintName("FK_MoParts_User");

				entity.HasOne(d => d.MoPartsUnitOfMeasure)
					.WithMany(p => p.MoParts)
					.HasForeignKey(d => d.MoPartsUnitOfMeasureId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoParts_UnitOfMeasure");
			});

			modelBuilder.Entity<MoPreCompiledCheckList>(entity =>
			{
				entity.Property(e => e.MoPreCompiledCheckListId)
					.HasColumnName("MoPreCompiledCheckList_Id")
					.HasComment("Mapping table for MO and Precompiled checklist. Maintenance supervisor can add more checklist from the library at any point of time.");

				entity.Property(e => e.MoPreCompiledCheckListCheckListId).HasColumnName("MoPreCompiledCheckList_CheckListId");

				entity.Property(e => e.MoPreCompiledCheckListDocumentVersionId).HasColumnName("MoPreCompiledCheckList_DocumentVersionId");

				entity.Property(e => e.MoPreCompiledCheckListMaintenanceOrderId).HasColumnName("MoPreCompiledCheckList_MaintenanceOrderId");

				entity.HasOne(d => d.MoPreCompiledCheckListCheckList)
					.WithMany(p => p.MoPreCompiledCheckList)
					.HasForeignKey(d => d.MoPreCompiledCheckListCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoPreCompiledCheckList_PreCompiledCheckList");

				entity.HasOne(d => d.MoPreCompiledCheckListMaintenanceOrder)
					.WithMany(p => p.MoPreCompiledCheckList)
					.HasForeignKey(d => d.MoPreCompiledCheckListMaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoPreCompiledCheckList_MaintenanceOrder");
			});

			modelBuilder.Entity<MoPreCompiledCheckListStep>(entity =>
			{
				entity.Property(e => e.MoPreCompiledCheckListStepId).HasColumnName("MoPreCompiledCheckListStep_Id");

				entity.Property(e => e.MoPreCompiledCheckListStepDescription)
					.IsRequired()
					.HasColumnName("MoPreCompiledCheckListStep_Description")
					.HasMaxLength(1024);

				entity.Property(e => e.MoPreCompiledCheckListStepDocumentPageNumber).HasColumnName("MoPreCompiledCheckListStep_DocumentPageNumber");

				entity.Property(e => e.MoPreCompiledCheckListStepEstimatedOutageInMins).HasColumnName("MoPreCompiledCheckListStep_EstimatedOutageInMins");

				entity.Property(e => e.MoPreCompiledCheckListStepIsPerformed)
					.HasColumnName("MoPreCompiledCheckListStep_IsPerformed")
					.HasComment("Is it checked or not?");

				entity.Property(e => e.MoPreCompiledCheckListStepMoCheckListId).HasColumnName("MoPreCompiledCheckListStep_MoCheckListId");

				entity.Property(e => e.MoPreCompiledCheckListStepPerformedByUserId).HasColumnName("MoPreCompiledCheckListStep_PerformedByUserId");

				entity.Property(e => e.MoPreCompiledCheckListStepPerformedDate)
					.HasColumnName("MoPreCompiledCheckListStep_PerformedDate")
					.HasComment("Datetime when the step was performed.");

				entity.Property(e => e.MoPreCompiledCheckListStepSkipStep).HasColumnName("MoPreCompiledCheckListStep_SkipStep");

				entity.Property(e => e.MoPreCompiledCheckListStepStepNumber)
					.HasColumnName("MoPreCompiledCheckListStep_StepNumber")
					.HasComment("Sequence number of the checklist steps");

				entity.Property(e => e.MoPreCompiledCheckListStepZoneName)
					.HasColumnName("MoPreCompiledCheckListStep_ZoneName")
					.HasMaxLength(200);

				entity.Property(e => e.PreCompiledCheckListStepId).HasColumnName("PreCompiledCheckListStep_Id");

				entity.HasOne(d => d.MoPreCompiledCheckListStepMoCheckList)
					.WithMany(p => p.MoPreCompiledCheckListStep)
					.HasForeignKey(d => d.MoPreCompiledCheckListStepMoCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoPreCompiledCheckListStep_MoPreCompiledCheckList");

				entity.HasOne(d => d.MoPreCompiledCheckListStepPerformedByUser)
					.WithMany(p => p.MoPreCompiledCheckListStep)
					.HasForeignKey(d => d.MoPreCompiledCheckListStepPerformedByUserId)
					.HasConstraintName("FK_MoPreCompiledCheckListStep_User");

				entity.HasOne(d => d.PreCompiledCheckListStep)
					.WithMany(p => p.MoPreCompiledCheckListStep)
					.HasForeignKey(d => d.PreCompiledCheckListStepId)
					.HasConstraintName("FK_MoPreCompiledCheckListStep_CheckList");
			});

			modelBuilder.Entity<MoPreCompiledCheckListStepPart>(entity =>
			{
				entity.Property(e => e.MoPreCompiledCheckListStepPartId).HasColumnName("MoPreCompiledCheckListStepPart_Id");

				entity.Property(e => e.MoPreCompiledCheckListStepPartMoCheckListStepId).HasColumnName("MoPreCompiledCheckListStepPart_MoCheckListStepId");

				entity.Property(e => e.MoPreCompiledCheckListStepPartPartId).HasColumnName("MoPreCompiledCheckListStepPart_PartId");

				entity.Property(e => e.MoPreCompiledCheckListStepPartQuantityNeeded).HasColumnName("MoPreCompiledCheckListStepPart_QuantityNeeded");

				entity.HasOne(d => d.MoPreCompiledCheckListStepPartMoCheckListStep)
					.WithMany(p => p.MoPreCompiledCheckListStepPart)
					.HasForeignKey(d => d.MoPreCompiledCheckListStepPartMoCheckListStepId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoPreCompiledCheckListStepPart_MoPreCompiledCheckListStep");

				entity.HasOne(d => d.MoPreCompiledCheckListStepPartPart)
					.WithMany(p => p.MoPreCompiledCheckListStepPart)
					.HasForeignKey(d => d.MoPreCompiledCheckListStepPartPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoPreCompiledCheckListStepPart_Part");
			});

			modelBuilder.Entity<MoRepairRequests>(entity =>
			{
				entity.Property(e => e.MoRepairRequestsId).HasColumnName("MoRepairRequests_Id");

				entity.Property(e => e.MoRepairRequestsMaintenanceOrderId).HasColumnName("MoRepairRequests_MaintenanceOrderId");

				entity.Property(e => e.MoRepairRequestsRepairRequestId).HasColumnName("MoRepairRequests_RepairRequestId");

				entity.HasOne(d => d.MoRepairRequestsMaintenanceOrder)
					.WithMany(p => p.MoRepairRequests)
					.HasForeignKey(d => d.MoRepairRequestsMaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoRepairRequests_MaintenanceOrder");

				entity.HasOne(d => d.MoRepairRequestsRepairRequest)
					.WithMany(p => p.MoRepairRequests)
					.HasForeignKey(d => d.MoRepairRequestsRepairRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoRepairRequests_RepairTicket");
			});

			modelBuilder.Entity<MoResources>(entity =>
			{
				entity.Property(e => e.MoResourcesId).HasColumnName("MoResources_Id");

				entity.Property(e => e.MoResourcesMaintenanceOrderId).HasColumnName("MoResources_MaintenanceOrderId");

				entity.Property(e => e.MoResourcesQuantityNeededInMins)
					.HasColumnName("MoResources_QuantityNeededInMins")
					.HasComment("Quantity Needed in Mins");

				entity.Property(e => e.MoResourcesQuantityUsedInMins)
					.HasColumnName("MoResources_QuantityUsedInMins")
					.HasComment("Quantity Used in Mins");

				entity.Property(e => e.MoResourcesScanOffDateTime)
					.HasColumnName("MoResources_ScanOffDateTime")
					.HasComment("Datetime when the user stopped work on this mo");

				entity.Property(e => e.MoResourcesScanOnDateTime)
					.HasColumnName("MoResources_ScanOnDateTime")
					.HasComment("Datetime when the user started work on this MO");

				entity.Property(e => e.MoResourcesUserGroupId)
					.HasColumnName("MoResources_UserGroupId")
					.HasComment("Resource Group");

				entity.Property(e => e.MoResourcesUserId)
					.HasColumnName("MoResources_UserId")
					.HasComment("Resource Id");

				entity.HasOne(d => d.MoResourcesMaintenanceOrder)
					.WithMany(p => p.MoResources)
					.HasForeignKey(d => d.MoResourcesMaintenanceOrderId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoResources_MaintenanceOrder");

				entity.HasOne(d => d.MoResourcesUserGroup)
					.WithMany(p => p.MoResources)
					.HasForeignKey(d => d.MoResourcesUserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoResources_UserGroup");

				entity.HasOne(d => d.MoResourcesUser)
					.WithMany(p => p.MoResources)
					.HasForeignKey(d => d.MoResourcesUserId)
					.HasConstraintName("FK_MoResources_User");
			});

			modelBuilder.Entity<MoTemplateCertificationCheckList>(entity =>
			{
				entity.HasOne(d => d.CertificationCheckList)
					.WithMany(p => p.MoTemplateCertificationCheckList)
					.HasForeignKey(d => d.CertificationCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplateCertificationCheckList_CertificationCheckList");

				entity.HasOne(d => d.MoTemplate)
					.WithMany(p => p.MoTemplateCertificationCheckList)
					.HasForeignKey(d => d.MoTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplateCertificationCheckList_MaintenanceOrderTemplate");
			});

			modelBuilder.Entity<MoTemplateCheckList>(entity =>
			{
				entity.Property(e => e.MoTemplateCheckListId).HasColumnName("MoTemplateCheckList_Id");

				entity.Property(e => e.MoTemplateCheckListCheckListId)
					.HasColumnName("MoTemplateCheckList_CheckListId")
					.HasComment("Precompiled check list");

				entity.Property(e => e.MoTemplateCheckListMoTemplateId)
					.HasColumnName("MoTemplateCheckList_MoTemplateId")
					.HasComment("Maintenance Order Template id");

				entity.HasOne(d => d.MoTemplateCheckListCheckList)
					.WithMany(p => p.MoTemplateCheckList)
					.HasForeignKey(d => d.MoTemplateCheckListCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplateCheckList_PreCompiledCheckList");

				entity.HasOne(d => d.MoTemplateCheckListMoTemplate)
					.WithMany(p => p.MoTemplateCheckList)
					.HasForeignKey(d => d.MoTemplateCheckListMoTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplateCheckList_MaintenanceOrderTemplate");
			});

			modelBuilder.Entity<MoTemplateDocument>(entity =>
			{
				entity.Property(e => e.MoTemplateDocumentId).HasColumnName("MoTemplateDocument_Id");

				entity.Property(e => e.MoTemplateDocumentDocumentVersionId).HasColumnName("MoTemplateDocument_DocumentVersionId");

				entity.Property(e => e.MoTemplateDocumentMoTemplateId).HasColumnName("MoTemplateDocument_MoTemplateId");

				entity.HasOne(d => d.MoTemplateDocumentDocumentVersion)
					.WithMany(p => p.MoTemplateDocument)
					.HasForeignKey(d => d.MoTemplateDocumentDocumentVersionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplateDocument_DocumentVersion");

				entity.HasOne(d => d.MoTemplateDocumentMoTemplate)
					.WithMany(p => p.MoTemplateDocument)
					.HasForeignKey(d => d.MoTemplateDocumentMoTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplateDocument_MaintenanceOrderTemplate");
			});

			modelBuilder.Entity<MoTemplatePartEstimate>(entity =>
			{
				entity.Property(e => e.MoTemplatePartEstimateId).HasColumnName("MoTemplatePartEstimate_Id");

				entity.Property(e => e.MoTemplatePartEstimateMoTemplateId).HasColumnName("MoTemplatePartEstimate_MoTemplateId");

				entity.Property(e => e.MoTemplatePartEstimatePartId)
					.HasColumnName("MoTemplatePartEstimate_PartId")
					.HasComment("Part Id from Part table.");

				entity.Property(e => e.MoTemplatePartEstimateQuantityNeeded)
					.HasColumnName("MoTemplatePartEstimate_QuantityNeeded")
					.HasColumnType("decimal(10, 2)")
					.HasComment("Quantity Needed as estimate");

				entity.Property(e => e.MoTemplatePartEstimateUnitOfMeasureId)
					.HasColumnName("MoTemplatePartEstimate_UnitOfMeasureId")
					.HasComment("UOM of the Part");

				entity.HasOne(d => d.MoTemplatePartEstimateMoTemplate)
					.WithMany(p => p.MoTemplatePartEstimate)
					.HasForeignKey(d => d.MoTemplatePartEstimateMoTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplatePartEstimate_MaintenanceOrderTemplate");

				entity.HasOne(d => d.MoTemplatePartEstimatePart)
					.WithMany(p => p.MoTemplatePartEstimate)
					.HasForeignKey(d => d.MoTemplatePartEstimatePartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplatePartEstimate_Part");

				entity.HasOne(d => d.MoTemplatePartEstimateUnitOfMeasure)
					.WithMany(p => p.MoTemplatePartEstimate)
					.HasForeignKey(d => d.MoTemplatePartEstimateUnitOfMeasureId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplatePartEstimate_UnitOfMeasure");
			});

			modelBuilder.Entity<MoTemplateResourceEstimate>(entity =>
			{
				entity.Property(e => e.MoTemplateResourceEstimateId).HasColumnName("MoTemplateResourceEstimate_Id");

				entity.Property(e => e.MoTemplateResourceEstimateMoTemplateId).HasColumnName("MoTemplateResourceEstimate_MoTemplateId");

				entity.Property(e => e.MoTemplateResourceEstimateQuantityNeededInMins).HasColumnName("MoTemplateResourceEstimate_QuantityNeededInMins");

				entity.Property(e => e.MoTemplateResourceEstimateUserGroupId)
					.HasColumnName("MoTemplateResourceEstimate_UserGroupId")
					.HasComment("Group id of the resource being added.");

				entity.Property(e => e.MoTemplateResourceEstimateUserId)
					.HasColumnName("MoTemplateResourceEstimate_UserId")
					.HasComment("Only Group could be defined when doign the estimation.User is optional.");

				entity.HasOne(d => d.MoTemplateResourceEstimateMoTemplate)
					.WithMany(p => p.MoTemplateResourceEstimate)
					.HasForeignKey(d => d.MoTemplateResourceEstimateMoTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplateResourceEstimate_MaintenanceOrderTemplate");

				entity.HasOne(d => d.MoTemplateResourceEstimateUserGroup)
					.WithMany(p => p.MoTemplateResourceEstimate)
					.HasForeignKey(d => d.MoTemplateResourceEstimateUserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_MoTemplateResourceEstimate_UserGroup");

				entity.HasOne(d => d.MoTemplateResourceEstimateUser)
					.WithMany(p => p.MoTemplateResourceEstimate)
					.HasForeignKey(d => d.MoTemplateResourceEstimateUserId)
					.HasConstraintName("FK_MoTemplateResourceEstimate_User");
			});

			modelBuilder.Entity<MobileAppVersion>(entity =>
			{
				entity.Property(e => e.MobileAppVersionId).HasColumnName("MobileAppVersion_Id");

				entity.Property(e => e.MobileAppVersionActive).HasColumnName("MobileAppVersion_Active");

				entity.Property(e => e.MobileAppVersionCreatedBy)
					.IsRequired()
					.HasColumnName("MobileAppVersion_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.MobileAppVersionCreatedDate).HasColumnName("MobileAppVersion_CreatedDate");

				entity.Property(e => e.MobileAppVersionDescription)
					.HasColumnName("MobileAppVersion_Description")
					.HasMaxLength(255);

				entity.Property(e => e.MobileAppVersionFileName)
					.IsRequired()
					.HasColumnName("MobileAppVersion_FileName")
					.HasMaxLength(255);

				entity.Property(e => e.MobileAppVersionIsUrl).HasColumnName("MobileAppVersion_IsUrl");

				entity.Property(e => e.MobileAppVersionName)
					.IsRequired()
					.HasColumnName("MobileAppVersion_Name")
					.HasMaxLength(255);

				entity.Property(e => e.MobileAppVersionReferenceId).HasColumnName("MobileAppVersion_ReferenceId");

				entity.Property(e => e.MobileAppVersionVersionNumber)
					.HasColumnName("MobileAppVersion_VersionNumber")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<Model>(entity =>
			{
				entity.Property(e => e.ModelId).HasColumnName("Model_Id");

				entity.Property(e => e.ModelModelNumber)
					.HasColumnName("Model_ModelNumber")
					.HasMaxLength(255);

				entity.Property(e => e.ModelPrimaryGroupId).HasColumnName("Model_PrimaryGroupId");

				entity.Property(e => e.ModelSecondaryGroupId).HasColumnName("Model_SecondaryGroupId");

				entity.Property(e => e.ModelSubGroupId).HasColumnName("Model_SubGroupId");

				entity.HasOne(d => d.ModelPrimaryGroup)
					.WithMany(p => p.ModelModelPrimaryGroup)
					.HasForeignKey(d => d.ModelPrimaryGroupId)
					.HasConstraintName("FK_Model_EquipmentGroupPrimary");

				entity.HasOne(d => d.ModelSecondaryGroup)
					.WithMany(p => p.ModelModelSecondaryGroup)
					.HasForeignKey(d => d.ModelSecondaryGroupId)
					.HasConstraintName("FK_Model_EquipmentGroupSecondary");

				entity.HasOne(d => d.ModelSubGroup)
					.WithMany(p => p.ModelModelSubGroup)
					.HasForeignKey(d => d.ModelSubGroupId)
					.HasConstraintName("FK_Model_EquipmentGroupSubGroup");
			});

			modelBuilder.Entity<OrphanAssets>(entity =>
			{
				entity.HasKey(e => e.OrphanAssetId);

				entity.Property(e => e.OrphanAssetId)
					.HasColumnName("OrphanAsset_Id")
					.HasColumnType("numeric(18, 0)")
					.ValueGeneratedOnAdd();

				entity.Property(e => e.OrphanAssetAssetType).HasColumnName("OrphanAsset_AssetType");

				entity.Property(e => e.OrphanAssetBarcode)
					.HasColumnName("OrphanAsset_Barcode")
					.HasMaxLength(50);

				entity.Property(e => e.OrphanAssetBirthdate)
					.HasColumnName("OrphanAsset_Birthdate")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.OrphanAssetName)
					.HasColumnName("OrphanAsset_NAME")
					.HasMaxLength(50);

				entity.Property(e => e.OrphanAssetOrphanedDate)
					.HasColumnName("OrphanAsset_OrphanedDate")
					.HasColumnType("numeric(18, 0)");

				entity.Property(e => e.OrphanAssetSerialno)
					.HasColumnName("OrphanAsset_SERIALNO")
					.HasMaxLength(50);

				entity.Property(e => e.OrphanAssetThirdpartyid)
					.HasColumnName("OrphanAsset_THIRDPARTYID")
					.HasColumnType("numeric(18, 0)");
			});

			modelBuilder.Entity<PanaCimmapping>(entity =>
			{
				entity.ToTable("PanaCIMMapping");

				entity.Property(e => e.PanaCimmappingId).HasColumnName("PanaCIMMapping_Id");

				entity.Property(e => e.CreatedDate).HasColumnType("datetime");

				entity.Property(e => e.MmsId).HasColumnName("MMS_Id");

				entity.Property(e => e.PanaCimBarCode)
					.HasColumnName("PanaCIM_BarCode")
					.HasMaxLength(100);

				entity.Property(e => e.PanaCimId).HasColumnName("PanaCIM_Id");

				entity.Property(e => e.PanaCimmappingIntegrationId).HasColumnName("PanaCIMMapping_IntegrationId");
			});

			modelBuilder.Entity<PanaCimserviceLog>(entity =>
			{
				entity.ToTable("PanaCIMServiceLog");

				entity.Property(e => e.PanaCimserviceLogId).HasColumnName("PanaCIMServiceLog_Id");

				entity.Property(e => e.CreatedDate)
					.HasColumnType("datetime")
					.HasDefaultValueSql("(getdate())");
			});

			modelBuilder.Entity<PanacimRuleSettings>(entity =>
			{
				entity.Property(e => e.PanacimRuleSettingsId).HasColumnName("PanacimRuleSettings_ID");

				entity.Property(e => e.PanacimRuleSettingsRuleName)
					.IsRequired()
					.HasColumnName("PanacimRuleSettings_RuleName")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<PanacimSetting>(entity =>
			{
				entity.Property(e => e.PanacimSettingId).HasColumnName("PanacimSetting_ID");

				entity.Property(e => e.PanacimSettingDbinstance)
					.IsRequired()
					.HasColumnName("PanacimSetting_DBInstance")
					.HasMaxLength(100);

				entity.Property(e => e.PanacimSettingEnableMachineIntegration).HasColumnName("PanacimSetting_EnableMachineIntegration");

				entity.Property(e => e.PanacimSettingHostName)
					.IsRequired()
					.HasColumnName("PanacimSetting_HostName")
					.HasMaxLength(100);

				entity.Property(e => e.PanacimSettingIntegrationId).HasColumnName("PanacimSetting_IntegrationID");

				entity.Property(e => e.PanacimSettingIntegrationServerId).HasColumnName("PanacimSetting_IntegrationServerID");

				entity.Property(e => e.PanacimSettingIsIntegrated).HasColumnName("PanacimSetting_IsIntegrated");

				entity.Property(e => e.PanacimSettingPassword)
					.IsRequired()
					.HasColumnName("PanacimSetting_Password")
					.HasMaxLength(100);

				entity.Property(e => e.PanacimSettingServiceUrl)
					.IsRequired()
					.HasColumnName("PanacimSetting_ServiceURL");

				entity.Property(e => e.PanacimSettingUserName)
					.IsRequired()
					.HasColumnName("PanacimSetting_UserName")
					.HasMaxLength(100);

				entity.HasOne(d => d.PanacimSettingIntegration)
					.WithMany(p => p.PanacimSetting)
					.HasForeignKey(d => d.PanacimSettingIntegrationId)
					.HasConstraintName("FK_PanacimSetting_IntegrationID");

				entity.HasOne(d => d.PanacimSettingIntegrationServer)
					.WithMany(p => p.PanacimSetting)
					.HasForeignKey(d => d.PanacimSettingIntegrationServerId)
					.OnDelete(DeleteBehavior.Cascade)
					.HasConstraintName("FK_PanacimSetting_IntegrationServerID");
			});

			modelBuilder.Entity<Part>(entity =>
			{
				entity.Property(e => e.PartId).HasColumnName("Part_Id");

				entity.Property(e => e.PartControlFlag).HasColumnName("Part_ControlFlag");

				entity.Property(e => e.PartCost)
					.HasColumnName("Part_Cost")
					.HasColumnType("decimal(10, 2)")
					.HasComment("Part cost to start with, Once we have Inventory Runtime, we will serialized and unserialized part with Batch number costing etc.");

				entity.Property(e => e.PartCreatedBy)
					.IsRequired()
					.HasColumnName("Part_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.PartCreatedDate).HasColumnName("Part_CreatedDate");

				entity.Property(e => e.PartDescription)
					.HasColumnName("Part_Description")
					.HasMaxLength(255)
					.HasComment("Short description about the Part");

				entity.Property(e => e.PartIsDeleted).HasColumnName("Part_IsDeleted");

				entity.Property(e => e.PartIsHazardous).HasColumnName("Part_IsHazardous");

				entity.Property(e => e.PartIsNonConsumable).HasColumnName("Part_IsNonConsumable");

				entity.Property(e => e.PartIsObsoletePart).HasColumnName("Part_IsObsoletePart");

				entity.Property(e => e.PartIsPartKit).HasColumnName("Part_IsPartKit");

				entity.Property(e => e.PartIsSerialNumberEnabled)
					.HasColumnName("Part_IsSerialNumberEnabled")
					.HasDefaultValueSql("((0))");

				entity.Property(e => e.PartIsToolKit).HasColumnName("Part_IsToolKit");

				entity.Property(e => e.PartIsToolKitInComplete).HasColumnName("Part_IsToolKitInComplete");

				entity.Property(e => e.PartLeadTime).HasColumnName("Part_LeadTime");

				entity.Property(e => e.PartLocationId)
					.HasColumnName("Part_LocationId")
					.HasComment("Primary Location where the part is available");

				entity.Property(e => e.PartMaxQuantity).HasColumnName("Part_MaxQuantity");

				entity.Property(e => e.PartMinQuantity).HasColumnName("Part_MinQuantity");

				entity.Property(e => e.PartName)
					.IsRequired()
					.HasColumnName("Part_Name")
					.HasMaxLength(50);

				entity.Property(e => e.PartNumber)
					.IsRequired()
					.HasColumnName("Part_Number")
					.HasMaxLength(50);

				entity.Property(e => e.PartPartClassId).HasColumnName("Part_PartClassId");

				entity.Property(e => e.PartPartType)
					.HasColumnName("Part_PartType")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.PartPhoto)
					.HasColumnName("Part_Photo")
					.HasMaxLength(510);

				entity.Property(e => e.PartPrimaryVendorId)
					.HasColumnName("Part_PrimaryVendorId")
					.HasComment("Primary Vendor Id,  Same Part can come from multiple Vendors.  This will make sense once we have Inventory transaction done");

				entity.Property(e => e.PartReferenceId).HasColumnName("Part_ReferenceId");

				entity.Property(e => e.PartUnitOfMeasureId)
					.HasColumnName("Part_UnitOfMeasureId")
					.HasComment("Primary Unit of Measure of the Spare Part");

				entity.Property(e => e.PartUsedPerMachine).HasColumnName("Part_UsedPerMachine");

				entity.Property(e => e.PartVendorPartNumber)
					.HasColumnName("Part_VendorPartNumber")
					.HasMaxLength(50);

				entity.HasOne(d => d.PartLocation)
					.WithMany(p => p.Part)
					.HasForeignKey(d => d.PartLocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Part_Location");

				entity.HasOne(d => d.PartPartClass)
					.WithMany(p => p.Part)
					.HasForeignKey(d => d.PartPartClassId)
					.HasConstraintName("FK_Part_InventoryTurnLevel");

				entity.HasOne(d => d.PartPrimaryVendor)
					.WithMany(p => p.Part)
					.HasForeignKey(d => d.PartPrimaryVendorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Part_Vendor");

				entity.HasOne(d => d.PartUnitOfMeasure)
					.WithMany(p => p.Part)
					.HasForeignKey(d => d.PartUnitOfMeasureId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Part_UnitOfMeasure");
			});

			modelBuilder.Entity<PartDelivery>(entity =>
			{
				entity.HasOne(d => d.DeliveryRequest)
					.WithMany(p => p.PartDelivery)
					.HasForeignKey(d => d.DeliveryRequestId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartDelivery_DeliveryRequestId");

				entity.HasOne(d => d.Location)
					.WithMany(p => p.PartDelivery)
					.HasForeignKey(d => d.LocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartDelivery_LocationId");

				entity.HasOne(d => d.Part)
					.WithMany(p => p.PartDelivery)
					.HasForeignKey(d => d.PartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartDelivery_PartId");
			});

			modelBuilder.Entity<PartGroup>(entity =>
			{
				entity.Property(e => e.PartGroupId)
					.HasColumnName("PartGroup_Id")
					.HasComment("Note:- Universe of all part group.  Same part list can be used by multiple equipments.");

				entity.Property(e => e.PartGroupControlFlag).HasColumnName("PartGroup_ControlFlag");

				entity.Property(e => e.PartGroupDescription)
					.HasColumnName("PartGroup_Description")
					.HasMaxLength(255);

				entity.Property(e => e.PartGroupIsDeleted).HasColumnName("PartGroup_IsDeleted");

				entity.Property(e => e.PartGroupName)
					.IsRequired()
					.HasColumnName("PartGroup_Name")
					.HasMaxLength(50)
					.HasComment("Name of the equipment part group");

				entity.Property(e => e.PartGroupReferenceId).HasColumnName("PartGroup_ReferenceId");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<PartGroupMembers>(entity =>
			{
				entity.Property(e => e.PartGroupMembersId).HasColumnName("PartGroupMembers_Id");

				entity.Property(e => e.PartGroupMembersPartGroupId).HasColumnName("PartGroupMembers_PartGroupId");

				entity.Property(e => e.PartGroupMembersPartId).HasColumnName("PartGroupMembers_PartId");

				entity.HasOne(d => d.PartGroupMembersPartGroup)
					.WithMany(p => p.PartGroupMembers)
					.HasForeignKey(d => d.PartGroupMembersPartGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartGroupMembers_PartGroup");

				entity.HasOne(d => d.PartGroupMembersPart)
					.WithMany(p => p.PartGroupMembers)
					.HasForeignKey(d => d.PartGroupMembersPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartGroupMembers_Part");
			});

			modelBuilder.Entity<PartInformationDocuments>(entity =>
			{
				entity.Property(e => e.PartInformationDocumentsId)
					.HasColumnName("PartInformationDocuments_Id")
					.ValueGeneratedNever();

				entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);

				entity.Property(e => e.PartInformationDocumentsCreatedBy)
					.IsRequired()
					.HasColumnName("PartInformationDocuments_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.PartInformationDocumentsCreatedDate).HasColumnName("PartInformationDocuments_CreatedDate");

				entity.Property(e => e.PartInformationDocumentsFileName)
					.IsRequired()
					.HasColumnName("PartInformationDocuments_FileName")
					.HasMaxLength(510);

				entity.Property(e => e.PartInformationDocumentsFileType)
					.HasColumnName("PartInformationDocuments_FileType")
					.HasMaxLength(50);

				entity.Property(e => e.PartInformationDocumentsIsActive).HasColumnName("PartInformationDocuments_IsActive");

				entity.Property(e => e.PartInformationDocumentsPartId).HasColumnName("PartInformationDocuments_PartId");

				entity.Property(e => e.PartInformationDocumentsVersion)
					.HasColumnName("PartInformationDocuments_Version")
					.HasMaxLength(50);

				entity.HasOne(d => d.PartInformationDocumentsPart)
					.WithMany(p => p.PartInformationDocuments)
					.HasForeignKey(d => d.PartInformationDocumentsPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartInformationDocuments_Part");
			});

			modelBuilder.Entity<PartInformationImages>(entity =>
			{
				entity.Property(e => e.PartInformationImagesId).HasColumnName("PartInformationImages_Id");

				entity.Property(e => e.LastUpdatedBy).HasMaxLength(50);

				entity.Property(e => e.PartInformationImagesCreatedBy)
					.IsRequired()
					.HasColumnName("PartInformationImages_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.PartInformationImagesCreatedDate).HasColumnName("PartInformationImages_CreatedDate");

				entity.Property(e => e.PartInformationImagesPartId).HasColumnName("PartInformationImages_PartId");

				entity.Property(e => e.PartInformationImagesPhoto)
					.HasColumnName("PartInformationImages_Photo")
					.HasMaxLength(510);

				entity.HasOne(d => d.PartInformationImagesPart)
					.WithMany(p => p.PartInformationImages)
					.HasForeignKey(d => d.PartInformationImagesPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartInformationImages_Part");
			});

			modelBuilder.Entity<PartInventory>(entity =>
			{
				entity.HasKey(e => e.InventoryId);

				entity.HasIndex(e => new { e.InventoryId, e.InventoryPartId })
					.HasName("INDX_PartInventory_Inventory_PartId");

				entity.HasIndex(e => new { e.InventoryAreaId, e.InventoryLocationId, e.InventoryPartId })
					.HasName("INDX_PartInventory_Inventory_PartId_AREAID");

				entity.HasIndex(e => new { e.InventoryId, e.InventoryAreaId, e.InventoryLocationId, e.InventorySubLocationId, e.InventoryBinId, e.InventoryQoh, e.InventoryMinimumQuantity, e.InventoryMaximumQuantity, e.InventoryLastIssueDate, e.InventoryIssueQuantityYtd, e.InventoryInventoryTurnRatio, e.InventoryPartId })
					.HasName("INDX_PartInventory_Inventory_PartId_INCLUDE");

				entity.Property(e => e.InventoryId).HasColumnName("Inventory_Id");

				entity.Property(e => e.InventoryAreaId).HasColumnName("Inventory_AreaId");

				entity.Property(e => e.InventoryBinId).HasColumnName("Inventory_BinId");

				entity.Property(e => e.InventoryInventoryTurnRatio).HasColumnName("Inventory_InventoryTurnRatio");

				entity.Property(e => e.InventoryIssueQuantityYtd).HasColumnName("Inventory_IssueQuantityYTD");

				entity.Property(e => e.InventoryLastIssueDate)
					.HasColumnName("Inventory_LastIssueDate")
					.HasColumnType("datetime");

				entity.Property(e => e.InventoryLocationId).HasColumnName("Inventory_LocationId");

				entity.Property(e => e.InventoryMaximumQuantity).HasColumnName("Inventory_MaximumQuantity");

				entity.Property(e => e.InventoryMinimumQuantity).HasColumnName("Inventory_MinimumQuantity");

				entity.Property(e => e.InventoryPartId).HasColumnName("Inventory_PartId");

				entity.Property(e => e.InventoryQoh).HasColumnName("Inventory_QOH");

				entity.Property(e => e.InventorySubLocationId).HasColumnName("Inventory_SubLocationId");

				entity.Property(e => e.PartInventoryCycleCountFlag)
					.HasColumnName("PartInventory_CycleCountFlag")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.PartInventoryIsDefaultLocation)
					.HasColumnName("PartInventory_IsDefaultLocation")
					.HasDefaultValueSql("((1))");

				entity.HasOne(d => d.InventoryArea)
					.WithMany(p => p.PartInventory)
					.HasForeignKey(d => d.InventoryAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartInventory_Area");

				entity.HasOne(d => d.InventoryBin)
					.WithMany(p => p.PartInventory)
					.HasForeignKey(d => d.InventoryBinId)
					.HasConstraintName("FK_PartInventory_Bin");

				entity.HasOne(d => d.InventoryLocation)
					.WithMany(p => p.PartInventory)
					.HasForeignKey(d => d.InventoryLocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartInventory_Location");

				entity.HasOne(d => d.InventoryPart)
					.WithMany(p => p.PartInventory)
					.HasForeignKey(d => d.InventoryPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartInventory_Part");

				entity.HasOne(d => d.InventorySubLocation)
					.WithMany(p => p.PartInventory)
					.HasForeignKey(d => d.InventorySubLocationId)
					.HasConstraintName("FK_PartInventory_SubLocation");
			});

			modelBuilder.Entity<PartInventoryHistory>(entity =>
			{
				entity.HasIndex(e => new { e.PartInventoryHistoryClosingQoH, e.PartInventoryHistoryPartId, e.PartInventoryHistoryDate })
					.HasName("INDX_PartInventoryHistory_PartInventoryHistory_PartId_PartInventoryHistory_Date");

				entity.Property(e => e.PartInventoryHistoryId).HasColumnName("PartInventoryHistory_Id");

				entity.Property(e => e.PartInventoryHistoryClosingQoH).HasColumnName("PartInventoryHistory_ClosingQoH");

				entity.Property(e => e.PartInventoryHistoryDate).HasColumnName("PartInventoryHistory_Date");

				entity.Property(e => e.PartInventoryHistoryPartId).HasColumnName("PartInventoryHistory_PartId");
			});

			modelBuilder.Entity<PartNotification>(entity =>
			{
				entity.Property(e => e.PartNotificationId).HasColumnName("PartNotification_Id");

				entity.Property(e => e.PartNotificationNotificationId).HasColumnName("PartNotification_NotificationId");

				entity.Property(e => e.PartNotificationPartId).HasColumnName("PartNotification_PartId");

				entity.HasOne(d => d.PartNotificationNotification)
					.WithMany(p => p.PartNotification)
					.HasForeignKey(d => d.PartNotificationNotificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartNotification_StockingNotification");

				entity.HasOne(d => d.PartNotificationPart)
					.WithMany(p => p.PartNotification)
					.HasForeignKey(d => d.PartNotificationPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartNotification_Part");
			});

			modelBuilder.Entity<PartSerialNumber>(entity =>
			{
				entity.Property(e => e.PartSerialNumberId).HasColumnName("PartSerialNumber_Id");

				entity.Property(e => e.PartSerialNumberAreaId).HasColumnName("PartSerialNumber_AreaId");

				entity.Property(e => e.PartSerialNumberBinNo).HasColumnName("PartSerialNumber_BinNo");

				entity.Property(e => e.PartSerialNumberIsAvailable)
					.IsRequired()
					.HasColumnName("PartSerialNumber_IsAvailable")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.PartSerialNumberLocationId).HasColumnName("PartSerialNumber_LocationId");

				entity.Property(e => e.PartSerialNumberNumber)
					.HasColumnName("PartSerialNumber_Number")
					.HasMaxLength(150)
					.IsUnicode(false);

				entity.Property(e => e.PartSerialNumberPartId).HasColumnName("PartSerialNumber_PartId");

				entity.Property(e => e.PartSerialNumberSubLocationId).HasColumnName("PartSerialNumber_SubLocationId");

				entity.HasOne(d => d.PartSerialNumberPart)
					.WithMany(p => p.PartSerialNumber)
					.HasForeignKey(d => d.PartSerialNumberPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartSerialNumber_Part");
			});

			modelBuilder.Entity<PartStore>(entity =>
			{
				entity.HasIndex(e => e.StoreId)
					.HasName("Uqc_PartStore_StoreId")
					.IsUnique();

				entity.Property(e => e.Address)
					.IsRequired()
					.HasMaxLength(500);

				entity.Property(e => e.ContactEmail)
					.IsRequired()
					.HasMaxLength(250);

				entity.Property(e => e.ContactPhoneNumber)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.IsActive)
					.IsRequired()
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(250);

				entity.Property(e => e.PhoneExt).HasMaxLength(50);

				entity.Property(e => e.PrimaryContact)
					.IsRequired()
					.HasMaxLength(250);

				entity.Property(e => e.StoreId)
					.IsRequired()
					.HasMaxLength(500);

				entity.Property(e => e.Url)
					.IsRequired()
					.HasMaxLength(250);

				entity.HasOne(d => d.CreatedByNavigation)
					.WithMany(p => p.PartStore)
					.HasForeignKey(d => d.CreatedBy)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartStore_User");
			});

			modelBuilder.Entity<PartSubstitute>(entity =>
			{
				entity.Property(e => e.PartSubstituteId).HasColumnName("PartSubstitute_Id");

				entity.Property(e => e.PartSubstitutePartId).HasColumnName("PartSubstitute_PartId");

				entity.Property(e => e.PartSubstitutePreference).HasColumnName("PartSubstitute_Preference");

				entity.Property(e => e.PartSubstituteSubstitutePartId).HasColumnName("PartSubstitute_SubstitutePartId");

				entity.HasOne(d => d.PartSubstitutePart)
					.WithMany(p => p.PartSubstitute)
					.HasForeignKey(d => d.PartSubstitutePartId)
					.HasConstraintName("FK_PartSubstitute_PartId");
			});

			modelBuilder.Entity<PartTransaction>(entity =>
			{
				entity.Property(e => e.PartTransactionId).HasColumnName("PartTransaction_Id");

				entity.Property(e => e.PartTransactionBinNo).HasColumnName("PartTransaction_BinNo");

				entity.Property(e => e.PartTransactionCheckOutInType).HasColumnName("PartTransaction_CheckOutInType");

				entity.Property(e => e.PartTransactionDateTime).HasColumnName("PartTransaction_DateTime");

				entity.Property(e => e.PartTransactionLocationId).HasColumnName("PartTransaction_LocationId");

				entity.Property(e => e.PartTransactionMaintenanceOrderId).HasColumnName("PartTransaction_MaintenanceOrderId");

				entity.Property(e => e.PartTransactionPartId).HasColumnName("PartTransaction_PartId");

				entity.Property(e => e.PartTransactionQuantity).HasColumnName("PartTransaction_Quantity");

				entity.Property(e => e.PartTransactionSubLocationId).HasColumnName("PartTransaction_SubLocationId");

				entity.Property(e => e.PartTransactionUserId).HasColumnName("PartTransaction_UserId");

				entity.HasOne(d => d.PartTransactionLocation)
					.WithMany(p => p.PartTransaction)
					.HasForeignKey(d => d.PartTransactionLocationId)
					.HasConstraintName("FK_PartTransaction_Location");

				entity.HasOne(d => d.PartTransactionMaintenanceOrder)
					.WithMany(p => p.PartTransaction)
					.HasForeignKey(d => d.PartTransactionMaintenanceOrderId)
					.HasConstraintName("FK_PartTransaction_MaintenanceOrder");

				entity.HasOne(d => d.PartTransactionPart)
					.WithMany(p => p.PartTransaction)
					.HasForeignKey(d => d.PartTransactionPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartTransaction_Part");

				entity.HasOne(d => d.PartTransactionUser)
					.WithMany(p => p.PartTransaction)
					.HasForeignKey(d => d.PartTransactionUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PartTransaction_User");
			});

			modelBuilder.Entity<PccheckListStepTranslation>(entity =>
			{
				entity.ToTable("PCCheckListStepTranslation");

				entity.Property(e => e.PccheckListStepTranslationId).HasColumnName("PCCheckListStepTranslation_Id");

				entity.Property(e => e.PccheckListStepTranslationAppLangId).HasColumnName("PCCheckListStepTranslation_AppLangId");

				entity.Property(e => e.PccheckListStepTranslationStepDescription)
					.HasColumnName("PCCheckListStepTranslation_StepDescription")
					.HasMaxLength(2048);

				entity.Property(e => e.PccheckListStepTranslationStepId).HasColumnName("PCCheckListStepTranslation_StepId");

				entity.HasOne(d => d.PccheckListStepTranslationAppLang)
					.WithMany(p => p.PccheckListStepTranslation)
					.HasForeignKey(d => d.PccheckListStepTranslationAppLangId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PCCheckListStepTranslation_AppLanguage");

				entity.HasOne(d => d.PccheckListStepTranslationStep)
					.WithMany(p => p.PccheckListStepTranslation)
					.HasForeignKey(d => d.PccheckListStepTranslationStepId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PCCheckListStepTranslation_PreCompiledCheckListStep");
			});

			modelBuilder.Entity<Pmschedule>(entity =>
			{
				entity.ToTable("PMSchedule");

				entity.HasIndex(e => new { e.PmscheduleIsActive, e.PmscheduleMeterId })
					.HasName("INDX_PMSCHEDULE_METER_ACTIVE");

				entity.HasIndex(e => new { e.PmscheduleEquipmentId, e.PmscheduleIsActive, e.PmscheduleIsAutoTag })
					.HasName("INDX_PMSCHEDULE_EQP_ACTIVE_AUTOTAG");

				entity.Property(e => e.PmscheduleId).HasColumnName("PMSchedule_Id");

				entity.Property(e => e.PmScheduleEndBy).HasColumnName("PmSchedule_EndBy");

				entity.Property(e => e.PmScheduleScheduleTimeOfDay).HasColumnName("PmSchedule_ScheduleTimeOfDay");

				entity.Property(e => e.PmScheduleYearlyDay).HasColumnName("PmSchedule_YearlyDay");

				entity.Property(e => e.PmscheduleAreaId).HasColumnName("PMSchedule_AreaId");

				entity.Property(e => e.PmscheduleControlFlag).HasColumnName("PMSchedule_ControlFlag");

				entity.Property(e => e.PmscheduleCreatedDate).HasColumnName("PMSchedule_CreatedDate");

				entity.Property(e => e.PmscheduleCreatedUser).HasColumnName("PMSchedule_CreatedUser");

				entity.Property(e => e.PmscheduleCurrentMaintenanceOrderDueDate)
					.HasColumnName("PMSchedule_CurrentMaintenanceOrderDueDate")
					.HasComment("Current Open Maintenance Order Due date.");

				entity.Property(e => e.PmscheduleEquipmentId)
					.HasColumnName("PMSchedule_EquipmentId")
					.HasComment("Equipment for which the schedule is created.");

				entity.Property(e => e.PmscheduleEveryNthTime)
					.HasColumnName("PMSchedule_EveryNthTime")
					.HasComment("Ex:  Schedule for every 2 weeks or every 3 days");

				entity.Property(e => e.PmscheduleFirstDue)
					.HasColumnName("PMSchedule_FirstDue")
					.HasComment("First due date from when the Schedule PM should start.");

				entity.Property(e => e.PmscheduleGroupName)
					.HasColumnName("PMSchedule_GroupName")
					.HasMaxLength(50);

				entity.Property(e => e.PmscheduleIsActive)
					.IsRequired()
					.HasColumnName("PMSchedule_IsActive")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.PmscheduleIsAutoTag).HasColumnName("PMSchedule_IsAutoTag");

				entity.Property(e => e.PmscheduleIsDeleted).HasColumnName("PMSchedule_IsDeleted");

				entity.Property(e => e.PmscheduleMaxThreshold).HasColumnName("PMSchedule_MaxThreshold");

				entity.Property(e => e.PmscheduleMeterId).HasColumnName("PMSchedule_MeterId");

				entity.Property(e => e.PmscheduleMeterReset).HasColumnName("PMSchedule_MeterReset");

				entity.Property(e => e.PmscheduleMinThreshold).HasColumnName("PMSchedule_MinThreshold");

				entity.Property(e => e.PmscheduleMoTemplateId)
					.HasColumnName("PMSchedule_MoTemplateId")
					.HasComment("Maintenance Order Template used for this PM Schedule");

				entity.Property(e => e.PmscheduleMonthlyDate)
					.HasColumnName("PMSchedule_MonthlyDate")
					.HasComment("On what date of the month the PM should occur for a monthly PM");

				entity.Property(e => e.PmscheduleNextDueMeter).HasColumnName("PMSchedule_NextDueMeter");

				entity.Property(e => e.PmscheduleRecurrenceType)
					.HasColumnName("PMSchedule_RecurrenceType")
					.HasComment("Ex: Hourly, Daily, Weekly, Monthly, Yearly");

				entity.Property(e => e.PmscheduleReferenceId).HasColumnName("PMSchedule_ReferenceId");

				entity.Property(e => e.PmscheduleWeeklyDay)
					.HasColumnName("PMSchedule_WeeklyDay")
					.HasComment("On what day of the week the PM should occur for a weekly PM");

				entity.Property(e => e.PmscheduleYearlyMonth)
					.HasColumnName("PMSchedule_YearlyMonth")
					.HasComment("On what month of the year the PM should occur for  a yearly PM");

				entity.HasOne(d => d.PmscheduleArea)
					.WithMany(p => p.Pmschedule)
					.HasForeignKey(d => d.PmscheduleAreaId)
					.OnDelete(DeleteBehavior.Cascade)
					.HasConstraintName("FK_PMSchedule_AreaId");

				entity.HasOne(d => d.PmscheduleCreatedUserNavigation)
					.WithMany(p => p.Pmschedule)
					.HasForeignKey(d => d.PmscheduleCreatedUser)
					.HasConstraintName("FK_PMSchedule_User");

				entity.HasOne(d => d.PmscheduleEquipment)
					.WithMany(p => p.Pmschedule)
					.HasForeignKey(d => d.PmscheduleEquipmentId)
					.HasConstraintName("FK_PMSchedule_Equipment");

				entity.HasOne(d => d.PmscheduleMoTemplate)
					.WithMany(p => p.Pmschedule)
					.HasForeignKey(d => d.PmscheduleMoTemplateId)
					.HasConstraintName("FK_PMSchedule_MaintenanceOrderTemplate");
			});

			modelBuilder.Entity<PmscheduleEquipment>(entity =>
			{
				entity.ToTable("PMScheduleEquipment");

				entity.Property(e => e.PmscheduleEquipmentId).HasColumnName("PMScheduleEquipment_ID");

				entity.Property(e => e.PmscheduleEquipmentCurrentMaintenanceOrderDueDate).HasColumnName("PMScheduleEquipment_CurrentMaintenanceOrderDueDate");

				entity.Property(e => e.PmscheduleEquipmentEquipmentId).HasColumnName("PMScheduleEquipment_EquipmentId");

				entity.Property(e => e.PmscheduleEquipmentMoTemplateId).HasColumnName("PMScheduleEquipment_MoTemplateId");

				entity.Property(e => e.PmscheduleEquipmentScheduleId).HasColumnName("PMScheduleEquipment_ScheduleId");

				entity.HasOne(d => d.PmscheduleEquipmentEquipment)
					.WithMany(p => p.PmscheduleEquipment)
					.HasForeignKey(d => d.PmscheduleEquipmentEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PMScheduleEquipment_EquipmentId");

				entity.HasOne(d => d.PmscheduleEquipmentMoTemplate)
					.WithMany(p => p.PmscheduleEquipment)
					.HasForeignKey(d => d.PmscheduleEquipmentMoTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PMScheduleEquipment_MoTemplateId");

				entity.HasOne(d => d.PmscheduleEquipmentSchedule)
					.WithMany(p => p.PmscheduleEquipmentNavigation)
					.HasForeignKey(d => d.PmscheduleEquipmentScheduleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PMScheduleEquipment_ScheduleId");
			});

			modelBuilder.Entity<PreCompiledCheckList>(entity =>
			{
				entity.Property(e => e.PreCompiledCheckListId).HasColumnName("PreCompiledCheckList_Id");

				entity.Property(e => e.PreCompiledCheckListControlFlag).HasColumnName("PreCompiledCheckList_ControlFlag");

				entity.Property(e => e.PreCompiledCheckListCreatedBy)
					.IsRequired()
					.HasColumnName("PreCompiledCheckList_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.PreCompiledCheckListCreatedDate).HasColumnName("PreCompiledCheckList_CreatedDate");

				entity.Property(e => e.PreCompiledCheckListDescription)
					.HasColumnName("PreCompiledCheckList_Description")
					.HasMaxLength(255);

				entity.Property(e => e.PreCompiledCheckListDocumentVersionId).HasColumnName("PreCompiledCheckList_DocumentVersionId");

				entity.Property(e => e.PreCompiledCheckListEquipmentId).HasColumnName("PreCompiledCheckList_EquipmentId");

				entity.Property(e => e.PreCompiledCheckListEstimatedOutageInMins).HasColumnName("PreCompiledCheckList_EstimatedOutageInMins");

				entity.Property(e => e.PreCompiledCheckListIsArEnabled).HasColumnName("PreCompiledCheckList_IsArEnabled");

				entity.Property(e => e.PreCompiledCheckListIsDeleted).HasColumnName("PreCompiledCheckList_IsDeleted");

				entity.Property(e => e.PreCompiledCheckListName)
					.IsRequired()
					.HasColumnName("PreCompiledCheckList_Name")
					.HasMaxLength(80);

				entity.Property(e => e.PreCompiledCheckListNumber)
					.HasColumnName("PreCompiledCheckList_Number")
					.HasMaxLength(50);

				entity.Property(e => e.PreCompiledCheckListReferenceId).HasColumnName("PreCompiledCheckList_ReferenceId");

				entity.Property(e => e.PreCompiledChecklistPrimaryGroupId).HasColumnName("PreCompiledChecklist_PrimaryGroupId");

				entity.Property(e => e.PreCompiledChecklistSecondaryGroupId).HasColumnName("PreCompiledChecklist_SecondaryGroupId");

				entity.Property(e => e.PreCompiledChecklistSubGroupId).HasColumnName("PreCompiledChecklist_SubGroupId");

				entity.Property(e => e.PrecompiledCheckListChapterVersionId).HasColumnName("PrecompiledCheckList_ChapterVersionId");

				entity.HasOne(d => d.PreCompiledCheckListDocumentVersion)
					.WithMany(p => p.PreCompiledCheckList)
					.HasForeignKey(d => d.PreCompiledCheckListDocumentVersionId)
					.HasConstraintName("FK_PreCompiledCheckList_DocumentVersion");

				entity.HasOne(d => d.PreCompiledCheckListEquipment)
					.WithMany(p => p.PreCompiledCheckList)
					.HasForeignKey(d => d.PreCompiledCheckListEquipmentId)
					.HasConstraintName("FK_PreCompiledCheckList_Equipment");

				entity.HasOne(d => d.PreCompiledChecklistPrimaryGroup)
					.WithMany(p => p.PreCompiledCheckListPreCompiledChecklistPrimaryGroup)
					.HasForeignKey(d => d.PreCompiledChecklistPrimaryGroupId)
					.HasConstraintName("FK_PreCompiledChecklist_EquipmentGroupPrimary");

				entity.HasOne(d => d.PreCompiledChecklistSecondaryGroup)
					.WithMany(p => p.PreCompiledCheckListPreCompiledChecklistSecondaryGroup)
					.HasForeignKey(d => d.PreCompiledChecklistSecondaryGroupId)
					.HasConstraintName("FK_PreCompiledChecklist_EquipmentGroupSecondary");

				entity.HasOne(d => d.PreCompiledChecklistSubGroup)
					.WithMany(p => p.PreCompiledCheckListPreCompiledChecklistSubGroup)
					.HasForeignKey(d => d.PreCompiledChecklistSubGroupId)
					.HasConstraintName("FK_PreCompiledChecklist_EquipmentGroupSubGroup");
			});

			modelBuilder.Entity<PreCompiledCheckListStep>(entity =>
			{
				entity.Property(e => e.PreCompiledCheckListStepId).HasColumnName("PreCompiledCheckListStep_Id");

				entity.Property(e => e.PreCompiledCheckListStepCheckListId).HasColumnName("PreCompiledCheckListStep_CheckListId");

				entity.Property(e => e.PreCompiledCheckListStepDocumentPageNumber).HasColumnName("PreCompiledCheckListStep_DocumentPageNumber");

				entity.Property(e => e.PreCompiledCheckListStepEstimatedOutageInMins).HasColumnName("PreCompiledCheckListStep_EstimatedOutageInMins");

				entity.Property(e => e.PreCompiledCheckListStepStepDescription)
					.IsRequired()
					.HasColumnName("PreCompiledCheckListStep_StepDescription")
					.HasMaxLength(1024);

				entity.Property(e => e.PreCompiledCheckListStepStepId).HasColumnName("PreCompiledCheckListStep_StepId");

				entity.HasOne(d => d.PreCompiledCheckListStepCheckList)
					.WithMany(p => p.PreCompiledCheckListStep)
					.HasForeignKey(d => d.PreCompiledCheckListStepCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PreCompiledCheckListStep_PreCompiledCheckList");
			});

			modelBuilder.Entity<PreCompiledCheckListStepPart>(entity =>
			{
				entity.Property(e => e.PreCompiledCheckListStepPartId).HasColumnName("PreCompiledCheckListStepPart_Id");

				entity.Property(e => e.PreCompiledCheckListStepPartPartId).HasColumnName("PreCompiledCheckListStepPart_PartId");

				entity.Property(e => e.PreCompiledCheckListStepPartQuantityNeeded).HasColumnName("PreCompiledCheckListStepPart_QuantityNeeded");

				entity.Property(e => e.PreCompiledCheckListStepPartStepId).HasColumnName("PreCompiledCheckListStepPart_StepId");

				entity.HasOne(d => d.PreCompiledCheckListStepPartPart)
					.WithMany(p => p.PreCompiledCheckListStepPart)
					.HasForeignKey(d => d.PreCompiledCheckListStepPartPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Parts_PreCompiledCheckListStep_Part");

				entity.HasOne(d => d.PreCompiledCheckListStepPartStep)
					.WithMany(p => p.PreCompiledCheckListStepPart)
					.HasForeignKey(d => d.PreCompiledCheckListStepPartStepId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Parts_PreCompiledCheckListStep_StepId");
			});

			modelBuilder.Entity<PreCompiledCheckListStepSkipMot>(entity =>
			{
				entity.ToTable("PreCompiledCheckListStepSkipMOT");

				entity.Property(e => e.PreCompiledCheckListStepSkipMotId).HasColumnName("PreCompiledCheckListStepSkipMOT_Id");

				entity.Property(e => e.PreCompiledCheckListStepSkipMotMoTemplateId).HasColumnName("PreCompiledCheckListStepSkipMOT_MoTemplateId");

				entity.Property(e => e.PreCompiledCheckListStepSkipMotStepId).HasColumnName("PreCompiledCheckListStepSkipMOT_StepId");

				entity.HasOne(d => d.PreCompiledCheckListStepSkipMotStep)
					.WithMany(p => p.PreCompiledCheckListStepSkipMot)
					.HasForeignKey(d => d.PreCompiledCheckListStepSkipMotStepId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PreCompiledCheckListStepSkipMOT_StepId");
			});

			modelBuilder.Entity<PreCompiledCheckListUserGroup>(entity =>
			{
				entity.Property(e => e.PreCompiledCheckListUserGroupId).HasColumnName("PreCompiledCheckListUserGroup_Id");

				entity.Property(e => e.PreCompiledCheckListUserGroupCheckListId).HasColumnName("PreCompiledCheckListUserGroup_CheckListId");

				entity.Property(e => e.PreCompiledCheckListUserGroupUserGroupId).HasColumnName("PreCompiledCheckListUserGroup_UserGroupId");

				entity.HasOne(d => d.PreCompiledCheckListUserGroupCheckList)
					.WithMany(p => p.PreCompiledCheckListUserGroup)
					.HasForeignKey(d => d.PreCompiledCheckListUserGroupCheckListId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PreCompiledCheckListUserGroup _CheckList");

				entity.HasOne(d => d.PreCompiledCheckListUserGroupUserGroup)
					.WithMany(p => p.PreCompiledCheckListUserGroup)
					.HasForeignKey(d => d.PreCompiledCheckListUserGroupUserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_PreCompiledCheckListUserGroup _UserGroup");
			});

			modelBuilder.Entity<ReasonCode>(entity =>
			{
				entity.Property(e => e.ReasonCodeId)
					.HasColumnName("ReasonCode_Id")
					.HasComment("Note:- Universe of all reason codes in the system");

				entity.Property(e => e.ReasonCodeControlFlag).HasColumnName("ReasonCode_ControlFlag");

				entity.Property(e => e.ReasonCodeCreatedBy)
					.IsRequired()
					.HasColumnName("ReasonCode_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.ReasonCodeCreatedDate).HasColumnName("ReasonCode_CreatedDate");

				entity.Property(e => e.ReasonCodeDescription)
					.HasColumnName("ReasonCode_Description")
					.HasMaxLength(255);

				entity.Property(e => e.ReasonCodeIsDeleted).HasColumnName("ReasonCode_IsDeleted");

				entity.Property(e => e.ReasonCodeName)
					.IsRequired()
					.HasColumnName("ReasonCode_Name")
					.HasMaxLength(50);

				entity.Property(e => e.ReasonCodeReferenceId).HasColumnName("ReasonCode_ReferenceId");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<ReasonCodeGroup>(entity =>
			{
				entity.Property(e => e.ReasonCodeGroupId)
					.HasColumnName("ReasonCodeGroup_Id")
					.HasComment("Notes:- Logical Grouping of Reason Codes for usability and reporting");

				entity.Property(e => e.ReasonCodeGroupControlFlag).HasColumnName("ReasonCodeGroup_ControlFlag");

				entity.Property(e => e.ReasonCodeGroupCreatedBy)
					.IsRequired()
					.HasColumnName("ReasonCodeGroup_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.ReasonCodeGroupCreatedDate).HasColumnName("ReasonCodeGroup_CreatedDate");

				entity.Property(e => e.ReasonCodeGroupDescription)
					.HasColumnName("ReasonCodeGroup_Description")
					.HasMaxLength(255);

				entity.Property(e => e.ReasonCodeGroupIsDeleted).HasColumnName("ReasonCodeGroup_IsDeleted");

				entity.Property(e => e.ReasonCodeGroupName)
					.IsRequired()
					.HasColumnName("ReasonCodeGroup_Name")
					.HasMaxLength(50);

				entity.Property(e => e.ReasonCodeGroupReferenceId).HasColumnName("ReasonCodeGroup_ReferenceId");

				entity.Property(e => e.Type).HasDefaultValueSql("((1))");
			});

			modelBuilder.Entity<ReasonCodeGroupMembers>(entity =>
			{
				entity.Property(e => e.ReasonCodeGroupMembersId)
					.HasColumnName("ReasonCodeGroupMembers_Id")
					.HasComment("Note:-  Relationship between Reason Code Group & Reason Code are Many to Many");

				entity.Property(e => e.ReasonCodeGroupMembersReasonCodeGroupId).HasColumnName("ReasonCodeGroupMembers_ReasonCodeGroupId");

				entity.Property(e => e.ReasonCodeGroupMembersReasonCodeId).HasColumnName("ReasonCodeGroupMembers_ReasonCodeId");

				entity.HasOne(d => d.ReasonCodeGroupMembersReasonCodeGroup)
					.WithMany(p => p.ReasonCodeGroupMembers)
					.HasForeignKey(d => d.ReasonCodeGroupMembersReasonCodeGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReasonCodeGroupMembers_ReasonCodeGroup");

				entity.HasOne(d => d.ReasonCodeGroupMembersReasonCode)
					.WithMany(p => p.ReasonCodeGroupMembers)
					.HasForeignKey(d => d.ReasonCodeGroupMembersReasonCodeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReasonCodeGroupMembers_ReasonCode");
			});

			modelBuilder.Entity<RepairTicket>(entity =>
			{
				entity.HasIndex(e => e.RepairTicketStatus)
					.HasName("INDX_RepairTicket_STATUS");

				entity.HasIndex(e => new { e.RepairTicketStatus, e.RepairTicketEquipmentId })
					.HasName("INDX_RepairTicket_STATUS_EQPID");

				entity.HasIndex(e => new { e.RepairTicketId, e.RepairTicketPriority, e.RepairTicketTitle, e.RepairTicketCreatedDate, e.RepairTicketNumber, e.RepairTicketStatus, e.RepairTicketEquipmentId })
					.HasName("INDX_RepairTicket_NUM_STATUS_EQP");

				entity.Property(e => e.RepairTicketId).HasColumnName("RepairTicket_Id");

				entity.Property(e => e.RepairTicketBusinessRuleId).HasColumnName("RepairTicket_BusinessRuleId");

				entity.Property(e => e.RepairTicketCancelReasonCodeId)
					.HasColumnName("RepairTicket_CancelReasonCodeId")
					.HasComment("If the ticket is cancelled, the cancellation reason code is captured here.  The cancellation comment will go to Reparir ticket Comments.");

				entity.Property(e => e.RepairTicketClosedDate).HasColumnName("RepairTicket_ClosedDate");

				entity.Property(e => e.RepairTicketCreatedDate).HasColumnName("RepairTicket_CreatedDate");

				entity.Property(e => e.RepairTicketDescription)
					.HasColumnName("RepairTicket_Description")
					.HasMaxLength(255);

				entity.Property(e => e.RepairTicketEquipmentId).HasColumnName("RepairTicket_EquipmentId");

				entity.Property(e => e.RepairTicketFailureCodeId)
					.HasColumnName("RepairTicket_FailureCodeId")
					.HasComment("Reasoncode for the failure of the equipment.  This will hold a valid Reason Code ID.");

				entity.Property(e => e.RepairTicketFailureDate)
					.HasColumnName("RepairTicket_FailureDate")
					.HasComment("The ticket could be created now but the equipment could have gone down 15 mins ago");

				entity.Property(e => e.RepairTicketIncidentDate)
					.HasColumnName("RepairTicket_IncidentDate")
					.HasComment("Always Now.  When the repair ticket is created.");

				entity.Property(e => e.RepairTicketNumber)
					.HasColumnName("RepairTicket_Number")
					.HasMaxLength(50)
					.HasComment("Repair Ticket Number.  Ex:RT000021");

				entity.Property(e => e.RepairTicketOriginator)
					.HasColumnName("RepairTicket_Originator")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketPriority)
					.HasColumnName("RepairTicket_Priority")
					.HasComment("Priority of the Repair Ticket. Critical/High/Medium/Low");

				entity.Property(e => e.RepairTicketReferenceId).HasColumnName("RepairTicket_ReferenceId");

				entity.Property(e => e.RepairTicketReportedByUserId)
					.HasColumnName("RepairTicket_ReportedByUserId")
					.HasComment("The user who reported the ticket");

				entity.Property(e => e.RepairTicketStatus)
					.HasColumnName("RepairTicket_Status")
					.HasComment("Status of the Repair ticket.  New/Cancelled/Closed");

				entity.Property(e => e.RepairTicketTitle)
					.IsRequired()
					.HasColumnName("RepairTicket_Title")
					.HasMaxLength(512)
					.HasComment("Any title the creator of the ticket gives");

				entity.HasOne(d => d.RepairTicketCancelReasonCode)
					.WithMany(p => p.RepairTicketRepairTicketCancelReasonCode)
					.HasForeignKey(d => d.RepairTicketCancelReasonCodeId)
					.HasConstraintName("FK_RepairTicket_CancelReasonCode");

				entity.HasOne(d => d.RepairTicketEquipment)
					.WithMany(p => p.RepairTicket)
					.HasForeignKey(d => d.RepairTicketEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicket_Equipment");

				entity.HasOne(d => d.RepairTicketFailureCode)
					.WithMany(p => p.RepairTicketRepairTicketFailureCode)
					.HasForeignKey(d => d.RepairTicketFailureCodeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicket_FailureReasonCode");

				entity.HasOne(d => d.RepairTicketReportedByUser)
					.WithMany(p => p.RepairTicket)
					.HasForeignKey(d => d.RepairTicketReportedByUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicket_User");
			});

			modelBuilder.Entity<RepairTicketClosedNotification>(entity =>
			{
				entity.Property(e => e.RepairTicketClosedNotificationId).HasColumnName("RepairTicketClosedNotification_Id");

				entity.Property(e => e.RepairTicketClosedNotificationRepairTicketId).HasColumnName("RepairTicketClosedNotification_RepairTicketId");

				entity.Property(e => e.RepairTicketClosedNotificationUserId).HasColumnName("RepairTicketClosedNotification_UserId");

				entity.HasOne(d => d.RepairTicketClosedNotificationRepairTicket)
					.WithMany(p => p.RepairTicketClosedNotification)
					.HasForeignKey(d => d.RepairTicketClosedNotificationRepairTicketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketClosedNotification_RepairTicket");

				entity.HasOne(d => d.RepairTicketClosedNotificationUser)
					.WithMany(p => p.RepairTicketClosedNotification)
					.HasForeignKey(d => d.RepairTicketClosedNotificationUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketClosedNotification_User");
			});

			modelBuilder.Entity<RepairTicketComment>(entity =>
			{
				entity.Property(e => e.RepairTicketCommentId).HasColumnName("RepairTicketComment_Id");

				entity.Property(e => e.RepairTicketCommentComment)
					.IsRequired()
					.HasColumnName("RepairTicketComment_Comment")
					.HasMaxLength(4000);

				entity.Property(e => e.RepairTicketCommentCommentAddedByUserId)
					.HasColumnName("RepairTicketComment_CommentAddedByUserId")
					.HasComment("User id of the person adding this comment");

				entity.Property(e => e.RepairTicketCommentCommentCreatedDate)
					.HasColumnName("RepairTicketComment_CommentCreatedDate")
					.HasComment("Date and Time by when the comment was added");

				entity.Property(e => e.RepairTicketCommentFileName)
					.HasColumnName("RepairTicketComment_FileName")
					.HasMaxLength(255);

				entity.Property(e => e.RepairTicketCommentRepairTicketId).HasColumnName("RepairTicketComment_RepairTicketId");

				entity.HasOne(d => d.RepairTicketCommentCommentAddedByUser)
					.WithMany(p => p.RepairTicketComment)
					.HasForeignKey(d => d.RepairTicketCommentCommentAddedByUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketComment_User");

				entity.HasOne(d => d.RepairTicketCommentRepairTicket)
					.WithMany(p => p.RepairTicketComment)
					.HasForeignKey(d => d.RepairTicketCommentRepairTicketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketComment_RepairTicket");
			});

			modelBuilder.Entity<RepairTicketHistory>(entity =>
			{
				entity.Property(e => e.RepairTicketHistoryId).HasColumnName("RepairTicketHistory_Id");

				entity.Property(e => e.RepairTicketHistoryFromState).HasColumnName("RepairTicketHistory_FromState");

				entity.Property(e => e.RepairTicketHistoryInitiatedByUserId).HasColumnName("RepairTicketHistory_InitiatedByUserId");

				entity.Property(e => e.RepairTicketHistoryInitiatedDate).HasColumnName("RepairTicketHistory_InitiatedDate");

				entity.Property(e => e.RepairTicketHistoryRepairTicketId).HasColumnName("RepairTicketHistory_RepairTicketId");

				entity.Property(e => e.RepairTicketHistoryToState).HasColumnName("RepairTicketHistory_ToState");

				entity.HasOne(d => d.RepairTicketHistoryInitiatedByUser)
					.WithMany(p => p.RepairTicketHistory)
					.HasForeignKey(d => d.RepairTicketHistoryInitiatedByUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketHistory_User");

				entity.HasOne(d => d.RepairTicketHistoryRepairTicket)
					.WithMany(p => p.RepairTicketHistory)
					.HasForeignKey(d => d.RepairTicketHistoryRepairTicketId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketHistory_RepairTicket");
			});

			modelBuilder.Entity<RepairTicketSummary>(entity =>
			{
				entity.Property(e => e.RepairTicketSummaryId).HasColumnName("RepairTicketSummary_Id");

				entity.Property(e => e.RepairTicketSummaryAreaId).HasColumnName("RepairTicketSummary_AreaId");

				entity.Property(e => e.RepairTicketSummaryAreaName)
					.HasColumnName("RepairTicketSummary_AreaName")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketSummaryCalendarDate).HasColumnName("RepairTicketSummary_CalendarDate");

				entity.Property(e => e.RepairTicketSummaryClosedDate).HasColumnName("RepairTicketSummary_ClosedDate");

				entity.Property(e => e.RepairTicketSummaryCreatedDate).HasColumnName("RepairTicketSummary_CreatedDate");

				entity.Property(e => e.RepairTicketSummaryDownTimeInMin).HasColumnName("RepairTicketSummary_DownTimeInMin");

				entity.Property(e => e.RepairTicketSummaryEquipmentId).HasColumnName("RepairTicketSummary_EquipmentId");

				entity.Property(e => e.RepairTicketSummaryEquipmentName)
					.HasColumnName("RepairTicketSummary_EquipmentName")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketSummaryMaintenanceOrderNumber)
					.HasColumnName("RepairTicketSummary_MaintenanceOrderNumber")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketSummaryRepairTicketNumber)
					.HasColumnName("RepairTicketSummary_RepairTicketNumber")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketSummaryTotalTimeInMin).HasColumnName("RepairTicketSummary_TotalTimeInMin");

				entity.HasOne(d => d.RepairTicketSummaryArea)
					.WithMany(p => p.RepairTicketSummary)
					.HasForeignKey(d => d.RepairTicketSummaryAreaId)
					.HasConstraintName("FK_RepairTicketSummary_Area");

				entity.HasOne(d => d.RepairTicketSummaryEquipment)
					.WithMany(p => p.RepairTicketSummary)
					.HasForeignKey(d => d.RepairTicketSummaryEquipmentId)
					.HasConstraintName("FK_RepairTicketSummary_Equipment");
			});

			modelBuilder.Entity<RepairTicketTemplate>(entity =>
			{
				entity.Property(e => e.RepairTicketTemplateId).HasColumnName("RepairTicketTemplate_Id");

				entity.Property(e => e.RepairTicketTemplateControlFlag).HasColumnName("RepairTicketTemplate_ControlFlag");

				entity.Property(e => e.RepairTicketTemplateCreatedDate).HasColumnName("RepairTicketTemplate_CreatedDate");

				entity.Property(e => e.RepairTicketTemplateDescription)
					.HasColumnName("RepairTicketTemplate_Description")
					.HasMaxLength(255);

				entity.Property(e => e.RepairTicketTemplateEquipmentId).HasColumnName("RepairTicketTemplate_EquipmentId");

				entity.Property(e => e.RepairTicketTemplateFailureCodeId)
					.HasColumnName("RepairTicketTemplate_FailureCodeId")
					.HasComment("Reasoncode for the failure of the equipment.  This will hold a valid Reason Code ID.");

				entity.Property(e => e.RepairTicketTemplateIncidentDate)
					.HasColumnName("RepairTicketTemplate_IncidentDate")
					.HasComment("Always Now.  When the repair ticket is created.");

				entity.Property(e => e.RepairTicketTemplateIsDeleted).HasColumnName("RepairTicketTemplate_IsDeleted");

				entity.Property(e => e.RepairTicketTemplateNumber)
					.HasColumnName("RepairTicketTemplate_Number")
					.HasMaxLength(50)
					.HasComment("Repair Ticket Number.  Ex:RT000021");

				entity.Property(e => e.RepairTicketTemplateOriginator)
					.HasColumnName("RepairTicketTemplate_Originator")
					.HasMaxLength(50);

				entity.Property(e => e.RepairTicketTemplatePriority)
					.HasColumnName("RepairTicketTemplate_Priority")
					.HasComment("Priority of the Repair Ticket. Critical/High/Medium/Low");

				entity.Property(e => e.RepairTicketTemplateReferenceId).HasColumnName("RepairTicketTemplate_ReferenceId");

				entity.Property(e => e.RepairTicketTemplateReportedByUserId)
					.HasColumnName("RepairTicketTemplate_ReportedByUserId")
					.HasComment("The user who reported the ticket");

				entity.Property(e => e.RepairTicketTemplateTitle)
					.IsRequired()
					.HasColumnName("RepairTicketTemplate_Title")
					.HasMaxLength(512)
					.HasComment("Any title the creator of the ticket gives");

				entity.HasOne(d => d.RepairTicketTemplateEquipment)
					.WithMany(p => p.RepairTicketTemplate)
					.HasForeignKey(d => d.RepairTicketTemplateEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketTemplate_Equipment");

				entity.HasOne(d => d.RepairTicketTemplateFailureCode)
					.WithMany(p => p.RepairTicketTemplate)
					.HasForeignKey(d => d.RepairTicketTemplateFailureCodeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketTemplate_FailureReasonCode");

				entity.HasOne(d => d.RepairTicketTemplateReportedByUser)
					.WithMany(p => p.RepairTicketTemplate)
					.HasForeignKey(d => d.RepairTicketTemplateReportedByUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketTemplate_User");
			});

			modelBuilder.Entity<RepairTicketTemplateClosedNotification>(entity =>
			{
				entity.Property(e => e.RepairTicketTemplateClosedNotificationId).HasColumnName("RepairTicketTemplateClosedNotification_Id");

				entity.Property(e => e.RepairTicketTemplateClosedNotificationRepairTicketTemplateId).HasColumnName("RepairTicketTemplateClosedNotification_RepairTicketTemplateId");

				entity.Property(e => e.RepairTicketTemplateClosedNotificationUserId).HasColumnName("RepairTicketTemplateClosedNotification_UserId");

				entity.HasOne(d => d.RepairTicketTemplateClosedNotificationRepairTicketTemplate)
					.WithMany(p => p.RepairTicketTemplateClosedNotification)
					.HasForeignKey(d => d.RepairTicketTemplateClosedNotificationRepairTicketTemplateId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketTemplateClosedNotification_RepairTicketTemplate");

				entity.HasOne(d => d.RepairTicketTemplateClosedNotificationUser)
					.WithMany(p => p.RepairTicketTemplateClosedNotification)
					.HasForeignKey(d => d.RepairTicketTemplateClosedNotificationUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_RepairTicketTemplateClosedNotification_User");
			});

			modelBuilder.Entity<ReplenishStock>(entity =>
			{
				entity.Property(e => e.ReplenishStockId).HasColumnName("ReplenishStock_Id");

				entity.Property(e => e.LastUpdatedBy)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.ReplenishStockAreaId).HasColumnName("ReplenishStock_AreaId");

				entity.Property(e => e.ReplenishStockBinId).HasColumnName("ReplenishStock_BinId");

				entity.Property(e => e.ReplenishStockCreatedBy)
					.IsRequired()
					.HasColumnName("ReplenishStock_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.ReplenishStockCreatedDate).HasColumnName("ReplenishStock_CreatedDate");

				entity.Property(e => e.ReplenishStockLocationId).HasColumnName("ReplenishStock_LocationId");

				entity.Property(e => e.ReplenishStockOrderedQty).HasColumnName("ReplenishStock_OrderedQty");

				entity.Property(e => e.ReplenishStockPartId).HasColumnName("ReplenishStock_PartId");

				entity.Property(e => e.ReplenishStockPono)
					.IsRequired()
					.HasColumnName("ReplenishStock_PONo")
					.HasMaxLength(100);

				entity.Property(e => e.ReplenishStockPrimaryVendorId)
					.IsRequired()
					.HasColumnName("ReplenishStock_PrimaryVendorId")
					.HasMaxLength(510);

				entity.Property(e => e.ReplenishStockReceivedQty).HasColumnName("ReplenishStock_ReceivedQty");

				entity.Property(e => e.ReplenishStockRejectedQty).HasColumnName("ReplenishStock_RejectedQty");

				entity.Property(e => e.ReplenishStockSubLocationId).HasColumnName("ReplenishStock_SubLocationId");
			});

			modelBuilder.Entity<ReportFilter>(entity =>
			{
				entity.Property(e => e.ReportFilterId).HasColumnName("ReportFilter_Id");

				entity.Property(e => e.ReportFilterFilterTypeId)
					.HasColumnName("ReportFilter_FilterTypeId")
					.HasComment("Id of the report filter type Id which is mapped to the report");

				entity.Property(e => e.ReportFilterReportId)
					.HasColumnName("ReportFilter_ReportId")
					.HasComment("Report Id");

				entity.HasOne(d => d.ReportFilterFilterType)
					.WithMany(p => p.ReportFilter)
					.HasForeignKey(d => d.ReportFilterFilterTypeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReportFilter_ReportFilterType");

				entity.HasOne(d => d.ReportFilterReport)
					.WithMany(p => p.ReportFilter)
					.HasForeignKey(d => d.ReportFilterReportId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ReportFilter_ReportMaster");
			});

			modelBuilder.Entity<ReportFilterOption>(entity =>
			{
				entity.Property(e => e.ReportFilterOptionId).HasColumnName("ReportFilterOption_Id");

				entity.Property(e => e.ReportFilterOptionFilterTypeId).HasColumnName("ReportFilterOption_FilterTypeId");

				entity.Property(e => e.ReportFilterOptionOptionId).HasColumnName("ReportFilterOption_OptionId");

				entity.Property(e => e.ReportFilterOptionOptionName)
					.HasColumnName("ReportFilterOption_OptionName")
					.HasMaxLength(50);

				entity.HasOne(d => d.ReportFilterOptionFilterType)
					.WithMany(p => p.ReportFilterOption)
					.HasForeignKey(d => d.ReportFilterOptionFilterTypeId)
					.HasConstraintName("FK_ReportFilterOption_ReportFilterType");
			});

			modelBuilder.Entity<ReportFilterType>(entity =>
			{
				entity.Property(e => e.ReportFilterTypeId).HasColumnName("ReportFilterType_Id");

				entity.Property(e => e.ReportFilterTypeInputType)
					.HasColumnName("ReportFilterType_InputType")
					.HasComment("Specifies whether the filter is of multiselect, etc.,");

				entity.Property(e => e.ReportFilterTypeName)
					.IsRequired()
					.HasColumnName("ReportFilterType_Name")
					.HasMaxLength(50)
					.HasComment("Name of the report filter");
			});

			modelBuilder.Entity<ReportMaster>(entity =>
			{
				entity.Property(e => e.ReportMasterId).HasColumnName("ReportMaster_Id");

				entity.Property(e => e.ReportMasterFunctionName)
					.IsRequired()
					.HasColumnName("ReportMaster_FunctionName")
					.HasMaxLength(255)
					.HasComment("Name of the Stored Procedure to be executed.");

				entity.Property(e => e.ReportMasterName)
					.IsRequired()
					.HasColumnName("ReportMaster_Name")
					.HasMaxLength(50)
					.HasComment("Report Name.");

				entity.Property(e => e.ReportMasterType)
					.HasColumnName("ReportMaster_Type")
					.HasComment("Specifies whether the report is of standard or custom type.");
			});

			modelBuilder.Entity<SerialPartTransaction>(entity =>
			{
				entity.Property(e => e.SerialPartTransactionId).HasColumnName("SerialPartTransaction_Id");

				entity.Property(e => e.SerialPartTransactionCheckOutInType).HasColumnName("SerialPartTransaction_CheckOutInType");

				entity.Property(e => e.SerialPartTransactionPartSerialNumberId).HasColumnName("SerialPartTransaction_PartSerialNumberId");

				entity.Property(e => e.SerialPartTransactionPartTransactionId).HasColumnName("SerialPartTransaction_PartTransactionId");

				entity.Property(e => e.SerialPartTransactionQuantity).HasColumnName("SerialPartTransaction_Quantity");

				entity.HasOne(d => d.SerialPartTransactionPartSerialNumber)
					.WithMany(p => p.SerialPartTransaction)
					.HasForeignKey(d => d.SerialPartTransactionPartSerialNumberId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SerialPartTransaction_PartSerialNumber");

				entity.HasOne(d => d.SerialPartTransactionPartTransaction)
					.WithMany(p => p.SerialPartTransaction)
					.HasForeignKey(d => d.SerialPartTransactionPartTransactionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SerialPartTransaction_PartTransaction");
			});

			modelBuilder.Entity<SerialToolKitTransaction>(entity =>
			{
				entity.Property(e => e.SerialToolKitTransactionId).HasColumnName("SerialToolKitTransaction_Id");

				entity.Property(e => e.SerialToolKitTransactionCheckOutInType).HasColumnName("SerialToolKitTransaction_CheckOutInType");

				entity.Property(e => e.SerialToolKitTransactionPartSerialNumberId).HasColumnName("SerialToolKitTransaction_PartSerialNumberId");

				entity.Property(e => e.SerialToolKitTransactionQuantity).HasColumnName("SerialToolKitTransaction_Quantity");

				entity.Property(e => e.SerialToolKitTransactionToolKitTransactionId).HasColumnName("SerialToolKitTransaction_ToolKitTransactionId");

				entity.HasOne(d => d.SerialToolKitTransactionPartSerialNumber)
					.WithMany(p => p.SerialToolKitTransaction)
					.HasForeignKey(d => d.SerialToolKitTransactionPartSerialNumberId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SerialToolKitTransaction_PartSerialNumber");

				entity.HasOne(d => d.SerialToolKitTransactionToolKitTransaction)
					.WithMany(p => p.SerialToolKitTransaction)
					.HasForeignKey(d => d.SerialToolKitTransactionToolKitTransactionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SerialToolKitTransaction_ToolKitTransaction");
			});

			modelBuilder.Entity<Site>(entity =>
			{
				entity.Property(e => e.SiteId).HasColumnName("Site_Id");

				entity.Property(e => e.SiteAddressLine1)
					.HasColumnName("Site_AddressLine1")
					.HasMaxLength(255);

				entity.Property(e => e.SiteAddressLine2)
					.HasColumnName("Site_AddressLine2")
					.HasMaxLength(255);

				entity.Property(e => e.SiteCity)
					.HasColumnName("Site_City")
					.HasMaxLength(100);

				entity.Property(e => e.SiteContactPhoneNumber)
					.HasColumnName("Site_ContactPhoneNumber")
					.HasMaxLength(50);

				entity.Property(e => e.SiteControlFlag).HasColumnName("Site_ControlFlag");

				entity.Property(e => e.SiteDescription)
					.HasColumnName("Site_Description")
					.HasMaxLength(510);

				entity.Property(e => e.SiteIsDeleted).HasColumnName("Site_IsDeleted");

				entity.Property(e => e.SiteName)
					.HasColumnName("Site_Name")
					.HasMaxLength(100);

				entity.Property(e => e.SiteNumber).HasColumnName("Site_Number");

				entity.Property(e => e.SitePostalCode)
					.HasColumnName("Site_PostalCode")
					.HasMaxLength(50);

				entity.Property(e => e.SiteReferenceId).HasColumnName("Site_ReferenceId");

				entity.Property(e => e.SiteState)
					.HasColumnName("Site_State")
					.HasMaxLength(100);
			});

			modelBuilder.Entity<SiteAttribute>(entity =>
			{
				entity.Property(e => e.SiteAttributeId).HasColumnName("SiteAttribute_Id");

				entity.Property(e => e.SiteAttributeAttributeId).HasColumnName("SiteAttribute_AttributeId");

				entity.Property(e => e.SiteAttributeSiteId).HasColumnName("SiteAttribute_SiteId");

				entity.Property(e => e.SiteAttributeValue)
					.HasColumnName("SiteAttribute_Value")
					.HasMaxLength(50);

				entity.HasOne(d => d.SiteAttributeAttribute)
					.WithMany(p => p.SiteAttribute)
					.HasForeignKey(d => d.SiteAttributeAttributeId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SiteAttribute_Attribute");

				entity.HasOne(d => d.SiteAttributeSite)
					.WithMany(p => p.SiteAttribute)
					.HasForeignKey(d => d.SiteAttributeSiteId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SiteAttribute_Site");
			});

			modelBuilder.Entity<Software>(entity =>
			{
				entity.Property(e => e.SoftwareId).HasColumnName("Software_Id");

				entity.Property(e => e.SoftwareActive)
					.HasColumnName("Software_Active")
					.HasDefaultValueSql("((1))");

				entity.Property(e => e.SoftwareControlFlag).HasColumnName("Software_ControlFlag");

				entity.Property(e => e.SoftwareCreatedBy)
					.IsRequired()
					.HasColumnName("Software_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.SoftwareCreatedDate).HasColumnName("Software_CreatedDate");

				entity.Property(e => e.SoftwareDescription)
					.HasColumnName("Software_Description")
					.HasMaxLength(255);

				entity.Property(e => e.SoftwareIsDeleted).HasColumnName("Software_IsDeleted");

				entity.Property(e => e.SoftwareName)
					.HasColumnName("Software_Name")
					.HasMaxLength(50);

				entity.Property(e => e.SoftwarePrimaryGroupId).HasColumnName("Software_PrimaryGroupId");

				entity.Property(e => e.SoftwareReferenceId).HasColumnName("Software_ReferenceId");

				entity.Property(e => e.SoftwareSecondaryGroupId).HasColumnName("Software_SecondaryGroupId");

				entity.Property(e => e.SoftwareSubGroupId).HasColumnName("Software_SubGroupId");

				entity.Property(e => e.SoftwareVersionNumber)
					.HasColumnName("Software_VersionNumber")
					.HasMaxLength(25)
					.IsFixedLength();

				entity.HasOne(d => d.SoftwarePrimaryGroup)
					.WithMany(p => p.SoftwareSoftwarePrimaryGroup)
					.HasForeignKey(d => d.SoftwarePrimaryGroupId)
					.HasConstraintName("FK_Software_EquipmentGroupPrimary");

				entity.HasOne(d => d.SoftwareSecondaryGroup)
					.WithMany(p => p.SoftwareSoftwareSecondaryGroup)
					.HasForeignKey(d => d.SoftwareSecondaryGroupId)
					.HasConstraintName("FK_Software_EquipmentGroupSecondary");

				entity.HasOne(d => d.SoftwareSubGroup)
					.WithMany(p => p.SoftwareSoftwareSubGroup)
					.HasForeignKey(d => d.SoftwareSubGroupId)
					.HasConstraintName("FK_Software_EquipmentGroupSubGroup");
			});

			modelBuilder.Entity<SoftwareAppliesTo>(entity =>
			{
				entity.ToTable("Software_AppliesTo");

				entity.Property(e => e.SoftwareAppliesToId).HasColumnName("Software_AppliesTo_Id");

				entity.Property(e => e.SoftwareAppliesToModelNumber)
					.IsRequired()
					.HasColumnName("Software_AppliesTo_ModelNumber")
					.HasMaxLength(50);

				entity.Property(e => e.SoftwareAppliesToSoftwareId).HasColumnName("Software_AppliesTo_SoftwareId");

				entity.HasOne(d => d.SoftwareAppliesToSoftware)
					.WithMany(p => p.SoftwareAppliesTo)
					.HasForeignKey(d => d.SoftwareAppliesToSoftwareId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_Software_AppliesTo_Software");
			});

			modelBuilder.Entity<SoftwareTargets>(entity =>
			{
				entity.Property(e => e.SoftwareTargetsId).HasColumnName("SoftwareTargets_Id");

				entity.Property(e => e.SoftwareTargetsActiveFrom).HasColumnName("SoftwareTargets_ActiveFrom");

				entity.Property(e => e.SoftwareTargetsActiveTill).HasColumnName("SoftwareTargets_ActiveTill");

				entity.Property(e => e.SoftwareTargetsAreaId).HasColumnName("SoftwareTargets_AreaId");

				entity.Property(e => e.SoftwareTargetsSoftwareId).HasColumnName("SoftwareTargets_SoftwareId");

				entity.Property(e => e.SoftwareTargetsSoftwareVersion)
					.HasColumnName("SoftwareTargets_SoftwareVersion")
					.HasMaxLength(10);

				entity.HasOne(d => d.SoftwareTargetsArea)
					.WithMany(p => p.SoftwareTargets)
					.HasForeignKey(d => d.SoftwareTargetsAreaId)
					.HasConstraintName("FK_SoftwareTargets_Area");

				entity.HasOne(d => d.SoftwareTargetsSoftware)
					.WithMany(p => p.SoftwareTargets)
					.HasForeignKey(d => d.SoftwareTargetsSoftwareId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SoftwareTargets_Software");
			});

			modelBuilder.Entity<SoftwareUpgradeSchedule>(entity =>
			{
				entity.Property(e => e.SoftwareUpgradeScheduleId).HasColumnName("SoftwareUpgradeSchedule_Id");

				entity.Property(e => e.SoftwareUpgradeScheduleAppliesToAll).HasColumnName("SoftwareUpgradeSchedule_AppliesToAll");

				entity.Property(e => e.SoftwareUpgradeScheduleAreaId).HasColumnName("SoftwareUpgradeSchedule_AreaId");

				entity.Property(e => e.SoftwareUpgradeScheduleControlFlag).HasColumnName("SoftwareUpgradeSchedule_ControlFlag");

				entity.Property(e => e.SoftwareUpgradeScheduleIsDeleted).HasColumnName("SoftwareUpgradeSchedule_IsDeleted");

				entity.Property(e => e.SoftwareUpgradeScheduleReferenceId).HasColumnName("SoftwareUpgradeSchedule_ReferenceId");

				entity.Property(e => e.SoftwareUpgradeScheduleScheduledDate).HasColumnName("SoftwareUpgradeSchedule_ScheduledDate");

				entity.Property(e => e.SoftwareUpgradeScheduleSoftwareId).HasColumnName("SoftwareUpgradeSchedule_SoftwareId");

				entity.Property(e => e.SoftwareUpgradeScheduleStatus).HasColumnName("SoftwareUpgradeSchedule_Status");

				entity.Property(e => e.SoftwareUpgradeScheduleVersionNumber)
					.IsRequired()
					.HasColumnName("SoftwareUpgradeSchedule_VersionNumber")
					.HasMaxLength(50);

				entity.HasOne(d => d.SoftwareUpgradeScheduleArea)
					.WithMany(p => p.SoftwareUpgradeSchedule)
					.HasForeignKey(d => d.SoftwareUpgradeScheduleAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SoftwareUpgradeSchedule_Area");

				entity.HasOne(d => d.SoftwareUpgradeScheduleSoftware)
					.WithMany(p => p.SoftwareUpgradeSchedule)
					.HasForeignKey(d => d.SoftwareUpgradeScheduleSoftwareId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SoftwareUpgradeSchedule_Software");

				entity.HasOne(d => d.SoftwareUpgradeScheduleStatusNavigation)
					.WithMany(p => p.SoftwareUpgradeSchedule)
					.HasForeignKey(d => d.SoftwareUpgradeScheduleStatus)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SoftwareUpgradeSchedule_Status");
			});

			modelBuilder.Entity<SoftwareUpgradeScheduleEquipment>(entity =>
			{
				entity.Property(e => e.SoftwareUpgradeScheduleEquipmentId).HasColumnName("SoftwareUpgradeScheduleEquipment_Id");

				entity.Property(e => e.SoftwareUpgradeScheduleEquipmentEquipmentId).HasColumnName("SoftwareUpgradeScheduleEquipment_EquipmentId");

				entity.Property(e => e.SoftwareUpgradeScheduleEquipmentSoftwareUpgradeScheduleId).HasColumnName("SoftwareUpgradeScheduleEquipment_SoftwareUpgradeScheduleId");

				entity.Property(e => e.SoftwareUpgradeScheduleEquipmentStatus)
					.HasColumnName("SoftwareUpgradeScheduleEquipment_Status")
					.HasDefaultValueSql("('1')");

				entity.HasOne(d => d.SoftwareUpgradeScheduleEquipmentEquipment)
					.WithMany(p => p.SoftwareUpgradeScheduleEquipment)
					.HasForeignKey(d => d.SoftwareUpgradeScheduleEquipmentEquipmentId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SoftwareUpgradeScheduleEquipment_Equipment");

				entity.HasOne(d => d.SoftwareUpgradeScheduleEquipmentSoftwareUpgradeSchedule)
					.WithMany(p => p.SoftwareUpgradeScheduleEquipment)
					.HasForeignKey(d => d.SoftwareUpgradeScheduleEquipmentSoftwareUpgradeScheduleId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SoftwareUpgradeScheduleEquipment_SoftwareUpgradeScheduleId");
			});

			modelBuilder.Entity<SoftwareUpgradeStatus>(entity =>
			{
				entity.Property(e => e.SoftwareUpgradeStatusId).HasColumnName("SoftwareUpgradeStatus_Id");

				entity.Property(e => e.SoftwareUpgradeStatusDescription)
					.HasColumnName("SoftwareUpgradeStatus_Description")
					.HasMaxLength(255);

				entity.Property(e => e.SoftwareUpgradeStatusName)
					.IsRequired()
					.HasColumnName("SoftwareUpgradeStatus_Name")
					.HasMaxLength(50);
			});

			modelBuilder.Entity<SoftwareVersion>(entity =>
			{
				entity.Property(e => e.SoftwareVersionId).HasColumnName("SoftwareVersion_Id");

				entity.Property(e => e.SoftwareVersionCreatedBy)
					.IsRequired()
					.HasColumnName("SoftwareVersion_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.SoftwareVersionCreatedDate).HasColumnName("SoftwareVersion_CreatedDate");

				entity.Property(e => e.SoftwareVersionFileName)
					.IsRequired()
					.HasColumnName("SoftwareVersion_FileName")
					.HasMaxLength(255);

				entity.Property(e => e.SoftwareVersionIsValid).HasColumnName("SoftwareVersion_IsValid");

				entity.Property(e => e.SoftwareVersionSoftwareId).HasColumnName("SoftwareVersion_SoftwareId");

				entity.Property(e => e.SoftwareVersionVersionNumber)
					.HasColumnName("SoftwareVersion_VersionNumber")
					.HasMaxLength(50);

				entity.HasOne(d => d.SoftwareVersionSoftware)
					.WithMany(p => p.SoftwareVersion)
					.HasForeignKey(d => d.SoftwareVersionSoftwareId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_SoftwareVersion_Software");
			});

			modelBuilder.Entity<StockingNotificationMailConfiguration>(entity =>
			{
				entity.Property(e => e.StockingNotificationMailConfigurationId).HasColumnName("StockingNotificationMailConfiguration_Id");

				entity.Property(e => e.StockingNotificationMailConfigurationAreaId).HasColumnName("StockingNotificationMailConfiguration_AreaId");

				entity.Property(e => e.StockingNotificationMailConfigurationEmail)
					.HasColumnName("StockingNotificationMailConfiguration_Email")
					.HasMaxLength(1000)
					.IsUnicode(false);

				entity.HasOne(d => d.StockingNotificationMailConfigurationArea)
					.WithMany(p => p.StockingNotificationMailConfiguration)
					.HasForeignKey(d => d.StockingNotificationMailConfigurationAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockingNotificationMailConfiguration_Area");
			});

			modelBuilder.Entity<StockingNotificationUser>(entity =>
			{
				entity.HasIndex(e => new { e.StockingNotificationId, e.UserId })
					.HasName("INDX_StockingNotificationUser_USERID");

				entity.HasIndex(e => new { e.UserId, e.StockingNotificationId, e.UserActionStatus })
					.HasName("INDX_StockingNotificationUser");

				entity.Property(e => e.StockingNotificationUserId).HasColumnName("StockingNotificationUser_Id");

				entity.HasOne(d => d.StockingNotification)
					.WithMany(p => p.StockingNotificationUser)
					.HasForeignKey(d => d.StockingNotificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockingNotificationUser_StockingNotification");

				entity.HasOne(d => d.User)
					.WithMany(p => p.StockingNotificationUser)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockingNotificationUser_User");
			});

			modelBuilder.Entity<StockingNotificationUserGroups>(entity =>
			{
				entity.Property(e => e.StockingNotificationUserGroupsId).HasColumnName("StockingNotificationUserGroups_Id");

				entity.Property(e => e.StockingNotificationUserGroupsAreaId).HasColumnName("StockingNotificationUserGroups_AreaId");

				entity.Property(e => e.StockingNotificationUserGroupsUserGroupId).HasColumnName("StockingNotificationUserGroups_UserGroupId");

				entity.HasOne(d => d.StockingNotificationUserGroupsArea)
					.WithMany(p => p.StockingNotificationUserGroups)
					.HasForeignKey(d => d.StockingNotificationUserGroupsAreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockingNotificationUserGroups_Area");

				entity.HasOne(d => d.StockingNotificationUserGroupsUserGroup)
					.WithMany(p => p.StockingNotificationUserGroups)
					.HasForeignKey(d => d.StockingNotificationUserGroupsUserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_StockingNotificationUserGroups_UserGroup");
			});

			modelBuilder.Entity<SubLocation>(entity =>
			{
				entity.Property(e => e.SubLocationId).HasColumnName("SubLocation_Id");

				entity.Property(e => e.SubLocationLocationId).HasColumnName("SubLocation_LocationId");

				entity.Property(e => e.SubLocationName)
					.IsRequired()
					.HasColumnName("SubLocation_Name")
					.HasMaxLength(50);

				entity.HasOne(d => d.SubLocationLocation)
					.WithMany(p => p.SubLocation)
					.HasForeignKey(d => d.SubLocationLocationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("fk_sublocations");
			});

			modelBuilder.Entity<ToolKit>(entity =>
			{
				entity.Property(e => e.ToolKitId).HasColumnName("ToolKit_Id");

				entity.Property(e => e.ToolKitPartId).HasColumnName("ToolKit_PartId");

				entity.Property(e => e.ToolKitQuantity).HasColumnName("ToolKit_Quantity");

				entity.Property(e => e.ToolKitSubPartId).HasColumnName("ToolKit_SubPartId");

				entity.HasOne(d => d.ToolKitPart)
					.WithMany(p => p.ToolKitToolKitPart)
					.HasForeignKey(d => d.ToolKitPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ToolKit_Part");

				entity.HasOne(d => d.ToolKitSubPart)
					.WithMany(p => p.ToolKitToolKitSubPart)
					.HasForeignKey(d => d.ToolKitSubPartId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ToolKit_SubPart");
			});

			modelBuilder.Entity<ToolKitSerialPart>(entity =>
			{
				entity.Property(e => e.ToolKitSerialPartId).HasColumnName("ToolKitSerialPart_Id");

				entity.Property(e => e.ToolKitSerialPartPartSerialNumberId).HasColumnName("ToolKitSerialPart_PartSerialNumberId");

				entity.Property(e => e.ToolKitSerialPartToolKitId).HasColumnName("ToolKitSerialPart_ToolKitId");

				entity.HasOne(d => d.ToolKitSerialPartPartSerialNumber)
					.WithMany(p => p.ToolKitSerialPart)
					.HasForeignKey(d => d.ToolKitSerialPartPartSerialNumberId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ToolKitSerialPart_PartSerialNumber");

				entity.HasOne(d => d.ToolKitSerialPartToolKit)
					.WithMany(p => p.ToolKitSerialPart)
					.HasForeignKey(d => d.ToolKitSerialPartToolKitId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ToolKitSerialPart_ToolKit");
			});

			modelBuilder.Entity<ToolKitTransaction>(entity =>
			{
				entity.Property(e => e.ToolKitTransactionId).HasColumnName("ToolKitTransaction_Id");

				entity.Property(e => e.ToolKitTransactionCheckOutInType).HasColumnName("ToolKitTransaction_CheckOutInType");

				entity.Property(e => e.ToolKitTransactionDateTime).HasColumnName("ToolKitTransaction_DateTime");

				entity.Property(e => e.ToolKitTransactionPartTransactionId).HasColumnName("ToolKitTransaction_PartTransactionId");

				entity.Property(e => e.ToolKitTransactionQuantity).HasColumnName("ToolKitTransaction_Quantity");

				entity.Property(e => e.ToolKitTransactionReason)
					.HasColumnName("ToolKitTransaction_Reason")
					.HasMaxLength(255);

				entity.Property(e => e.ToolKitTransactionToolKitId).HasColumnName("ToolKitTransaction_ToolKitId");

				entity.HasOne(d => d.ToolKitTransactionPartTransaction)
					.WithMany(p => p.ToolKitTransaction)
					.HasForeignKey(d => d.ToolKitTransactionPartTransactionId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ToolKitTransaction_PartTransaction");

				entity.HasOne(d => d.ToolKitTransactionToolKit)
					.WithMany(p => p.ToolKitTransaction)
					.HasForeignKey(d => d.ToolKitTransactionToolKitId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_ToolKitTransaction_ToolKit");
			});

			modelBuilder.Entity<UnitOfCost>(entity =>
			{
				entity.Property(e => e.Currency)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Symbol)
					.IsRequired()
					.HasMaxLength(10);
			});

			modelBuilder.Entity<UnitOfMeasure>(entity =>
			{
				entity.Property(e => e.UnitOfMeasureId)
					.HasColumnName("UnitOfMeasure_Id")
					.HasComment("Note:- Simple Model as of now, Needs to implement Complex UOM with base UOM and conversion etc in upcoming releases");

				entity.Property(e => e.UnitOfMeasureControlFlag).HasColumnName("UnitOfMeasure_ControlFlag");

				entity.Property(e => e.UnitOfMeasureDescription)
					.HasColumnName("UnitOfMeasure_Description")
					.HasMaxLength(255)
					.HasComment("UOM Description");

				entity.Property(e => e.UnitOfMeasureIsDeleted).HasColumnName("UnitOfMeasure_IsDeleted");

				entity.Property(e => e.UnitOfMeasureName)
					.IsRequired()
					.HasColumnName("UnitOfMeasure_Name")
					.HasMaxLength(50)
					.HasComment("UOM Name");

				entity.Property(e => e.UnitOfMeasureReferenceId).HasColumnName("UnitOfMeasure_ReferenceId");
			});

			modelBuilder.Entity<User>(entity =>
			{
				entity.Property(e => e.UserId).HasColumnName("User_Id");

				entity.Property(e => e.UserControlFlag).HasColumnName("User_ControlFlag");

				entity.Property(e => e.UserCreatedBy)
					.IsRequired()
					.HasColumnName("User_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.UserCreatedDate).HasColumnName("User_CreatedDate");

				entity.Property(e => e.UserDefaultLanguage).HasColumnName("User_DefaultLanguage");

				entity.Property(e => e.UserDescription)
					.HasColumnName("User_Description")
					.HasMaxLength(255)
					.HasComment("Notes");

				entity.Property(e => e.UserEmailId)
					.HasColumnName("User_EmailId")
					.HasMaxLength(50);

				entity.Property(e => e.UserExtension).HasColumnName("User_Extension");

				entity.Property(e => e.UserFirstName)
					.IsRequired()
					.HasColumnName("User_FirstName")
					.HasMaxLength(50);

				entity.Property(e => e.UserInvalidAttempts).HasColumnName("User_InvalidAttempts");

				entity.Property(e => e.UserIsActive)
					.IsRequired()
					.HasColumnName("User_IsActive")
					.HasDefaultValueSql("((1))")
					.HasComment("Temporarily Deactivate a user, 1=Active, 0=InActive");

				entity.Property(e => e.UserIsDeleted).HasColumnName("User_IsDeleted");

				entity.Property(e => e.UserIsPasswordReset).HasColumnName("User_IsPasswordReset");

				entity.Property(e => e.UserLastName)
					.IsRequired()
					.HasColumnName("User_LastName")
					.HasMaxLength(50);

				entity.Property(e => e.UserLoginId)
					.IsRequired()
					.HasColumnName("User_LoginId")
					.HasMaxLength(50)
					.HasComment("LoginId");

				entity.Property(e => e.UserPassword)
					.IsRequired()
					.HasColumnName("User_Password")
					.HasMaxLength(255);

				entity.Property(e => e.UserPhoneNumber)
					.HasColumnName("User_PhoneNumber")
					.HasMaxLength(50);

				entity.Property(e => e.UserPrimaryGroupId)
					.HasColumnName("User_PrimaryGroupId")
					.HasComment("User could be part of multiple groups, This field will store primary group id");

				entity.Property(e => e.UserReferenceId).HasColumnName("User_ReferenceId");

				entity.Property(e => e.UserUnLockTimeStamp).HasColumnName("User_UnLockTimeStamp");

				entity.HasOne(d => d.UserDefaultLanguageNavigation)
					.WithMany(p => p.User)
					.HasForeignKey(d => d.UserDefaultLanguage)
					.HasConstraintName("FK_User_AppLanguage");

				entity.HasOne(d => d.UserPrimaryGroup)
					.WithMany(p => p.User)
					.HasForeignKey(d => d.UserPrimaryGroupId)
					.HasConstraintName("FK_User_UserGroup");
			});

			modelBuilder.Entity<UserCertAreaAssociation>(entity =>
			{
				entity.HasOne(d => d.Area)
					.WithMany(p => p.UserCertAreaAssociation)
					.HasForeignKey(d => d.AreaId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertAreaAssociation_Area");

				entity.HasOne(d => d.Certification)
					.WithMany(p => p.UserCertAreaAssociation)
					.HasForeignKey(d => d.CertificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertAreaAssociation_UserCertificationList");
			});

			modelBuilder.Entity<UserCertAssignedUserList>(entity =>
			{
				entity.HasOne(d => d.Certification)
					.WithMany(p => p.UserCertAssignedUserList)
					.HasForeignKey(d => d.CertificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertAssignedUserList_UserCertificationList");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserCertAssignedUserList)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertAssignedUserList_User");
			});

			modelBuilder.Entity<UserCertNotificationMapping>(entity =>
			{
				entity.HasOne(d => d.Certification)
					.WithMany(p => p.UserCertNotificationMapping)
					.HasForeignKey(d => d.CertificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertNotificationMapping_UserCertificationList");

				entity.HasOne(d => d.CertificationResult)
					.WithMany(p => p.UserCertNotificationMapping)
					.HasForeignKey(d => d.CertificationResultId)
					.HasConstraintName("FK_UserCertNotificationMapping_UserCertificationResults");

				entity.HasOne(d => d.Notification)
					.WithMany(p => p.UserCertNotificationMapping)
					.HasForeignKey(d => d.NotificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertNotificationMapping_StockingNotification");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserCertNotificationMapping)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertNotificationMapping_User");
			});

			modelBuilder.Entity<UserCertTrainerExternalMailList>(entity =>
			{
				entity.Property(e => e.NotifyEmailAddress).HasMaxLength(1000);

				entity.HasOne(d => d.Certification)
					.WithMany(p => p.UserCertTrainerExternalMailList)
					.HasForeignKey(d => d.CertificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertTrainerExternalMailList_UserCertificationList");
			});

			modelBuilder.Entity<UserCertTrainerUserList>(entity =>
			{
				entity.HasOne(d => d.Certification)
					.WithMany(p => p.UserCertTrainerUserList)
					.HasForeignKey(d => d.CertificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertTrainerUserList_UserCertificationList");

				entity.HasOne(d => d.User)
					.WithMany(p => p.UserCertTrainerUserList)
					.HasForeignKey(d => d.UserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertTrainerUserList_User");
			});

			modelBuilder.Entity<UserCertificationList>(entity =>
			{
				entity.Property(e => e.Description).HasMaxLength(255);

				entity.Property(e => e.Name)
					.IsRequired()
					.HasMaxLength(50);

				entity.Property(e => e.Number).HasMaxLength(50);

				entity.Property(e => e.UserCertificationListReferenceId).HasColumnName("UserCertificationList_ReferenceId");
			});

			modelBuilder.Entity<UserCertificationResultStepList>(entity =>
			{
				entity.Property(e => e.MaxValue).HasMaxLength(50);

				entity.Property(e => e.MinValue).HasMaxLength(50);

				entity.Property(e => e.StepDescription)
					.IsRequired()
					.HasMaxLength(1024);

				entity.Property(e => e.Value).HasMaxLength(50);

				entity.HasOne(d => d.CertificationResult)
					.WithMany(p => p.UserCertificationResultStepList)
					.HasForeignKey(d => d.CertificationResultId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertificationResultStepList_UserCertificationResults");
			});

			modelBuilder.Entity<UserCertificationResults>(entity =>
			{
				entity.HasOne(d => d.Certification)
					.WithMany(p => p.UserCertificationResults)
					.HasForeignKey(d => d.CertificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertificationResults_UserCertificationList");

				entity.HasOne(d => d.PerformedUser)
					.WithMany(p => p.UserCertificationResultsPerformedUser)
					.HasForeignKey(d => d.PerformedUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertificationResults_User");

				entity.HasOne(d => d.RecordedUser)
					.WithMany(p => p.UserCertificationResultsRecordedUser)
					.HasForeignKey(d => d.RecordedUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertificationResults_User1");
			});

			modelBuilder.Entity<UserCertificationStepList>(entity =>
			{
				entity.Property(e => e.MaxValue).HasMaxLength(50);

				entity.Property(e => e.MinValue).HasMaxLength(50);

				entity.Property(e => e.StepDescription)
					.IsRequired()
					.HasMaxLength(1024);

				entity.HasOne(d => d.Certification)
					.WithMany(p => p.UserCertificationStepList)
					.HasForeignKey(d => d.CertificationId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserCertificationStepList_UserCertificationList");
			});

			modelBuilder.Entity<UserGroup>(entity =>
			{
				entity.Property(e => e.UserGroupId).HasColumnName("UserGroup_Id");

				entity.Property(e => e.UserGroupControlFlag).HasColumnName("UserGroup_ControlFlag");

				entity.Property(e => e.UserGroupCreatedBy)
					.IsRequired()
					.HasColumnName("UserGroup_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.UserGroupCreatedDate).HasColumnName("UserGroup_CreatedDate");

				entity.Property(e => e.UserGroupDescription)
					.HasColumnName("UserGroup_Description")
					.HasMaxLength(255)
					.HasComment("Short Description about the group");

				entity.Property(e => e.UserGroupEmailId)
					.HasColumnName("UserGroup_EmailId")
					.HasMaxLength(50)
					.HasComment("Group email id");

				entity.Property(e => e.UserGroupIsDeleted).HasColumnName("UserGroup_IsDeleted");

				entity.Property(e => e.UserGroupName)
					.IsRequired()
					.HasColumnName("UserGroup_Name")
					.HasMaxLength(50)
					.HasComment("Name of the Usergroup");

				entity.Property(e => e.UserGroupReferenceId).HasColumnName("UserGroup_ReferenceId");
			});

			modelBuilder.Entity<UserGroupClaim>(entity =>
			{
				entity.Property(e => e.UserGroupClaimId)
					.HasColumnName("UserGroupClaim_Id")
					.HasComment("Note: User group/Claim combination means the usergroup has access to the functionality marked by the claim");

				entity.Property(e => e.UserGroupClaimClaimId).HasColumnName("UserGroupClaim_ClaimId");

				entity.Property(e => e.UserGroupClaimUserGroupId).HasColumnName("UserGroupClaim_UserGroupId");

				entity.HasOne(d => d.UserGroupClaimClaim)
					.WithMany(p => p.UserGroupClaim)
					.HasForeignKey(d => d.UserGroupClaimClaimId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserGroupClaim_ClaimMaster");

				entity.HasOne(d => d.UserGroupClaimUserGroup)
					.WithMany(p => p.UserGroupClaim)
					.HasForeignKey(d => d.UserGroupClaimUserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserGroupClaim_UserGroup");
			});

			modelBuilder.Entity<UserGroupMembers>(entity =>
			{
				entity.Property(e => e.UserGroupMembersId).HasColumnName("UserGroupMembers_Id");

				entity.Property(e => e.UserGroupMembersUserGroupId).HasColumnName("UserGroupMembers_UserGroupId");

				entity.Property(e => e.UserGroupMembersUserId).HasColumnName("UserGroupMembers_UserId");

				entity.HasOne(d => d.UserGroupMembersUserGroup)
					.WithMany(p => p.UserGroupMembers)
					.HasForeignKey(d => d.UserGroupMembersUserGroupId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserGroupMembers_UserGroup");

				entity.HasOne(d => d.UserGroupMembersUser)
					.WithMany(p => p.UserGroupMembers)
					.HasForeignKey(d => d.UserGroupMembersUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserGroupMembers_User");
			});

			modelBuilder.Entity<UserLoginHistory>(entity =>
			{
				entity.Property(e => e.UserLoginHistoryId)
					.HasColumnName("UserLoginHistory_Id")
					.HasComment("Note:- Maintain Login Hisotry");

				entity.Property(e => e.UserLoginHistoryLoginTime).HasColumnName("UserLoginHistory_LoginTime");

				entity.Property(e => e.UserLoginHistoryLogoutTime).HasColumnName("UserLoginHistory_LogoutTime");

				entity.Property(e => e.UserLoginHistorySessionId)
					.HasColumnName("UserLoginHistory_SessionId")
					.HasMaxLength(255);

				entity.Property(e => e.UserLoginHistoryUserId).HasColumnName("UserLoginHistory_UserId");

				entity.HasOne(d => d.UserLoginHistoryUser)
					.WithMany(p => p.UserLoginHistory)
					.HasForeignKey(d => d.UserLoginHistoryUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserLoginHistory_User");
			});

			modelBuilder.Entity<UserPreference>(entity =>
			{
				entity.Property(e => e.UserPreferenceId).HasColumnName("UserPreference_Id");

				entity.Property(e => e.UserPreferenceMasterId).HasColumnName("UserPreference_MasterId");

				entity.Property(e => e.UserPreferenceUserId).HasColumnName("UserPreference_UserId");

				entity.Property(e => e.UserPreferenceValue)
					.HasColumnName("UserPreference_Value")
					.HasMaxLength(4000);

				entity.HasOne(d => d.UserPreferenceMaster)
					.WithMany(p => p.UserPreference)
					.HasForeignKey(d => d.UserPreferenceMasterId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserPreference_UserPreferenceMaster");

				entity.HasOne(d => d.UserPreferenceUser)
					.WithMany(p => p.UserPreference)
					.HasForeignKey(d => d.UserPreferenceUserId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_UserPreference_User");
			});

			modelBuilder.Entity<UserPreferenceMaster>(entity =>
			{
				entity.Property(e => e.UserPreferenceMasterId)
					.HasColumnName("UserPreferenceMaster_Id")
					.HasComment("Note:-  The description to display on the UI about every preference should be stored in resource file for localization");

				entity.Property(e => e.UserPreferenceMasterCategory)
					.IsRequired()
					.HasColumnName("UserPreferenceMaster_Category")
					.HasMaxLength(50);

				entity.Property(e => e.UserPreferenceMasterControlFlag).HasColumnName("UserPreferenceMaster_ControlFlag");

				entity.Property(e => e.UserPreferenceMasterIsDeleted).HasColumnName("UserPreferenceMaster_IsDeleted");

				entity.Property(e => e.UserPreferenceMasterName)
					.IsRequired()
					.HasColumnName("UserPreferenceMaster_Name")
					.HasMaxLength(50)
					.HasComment("Preference Name");

				entity.Property(e => e.UserPreferenceMasterReference)
					.HasColumnName("UserPreferenceMaster_Reference")
					.HasMaxLength(255)
					.HasComment("If Reference Type, Data Source. For example ReasonCode_Name");

				entity.Property(e => e.UserPreferenceMasterType)
					.HasColumnName("UserPreferenceMaster_Type")
					.HasDefaultValueSql("((1))")
					.HasComment("1 = String or 2=int or 3= Reference Type");
			});

			modelBuilder.Entity<Vendor>(entity =>
			{
				entity.Property(e => e.VendorId).HasColumnName("Vendor_Id");

				entity.Property(e => e.VendorAddress1)
					.HasColumnName("Vendor_Address1")
					.HasMaxLength(100);

				entity.Property(e => e.VendorAddress2)
					.HasColumnName("Vendor_Address2")
					.HasMaxLength(100);

				entity.Property(e => e.VendorBuilding)
					.HasColumnName("Vendor_Building")
					.HasMaxLength(100);

				entity.Property(e => e.VendorCity)
					.HasColumnName("Vendor_City")
					.HasMaxLength(100);

				entity.Property(e => e.VendorControlFlag).HasColumnName("Vendor_ControlFlag");

				entity.Property(e => e.VendorCountryId).HasColumnName("Vendor_CountryId");

				entity.Property(e => e.VendorCreatedBy)
					.IsRequired()
					.HasColumnName("Vendor_CreatedBy")
					.HasMaxLength(50);

				entity.Property(e => e.VendorCreatedDate).HasColumnName("Vendor_CreatedDate");

				entity.Property(e => e.VendorDescription)
					.HasColumnName("Vendor_Description")
					.HasMaxLength(255);

				entity.Property(e => e.VendorEmailId)
					.HasColumnName("Vendor_EmailId")
					.HasMaxLength(100);

				entity.Property(e => e.VendorIsDeleted).HasColumnName("Vendor_IsDeleted");

				entity.Property(e => e.VendorName)
					.IsRequired()
					.HasColumnName("Vendor_Name")
					.HasMaxLength(50);

				entity.Property(e => e.VendorPhoneNumber)
					.HasColumnName("Vendor_PhoneNumber")
					.HasMaxLength(50)
					.HasComment("Vendor Phone number -  No particular format");

				entity.Property(e => e.VendorPostalCode)
					.HasColumnName("Vendor_PostalCode")
					.HasMaxLength(50);

				entity.Property(e => e.VendorPrimaryContactName)
					.HasColumnName("Vendor_PrimaryContactName")
					.HasMaxLength(100)
					.HasComment("Contact Person in the Vendor company");

				entity.Property(e => e.VendorReferenceId).HasColumnName("Vendor_ReferenceId");

				entity.Property(e => e.VendorState)
					.HasColumnName("Vendor_State")
					.HasMaxLength(100);

				entity.Property(e => e.VendorWebsite)
					.HasColumnName("Vendor_Website")
					.HasMaxLength(100);

				entity.HasOne(d => d.VendorCountry)
					.WithMany(p => p.Vendor)
					.HasForeignKey(d => d.VendorCountryId)
					.HasConstraintName("FK_Vendor_Country");
			});

			modelBuilder.Entity<VendorContact>(entity =>
			{
				entity.Property(e => e.Address)
					.HasMaxLength(50)
					.IsFixedLength();

				entity.Property(e => e.DeptArea)
					.HasMaxLength(50)
					.IsFixedLength();

				entity.Property(e => e.EmailId)
					.HasMaxLength(50)
					.IsFixedLength();

				entity.Property(e => e.Name)
					.HasMaxLength(50)
					.IsFixedLength();

				entity.Property(e => e.PhoneNumber)
					.HasMaxLength(50)
					.IsFixedLength();

				entity.Property(e => e.PostalCode)
					.HasMaxLength(50)
					.IsFixedLength();

				entity.HasOne(d => d.Country)
					.WithMany(p => p.VendorContact)
					.HasForeignKey(d => d.CountryId)
					.HasConstraintName("FK_VendorContact_Country");

				entity.HasOne(d => d.Vendor)
					.WithMany(p => p.VendorContact)
					.HasForeignKey(d => d.VendorId)
					.OnDelete(DeleteBehavior.ClientSetNull)
					.HasConstraintName("FK_VendorContact_Vendor");
			});

			modelBuilder.Entity<WipSetting>(entity =>
			{
				entity.Property(e => e.WipSettingId).HasColumnName("WipSetting_ID");

				entity.Property(e => e.WipSettingIntegrationId).HasColumnName("WipSetting_IntegrationID");

				entity.Property(e => e.WipSettingIntegrationServerId).HasColumnName("WipSetting_IntegrationServerID");

				entity.Property(e => e.WipSettingIsIntegrated).HasColumnName("WipSetting_IsIntegrated");

				entity.HasOne(d => d.WipSettingIntegration)
					.WithMany(p => p.WipSetting)
					.HasForeignKey(d => d.WipSettingIntegrationId)
					.HasConstraintName("FK_WipSetting_IntegrationID");

				entity.HasOne(d => d.WipSettingIntegrationServer)
					.WithMany(p => p.WipSetting)
					.HasForeignKey(d => d.WipSettingIntegrationServerId)
					.OnDelete(DeleteBehavior.Cascade)
					.HasConstraintName("FK_WipSetting_IntegrationServerID");
			});

			OnModelCreatingPartial(modelBuilder);
		}

		partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
	}
}
