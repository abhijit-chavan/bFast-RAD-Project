using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace TemporaryDBappllication.Pages
{
     [AutoValidateAntiforgeryToken]
     public class WorkflowMaster_UnboundModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public TemporaryDBappllicationAPI.BusinessObject.WorkflowMaster WorkflowMaster { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public CrudOperation Operation;


         /// <summary>
         /// Default Constructor: /WorkflowMaster_UnboundModel
         /// </summary>
         public WorkflowMaster_UnboundModel (ILog Ilog,IEmail IEmail)
         {
             if (_Ilog == null)
                 _Ilog = Ilog;
if (_IEmail == null)
_IEmail = IEmail;
         }

         /// <summary>
         /// Initial handler the razor page encounters.
         /// </summary>
         public void OnGet()
         {
             // assign model(s) used by this page
             ReturnUrl = "/Index";
         }

         public IActionResult OnPostSubmit()
         {
             if (ModelState.IsValid)
             {
                 try
                 {
                     // add new record (or update existing record) here

                     // redirect to another page
                     return RedirectToPage("");
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
             return Page();
         }
     }
}
