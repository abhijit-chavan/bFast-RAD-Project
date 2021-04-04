using System;
using CourseEnquiryAPI.BusinessObject.Base;

namespace CourseEnquiryAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional CourseEnrollmentInfo Business Layer code in this class.
     /// </summary>
     public partial class CourseEnrollmentInfo : CourseEnrollmentInfoBase
     {
        public CourseEnrollmentInfo ShallowCopy()
        {
            return (CourseEnrollmentInfo)this.MemberwiseClone();
        }
     }
}
