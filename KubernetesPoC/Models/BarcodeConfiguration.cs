using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BarcodeConfiguration
    {
        public int BarcodeConfigurationId { get; set; }
        public int BarcodeconfigurationIdentifier { get; set; }
        public string BarcodeConfigurationEntityName { get; set; }
    }
}
