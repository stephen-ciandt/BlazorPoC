using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class FactoryCalendar
    {
        public int FactoryCalendarId { get; set; }
        public int? AreaId { get; set; }
        public string Event { get; set; }
        public string EventDescription { get; set; }
        public long StartDate { get; set; }
        public string StartTime { get; set; }
        public long EndDate { get; set; }
        public string EndTime { get; set; }
        public bool? AllDay { get; set; }
        public int? EventType { get; set; }
        public string EventColor { get; set; }
        public string Reason { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
    }
}
