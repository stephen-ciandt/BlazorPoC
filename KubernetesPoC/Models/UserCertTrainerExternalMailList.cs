using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserCertTrainerExternalMailList
    {
        public int Id { get; set; }
        public int CertificationId { get; set; }
        public string NotifyEmailAddress { get; set; }

        public virtual UserCertificationList Certification { get; set; }
    }
}
