using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class FactoryHour
    {
        public int FactoryHourId { get; set; }
        public int WeekDay { get; set; }
        public long StartDate { get; set; }
        public long EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool Fullday { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
    }
}
