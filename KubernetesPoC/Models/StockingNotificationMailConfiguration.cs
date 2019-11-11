using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class StockingNotificationMailConfiguration
    {
        public int StockingNotificationMailConfigurationId { get; set; }
        public int StockingNotificationMailConfigurationAreaId { get; set; }
        public string StockingNotificationMailConfigurationEmail { get; set; }

        public virtual Area StockingNotificationMailConfigurationArea { get; set; }
    }
}
