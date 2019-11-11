using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoPreCompiledCheckList
    {
        public MoPreCompiledCheckList()
        {
            MoPreCompiledCheckListStep = new HashSet<MoPreCompiledCheckListStep>();
        }

        public int MoPreCompiledCheckListId { get; set; }
        public int MoPreCompiledCheckListCheckListId { get; set; }
        public int MoPreCompiledCheckListMaintenanceOrderId { get; set; }
        public int MoPreCompiledCheckListDocumentVersionId { get; set; }

        public virtual PreCompiledCheckList MoPreCompiledCheckListCheckList { get; set; }
        public virtual MaintenanceOrder MoPreCompiledCheckListMaintenanceOrder { get; set; }
        public virtual ICollection<MoPreCompiledCheckListStep> MoPreCompiledCheckListStep { get; set; }
    }
}
