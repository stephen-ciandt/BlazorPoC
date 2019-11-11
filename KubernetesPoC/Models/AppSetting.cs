using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AppSetting
    {
        public int AppSettingId { get; set; }
        public string AppSettingCategory { get; set; }
        public string AppSettingValue { get; set; }
        public string AppSettingName { get; set; }
        public string AppSettingType { get; set; }
        public string AppSettingReference { get; set; }
        public int AppSettingControlFlag { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public string GroupName { get; set; }
        public int Sequence { get; set; }
    }
}
