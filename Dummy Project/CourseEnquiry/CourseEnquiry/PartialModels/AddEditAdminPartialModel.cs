using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;

namespace CourseEnquiry.PartialModels
{
     public class AddEditAdminPartialModel
     {
         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.Admin Admin { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditAdminPartialModel()
         {
         }

     }
}
