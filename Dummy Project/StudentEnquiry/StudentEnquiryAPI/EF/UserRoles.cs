using System;
using System.Collections.Generic;

namespace StudentEnquiryAPI.BusinessObject
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
