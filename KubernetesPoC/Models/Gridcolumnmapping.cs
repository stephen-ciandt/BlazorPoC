using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Gridcolumnmapping
    {
        public int GridcolumnmappingId { get; set; }
        public string GridcolumnmappingGridname { get; set; }
        public string GridcolumnmappingColumnname { get; set; }
        public string GridcolumnmappingColumndisplayname { get; set; }
        public bool GridcolumnmappingSelected { get; set; }
        public string GridcolumnmappingType { get; set; }
    }
}
