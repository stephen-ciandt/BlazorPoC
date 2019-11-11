using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Extu20nozzleVacuum
    {
        public int Extu20nozzleVacuumId { get; set; }
        public string Extu20nozzleVacuumMoNumber { get; set; }
        public int? Extu20nozzleVacuumMoId { get; set; }
        public string Extu20nozzleVacuumSerialNumber { get; set; }
        public int? Extu20nozzleVacuumEquipmentId { get; set; }
        public string Extu20nozzleVacuumEquipmentName { get; set; }
        public decimal? Extu20nozzleVacuumAirLeakStatus { get; set; }
        public decimal? Extu20nozzleVacuumAirStuffStatus { get; set; }
        public decimal? Extu20nozzleVacuumAirLeakValue { get; set; }
        public decimal? Extu20nozzleVacuumAirLeakThreshold { get; set; }
        public decimal? Extu20nozzleVacuumAirStuffValue { get; set; }
        public decimal? Extu20nozzleVacuumAirStuffThreshold { get; set; }
        public long? Extu20nozzleVacuumRecordedDate { get; set; }
    }
}
