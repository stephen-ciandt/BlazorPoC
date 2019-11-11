using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserPreferenceMaster
    {
        public UserPreferenceMaster()
        {
            UserPreference = new HashSet<UserPreference>();
        }

        public int UserPreferenceMasterId { get; set; }
        public string UserPreferenceMasterName { get; set; }
        public int UserPreferenceMasterType { get; set; }
        public string UserPreferenceMasterReference { get; set; }
        public string UserPreferenceMasterCategory { get; set; }
        public int UserPreferenceMasterControlFlag { get; set; }
        public bool UserPreferenceMasterIsDeleted { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual ICollection<UserPreference> UserPreference { get; set; }
    }
}
