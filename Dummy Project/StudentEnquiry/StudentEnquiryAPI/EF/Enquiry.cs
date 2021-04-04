using System;
using System.Collections.Generic;

namespace StudentEnquiryAPI.BusinessObject
{
    public partial class Enquiry
    {
        public Enquiry()
        {
        }

        public virtual Enquiry Enquiry1 { get; set; }
        public virtual ICollection<Enquiry> InverseEnquiryIdNavigation { get; set; }
        public virtual Couse CourseIdNavigation { get; set; }
    }
}
