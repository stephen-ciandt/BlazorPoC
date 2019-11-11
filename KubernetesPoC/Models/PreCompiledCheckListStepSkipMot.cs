using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PreCompiledCheckListStepSkipMot
    {
        public int PreCompiledCheckListStepSkipMotId { get; set; }
        public int PreCompiledCheckListStepSkipMotMoTemplateId { get; set; }
        public int PreCompiledCheckListStepSkipMotStepId { get; set; }

        public virtual PreCompiledCheckListStep PreCompiledCheckListStepSkipMotStep { get; set; }
    }
}
