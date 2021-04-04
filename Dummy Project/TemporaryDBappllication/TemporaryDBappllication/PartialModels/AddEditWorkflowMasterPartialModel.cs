using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;

namespace TemporaryDBappllication.PartialModels
{
     public class AddEditWorkflowMasterPartialModel
     {
         [BindProperty]
         public TemporaryDBappllicationAPI.BusinessObject.WorkflowMaster WorkflowMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowMasterPartialModel()
         {
         }

     }
}
