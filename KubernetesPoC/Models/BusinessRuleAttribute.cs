using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BusinessRuleAttribute
    {
        public int BusinessRuleAttributeId { get; set; }
        public int BusinessRuleAttributeBusinessRuleId { get; set; }
        public int BusinessRuleAttributeAttributeId { get; set; }

        public virtual Attribute BusinessRuleAttributeAttribute { get; set; }
        public virtual BusinessRule BusinessRuleAttributeBusinessRule { get; set; }
    }
}
