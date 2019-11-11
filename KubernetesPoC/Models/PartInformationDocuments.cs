using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartInformationDocuments
    {
        public int PartInformationDocumentsId { get; set; }
        public int PartInformationDocumentsPartId { get; set; }
        public string PartInformationDocumentsFileName { get; set; }
        public string PartInformationDocumentsVersion { get; set; }
        public bool PartInformationDocumentsIsActive { get; set; }
        public string PartInformationDocumentsFileType { get; set; }
        public string PartInformationDocumentsCreatedBy { get; set; }
        public long PartInformationDocumentsCreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual Part PartInformationDocumentsPart { get; set; }
    }
}
