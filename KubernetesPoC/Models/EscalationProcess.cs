using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EscalationProcess
    {
        public EscalationProcess()
        {
            EscalationProcessLevel = new HashSet<EscalationProcessLevel>();
        }

        public int EscalationProcessId { get; set; }
        public string EscalationProcessName { get; set; }

        public virtual ICollection<EscalationProcessLevel> EscalationProcessLevel { get; set; }
    }
}
