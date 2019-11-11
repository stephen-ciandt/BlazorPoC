using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BackupConfig
    {
        public int BackupConfigId { get; set; }
        public string BackupConfigBackupPath { get; set; }
        public TimeSpan BackupConfigBackupTime { get; set; }
        public int BackupConfigPurgeInDays { get; set; }
        public string BackupConfigEmailAddress { get; set; }
        public bool? BackupConfigIsRemoteServer { get; set; }
        public string BackupConfigSharedLocationPath { get; set; }
        public string BackupConfigSharedLocationUserName { get; set; }
        public string BackupConfigSharedLocationPassword { get; set; }
    }
}
