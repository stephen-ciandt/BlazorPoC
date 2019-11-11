using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoTemplateCheckList
    {
        public int MoTemplateCheckListId { get; set; }
        public int MoTemplateCheckListCheckListId { get; set; }
        public int MoTemplateCheckListMoTemplateId { get; set; }

        public virtual PreCompiledCheckList MoTemplateCheckListCheckList { get; set; }
        public virtual MaintenanceOrderTemplate MoTemplateCheckListMoTemplate { get; set; }
    }
}
