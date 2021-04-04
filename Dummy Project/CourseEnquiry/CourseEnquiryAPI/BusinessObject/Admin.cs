using System;
using CourseEnquiryAPI.BusinessObject.Base;

namespace CourseEnquiryAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional Admin Business Layer code in this class.
     /// </summary>
     public partial class Admin : AdminBase
     {
        public Admin ShallowCopy()
        {
            return (Admin)this.MemberwiseClone();
        }
     }
}
