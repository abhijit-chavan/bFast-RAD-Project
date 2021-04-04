using System;
using System.Collections.Generic;

namespace CourseEnquiryAPI.BusinessObject
{
    public partial class CourseEnrollmentInfo
    {
        public CourseEnrollmentInfo()
        {
        }

        public virtual CourseEnrollmentInfo CourseEnrollmentInfo1 { get; set; }
        public virtual ICollection<CourseEnrollmentInfo> InverseEnrollmentIdNavigation { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
