using System;
using System.Collections.Generic;

namespace StudentEnquiryAPI.BusinessObject
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
