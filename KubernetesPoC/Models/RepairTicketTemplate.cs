using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class RepairTicketTemplate
    {
        public RepairTicketTemplate()
        {
            BusinessRule = new HashSet<BusinessRule>();
            RepairTicketTemplateClosedNotification = new HashSet<RepairTicketTemplateClosedNotification>();
        }

        public int RepairTicketTemplateId { get; set; }
        public int? RepairTicketTemplatePriority { get; set; }
        public string RepairTicketTemplateNumber { get; set; }
        public int RepairTicketTemplateFailureCodeId { get; set; }
        public string RepairTicketTemplateTitle { get; set; }
        public long RepairTicketTemplateIncidentDate { get; set; }
        public string RepairTicketTemplateDescription { get; set; }
        public int RepairTicketTemplateEquipmentId { get; set; }
        public int RepairTicketTemplateControlFlag { get; set; }
        public bool RepairTicketTemplateIsDeleted { get; set; }
        public int RepairTicketTemplateReportedByUserId { get; set; }
        public long RepairTicketTemplateCreatedDate { get; set; }
        public Guid? RepairTicketTemplateReferenceId { get; set; }
        public string RepairTicketTemplateOriginator { get; set; }
        public int? LastUpdatedBy { get; set; }
        public long? LastUpdatedTimeStamp { get; set; }

        public virtual Equipment RepairTicketTemplateEquipment { get; set; }
        public virtual ReasonCode RepairTicketTemplateFailureCode { get; set; }
        public virtual User RepairTicketTemplateReportedByUser { get; set; }
        public virtual ICollection<BusinessRule> BusinessRule { get; set; }
        public virtual ICollection<RepairTicketTemplateClosedNotification> RepairTicketTemplateClosedNotification { get; set; }
    }
}
