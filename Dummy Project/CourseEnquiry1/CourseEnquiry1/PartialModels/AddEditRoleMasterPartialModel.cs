using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;

namespace CourseEnquiry1.PartialModels
{
     public class AddEditRoleMasterPartialModel
     {
         [BindProperty]
         public CourseEnquiry1API.BusinessObject.RoleMaster RoleMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditRoleMasterPartialModel()
         {
         }

     }
}
