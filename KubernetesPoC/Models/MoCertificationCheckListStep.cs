using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoCertificationCheckListStep
    {
        public int Id { get; set; }
        public int MoCertificationCheckListId { get; set; }
        public int Sequence { get; set; }
        public string StepDescription { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }
        public string Value { get; set; }
        public int? Result { get; set; }
        public long? PerformedDate { get; set; }
        public int? PerformedByUserId { get; set; }
        public int? CertificationCheckListStepId { get; set; }

        public virtual CertificationCheckListStep CertificationCheckListStep { get; set; }
        public virtual MoCertificationCheckList MoCertificationCheckList { get; set; }
        public virtual User PerformedByUser { get; set; }
    }
}
