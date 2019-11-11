using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentMeterHistory
    {
        public EquipmentMeterHistory()
        {
            ExtfeederParameters = new HashSet<ExtfeederParameters>();
        }

        public int EquipmentMeterHistoryId { get; set; }
        public int EquipmentMeterHistoryMeterId { get; set; }
        public string EquipmentMeterHistoryName { get; set; }
        public int? EquipmentMeterHistoryType { get; set; }
        public double EquipmentMeterHistoryValue { get; set; }
        public string EquipmentMeterHistoryUom { get; set; }
        public double? EquipmentMeterHistoryMinValue { get; set; }
        public double? EquipmentMeterHistoryMaxValue { get; set; }
        public int EquipmentMeterHistoryTotalNumberOfReadings { get; set; }
        public double? EquipmentMeterHistoryLastReading { get; set; }
        public long? EquipmentMeterHistoryLastReadingTimeStamp { get; set; }
        public double? EquipmentMeterHistoryAvgRocInValue { get; set; }
        public double? EquipmentMeterHistoryAvgRocInTime { get; set; }
        public long? EquipmentMeterHistoryTimeStamp { get; set; }
        public string EquipmentMeterHistoryParameters { get; set; }

        public virtual EquipmentMeter EquipmentMeterHistoryMeter { get; set; }
        public virtual ICollection<ExtfeederParameters> ExtfeederParameters { get; set; }
    }
}
