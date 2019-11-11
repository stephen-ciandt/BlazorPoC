using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BarcodeFields
    {
        public int BarcodeFieldsId { get; set; }
        public int BarcodeFieldsField { get; set; }
        public string BarcodeFieldsExpression { get; set; }
        public int BarcodeFieldsLabelId { get; set; }

        public virtual BarcodeLabels BarcodeFieldsLabel { get; set; }
    }
}
