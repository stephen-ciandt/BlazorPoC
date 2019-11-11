using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentArZone
    {
        public EquipmentArZone()
        {
            CheckListZoneMapping = new HashSet<CheckListZoneMapping>();
            EquipmentArZonePreCompiledCheckList = new HashSet<EquipmentArZonePreCompiledCheckList>();
        }

        public int EquipmentArZoneId { get; set; }
        public int EquipmentArZoneEquipmentPictureId { get; set; }
        public string EquipmentArZoneName { get; set; }
        public int EquipmentArZoneXpos { get; set; }
        public int EquipmentArZoneYpos { get; set; }
        public string EquipmentArZoneIcon { get; set; }
        public int Type { get; set; }

        public virtual EquipmentPicture EquipmentArZoneEquipmentPicture { get; set; }
        public virtual ICollection<CheckListZoneMapping> CheckListZoneMapping { get; set; }
        public virtual ICollection<EquipmentArZonePreCompiledCheckList> EquipmentArZonePreCompiledCheckList { get; set; }
    }
}
