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
using CourseEnquiry1.PartialModels;

namespace CourseEnquiry1.Pages
{
     [AutoValidateAntiforgeryToken]
     public class CourseEnrollment_UpdateModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiry1API.BusinessObject.CourseEnrollment CourseEnrollment { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public AddEditCourseEnrollmentPartialModel PartialModel { get; set; }


         /// <summary>
         /// Default Constructor: /CourseEnrollment_UpdateModel
         /// </summary>
         public CourseEnrollment_UpdateModel (ILog Ilog,IEmail IEmail)
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

         public PageResult LoadPage(int id, string returnUrl)
         {
             // select a record by primary key(s)
             CourseEnquiry1API.BusinessObject.CourseEnrollment objCourseEnrollment = CourseEnrollment.SelectByPrimaryKey(id);

             // create the model used by the partial page
             AddEditCourseEnrollmentPartialModel model = new AddEditCourseEnrollmentPartialModel();
             model.CourseDropDownListData = Course.SelectCourseDropDownListData();
             model.StudentDropDownListData = Student.SelectStudentDropDownListData();
             model.Operation = CrudOperation.Update;
             model.ReturnUrl = returnUrl;
             model.CourseEnrollment = objCourseEnrollment;

             // assign values to the model used by this page
             PartialModel = model;

             // assign the return url
             ReturnUrl = returnUrl;

             return Page();
         }

         public IActionResult OnPostUpdate()
         {
             if (ModelState.IsValid)
             {
                 try
                 {
                     // update record
                     CourseEnrollmentFunctions.AddOrEdit(CourseEnrollment, CrudOperation.Update);
                     return RedirectToPage(ReturnUrl);
                 }
                 catch(Exception ex)
                 {
                     _Ilog.GetInstance().Error("Error Occured", ex);

                     if (ex.InnerException != null)
                         ModelState.AddModelError("", ex.InnerException.Message);
                     else
                         ModelState.AddModelError("", ex.Message);
                 }
             }

             // if we got this far, something failed, redisplay form
             return LoadPage(CourseEnrollment.EnrollmentId, ReturnUrl);
         }
     }
}
