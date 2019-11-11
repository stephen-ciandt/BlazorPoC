using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoTemplateCertificationCheckList
    {
        public int Id { get; set; }
        public int CertificationCheckListId { get; set; }
        public int MoTemplateId { get; set; }

        public virtual CertificationCheckList CertificationCheckList { get; set; }
        public virtual MaintenanceOrderTemplate MoTemplate { get; set; }
    }
}
