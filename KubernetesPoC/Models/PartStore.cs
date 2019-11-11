using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PartStore
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string StoreId { get; set; }
        public string PrimaryContact { get; set; }
        public string Address { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public string ContactEmail { get; set; }
        public bool IsHostStore { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public long CreatedDate { get; set; }
        public long? UpdatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; }
    }
}
