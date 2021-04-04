using System;
using System.Collections.Generic;

namespace TemporaryDBappllicationAPI.BusinessObject
{
    public partial class WorkflowStepsMaster
    {
        public WorkflowStepsMaster()
        {
        }

        public virtual WorkflowMaster WorKflowIdNavigation { get; set; }
    }
}
