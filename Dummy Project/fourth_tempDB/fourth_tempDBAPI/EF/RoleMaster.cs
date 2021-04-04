using System;
using System.Collections.Generic;

namespace fourth_tempDBAPI.BusinessObject
{
    public partial class RoleMaster
    {
        public RoleMaster()
        {
            UserRoles = new HashSet<UserRoles>();
        }

        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
