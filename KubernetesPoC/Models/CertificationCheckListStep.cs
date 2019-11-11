using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CertificationCheckListStep
    {
        public CertificationCheckListStep()
        {
            CcheckListStepTranslation = new HashSet<CcheckListStepTranslation>();
            MoCertificationCheckListStep = new HashSet<MoCertificationCheckListStep>();
        }

        public int Id { get; set; }
        public int CheckListId { get; set; }
        public int Sequence { get; set; }
        public string StepDescription { get; set; }
        public string MinValue { get; set; }
        public string MaxValue { get; set; }

        public virtual CertificationCheckList CheckList { get; set; }
        public virtual ICollection<CcheckListStepTranslation> CcheckListStepTranslation { get; set; }
        public virtual ICollection<MoCertificationCheckListStep> MoCertificationCheckListStep { get; set; }
    }
}
