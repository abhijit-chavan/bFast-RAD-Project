using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;

namespace CourseEnquiry.PartialModels
{
     public class AddEditUserMasterPartialModel
     {
         [BindProperty]
         public CourseEnquiryAPI.BusinessObject.UserMaster UserMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditUserMasterPartialModel()
         {
         }

     }
}
