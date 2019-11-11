using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class MaterialMovement
    {
        public int MaterialMovementId { get; set; }
        public int MaterialMovementSourceAreaId { get; set; }
        public int MaterialMovementSourceLocationId { get; set; }
        public int? MaterialMovementSourceSubLocationId { get; set; }
        public int? MaterialMovementSourceBinNo { get; set; }
        public int MaterialMovementDestinationAreaId { get; set; }
        public int MaterialMovementDestinationLocationId { get; set; }
        public int? MaterialMovementDestinationSubLocationId { get; set; }
        public int? MaterialMovementDestinationBinNo { get; set; }
        public int MaterialMovementPartId { get; set; }
        public int MaterialMovementQty { get; set; }
        public long MaterialMovementTransferDate { get; set; }
        public string MaterialMovementTransferBy { get; set; }
    }
}
