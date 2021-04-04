using System;
using System.Collections.Generic;

namespace CourseEnquiry1API.BusinessObject
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
