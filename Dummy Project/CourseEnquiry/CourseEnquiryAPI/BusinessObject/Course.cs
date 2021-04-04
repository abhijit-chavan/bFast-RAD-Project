using System;
using CourseEnquiryAPI.BusinessObject.Base;

namespace CourseEnquiryAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional Course Business Layer code in this class.
     /// </summary>
     public partial class Course : CourseBase
     {
        public Course ShallowCopy()
        {
            return (Course)this.MemberwiseClone();
        }
     }
}
