using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class WipSetting
    {
        public int WipSettingId { get; set; }
        public int? WipSettingIntegrationServerId { get; set; }
        public int WipSettingIntegrationId { get; set; }
        public int WipSettingIsIntegrated { get; set; }

        public virtual Integration WipSettingIntegration { get; set; }
        public virtual IntIntegrationServer WipSettingIntegrationServer { get; set; }
    }
}
