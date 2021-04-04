using System;
using System.Collections.Generic;

namespace TemporaryDBappllicationAPI.BusinessObject
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
