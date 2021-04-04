using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;

namespace StudentEnquiry.PartialModels
{
     public class AddEditUserRolesPartialModel
     {
         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.UserRoles UserRoles { get; set; }

         public List<UserMaster> UserMasterDropDownListData;
         public List<RoleMaster> RoleMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditUserRolesPartialModel()
         {
         }

     }
}
