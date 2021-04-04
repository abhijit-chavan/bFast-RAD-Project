using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace StudentEnquiry
{
     public class UserRolesFunctions
     {
         private UserRolesFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(UserRoles model, CrudOperation operation, bool isForListInline = false)
         {
             UserRoles objUserRoles;
             UserRoles objUserRolesOld = new UserRoles();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objUserRoles = new UserRoles();
             else
             {
                 objUserRoles = UserRoles.SelectByPrimaryKey(model.UserRoleId);
                 objUserRolesOld = objUserRoles.ShallowCopy();
             }

             objUserRoles.UserRoleId = model.UserRoleId;
             objUserRoles.UserId = model.UserId;
             objUserRoles.RoleId = model.RoleId;
             objUserRoles.Status = model.Status;

             if (operation == CrudOperation.Add)
             {
                id = objUserRoles.Insert();
             }
             else
             {
                objUserRoles.Update();
             }
         }
     }
}
