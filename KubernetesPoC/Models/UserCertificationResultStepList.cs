using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserCertificationResultStepList
    {
        public int Id { get; set; }
        public int CertificationResultId { get; set; }
        public int Sequence { get; set; }
        public string StepDescription { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }
        public string Value { get; set; }
        public int? Result { get; set; }

        public virtual UserCertificationResults CertificationResult { get; set; }
    }
}
