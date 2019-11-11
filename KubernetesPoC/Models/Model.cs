using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Model
    {
        public int ModelId { get; set; }
        public int? ModelPrimaryGroupId { get; set; }
        public int? ModelSecondaryGroupId { get; set; }
        public int? ModelSubGroupId { get; set; }
        public string ModelModelNumber { get; set; }

        public virtual EquipmentGroup ModelPrimaryGroup { get; set; }
        public virtual EquipmentGroup ModelSecondaryGroup { get; set; }
        public virtual EquipmentGroup ModelSubGroup { get; set; }
    }
}
