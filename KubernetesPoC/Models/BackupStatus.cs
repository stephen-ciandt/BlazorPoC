using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BackupStatus
    {
        public int BackupStatusId { get; set; }
        public long BackupStatusTimestamp { get; set; }
        public string BackupStatusStatus { get; set; }
        public string BackupStatusLogInformation { get; set; }
        public string BackupStatusBackupConfigType { get; set; }
        public string BackupStatusBackupType { get; set; }
    }
}
