using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BusinessRuleResult
    {
        public int BusinessRuleResultId { get; set; }
        public int BusinessRuleResultBusinessRuleId { get; set; }
        public int BusinessRuleResultEquipmentId { get; set; }
        public bool BusinessRuleResultEvaluationResult { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public bool? BusinessRuleResultIgnoreResult { get; set; }
    }
}
