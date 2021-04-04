using System;
using System.Collections.Generic;

namespace fifth_tempDBAPI.BusinessObject
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
