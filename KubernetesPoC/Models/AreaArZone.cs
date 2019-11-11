using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AreaArZone
    {
        public int AreaArZoneId { get; set; }
        public int AreaArZoneAreaPictureId { get; set; }
        public int AreaArZoneEquipmentId { get; set; }
        public int AreaArZoneXpos { get; set; }
        public int AreaArZoneYpos { get; set; }
        public int AreaArZoneWidth { get; set; }
        public int AreaArZoneHeight { get; set; }

        public virtual AreaPicture AreaArZoneAreaPicture { get; set; }
        public virtual Equipment AreaArZoneEquipment { get; set; }
    }
}
