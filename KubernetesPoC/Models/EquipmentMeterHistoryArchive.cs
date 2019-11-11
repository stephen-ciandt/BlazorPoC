using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentMeterHistoryArchive
    {
        public int EquipmentMeterHistoryArchiveId { get; set; }
        public int EquipmentMeterHistoryArchiveMeterId { get; set; }
        public string EquipmentMeterHistoryArchiveName { get; set; }
        public int? EquipmentMeterHistoryArchiveType { get; set; }
        public double EquipmentMeterHistoryArchiveValue { get; set; }
        public string EquipmentMeterHistoryArchiveUom { get; set; }
        public double? EquipmentMeterHistoryArchiveMinValue { get; set; }
        public double? EquipmentMeterHistoryArchiveMaxValue { get; set; }
        public int EquipmentMeterHistoryArchiveTotalNumberOfReadings { get; set; }
        public double? EquipmentMeterHistoryArchiveLastReading { get; set; }
        public long? EquipmentMeterHistoryArchiveLastReadingTimeStamp { get; set; }
        public double? EquipmentMeterHistoryArchiveAvgRocInValue { get; set; }
        public double? EquipmentMeterHistoryArchiveAvgRocInTime { get; set; }
        public long? EquipmentMeterHistoryArchiveTimeStamp { get; set; }
        public string EquipmentMeterHistoryArchiveParameters { get; set; }
    }
}
