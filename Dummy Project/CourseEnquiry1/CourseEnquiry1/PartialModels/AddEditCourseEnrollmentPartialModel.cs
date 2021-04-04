using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;

namespace CourseEnquiry1.PartialModels
{
     public class AddEditCourseEnrollmentPartialModel
     {
         [BindProperty]
         public CourseEnquiry1API.BusinessObject.CourseEnrollment CourseEnrollment { get; set; }

         public List<Course> CourseDropDownListData;
         public List<Student> StudentDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditCourseEnrollmentPartialModel()
         {
         }

     }
}
