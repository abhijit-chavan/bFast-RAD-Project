using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using fourth_tempDBAPI.Domain;
using fourth_tempDBAPI.BusinessObject;

namespace fourth_tempDB.PartialModels
{
     public class AddEditWorkflowMasterPartialModel
     {
         [BindProperty]
         public fourth_tempDBAPI.BusinessObject.WorkflowMaster WorkflowMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowMasterPartialModel()
         {
         }

     }
}
