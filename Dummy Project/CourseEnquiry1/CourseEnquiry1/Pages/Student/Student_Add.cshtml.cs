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
     public class Student_AddModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiry1API.BusinessObject.Student Student { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public AddEditStudentPartialModel PartialModel { get; set; }


         /// <summary>
         /// Default Constructor: /Student_AddModel
         /// </summary>
         public Student_AddModel (ILog Ilog,IEmail IEmail)
         {
             if (_Ilog == null)
                 _Ilog = Ilog;
if (_IEmail == null)
_IEmail = IEmail;
         }

         /// <summary>
         /// Initial handler the razor page encounters.
         /// </summary>
         public void OnGet(string returnUrl)
         {
             LoadPage(returnUrl);
         }

         private PageResult LoadPage(string returnUrl)
         {
             // create the model used by the partial page
             AddEditStudentPartialModel model = new AddEditStudentPartialModel();
             model.Operation = CrudOperation.Add;
             model.ReturnUrl = returnUrl;

             // assign values to the model used by this page
             PartialModel = model;

             // assign the return url
             ReturnUrl = returnUrl;

             return Page();
         }

         public IActionResult OnPostAdd()
         {
             if (ModelState.IsValid)
             {
                 try
                 {
                     // add new record
                     StudentFunctions.AddOrEdit(Student, CrudOperation.Add);
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
             return LoadPage(ReturnUrl);
         }
     }
}
