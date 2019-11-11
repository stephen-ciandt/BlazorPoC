using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntegrationAttribute
    {
        public int IntegrationAttributeId { get; set; }
        public int IntegrationAttributeIntegrationId { get; set; }
        public string IntegrationAttributeName { get; set; }
        public string IntegrationAttributeValue { get; set; }
        public int IntegrationAttributeType { get; set; }
        public string IntegrationAttributeReference { get; set; }
        public bool? IntegrationAttributeMandatory { get; set; }

        public virtual Integration IntegrationAttributeIntegration { get; set; }
    }
}
