using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AlertDetails
    {
        public int AlertDetailsId { get; set; }
        public int AlertDetailsAlertId { get; set; }
        public int AlertDetailsUserId { get; set; }
        public int AlertDetailsUserActionStatus { get; set; }
        public long AlertDetailsActionDate { get; set; }

        public virtual Alert AlertDetailsAlert { get; set; }
    }
}
