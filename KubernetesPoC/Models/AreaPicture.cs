using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AreaPicture
    {
        public AreaPicture()
        {
            AreaArZone = new HashSet<AreaArZone>();
        }

        public int AreaPictureId { get; set; }
        public int AreaPictureAreaId { get; set; }
        public string AreaPictureImage { get; set; }
        public int AreaPictureWidth { get; set; }
        public int AreaPictureHeight { get; set; }

        public virtual Area AreaPictureArea { get; set; }
        public virtual ICollection<AreaArZone> AreaArZone { get; set; }
    }
}
