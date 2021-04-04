using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;

namespace CourseEnquiry1.PartialModels
{
     public class AddEditWorkflowStepsMasterPartialModel
     {
         [BindProperty]
         public CourseEnquiry1API.BusinessObject.WorkflowStepsMaster WorkflowStepsMaster { get; set; }

         public List<WorkflowMaster> WorkflowMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowStepsMasterPartialModel()
         {
         }

     }
}
