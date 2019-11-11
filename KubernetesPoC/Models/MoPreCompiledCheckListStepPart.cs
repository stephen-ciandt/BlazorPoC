using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoPreCompiledCheckListStepPart
    {
        public int MoPreCompiledCheckListStepPartId { get; set; }
        public double? MoPreCompiledCheckListStepPartQuantityNeeded { get; set; }
        public int MoPreCompiledCheckListStepPartPartId { get; set; }
        public int MoPreCompiledCheckListStepPartMoCheckListStepId { get; set; }

        public virtual MoPreCompiledCheckListStep MoPreCompiledCheckListStepPartMoCheckListStep { get; set; }
        public virtual Part MoPreCompiledCheckListStepPartPart { get; set; }
    }
}
