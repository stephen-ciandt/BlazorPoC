using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UserCertificationList
    {
        public UserCertificationList()
        {
            UserCertAreaAssociation = new HashSet<UserCertAreaAssociation>();
            UserCertAssignedUserList = new HashSet<UserCertAssignedUserList>();
            UserCertNotificationMapping = new HashSet<UserCertNotificationMapping>();
            UserCertTrainerExternalMailList = new HashSet<UserCertTrainerExternalMailList>();
            UserCertTrainerUserList = new HashSet<UserCertTrainerUserList>();
            UserCertificationResults = new HashSet<UserCertificationResults>();
            UserCertificationStepList = new HashSet<UserCertificationStepList>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ValidDuration { get; set; }
        public int RenewalDuration { get; set; }
        public bool IsActive { get; set; }
        public bool PreventInteraction { get; set; }
        public bool ProcessCertification { get; set; }
        public Guid? UserCertificationListReferenceId { get; set; }

        public virtual ICollection<UserCertAreaAssociation> UserCertAreaAssociation { get; set; }
        public virtual ICollection<UserCertAssignedUserList> UserCertAssignedUserList { get; set; }
        public virtual ICollection<UserCertNotificationMapping> UserCertNotificationMapping { get; set; }
        public virtual ICollection<UserCertTrainerExternalMailList> UserCertTrainerExternalMailList { get; set; }
        public virtual ICollection<UserCertTrainerUserList> UserCertTrainerUserList { get; set; }
        public virtual ICollection<UserCertificationResults> UserCertificationResults { get; set; }
        public virtual ICollection<UserCertificationStepList> UserCertificationStepList { get; set; }
    }
}
