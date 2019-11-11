using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ActiveMaintenanceOrders
    {
        public int Id { get; set; }
        public int Priority { get; set; }
        public string MoNumber { get; set; }
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public int AssetType { get; set; }
        public int PrimaryAreaId { get; set; }
        public string PrimaryAreaName { get; set; }
        public string Title { get; set; }
        public long? DueDate { get; set; }
        public long? StartDate { get; set; }
        public int Status { get; set; }
        public int ReasonCodeId { get; set; }
        public string ReasonCodeName { get; set; }
        public int AlertType { get; set; }
    }
}
