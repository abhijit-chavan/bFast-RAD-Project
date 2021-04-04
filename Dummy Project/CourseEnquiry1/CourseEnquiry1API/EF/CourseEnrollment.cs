using System;
using System.Collections.Generic;

namespace CourseEnquiry1API.BusinessObject
{
    public partial class CourseEnrollment
    {
        public CourseEnrollment()
        {
        }

        public virtual Course CourseNameNavigation { get; set; }
        public virtual Student StudentNameNavigation { get; set; }
    }
}
