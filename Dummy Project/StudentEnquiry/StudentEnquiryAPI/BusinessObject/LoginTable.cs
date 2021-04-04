using System;
using StudentEnquiryAPI.BusinessObject.Base;

namespace StudentEnquiryAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional LoginTable Business Layer code in this class.
     /// </summary>
     public partial class LoginTable : LoginTableBase
     {
        public LoginTable ShallowCopy()
        {
            return (LoginTable)this.MemberwiseClone();
        }
     }
}
