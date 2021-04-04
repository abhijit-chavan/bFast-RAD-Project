using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;

namespace TemporaryDBappllication.PartialModels
{
     public class AddEditRoleMasterPartialModel
     {
         [BindProperty]
         public TemporaryDBappllicationAPI.BusinessObject.RoleMaster RoleMaster { get; set; }

         public CrudOperation Operation;
         public string ReturnUrl;

         public AddEditRoleMasterPartialModel()
         {
         }

     }
}
