using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentBusinessRule
    {
        public int EquipmentBusinessRuleId { get; set; }
        public int EquipmentBusinessRuleBusinessRuleId { get; set; }
        public int EquipmentBusinessRuleEquipmentId { get; set; }

        public virtual BusinessRule EquipmentBusinessRuleBusinessRule { get; set; }
        public virtual Equipment EquipmentBusinessRuleEquipment { get; set; }
    }
}
