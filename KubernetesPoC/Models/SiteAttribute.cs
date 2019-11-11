using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class SiteAttribute
    {
        public int SiteAttributeId { get; set; }
        public int SiteAttributeAttributeId { get; set; }
        public int SiteAttributeSiteId { get; set; }
        public string SiteAttributeValue { get; set; }

        public virtual Attribute SiteAttributeAttribute { get; set; }
        public virtual Site SiteAttributeSite { get; set; }
    }
}
