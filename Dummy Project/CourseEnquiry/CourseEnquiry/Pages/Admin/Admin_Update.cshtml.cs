using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;
using CourseEnquiry.PartialModels;

namespace CourseEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class Admin_UpdateModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.Admin Admin { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public AddEditAdminPartialModel PartialModel { get; set; }


         /// <summary>
         /// Default Constructor: /Admin_UpdateModel
         /// </summary>
         public Admin_UpdateModel (ILog Ilog,IEmail IEmail)
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
             CourseEnquiryAPI.BusinessObject.Admin objAdmin = Admin.SelectByPrimaryKey(id);

             // create the model used by the partial page
             AddEditAdminPartialModel model = new AddEditAdminPartialModel();
             model.Operation = CrudOperation.Update;
             model.ReturnUrl = returnUrl;
             model.Admin = objAdmin;

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
                     AdminFunctions.AddOrEdit(Admin, CrudOperation.Update);
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
             return LoadPage(Admin.AdminId, ReturnUrl);
         }
     }
}
