using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UnitOfMeasure
    {
        public UnitOfMeasure()
        {
            MoParts = new HashSet<MoParts>();
            MoTemplatePartEstimate = new HashSet<MoTemplatePartEstimate>();
            Part = new HashSet<Part>();
        }

        public int UnitOfMeasureId { get; set; }
        public string UnitOfMeasureName { get; set; }
        public string UnitOfMeasureDescription { get; set; }
        public int UnitOfMeasureControlFlag { get; set; }
        public bool UnitOfMeasureIsDeleted { get; set; }
        public Guid? UnitOfMeasureReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<MoParts> MoParts { get; set; }
        public virtual ICollection<MoTemplatePartEstimate> MoTemplatePartEstimate { get; set; }
        public virtual ICollection<Part> Part { get; set; }
    }
}
