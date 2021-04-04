using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using fifth_tempDBAPI.Domain;
using fifth_tempDBAPI.BusinessObject;

namespace fifth_tempDB.PartialModels
{
     public class AddEditWorkflowStepsMasterPartialModel
     {
         [BindProperty]
         public fifth_tempDBAPI.BusinessObject.WorkflowStepsMaster WorkflowStepsMaster { get; set; }

         public List<WorkflowMaster> WorkflowMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowStepsMasterPartialModel()
         {
         }

     }
}
