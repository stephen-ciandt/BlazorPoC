using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PccheckListStepTranslation
    {
        public int PccheckListStepTranslationId { get; set; }
        public int PccheckListStepTranslationStepId { get; set; }
        public int PccheckListStepTranslationAppLangId { get; set; }
        public string PccheckListStepTranslationStepDescription { get; set; }

        public virtual AppLanguage PccheckListStepTranslationAppLang { get; set; }
        public virtual PreCompiledCheckListStep PccheckListStepTranslationStep { get; set; }
    }
}
