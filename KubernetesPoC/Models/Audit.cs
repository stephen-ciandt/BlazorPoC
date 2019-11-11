using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Audit
    {
        public long Id { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string HttpRequestData { get; set; }

        public virtual User User { get; set; }
    }
}
