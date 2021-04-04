using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;

namespace CourseEnquiry.PartialModels
{
     public class AddEditStudentPartialModel
     {
         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.Student Student { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditStudentPartialModel()
         {
         }

     }
}
