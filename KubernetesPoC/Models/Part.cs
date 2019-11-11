using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Part
    {
        public Part()
        {
            CycleCountPart = new HashSet<CycleCountPart>();
            CycleCountPartList = new HashSet<CycleCountPartList>();
            KnowledgeBaseSparePart = new HashSet<KnowledgeBaseSparePart>();
            MoParts = new HashSet<MoParts>();
            MoPreCompiledCheckListStepPart = new HashSet<MoPreCompiledCheckListStepPart>();
            MoTemplatePartEstimate = new HashSet<MoTemplatePartEstimate>();
            PartDelivery = new HashSet<PartDelivery>();
            PartGroupMembers = new HashSet<PartGroupMembers>();
            PartInformationDocuments = new HashSet<PartInformationDocuments>();
            PartInformationImages = new HashSet<PartInformationImages>();
            PartInventory = new HashSet<PartInventory>();
            PartNotification = new HashSet<PartNotification>();
            PartSerialNumber = new HashSet<PartSerialNumber>();
            PartSubstitute = new HashSet<PartSubstitute>();
            PartTransaction = new HashSet<PartTransaction>();
            PreCompiledCheckListStepPart = new HashSet<PreCompiledCheckListStepPart>();
            ToolKitToolKitPart = new HashSet<ToolKit>();
            ToolKitToolKitSubPart = new HashSet<ToolKit>();
        }

        public int PartId { get; set; }
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public string PartVendorPartNumber { get; set; }
        public int PartPrimaryVendorId { get; set; }
        public string PartDescription { get; set; }
        public int PartUnitOfMeasureId { get; set; }
        public decimal? PartCost { get; set; }
        public int PartLocationId { get; set; }
        public string PartCreatedBy { get; set; }
        public long PartCreatedDate { get; set; }
        public bool PartIsNonConsumable { get; set; }
        public int? PartLeadTime { get; set; }
        public int? PartPartClassId { get; set; }
        public bool? PartIsSerialNumberEnabled { get; set; }
        public string PartPhoto { get; set; }
        public bool PartIsToolKit { get; set; }
        public bool PartIsToolKitInComplete { get; set; }
        public double? PartUsedPerMachine { get; set; }
        public int PartControlFlag { get; set; }
        public bool PartIsDeleted { get; set; }
        public Guid? PartReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public int PartPartType { get; set; }
        public bool? PartIsPartKit { get; set; }
        public bool? PartIsHazardous { get; set; }
        public bool? PartIsObsoletePart { get; set; }
        public double? PartMinQuantity { get; set; }
        public double? PartMaxQuantity { get; set; }

        public virtual Location PartLocation { get; set; }
        public virtual InventoryTurnLevel PartPartClass { get; set; }
        public virtual Vendor PartPrimaryVendor { get; set; }
        public virtual UnitOfMeasure PartUnitOfMeasure { get; set; }
        public virtual ICollection<CycleCountPart> CycleCountPart { get; set; }
        public virtual ICollection<CycleCountPartList> CycleCountPartList { get; set; }
        public virtual ICollection<KnowledgeBaseSparePart> KnowledgeBaseSparePart { get; set; }
        public virtual ICollection<MoParts> MoParts { get; set; }
        public virtual ICollection<MoPreCompiledCheckListStepPart> MoPreCompiledCheckListStepPart { get; set; }
        public virtual ICollection<MoTemplatePartEstimate> MoTemplatePartEstimate { get; set; }
        public virtual ICollection<PartDelivery> PartDelivery { get; set; }
        public virtual ICollection<PartGroupMembers> PartGroupMembers { get; set; }
        public virtual ICollection<PartInformationDocuments> PartInformationDocuments { get; set; }
        public virtual ICollection<PartInformationImages> PartInformationImages { get; set; }
        public virtual ICollection<PartInventory> PartInventory { get; set; }
        public virtual ICollection<PartNotification> PartNotification { get; set; }
        public virtual ICollection<PartSerialNumber> PartSerialNumber { get; set; }
        public virtual ICollection<PartSubstitute> PartSubstitute { get; set; }
        public virtual ICollection<PartTransaction> PartTransaction { get; set; }
        public virtual ICollection<PreCompiledCheckListStepPart> PreCompiledCheckListStepPart { get; set; }
        public virtual ICollection<ToolKit> ToolKitToolKitPart { get; set; }
        public virtual ICollection<ToolKit> ToolKitToolKitSubPart { get; set; }
    }
}
