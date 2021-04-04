using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;

namespace CourseEnquiry1.PartialModels
{
     public class AddEditCoursePartialModel
     {
         [BindProperty]
         public CourseEnquiry1API.BusinessObject.Course Course { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditCoursePartialModel()
         {
         }

     }
}
