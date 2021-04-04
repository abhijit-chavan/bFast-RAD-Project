using TemporaryDBappllicationAPI.Domain;
using TemporaryDBappllicationAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace TemporaryDBappllication
{
     public class UserMasterFunctions
     {
         private UserMasterFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(UserMaster model, CrudOperation operation, bool isForListInline = false)
         {
             UserMaster objUserMaster;
             UserMaster objUserMasterOld = new UserMaster();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objUserMaster = new UserMaster();
             else
             {
                 objUserMaster = UserMaster.SelectByPrimaryKey(model.UserId);
                 objUserMasterOld = objUserMaster.ShallowCopy();
             }

             objUserMaster.UserId = model.UserId;
             objUserMaster.UserName = model.UserName;
             objUserMaster.Password = model.Password;
             objUserMaster.Email = model.Email;
             objUserMaster.CreatedOn = model.CreatedOn;
             objUserMaster.CreatedBy = model.CreatedBy;
             objUserMaster.ModifiedOn = model.ModifiedOn;
             objUserMaster.ModifiedBy = model.ModifiedBy;

             if (operation == CrudOperation.Add)
             {
                id = objUserMaster.Insert();
             }
             else
             {
                objUserMaster.Update();
             }
         }
     }
}
