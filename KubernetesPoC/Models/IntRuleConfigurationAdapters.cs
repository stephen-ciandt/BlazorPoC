using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntRuleConfigurationAdapters
    {
        public int IntRuleConfigurationAdaptersId { get; set; }
        public int IntRuleConfigurationAdaptersIntRuleConfigurationId { get; set; }
        public string IntRuleConfigurationAdaptersName { get; set; }
        public int IntRuleConfigurationAdaptersType { get; set; }
        public string IntRuleConfigurationAdaptersIwait { get; set; }
        public string IntRuleConfigurationAdaptersIwaitType { get; set; }
        public string IntRuleConfigurationAdaptersHostName { get; set; }
        public int? IntRuleConfigurationAdaptersPort { get; set; }
        public string IntRuleConfigurationAdaptersUserName { get; set; }
        public string IntRuleConfigurationAdaptersPassword { get; set; }
        public string IntRuleConfigurationAdaptersMaptoDrive { get; set; }
        public int IntRuleConfigurationAdaptersProcessbacklog { get; set; }
        public int? IntRuleConfigurationAdaptersHeartbeat { get; set; }
        public string IntRuleConfigurationAdaptersHeartBeatFrequency { get; set; }
        public string IntRuleConfigurationAdaptersIwaitEvent { get; set; }

        public virtual IntRuleConfiguration IntRuleConfigurationAdaptersIntRuleConfiguration { get; set; }
    }
}
