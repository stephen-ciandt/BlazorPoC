using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class DataWarehouseSetting
    {
        public int DataWarehouseSettingId { get; set; }
        public int? DataWarehouseSettingIntegrationServerId { get; set; }
        public int DataWarehouseSettingIntegrationId { get; set; }
        public int DataWarehouseSettingIsIntegrated { get; set; }
        public string DataWarehouseSettingServiceUrl { get; set; }

        public virtual Integration DataWarehouseSettingIntegration { get; set; }
        public virtual IntIntegrationServer DataWarehouseSettingIntegrationServer { get; set; }
    }
}
