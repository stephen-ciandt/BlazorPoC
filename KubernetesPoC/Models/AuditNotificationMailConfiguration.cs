using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AuditNotificationMailConfiguration
    {
        public int AuditNotificationMailConfigurationId { get; set; }
        public int AuditNotificationMailConfigurationAreaId { get; set; }
        public string AuditNotificationMailConfigurationEmail { get; set; }

        public virtual Area AuditNotificationMailConfigurationArea { get; set; }
    }
}
