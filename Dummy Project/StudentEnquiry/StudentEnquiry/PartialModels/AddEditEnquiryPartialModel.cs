using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;

namespace StudentEnquiry.PartialModels
{
     public class AddEditEnquiryPartialModel
     {
         [BindProperty]
         public StudentEnquiryAPI.BusinessObject.Enquiry Enquiry { get; set; }

         public List<Enquiry> EnquiryDropDownListData;
         public List<Couse> CouseDropDownListData;

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditEnquiryPartialModel()
         {
         }

     }
}
