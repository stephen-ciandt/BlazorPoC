using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Mmsintsall
    {
        public int InstallId { get; set; }
        public DateTime InstallDate { get; set; }
        public string Pguid { get; set; }
        public string Uguid { get; set; }
        public string ProductVersion { get; set; }
        public string InstallPath { get; set; }
    }
}
