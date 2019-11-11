using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Site
    {
        public Site()
        {
            Building = new HashSet<Building>();
            CycleCount = new HashSet<CycleCount>();
            SiteAttribute = new HashSet<SiteAttribute>();
        }

        public int SiteId { get; set; }
        public string SiteName { get; set; }
        public string SiteDescription { get; set; }
        public int SiteControlFlag { get; set; }
        public bool SiteIsDeleted { get; set; }
        public Guid? SiteReferenceId { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }
        public int? SiteNumber { get; set; }
        public string SiteAddressLine1 { get; set; }
        public string SiteAddressLine2 { get; set; }
        public string SiteCity { get; set; }
        public string SiteState { get; set; }
        public string SitePostalCode { get; set; }
        public string SiteContactPhoneNumber { get; set; }

        public virtual ICollection<Building> Building { get; set; }
        public virtual ICollection<CycleCount> CycleCount { get; set; }
        public virtual ICollection<SiteAttribute> SiteAttribute { get; set; }
    }
}
