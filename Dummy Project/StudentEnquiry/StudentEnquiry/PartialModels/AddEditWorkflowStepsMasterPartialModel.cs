using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;

namespace StudentEnquiry.PartialModels
{
     public class AddEditWorkflowStepsMasterPartialModel
     {
         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.WorkflowStepsMaster WorkflowStepsMaster { get; set; }

         public List<WorkflowMaster> WorkflowMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditWorkflowStepsMasterPartialModel()
         {
         }

     }
}
