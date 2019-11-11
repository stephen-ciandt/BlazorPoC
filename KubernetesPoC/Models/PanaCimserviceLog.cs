using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PanaCimserviceLog
    {
        public int PanaCimserviceLogId { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public int Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
