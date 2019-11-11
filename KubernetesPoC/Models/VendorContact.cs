using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class VendorContact
    {
        public int Id { get; set; }
        public string DeptArea { get; set; }
        public string Name { get; set; }
        public int? CountryId { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool PrimaryContact { get; set; }
        public int VendorId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
