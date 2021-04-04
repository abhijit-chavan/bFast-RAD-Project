using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;

namespace CourseEnquiry1.PartialModels
{
     public class AddEditStudentPartialModel
     {
         [BindProperty]
         public CourseEnquiry1API.BusinessObject.Student Student { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditStudentPartialModel()
         {
         }

     }
}
