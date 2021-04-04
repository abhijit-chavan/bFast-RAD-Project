using System;
using System.Collections.Generic;

namespace CourseEnquiry1API.BusinessObject
{
    public partial class Student
    {
        public Student()
        {
            CourseEnrollment = new HashSet<CourseEnrollment>();
        }

        public virtual ICollection<CourseEnrollment> CourseEnrollment { get; set; }
    }
}
