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
     public class UserMaster_UpdateModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.UserMaster UserMaster { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public AddEditUserMasterPartialModel PartialModel { get; set; }


         /// <summary>
         /// Default Constructor: /UserMaster_UpdateModel
         /// </summary>
         public UserMaster_UpdateModel (ILog Ilog,IEmail IEmail)
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
             CourseEnquiryAPI.BusinessObject.UserMaster objUserMaster = UserMaster.SelectByPrimaryKey(id);

             // create the model used by the partial page
             AddEditUserMasterPartialModel model = new AddEditUserMasterPartialModel();
             model.Operation = CrudOperation.Update;
             model.ReturnUrl = returnUrl;
             model.UserMaster = objUserMaster;

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
                     UserMasterFunctions.AddOrEdit(UserMaster, CrudOperation.Update);
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
             return LoadPage(UserMaster.UserId, ReturnUrl);
         }
     }
}
