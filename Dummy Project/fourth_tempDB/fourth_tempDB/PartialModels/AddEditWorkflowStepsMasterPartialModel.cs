using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using fourth_tempDBAPI.Domain;
using fourth_tempDBAPI.BusinessObject;

namespace fourth_tempDB.PartialModels
{
     public class AddEditWorkflowStepsMasterPartialModel
     {
         [BindProperty]
         public fourth_tempDBAPI.BusinessObject.WorkflowStepsMaster WorkflowStepsMaster { get; set; }

         public List<WorkflowMaster> WorkflowMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowStepsMasterPartialModel()
         {
         }

     }
}
