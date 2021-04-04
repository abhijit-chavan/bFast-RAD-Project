using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace CourseEnquiry1.Pages
{
     [AutoValidateAntiforgeryToken]
     public class CourseEnrollment_DetailsModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiry1API.BusinessObject.CourseEnrollment CourseEnrollment { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }


         /// <summary>
         /// Default Constructor: /CourseEnrollment_DetailsModel
         /// </summary>
         public CourseEnrollment_DetailsModel (ILog Ilog,IEmail IEmail)
         {
             if (_Ilog == null)
                 _Ilog = Ilog;
if (_IEmail == null)
_IEmail = IEmail;
         }

         /// <summary>
         /// Initial handler the razor page encounters.
         /// </summary>
         public void OnGet(int id, string returnUrl)
         {
             LoadPage(id, returnUrl);
         }

         public void LoadPage(int id, string returnUrl)
         {
             // select a record by primary key(s)
             CourseEnquiry1API.BusinessObject.CourseEnrollment objCourseEnrollment = CourseEnrollment.SelectByPrimaryKey(id);

             // assign values to this page's bound property
             CourseEnrollment = objCourseEnrollment;

             // assign the return url
             ReturnUrl = returnUrl;
         }
     }
}
