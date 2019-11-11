using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class Literal
    {
        public int LiteralId { get; set; }
        public string LiteralKey { get; set; }
        public string LiteralValue { get; set; }
        public string LiteralLocale { get; set; }
        public string LiteralDescription { get; set; }
        public string LiteralScreenName { get; set; }
    }
}
