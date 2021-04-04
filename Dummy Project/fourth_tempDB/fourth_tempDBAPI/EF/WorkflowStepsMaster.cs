using System;
using System.Collections.Generic;

namespace fourth_tempDBAPI.BusinessObject
{
    public partial class WorkflowStepsMaster
    {
        public WorkflowStepsMaster()
        {
        }

        public virtual WorkflowMaster WorKflowIdNavigation { get; set; }
    }
}
