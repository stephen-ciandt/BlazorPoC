using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntegrationImportEntites
    {
        public int IntegrationImportEntitesId { get; set; }
        public int IntegrationImportEntitesIntegrationId { get; set; }
        public string IntegrationImportEntitesEntityName { get; set; }
        public int IntegrationImportEntitesEntityType { get; set; }

        public virtual Integration IntegrationImportEntitesIntegration { get; set; }
    }
}
