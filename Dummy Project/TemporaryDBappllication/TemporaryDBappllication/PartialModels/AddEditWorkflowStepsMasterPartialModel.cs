using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;

namespace TemporaryDBappllication.PartialModels
{
     public class AddEditWorkflowStepsMasterPartialModel
     {
         [BindProperty]
         public TemporaryDBappllicationAPI.BusinessObject.WorkflowStepsMaster WorkflowStepsMaster { get; set; }

         public List<WorkflowMaster> WorkflowMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowStepsMasterPartialModel()
         {
         }

     }
}
