using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntRuleConfigurationDependentAssemblies
    {
        public int IntRuleConfigurationDependentAssembliesId { get; set; }
        public int? IntRuleConfigurationDependentAssembliesIntRuleConfigurationId { get; set; }
        public string IntRuleConfigurationDependentAssembliesDependentAssembly { get; set; }

        public virtual IntRuleConfiguration IntRuleConfigurationDependentAssembliesIntRuleConfiguration { get; set; }
    }
}
