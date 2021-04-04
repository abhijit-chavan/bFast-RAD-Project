using System;
using StudentEnquiryAPI.BusinessObject.Base;

namespace StudentEnquiryAPI.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional WorkflowStepsMaster Business Layer code in this class.
     /// </summary>
     public partial class WorkflowStepsMaster : WorkflowStepsMasterBase
     {
        public WorkflowStepsMaster ShallowCopy()
        {
            return (WorkflowStepsMaster)this.MemberwiseClone();
        }
     }
}
