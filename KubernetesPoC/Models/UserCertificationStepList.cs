using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserCertificationStepList
    {
        public int Id { get; set; }
        public int CertificationId { get; set; }
        public int Sequence { get; set; }
        public string StepDescription { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }

        public virtual UserCertificationList Certification { get; set; }
    }
}
