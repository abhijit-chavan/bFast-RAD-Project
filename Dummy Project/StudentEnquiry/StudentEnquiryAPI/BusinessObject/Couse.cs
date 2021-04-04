using System;
using StudentEnquiryAPI.BusinessObject.Base;

namespace StudentEnquiryAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional Couse Business Layer code in this class.
     /// </summary>
     public partial class Couse : CouseBase
     {
        public Couse ShallowCopy()
        {
            return (Couse)this.MemberwiseClone();
        }
     }
}
