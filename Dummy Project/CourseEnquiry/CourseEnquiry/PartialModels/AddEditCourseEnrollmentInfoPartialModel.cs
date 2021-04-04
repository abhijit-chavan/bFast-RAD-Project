using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;

namespace CourseEnquiry.PartialModels
{
     public class AddEditCourseEnrollmentInfoPartialModel
     {
         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.CourseEnrollmentInfo CourseEnrollmentInfo { get; set; }

         public List<CourseEnrollmentInfo> CourseEnrollmentInfoDropDownListData;
         public List<Course> CourseDropDownListData;
         public List<Student> StudentDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditCourseEnrollmentInfoPartialModel()
         {
         }

     }
}
