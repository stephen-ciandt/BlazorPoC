using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoPreCompiledCheckListStep
    {
        public MoPreCompiledCheckListStep()
        {
            MoPreCompiledCheckListStepPart = new HashSet<MoPreCompiledCheckListStepPart>();
        }

        public int MoPreCompiledCheckListStepId { get; set; }
        public int MoPreCompiledCheckListStepMoCheckListId { get; set; }
        public int MoPreCompiledCheckListStepStepNumber { get; set; }
        public string MoPreCompiledCheckListStepDescription { get; set; }
        public bool? MoPreCompiledCheckListStepIsPerformed { get; set; }
        public long? MoPreCompiledCheckListStepPerformedDate { get; set; }
        public int? MoPreCompiledCheckListStepPerformedByUserId { get; set; }
        public int? MoPreCompiledCheckListStepDocumentPageNumber { get; set; }
        public string MoPreCompiledCheckListStepZoneName { get; set; }
        public bool MoPreCompiledCheckListStepSkipStep { get; set; }
        public int? MoPreCompiledCheckListStepEstimatedOutageInMins { get; set; }
        public int? PreCompiledCheckListStepId { get; set; }

        public virtual MoPreCompiledCheckList MoPreCompiledCheckListStepMoCheckList { get; set; }
        public virtual User MoPreCompiledCheckListStepPerformedByUser { get; set; }
        public virtual PreCompiledCheckListStep PreCompiledCheckListStep { get; set; }
        public virtual ICollection<MoPreCompiledCheckListStepPart> MoPreCompiledCheckListStepPart { get; set; }
    }
}
