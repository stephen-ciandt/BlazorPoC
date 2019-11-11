using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BusinessRuleResultArchive
    {
        public int BusinessRuleResultArchiveId { get; set; }
        public int BusinessRuleResultArchiveBusinessRuleResultId { get; set; }
        public int BusinessRuleResultArchiveBusinessRuleId { get; set; }
        public int BusinessRuleResultArchiveEquipmentId { get; set; }
        public bool BusinessRuleResultArchiveEvaluationResult { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public bool? BusinessRuleResultArchiveIgnoreResult { get; set; }
    }
}
