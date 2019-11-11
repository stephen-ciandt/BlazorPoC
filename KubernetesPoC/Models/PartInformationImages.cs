using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartInformationImages
    {
        public int PartInformationImagesId { get; set; }
        public int PartInformationImagesPartId { get; set; }
        public string PartInformationImagesPhoto { get; set; }
        public string PartInformationImagesCreatedBy { get; set; }
        public long PartInformationImagesCreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual Part PartInformationImagesPart { get; set; }
    }
}
