using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntIntegrationServerRuleConfiguration
    {
        public int IntIntegrationServerRuleConfigurationId { get; set; }
        public int IntIntegrationServerRuleConfigurationIntRuleConfigurationId { get; set; }
        public int IntIntegrationServerRuleConfigurationIntIntegrationServerId { get; set; }

        public virtual IntIntegrationServer IntIntegrationServerRuleConfigurationIntIntegrationServer { get; set; }
        public virtual IntRuleConfiguration IntIntegrationServerRuleConfigurationIntRuleConfiguration { get; set; }
    }
}
