using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Integration
    {
        public Integration()
        {
            DataWarehouseSetting = new HashSet<DataWarehouseSetting>();
            IntegrationAttribute = new HashSet<IntegrationAttribute>();
            IntegrationImportEntites = new HashSet<IntegrationImportEntites>();
            PanacimSetting = new HashSet<PanacimSetting>();
            WipSetting = new HashSet<WipSetting>();
        }

        public int IntegrationId { get; set; }
        public string IntegrationName { get; set; }

        public virtual ICollection<DataWarehouseSetting> DataWarehouseSetting { get; set; }
        public virtual ICollection<IntegrationAttribute> IntegrationAttribute { get; set; }
        public virtual ICollection<IntegrationImportEntites> IntegrationImportEntites { get; set; }
        public virtual ICollection<PanacimSetting> PanacimSetting { get; set; }
        public virtual ICollection<WipSetting> WipSetting { get; set; }
    }
}
