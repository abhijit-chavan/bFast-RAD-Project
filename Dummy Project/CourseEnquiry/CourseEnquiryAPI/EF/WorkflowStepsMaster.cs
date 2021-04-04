using System;
using System.Collections.Generic;

namespace CourseEnquiryAPI.BusinessObject
{
    public partial class WorkflowStepsMaster
    {
        public WorkflowStepsMaster()
        {
        }

        public virtual WorkflowMaster WorKflowIdNavigation { get; set; }
    }
}
