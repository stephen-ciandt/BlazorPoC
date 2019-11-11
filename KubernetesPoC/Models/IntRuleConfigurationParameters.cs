using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntRuleConfigurationParameters
    {
        public int IntRuleConfigurationParametersId { get; set; }
        public int IntRuleConfigurationParametersIntRuleConfigurationId { get; set; }
        public string IntRuleConfigurationParametersName { get; set; }
        public string IntRuleConfigurationParametersValue { get; set; }
        public bool? IntRuleConfigurationParametersMandatory { get; set; }

        public virtual IntRuleConfiguration IntRuleConfigurationParametersIntRuleConfiguration { get; set; }
    }
}
