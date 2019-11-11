using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class CcheckListStepTranslation
    {
        public int CcheckListStepTranslationId { get; set; }
        public int CcheckListStepTranslationStepId { get; set; }
        public int CcheckListStepTranslationAppLangId { get; set; }
        public string CcheckListStepTranslationStepDescription { get; set; }

        public virtual AppLanguage CcheckListStepTranslationAppLang { get; set; }
        public virtual CertificationCheckListStep CcheckListStepTranslationStep { get; set; }
    }
}
