using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AreaAttribute
    {
        public int AreaAttributeId { get; set; }
        public int AreaAttributeAttributeId { get; set; }
        public int AreaAttributeAreaId { get; set; }
        public string AreaAttributeValue { get; set; }

        public virtual Area AreaAttributeArea { get; set; }
        public virtual Attribute AreaAttributeAttribute { get; set; }
    }
}
