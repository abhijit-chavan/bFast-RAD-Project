using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;

namespace StudentEnquiry.PartialModels
{
     public class AddEditWorkflowMasterPartialModel
     {
         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.WorkflowMaster WorkflowMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowMasterPartialModel()
         {
         }

     }
}
