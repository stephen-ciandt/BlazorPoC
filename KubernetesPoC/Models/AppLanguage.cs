using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class AppLanguage
    {
        public AppLanguage()
        {
            CcheckListStepTranslation = new HashSet<CcheckListStepTranslation>();
            PccheckListStepTranslation = new HashSet<PccheckListStepTranslation>();
            User = new HashSet<User>();
        }

        public int AppLanguageId { get; set; }
        public string AppLanguageName { get; set; }
        public string AppLanguageCultureCode { get; set; }
        public string AppLanguageAbbreviation { get; set; }
        public string AppLanguageCountryName { get; set; }
        public string AppLanguageRegion { get; set; }
        public int AppLanguageStatus { get; set; }

        public virtual ICollection<CcheckListStepTranslation> CcheckListStepTranslation { get; set; }
        public virtual ICollection<PccheckListStepTranslation> PccheckListStepTranslation { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
