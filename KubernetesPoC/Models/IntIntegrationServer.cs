using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntIntegrationServer
    {
        public IntIntegrationServer()
        {
            DataWarehouseSetting = new HashSet<DataWarehouseSetting>();
            IntIntegrationServerRuleConfiguration = new HashSet<IntIntegrationServerRuleConfiguration>();
            PanacimSetting = new HashSet<PanacimSetting>();
            WipSetting = new HashSet<WipSetting>();
        }

        public int IntIntegrationServerId { get; set; }
        public string IntIntegrationServerName { get; set; }
        public string IntIntegrationServerDescription { get; set; }
        public string IntIntegrationServerMessageQueueHostName { get; set; }

        public virtual ICollection<DataWarehouseSetting> DataWarehouseSetting { get; set; }
        public virtual ICollection<IntIntegrationServerRuleConfiguration> IntIntegrationServerRuleConfiguration { get; set; }
        public virtual ICollection<PanacimSetting> PanacimSetting { get; set; }
        public virtual ICollection<WipSetting> WipSetting { get; set; }
    }
}
