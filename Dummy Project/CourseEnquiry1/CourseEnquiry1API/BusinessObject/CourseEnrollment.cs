using System;
using CourseEnquiry1API.BusinessObject.Base;

namespace CourseEnquiry1API.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional CourseEnrollment Business Layer code in this class.
     /// </summary>
     public partial class CourseEnrollment : CourseEnrollmentBase
     {
        public CourseEnrollment ShallowCopy()
        {
            return (CourseEnrollment)this.MemberwiseClone();
        }
     }
}
