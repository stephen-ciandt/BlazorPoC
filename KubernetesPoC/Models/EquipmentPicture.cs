using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentPicture
    {
        public EquipmentPicture()
        {
            EquipmentArZone = new HashSet<EquipmentArZone>();
        }

        public int EquipmentPictureId { get; set; }
        public int EquipmentPictureEquipmentId { get; set; }
        public int EquipmentPictureAngle { get; set; }
        public string EquipmentPictureImage { get; set; }
        public int EquipmentPictureWidth { get; set; }
        public int EquipmentPictureHeight { get; set; }
        public int Type { get; set; }

        public virtual Equipment EquipmentPictureEquipment { get; set; }
        public virtual ICollection<EquipmentArZone> EquipmentArZone { get; set; }
    }
}
