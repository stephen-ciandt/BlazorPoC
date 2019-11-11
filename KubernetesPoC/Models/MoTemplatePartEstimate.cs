using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoTemplatePartEstimate
    {
        public int MoTemplatePartEstimateId { get; set; }
        public int MoTemplatePartEstimateMoTemplateId { get; set; }
        public decimal? MoTemplatePartEstimateQuantityNeeded { get; set; }
        public int MoTemplatePartEstimatePartId { get; set; }
        public int MoTemplatePartEstimateUnitOfMeasureId { get; set; }

        public virtual MaintenanceOrderTemplate MoTemplatePartEstimateMoTemplate { get; set; }
        public virtual Part MoTemplatePartEstimatePart { get; set; }
        public virtual UnitOfMeasure MoTemplatePartEstimateUnitOfMeasure { get; set; }
    }
}
