using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using fourth_tempDBAPI.Domain;
using fourth_tempDBAPI.BusinessObject;
using Newtonsoft.Json;
using Application_Components.Logging;
using Application_Components.EmailNotification;

namespace fourth_tempDB.Pages
{
     [AutoValidateAntiforgeryToken]
     public class UserMaster_DetailsModel : PageModel
     {
         ILog _Ilog;
IEmail _IEmail;

         [BindProperty]
         public fourth_tempDBAPI.BusinessObject.UserMaster UserMaster { get; set; }

         [BindProperty]
         public string ReturnUrl { get; set; }


         /// <summary>
         /// Default Constructor: /UserMaster_DetailsModel
         /// </summary>
         public UserMaster_DetailsModel (ILog Ilog,IEmail IEmail)
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
             fourth_tempDBAPI.BusinessObject.UserMaster objUserMaster = UserMaster.SelectByPrimaryKey(id);

             // assign values to this page's bound property
             UserMaster = objUserMaster;

             // assign the return url
             ReturnUrl = returnUrl;
         }
     }
}
