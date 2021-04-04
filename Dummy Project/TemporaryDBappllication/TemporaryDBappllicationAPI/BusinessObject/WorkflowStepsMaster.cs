using System;
using TemporaryDBappllicationAPI.BusinessObject.Base;

namespace TemporaryDBappllicationAPI.BusinessObject
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
