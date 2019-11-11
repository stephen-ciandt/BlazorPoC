using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserCertAreaAssociation
    {
        public int Id { get; set; }
        public int CertificationId { get; set; }
        public int AreaId { get; set; }

        public virtual Area Area { get; set; }
        public virtual UserCertificationList Certification { get; set; }
    }
}
