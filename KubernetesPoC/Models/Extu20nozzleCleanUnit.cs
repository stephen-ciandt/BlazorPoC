using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Extu20nozzleCleanUnit
    {
        public int Extu20nozzleCleanUnitId { get; set; }
        public string Extu20nozzleCleanUnitMoNumber { get; set; }
        public int? Extu20nozzleCleanUnitMoId { get; set; }
        public string Extu20nozzleCleanUnitSerialNumber { get; set; }
        public int? Extu20nozzleCleanUnitEquipmentId { get; set; }
        public string Extu20nozzleCleanUnitEquipmentName { get; set; }
        public string Extu20nozzleCleanUnitTestUnitSerialNumber { get; set; }
        public string Extu20nozzleCleanUnitNozzleType { get; set; }
        public int? Extu20nozzleCleanUnitCleanStatus { get; set; }
        public string Extu20nozzleCleanUnitUnitUsageTime { get; set; }
        public long? Extu20nozzleCleanUnitRecordedDate { get; set; }
    }
}
