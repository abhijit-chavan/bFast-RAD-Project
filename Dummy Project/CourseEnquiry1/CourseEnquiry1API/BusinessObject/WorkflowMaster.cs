using System;
using CourseEnquiry1API.BusinessObject.Base;

namespace CourseEnquiry1API.BusinessObject
{
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional WorkflowMaster Business Layer code in this class.
     /// </summary>
     public partial class WorkflowMaster : WorkflowMasterBase
     {
        public WorkflowMaster ShallowCopy()
        {
            return (WorkflowMaster)this.MemberwiseClone();
        }
     }
}
