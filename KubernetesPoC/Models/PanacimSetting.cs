using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PanacimSetting
    {
        public int PanacimSettingId { get; set; }
        public int? PanacimSettingIntegrationServerId { get; set; }
        public int PanacimSettingIntegrationId { get; set; }
        public int PanacimSettingIsIntegrated { get; set; }
        public string PanacimSettingServiceUrl { get; set; }
        public string PanacimSettingHostName { get; set; }
        public string PanacimSettingDbinstance { get; set; }
        public string PanacimSettingUserName { get; set; }
        public string PanacimSettingPassword { get; set; }
        public bool PanacimSettingEnableMachineIntegration { get; set; }

        public virtual Integration PanacimSettingIntegration { get; set; }
        public virtual IntIntegrationServer PanacimSettingIntegrationServer { get; set; }
    }
}
