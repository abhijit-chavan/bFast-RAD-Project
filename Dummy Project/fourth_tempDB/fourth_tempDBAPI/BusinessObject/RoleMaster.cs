using System;
using fourth_tempDBAPI.BusinessObject.Base;

namespace fourth_tempDBAPI.BusinessObject
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
