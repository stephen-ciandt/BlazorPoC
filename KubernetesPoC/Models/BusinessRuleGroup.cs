using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BusinessRuleGroup
    {
        public int BusinessRuleGroupId { get; set; }
        public int BusinessRuleGroupBusinessRuleId { get; set; }
        public bool BusinessRuleGroupIsEnabled { get; set; }
        public int BusinessRuleGroupSequence { get; set; }
        public string BusinessRuleGroupOperator { get; set; }
        public string BusinessRuleGroupExpressionJson { get; set; }
        public string BusinessRuleGroupExpressionQuery { get; set; }

        public virtual BusinessRule BusinessRuleGroupBusinessRule { get; set; }
    }
}
