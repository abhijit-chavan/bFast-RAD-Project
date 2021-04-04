using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;

namespace StudentEnquiry.PartialModels
{
     public class AddEditRoleMasterPartialModel
     {
         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.RoleMaster RoleMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditRoleMasterPartialModel()
         {
         }

     }
}
