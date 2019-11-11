using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class UnitOfCost
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public bool IsActive { get; set; }
    }
}
