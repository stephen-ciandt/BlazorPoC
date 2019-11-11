using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CheckListZoneMapping
    {
        public int CheckListZoneMappingId { get; set; }
        public int CheckListZoneMappingCheckListId { get; set; }
        public int CheckListZoneMappingZoneId { get; set; }

        public virtual PreCompiledCheckList CheckListZoneMappingCheckList { get; set; }
        public virtual EquipmentArZone CheckListZoneMappingZone { get; set; }
    }
}
