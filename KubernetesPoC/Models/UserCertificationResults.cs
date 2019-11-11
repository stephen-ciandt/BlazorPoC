using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserCertificationResults
    {
        public UserCertificationResults()
        {
            UserCertNotificationMapping = new HashSet<UserCertNotificationMapping>();
            UserCertificationResultStepList = new HashSet<UserCertificationResultStepList>();
        }

        public int Id { get; set; }
        public int CertificationId { get; set; }
        public int PerformedUserId { get; set; }
        public int RecordedUserId { get; set; }
        public long CompletionDate { get; set; }
        public int Result { get; set; }

        public virtual UserCertificationList Certification { get; set; }
        public virtual User PerformedUser { get; set; }
        public virtual User RecordedUser { get; set; }
        public virtual ICollection<UserCertNotificationMapping> UserCertNotificationMapping { get; set; }
        public virtual ICollection<UserCertificationResultStepList> UserCertificationResultStepList { get; set; }
    }
}
