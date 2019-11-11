using System;
using System.Collections.Generic;

namespace KubernetesPoC.Models
{
    public partial class PreCompiledCheckListUserGroup
    {
        public int PreCompiledCheckListUserGroupId { get; set; }
        public int PreCompiledCheckListUserGroupUserGroupId { get; set; }
        public int PreCompiledCheckListUserGroupCheckListId { get; set; }

        public virtual PreCompiledCheckList PreCompiledCheckListUserGroupCheckList { get; set; }
        public virtual UserGroup PreCompiledCheckListUserGroupUserGroup { get; set; }
    }
}
