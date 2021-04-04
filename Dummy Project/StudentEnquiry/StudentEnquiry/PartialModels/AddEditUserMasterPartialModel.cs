using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;

namespace StudentEnquiry.PartialModels
{
     public class AddEditUserMasterPartialModel
     {
         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.UserMaster UserMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditUserMasterPartialModel()
         {
         }

     }
}
