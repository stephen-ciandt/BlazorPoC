using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserCertAssignedUserList
    {
        public int Id { get; set; }
        public int CertificationId { get; set; }
        public int UserId { get; set; }

        public virtual UserCertificationList Certification { get; set; }
        public virtual User User { get; set; }
    }
}
