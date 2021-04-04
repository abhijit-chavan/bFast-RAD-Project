using System;
using fifth_tempDBAPI.BusinessObject.Base;

namespace fifth_tempDBAPI.BusinessObject
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
