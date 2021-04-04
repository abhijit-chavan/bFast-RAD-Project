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

namespace StudentEnquiry.Pages
{
     [AutoValidateAntiforgeryToken]
     public class LoginTable_DetailsModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.LoginTable LoginTable { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }


         /// <summary>
         /// Default Constructor: /LoginTable_DetailsModel
         /// </summary>
         public LoginTable_DetailsModel (ILog Ilog,IEmail IEmail)
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
             StudentEnquiryAPI.BusinessObject.LoginTable objLoginTable = LoginTable.SelectByPrimaryKey(id);

             // assign values to this page's bound property
             LoginTable = objLoginTable;

             // assign the return url
             ReturnUrl = returnUrl;
         }
     }
}
