using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using fifth_tempDBAPI.Domain;
using fifth_tempDBAPI.BusinessObject;

namespace fifth_tempDB.PartialModels
{
     public class AddEditUserRolesPartialModel
     {
         [BindProperty]
         public fifth_tempDBAPI.BusinessObject.UserRoles UserRoles { get; set; }

         public List<UserMaster> UserMasterDropDownListData;
         public List<RoleMaster> RoleMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditUserRolesPartialModel()
         {
         }

     }
}
