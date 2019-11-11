using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartSubstitute
    {
        public int PartSubstituteId { get; set; }
        public int PartSubstitutePreference { get; set; }
        public int PartSubstitutePartId { get; set; }
        public int PartSubstituteSubstitutePartId { get; set; }

        public virtual Part PartSubstitutePart { get; set; }
    }
}
