using System;
using System.Collections.Generic;

namespace fourth_tempDBAPI.BusinessObject
{
    public partial class UserRoles
    {
        public UserRoles()
        {
        }

        public virtual UserMaster UserMaster { get; set; }
        public virtual RoleMaster RoleMaster { get; set; }
    }
}
