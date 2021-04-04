using System;
using System.Collections.Generic;

namespace StudentEnquiryAPI.BusinessObject
{
    public partial class Couse
    {
        public Couse()
        {
            Enquiry = new HashSet<Enquiry>();
        }

        public virtual ICollection<Enquiry> Enquiry { get; set; }
    }
}
