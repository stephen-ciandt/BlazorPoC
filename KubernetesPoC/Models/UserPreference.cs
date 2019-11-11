using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserPreference
    {
        public int UserPreferenceId { get; set; }
        public string UserPreferenceValue { get; set; }
        public int UserPreferenceMasterId { get; set; }
        public int UserPreferenceUserId { get; set; }

        public virtual UserPreferenceMaster UserPreferenceMaster { get; set; }
        public virtual User UserPreferenceUser { get; set; }
    }
}
