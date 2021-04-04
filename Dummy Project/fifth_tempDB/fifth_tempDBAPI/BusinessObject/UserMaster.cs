using System;
using fifth_tempDBAPI.BusinessObject.Base;

namespace fifth_tempDBAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional UserMaster Business Layer code in this class.
     /// </summary>
     public partial class UserMaster : UserMasterBase
     {
        public UserMaster ShallowCopy()
        {
            return (UserMaster)this.MemberwiseClone();
        }
     }
}
