using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;

namespace StudentEnquiry.PartialModels
{
     public class AddEditLoginTablePartialModel
     {
         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.LoginTable LoginTable { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditLoginTablePartialModel()
         {
         }

     }
}
