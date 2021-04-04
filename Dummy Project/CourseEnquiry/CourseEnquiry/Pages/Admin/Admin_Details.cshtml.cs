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

namespace CourseEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class Admin_DetailsModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.Admin Admin { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }


         /// <summary>
         /// Default Constructor: /Admin_DetailsModel
         /// </summary>
         public Admin_DetailsModel (ILog Ilog,IEmail IEmail)
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
             CourseEnquiryAPI.BusinessObject.Admin objAdmin = Admin.SelectByPrimaryKey(id);

             // assign values to this page's bound property
             Admin = objAdmin;

             // assign the return url
             ReturnUrl = returnUrl;
         }
     }
}
