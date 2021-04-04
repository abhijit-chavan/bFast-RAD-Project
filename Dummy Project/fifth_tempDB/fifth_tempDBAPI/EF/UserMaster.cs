using System;
using System.Collections.Generic;

namespace fifth_tempDBAPI.BusinessObject
{
    public partial class UserMaster
    {
        public UserMaster()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
