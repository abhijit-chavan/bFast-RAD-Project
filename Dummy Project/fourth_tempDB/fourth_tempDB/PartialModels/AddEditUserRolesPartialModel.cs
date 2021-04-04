using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using fourth_tempDBAPI.Domain;
using fourth_tempDBAPI.BusinessObject;

namespace fourth_tempDB.PartialModels
{
     public class AddEditUserRolesPartialModel
     {
         [BindProperty]
         public fourth_tempDBAPI.BusinessObject.UserRoles UserRoles { get; set; }

         public List<UserMaster> UserMasterDropDownListData;
         public List<RoleMaster> RoleMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditUserRolesPartialModel()
         {
         }

     }
}
