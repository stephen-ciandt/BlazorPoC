using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoTemplateDocument
    {
        public int MoTemplateDocumentId { get; set; }
        public int MoTemplateDocumentDocumentVersionId { get; set; }
        public int MoTemplateDocumentMoTemplateId { get; set; }

        public virtual DocumentVersion MoTemplateDocumentDocumentVersion { get; set; }
        public virtual MaintenanceOrderTemplate MoTemplateDocumentMoTemplate { get; set; }
    }
}
