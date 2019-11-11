using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ImportLog
    {
        public int ImportLogId { get; set; }
        public int ImportLogIntegrationId { get; set; }
        public int ImportLogRun { get; set; }
        public int ImportLogEntityType { get; set; }
        public string ImportLogStatus { get; set; }
        public string ImportLogUser { get; set; }
        public long ImportLogLastRun { get; set; }
        public int? ImportLogTotalRecords { get; set; }
        public int? ImportLogImportedRecords { get; set; }
        public string ImportLogErrorDetails { get; set; }
        public string ImportLogFileName { get; set; }
    }
}
