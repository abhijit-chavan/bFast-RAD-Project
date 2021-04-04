using System;
using StudentEnquiryAPI.BusinessObject.Base;

namespace StudentEnquiryAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional Enquiry Business Layer code in this class.
     /// </summary>
     public partial class Enquiry : EnquiryBase
     {
        public Enquiry ShallowCopy()
        {
            return (Enquiry)this.MemberwiseClone();
        }
     }
}
