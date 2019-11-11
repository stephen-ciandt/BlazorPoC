using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AttributeAppliesTo
    {
        public int AttributeAppliesToId { get; set; }
        public int AttributeAppliesToAttributeId { get; set; }
        public int AttributeAppliesToValue { get; set; }

        public virtual Attribute AttributeAppliesToAttribute { get; set; }
    }
}
