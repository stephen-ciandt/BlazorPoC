using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntRuleConfiguration
    {
        public IntRuleConfiguration()
        {
            IntIntegrationServerRuleConfiguration = new HashSet<IntIntegrationServerRuleConfiguration>();
            IntRuleConfigurationAdapters = new HashSet<IntRuleConfigurationAdapters>();
            IntRuleConfigurationDependentAssemblies = new HashSet<IntRuleConfigurationDependentAssemblies>();
            IntRuleConfigurationParameters = new HashSet<IntRuleConfigurationParameters>();
        }

        public int IntRuleConfigurationId { get; set; }
        public string IntRuleConfigurationName { get; set; }
        public string IntRuleConfigurationDescription { get; set; }
        public string IntRuleConfigurationAssemblyName { get; set; }
        public string IntRuleConfigurationLogLevels { get; set; }
        public string IntRuleConfigurationProduct { get; set; }
        public int? IntRuleConfigurationIntegrationId { get; set; }

        public virtual ICollection<IntIntegrationServerRuleConfiguration> IntIntegrationServerRuleConfiguration { get; set; }
        public virtual ICollection<IntRuleConfigurationAdapters> IntRuleConfigurationAdapters { get; set; }
        public virtual ICollection<IntRuleConfigurationDependentAssemblies> IntRuleConfigurationDependentAssemblies { get; set; }
        public virtual ICollection<IntRuleConfigurationParameters> IntRuleConfigurationParameters { get; set; }
    }
}
