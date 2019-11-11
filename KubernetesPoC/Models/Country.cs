using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Country
    {
        public Country()
        {
            Vendor = new HashSet<Vendor>();
            VendorContact = new HashSet<VendorContact>();
        }

        public int CountryId { get; set; }
        public int CountryCountryId { get; set; }
        public string CountryLocale { get; set; }
        public string CountryCountryName { get; set; }

        public virtual ICollection<Vendor> Vendor { get; set; }
        public virtual ICollection<VendorContact> VendorContact { get; set; }
    }
}
