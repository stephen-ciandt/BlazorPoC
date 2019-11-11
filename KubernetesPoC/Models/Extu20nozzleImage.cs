using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Extu20nozzleImage
    {
        public int Extu20nozzleImageId { get; set; }
        public string Extu20nozzleImageMoNumber { get; set; }
        public int? Extu20nozzleImageMoId { get; set; }
        public string Extu20nozzleImageSerialNumber { get; set; }
        public int? Extu20nozzleImageEquipmentId { get; set; }
        public string Extu20nozzleImageEquipmentName { get; set; }
        public int? Extu20nozzleImageInspectionStatus { get; set; }
        public long? Extu20nozzleImageRecordedDate { get; set; }
    }
}
