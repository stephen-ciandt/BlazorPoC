using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class BarcodeLabels
    {
        public BarcodeLabels()
        {
            BarcodeFields = new HashSet<BarcodeFields>();
        }

        public int BarcodeLabelsId { get; set; }
        public int BarcodeLabelsWeight { get; set; }
        public string BarcodeLabelsExpression { get; set; }
        public string BarcodeLabelsName { get; set; }
        public int BarcodeLabelsType { get; set; }

        public virtual ICollection<BarcodeFields> BarcodeFields { get; set; }
    }
}
