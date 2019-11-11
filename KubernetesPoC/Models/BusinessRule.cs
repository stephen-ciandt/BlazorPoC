using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BusinessRule
    {
        public BusinessRule()
        {
            BusinessRuleAttribute = new HashSet<BusinessRuleAttribute>();
            BusinessRuleGroup = new HashSet<BusinessRuleGroup>();
            EquipmentBusinessRule = new HashSet<EquipmentBusinessRule>();
        }

        public int BusinessRuleId { get; set; }
        public string BusinessRuleName { get; set; }
        public bool BusinessRuleExpectedResult { get; set; }
        public string BusinessRuleEvaluationTime { get; set; }
        public int? BusinessRuleEvaluationType { get; set; }
        public int? BusinessRuleMoTemplateId { get; set; }
        public int BusinessRuleControlFlag { get; set; }
        public bool BusinessRuleIsDeleted { get; set; }
        public Guid? BusinessRuleReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public string BusinessRuleStatement { get; set; }
        public int? BusinessRuleRtTemplateId { get; set; }
        public int? BusinessRuleAssetSubType { get; set; }

        public virtual MaintenanceOrderTemplate BusinessRuleMoTemplate { get; set; }
        public virtual RepairTicketTemplate BusinessRuleRtTemplate { get; set; }
        public virtual ICollection<BusinessRuleAttribute> BusinessRuleAttribute { get; set; }
        public virtual ICollection<BusinessRuleGroup> BusinessRuleGroup { get; set; }
        public virtual ICollection<EquipmentBusinessRule> EquipmentBusinessRule { get; set; }
    }
}
