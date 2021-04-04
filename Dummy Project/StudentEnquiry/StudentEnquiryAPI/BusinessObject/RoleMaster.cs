using System;
using StudentEnquiryAPI.BusinessObject.Base;

namespace StudentEnquiryAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional RoleMaster Business Layer code in this class.
     /// </summary>
     public partial class RoleMaster : RoleMasterBase
     {
        public RoleMaster ShallowCopy()
        {
            return (RoleMaster)this.MemberwiseClone();
        }
     }
}
