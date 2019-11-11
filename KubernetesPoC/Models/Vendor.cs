using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            Part = new HashSet<Part>();
            VendorContact = new HashSet<VendorContact>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public int? VendorCountryId { get; set; }
        public string VendorEmailId { get; set; }
        public string VendorBuilding { get; set; }
        public string VendorAddress1 { get; set; }
        public string VendorAddress2 { get; set; }
        public string VendorCity { get; set; }
        public string VendorState { get; set; }
        public string VendorPostalCode { get; set; }
        public string VendorPhoneNumber { get; set; }
        public string VendorPrimaryContactName { get; set; }
        public string VendorCreatedBy { get; set; }
        public long VendorCreatedDate { get; set; }
        public string VendorWebsite { get; set; }
        public int VendorControlFlag { get; set; }
        public bool VendorIsDeleted { get; set; }
        public Guid? VendorReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual Country VendorCountry { get; set; }
        public virtual ICollection<Part> Part { get; set; }
        public virtual ICollection<VendorContact> VendorContact { get; set; }
    }
}
