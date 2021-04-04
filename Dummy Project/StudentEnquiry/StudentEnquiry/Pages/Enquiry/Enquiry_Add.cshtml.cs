using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;
using StudentEnquiry.PartialModels;

namespace StudentEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class Enquiry_AddModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.Enquiry Enquiry { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }

         public AddEditEnquiryPartialModel PartialModel { get; set; }


         /// <summary>
         /// Default Constructor: /Enquiry_AddModel
         /// </summary>
         public Enquiry_AddModel (ILog Ilog,IEmail IEmail)
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
             AddEditEnquiryPartialModel model = new AddEditEnquiryPartialModel();
             model.EnquiryDropDownListData = Enquiry.SelectEnquiryDropDownListData();
             model.CouseDropDownListData = Couse.SelectCouseDropDownListData();
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
                     EnquiryFunctions.AddOrEdit(Enquiry, CrudOperation.Add);
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
