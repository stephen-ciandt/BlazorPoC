using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EscalationLevel
    {
        public EscalationLevel()
        {
            EscalationProcessLevel = new HashSet<EscalationProcessLevel>();
        }

        public int EscalationLevelId { get; set; }
        public string EscalationLevelName { get; set; }
        public bool EscalationLevelIsActive { get; set; }

        public virtual ICollection<EscalationProcessLevel> EscalationProcessLevel { get; set; }
    }
}
