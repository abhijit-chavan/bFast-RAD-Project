using System;
using System.Collections.Generic;

namespace CourseEnquiry1API.BusinessObject
{
    public partial class WorkflowStepsMaster
    {
        public WorkflowStepsMaster()
        {
        }

        public virtual WorkflowMaster WorKflowIdNavigation { get; set; }
    }
}
