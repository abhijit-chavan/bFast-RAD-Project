using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;

namespace CourseEnquiry.PartialModels
{
     public class AddEditWorkflowMasterPartialModel
     {
         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.WorkflowMaster WorkflowMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowMasterPartialModel()
         {
         }

     }
}
