using System;
using CourseEnquiry1API.BusinessObject.Base;

namespace CourseEnquiry1API.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional UserRoles Business Layer code in this class.
     /// </summary>
     public partial class UserRoles : UserRolesBase
     {
        public UserRoles ShallowCopy()
        {
            return (UserRoles)this.MemberwiseClone();
        }
     }
}
