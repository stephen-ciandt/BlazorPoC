using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AttributeValues
    {
        public int AttributeValueId { get; set; }
        public int AttributeValueAttributeId { get; set; }
        public string AttributeValue { get; set; }
        public bool? AttributeIsDefault { get; set; }
        public decimal? AttributeMinimumValue { get; set; }
        public decimal? AttributeMaximumValue { get; set; }

        public virtual Attribute AttributeValueAttribute { get; set; }
    }
}
