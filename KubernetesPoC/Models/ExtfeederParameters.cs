using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ExtfeederParameters
    {
        public int ExtfeederParametersId { get; set; }
        public int ExtfeederParametersMeterHistoryId { get; set; }
        public int ExtfeederParametersPlacementCount { get; set; }
        public int ExtfeederParametersPickupMiss { get; set; }
        public int ExtfeederParametersPickupError { get; set; }
        public int ExtfeederParametersShapeError { get; set; }
        public int ExtfeederParametersRecognitionError { get; set; }

        public virtual EquipmentMeterHistory ExtfeederParametersMeterHistory { get; set; }
    }
}
