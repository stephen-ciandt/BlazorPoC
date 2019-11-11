using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoCertificationCheckList
    {
        public MoCertificationCheckList()
        {
            MoCertificationCheckListStep = new HashSet<MoCertificationCheckListStep>();
        }

        public int Id { get; set; }
        public int CertificationCheckListId { get; set; }
        public int MaintenanceOrderId { get; set; }
        public int? DocumentVersionId { get; set; }

        public virtual CertificationCheckList CertificationCheckList { get; set; }
        public virtual DocumentVersion DocumentVersion { get; set; }
        public virtual MaintenanceOrder MaintenanceOrder { get; set; }
        public virtual ICollection<MoCertificationCheckListStep> MoCertificationCheckListStep { get; set; }
    }
}
