using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;

namespace CourseEnquiry.PartialModels
{
     public class AddEditUserRolesPartialModel
     {
         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.UserRoles UserRoles { get; set; }

         public List<UserMaster> UserMasterDropDownListData;
         public List<RoleMaster> RoleMasterDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditUserRolesPartialModel()
         {
         }

     }
}
