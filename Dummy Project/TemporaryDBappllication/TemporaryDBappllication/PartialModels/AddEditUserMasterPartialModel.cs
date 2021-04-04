using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;

namespace TemporaryDBappllication.PartialModels
{
     public class AddEditUserMasterPartialModel
     {
         [BindProperty]
         public TemporaryDBappllicationAPI.BusinessObject.UserMaster UserMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditUserMasterPartialModel()
         {
         }

     }
}
