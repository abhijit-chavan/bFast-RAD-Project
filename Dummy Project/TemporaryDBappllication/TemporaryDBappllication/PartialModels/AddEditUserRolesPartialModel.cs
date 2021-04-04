using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;

namespace TemporaryDBappllication.PartialModels
{
     public class AddEditUserRolesPartialModel
     {
         [BindProperty]
         public TemporaryDBappllicationAPI.BusinessObject.UserRoles UserRoles { get; set; }

         public List<UserMaster> UserMasterDropDownListData;
         public List<RoleMaster> RoleMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditUserRolesPartialModel()
         {
         }

     }
}
