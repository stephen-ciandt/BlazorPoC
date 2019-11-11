using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PreCompiledCheckListStepPart
    {
        public int PreCompiledCheckListStepPartId { get; set; }
        public double? PreCompiledCheckListStepPartQuantityNeeded { get; set; }
        public int PreCompiledCheckListStepPartPartId { get; set; }
        public int PreCompiledCheckListStepPartStepId { get; set; }

        public virtual Part PreCompiledCheckListStepPartPart { get; set; }
        public virtual PreCompiledCheckListStep PreCompiledCheckListStepPartStep { get; set; }
    }
}
