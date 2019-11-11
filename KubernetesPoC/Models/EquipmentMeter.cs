using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentMeter
    {
        public EquipmentMeter()
        {
            EquipmentMeterHistory = new HashSet<EquipmentMeterHistory>();
        }

        public int EquipmentMeterId { get; set; }
        public int EquipmentMeterEquipmentId { get; set; }
        public string EquipmentMeterName { get; set; }
        public int? EquipmentMeterType { get; set; }
        public double EquipmentMeterValue { get; set; }
        public string EquipmentMeterUom { get; set; }
        public double? EquipmentMeterMinValue { get; set; }
        public double? EquipmentMeterMaxValue { get; set; }
        public int EquipmentMeterTotalNumberOfReadings { get; set; }
        public double? EquipmentMeterLastReading { get; set; }
        public long? EquipmentMeterLastReadingTimeStamp { get; set; }
        public double? EquipmentMeterAvgRocInValue { get; set; }
        public double? EquipmentMeterAvgRocInTime { get; set; }
        public string EquipmentMeterParameters { get; set; }

        public virtual Equipment EquipmentMeterEquipment { get; set; }
        public virtual ICollection<EquipmentMeterHistory> EquipmentMeterHistory { get; set; }
    }
}
