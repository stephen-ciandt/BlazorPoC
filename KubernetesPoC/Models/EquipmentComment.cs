using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class EquipmentComment
    {
        public int EquipmentCommentId { get; set; }
        public string EquipmentCommentComment { get; set; }
        public string EquipmentCommentFileName { get; set; }
        public int EquipmentCommentCommentAddedByUserId { get; set; }
        public long EquipmentCommentCommentCreatedDate { get; set; }
        public int EquipmentCommentEquipmentId { get; set; }
        public int Type { get; set; }

        public virtual User EquipmentCommentCommentAddedByUser { get; set; }
        public virtual Equipment EquipmentCommentEquipment { get; set; }
    }
}
