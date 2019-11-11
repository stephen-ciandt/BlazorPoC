using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CycleCount
    {
        public CycleCount()
        {
            CycleCountAssets = new HashSet<CycleCountAssets>();
            CycleCountNotification = new HashSet<CycleCountNotification>();
            CycleCountPart = new HashSet<CycleCountPart>();
            CycleCountPartList = new HashSet<CycleCountPartList>();
            CycleCountResources = new HashSet<CycleCountResources>();
            InventorySchedules = new HashSet<InventorySchedules>();
        }

        public long Id { get; set; }
        public string RefNumber { get; set; }
        public int TemplateId { get; set; }
        public short EstimatedDuration { get; set; }
        public string Description { get; set; }
        public int TotalPartsByLines { get; set; }
        public int TotalPartsByCount { get; set; }
        public double TotalPriceOfParts { get; set; }
        public DateTime DueDate { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public bool IsTemplate { get; set; }
        public int AreaId { get; set; }
        public int LocationId { get; set; }
        public int? SubLocationId { get; set; }
        public int? BinId { get; set; }
        public int CreatedBy { get; set; }
        public long CreatedDate { get; set; }
        public long? StartedDate { get; set; }
        public long? EndDate { get; set; }
        public int? CancelReasonCodeId { get; set; }
        public string CancelComments { get; set; }
        public bool IsPrinted { get; set; }
        public int? UserExecuting { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public int CycleCountCategory { get; set; }
        public string CycleCountTitle { get; set; }
        public int? CycleCountSiteId { get; set; }
        public int? CycleCountScheduleId { get; set; }

        public virtual Area Area { get; set; }
        public virtual Bin Bin { get; set; }
        public virtual ReasonCode CancelReasonCode { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Site CycleCountSite { get; set; }
        public virtual Location Location { get; set; }
        public virtual SubLocation SubLocation { get; set; }
        public virtual User UserExecutingNavigation { get; set; }
        public virtual ICollection<CycleCountAssets> CycleCountAssets { get; set; }
        public virtual ICollection<CycleCountNotification> CycleCountNotification { get; set; }
        public virtual ICollection<CycleCountPart> CycleCountPart { get; set; }
        public virtual ICollection<CycleCountPartList> CycleCountPartList { get; set; }
        public virtual ICollection<CycleCountResources> CycleCountResources { get; set; }
        public virtual ICollection<InventorySchedules> InventorySchedules { get; set; }
    }
}
