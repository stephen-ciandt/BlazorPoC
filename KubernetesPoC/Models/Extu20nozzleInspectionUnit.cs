using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Extu20nozzleInspectionUnit
    {
        public int Extu20nozzleInspectionUnitId { get; set; }
        public string Extu20nozzleInspectionUnitMoNumber { get; set; }
        public int? Extu20nozzleInspectionUnitMoId { get; set; }
        public string Extu20nozzleInspectionUnitSerialNumber { get; set; }
        public int? Extu20nozzleInspectionUnitEquipmentId { get; set; }
        public string Extu20nozzleInspectionUnitEquipmentName { get; set; }
        public string Extu20nozzleInspectionUnitTestUnitSerialNumber { get; set; }
        public string Extu20nozzleInspectionUnitNozzleType { get; set; }
        public int? Extu20nozzleInspectionUnitNozzleStatus { get; set; }
        public string Extu20nozzleInspectionUnitUnitUsageTime { get; set; }
        public long? Extu20nozzleInspectionUnitRecordedDate { get; set; }
    }
}
