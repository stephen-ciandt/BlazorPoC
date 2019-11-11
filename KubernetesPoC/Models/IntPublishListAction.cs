using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntPublishListAction
    {
        public int IntPublishListActionId { get; set; }
        public int IntPublishListActionIntPublishListId { get; set; }
        public string IntPublishListActionName { get; set; }
        public string IntPublishListActionDescription { get; set; }
        public bool? IntPublishListActionIsPublished { get; set; }

        public virtual IntPublishList IntPublishListActionIntPublishList { get; set; }
    }
}
