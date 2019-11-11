using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class IntPublishList
    {
        public IntPublishList()
        {
            IntPublishListAction = new HashSet<IntPublishListAction>();
        }

        public int IntPublishListId { get; set; }
        public string IntPublishListName { get; set; }
        public string IntPublishListDescription { get; set; }

        public virtual ICollection<IntPublishListAction> IntPublishListAction { get; set; }
    }
}
