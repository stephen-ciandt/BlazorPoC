using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserLoginHistory
    {
        public int UserLoginHistoryId { get; set; }
        public int UserLoginHistoryUserId { get; set; }
        public string UserLoginHistorySessionId { get; set; }
        public long UserLoginHistoryLoginTime { get; set; }
        public long? UserLoginHistoryLogoutTime { get; set; }

        public virtual User UserLoginHistoryUser { get; set; }
    }
}
