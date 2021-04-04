using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using fifth_tempDBAPI.Domain;
using fifth_tempDBAPI.BusinessObject;

namespace fifth_tempDB.PartialModels
{
     public class AddEditWorkflowMasterPartialModel
     {
         [BindProperty]
         public fifth_tempDBAPI.BusinessObject.WorkflowMaster WorkflowMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowMasterPartialModel()
         {
         }

     }
}
