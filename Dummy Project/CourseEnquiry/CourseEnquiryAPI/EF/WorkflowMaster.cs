using System;
using System.Collections.Generic;

namespace CourseEnquiryAPI.BusinessObject
{
    public partial class WorkflowMaster
    {
        public WorkflowMaster()
        {
            WorkflowStepsMaster = new HashSet<WorkflowStepsMaster>();
        }

        public virtual ICollection<WorkflowStepsMaster> WorkflowStepsMaster { get; set; }
    }
}
