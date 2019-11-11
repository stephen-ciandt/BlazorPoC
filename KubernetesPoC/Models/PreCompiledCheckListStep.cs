using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PreCompiledCheckListStep
    {
        public PreCompiledCheckListStep()
        {
            MoPreCompiledCheckListStep = new HashSet<MoPreCompiledCheckListStep>();
            PccheckListStepTranslation = new HashSet<PccheckListStepTranslation>();
            PreCompiledCheckListStepPart = new HashSet<PreCompiledCheckListStepPart>();
            PreCompiledCheckListStepSkipMot = new HashSet<PreCompiledCheckListStepSkipMot>();
        }

        public int PreCompiledCheckListStepId { get; set; }
        public int PreCompiledCheckListStepCheckListId { get; set; }
        public int PreCompiledCheckListStepStepId { get; set; }
        public string PreCompiledCheckListStepStepDescription { get; set; }
        public int? PreCompiledCheckListStepDocumentPageNumber { get; set; }
        public int? PreCompiledCheckListStepEstimatedOutageInMins { get; set; }

        public virtual PreCompiledCheckList PreCompiledCheckListStepCheckList { get; set; }
        public virtual ICollection<MoPreCompiledCheckListStep> MoPreCompiledCheckListStep { get; set; }
        public virtual ICollection<PccheckListStepTranslation> PccheckListStepTranslation { get; set; }
        public virtual ICollection<PreCompiledCheckListStepPart> PreCompiledCheckListStepPart { get; set; }
        public virtual ICollection<PreCompiledCheckListStepSkipMot> PreCompiledCheckListStepSkipMot { get; set; }
    }
}
