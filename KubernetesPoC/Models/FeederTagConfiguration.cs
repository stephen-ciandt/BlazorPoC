using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class FeederTagConfiguration
    {
        public int FeederTagConfigurationId { get; set; }
        public int? FeederId { get; set; }
        public int MahinceFamily { get; set; }
        public int AttrType { get; set; }
        public bool EnableCount { get; set; }
        public long TagCount { get; set; }
        public bool EnableTime { get; set; }
        public decimal TagTime { get; set; }
        public decimal TagCondition { get; set; }
        public decimal TagPlacementCountRatio { get; set; }
        public decimal TagPickupMissRatio { get; set; }
        public decimal TagPickupErrorRatio { get; set; }
        public decimal TagShapeErrorRatio { get; set; }
        public decimal TagRecognitionErrorRatio { get; set; }
    }
}
