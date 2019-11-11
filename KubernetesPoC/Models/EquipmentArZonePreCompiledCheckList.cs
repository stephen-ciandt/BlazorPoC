using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentArZonePreCompiledCheckList
    {
        public int EquipmentArZonePreCompiledCheckListId { get; set; }
        public int EquipmentArZonePreCompiledCheckListPreCompiledCheckListId { get; set; }
        public int EquipmentArZonePreCompiledCheckListEquipmentArZoneId { get; set; }

        public virtual EquipmentArZone EquipmentArZonePreCompiledCheckListEquipmentArZone { get; set; }
        public virtual PreCompiledCheckList EquipmentArZonePreCompiledCheckListPreCompiledCheckList { get; set; }
    }
}
