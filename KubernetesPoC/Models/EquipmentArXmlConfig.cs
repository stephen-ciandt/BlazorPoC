using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentArXmlConfig
    {
        public int EquipmentArXmlConfigId { get; set; }
        public int EquipmentArXmlConfigEquipmentId { get; set; }
        public string EquipmentArXmlConfigName { get; set; }
        public string EquipmentArXmlConfigPath { get; set; }
        public int Type { get; set; }

        public virtual Equipment EquipmentArXmlConfigEquipment { get; set; }
    }
}
