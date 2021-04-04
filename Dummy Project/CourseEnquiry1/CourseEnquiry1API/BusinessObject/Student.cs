using System;
using CourseEnquiry1API.BusinessObject.Base;

namespace CourseEnquiry1API.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional Student Business Layer code in this class.
     /// </summary>
     public partial class Student : StudentBase
     {
        public Student ShallowCopy()
        {
            return (Student)this.MemberwiseClone();
        }
     }
}
