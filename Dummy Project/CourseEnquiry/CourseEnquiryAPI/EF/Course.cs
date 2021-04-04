using System;
using System.Collections.Generic;

namespace CourseEnquiryAPI.BusinessObject
{
    public partial class Course
    {
        public Course()
        {
            CourseEnrollmentInfo = new HashSet<CourseEnrollmentInfo>();
        }

        public virtual ICollection<CourseEnrollmentInfo> CourseEnrollmentInfo { get; set; }
    }
}
