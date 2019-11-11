using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class FeederGroup
    {
        public int FeederGroupId { get; set; }
        public string FeederStartsWithText { get; set; }
        public int? FeederTemplateId { get; set; }
    }
}
