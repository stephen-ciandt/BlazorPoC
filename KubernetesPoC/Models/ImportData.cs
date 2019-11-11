using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class ImportData
    {
        public int ImportDataId { get; set; }
        public int ImportDataEntityType { get; set; }
        public string ImportDataFileName { get; set; }
        public string ImportDataState { get; set; }
        public string ImportDataUser { get; set; }
        public long ImportDataTimeStamp { get; set; }
    }
}
