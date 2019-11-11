using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EscalationProcessLevel
    {
        public int EscalationProcessLevelId { get; set; }
        public int EscalationProcessLevelEscalationProcessId { get; set; }
        public int EscalationProcessLevelEscalationLevelId { get; set; }
        public decimal? EscalationProcessLevelEscalationTime { get; set; }
        public bool? EscalationProcessLevelIsNotify { get; set; }

        public virtual EscalationLevel EscalationProcessLevelEscalationLevel { get; set; }
        public virtual EscalationProcess EscalationProcessLevelEscalationProcess { get; set; }
    }
}
