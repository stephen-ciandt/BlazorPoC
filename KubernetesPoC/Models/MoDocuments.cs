using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MoDocuments
    {
        public int MoDocumentsId { get; set; }
        public int MoDocumentsDocumentVersionId { get; set; }
        public int MoDocumentsMaintenanceOrderId { get; set; }

        public virtual DocumentVersion MoDocumentsDocumentVersion { get; set; }
        public virtual MaintenanceOrder MoDocumentsMaintenanceOrder { get; set; }
    }
}
