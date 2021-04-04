using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;

namespace StudentEnquiry.PartialModels
{
     public class AddEditCousePartialModel
     {
         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.Couse Couse { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditCousePartialModel()
         {
         }

     }
}
