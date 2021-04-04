using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;

namespace CourseEnquiry.PartialModels
{
     public class AddEditCoursePartialModel
     {
         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.Course Course { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditCoursePartialModel()
         {
         }

     }
}
