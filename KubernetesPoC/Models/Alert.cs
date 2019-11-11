using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Alert
    {
        public Alert()
        {
            AlertDetails = new HashSet<AlertDetails>();
        }

        public int AlertId { get; set; }
        public int AlertType { get; set; }
        public string AlertReferenceNumber { get; set; }
        public int AlertOverallStatus { get; set; }
        public long AlertNotifiedDate { get; set; }

        public virtual ICollection<AlertDetails> AlertDetails { get; set; }
    }
}
