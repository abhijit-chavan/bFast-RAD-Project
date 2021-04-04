using System;
using CourseEnquiry1API.BusinessObject.Base;

namespace CourseEnquiry1API.BusinessObject
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
