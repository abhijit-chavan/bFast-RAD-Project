using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace StudentEnquiry
{
     public class RoleMasterFunctions
     {
         private RoleMasterFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(RoleMaster model, CrudOperation operation, bool isForListInline = false)
         {
             RoleMaster objRoleMaster;
             RoleMaster objRoleMasterOld = new RoleMaster();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objRoleMaster = new RoleMaster();
             else
             {
                 objRoleMaster = RoleMaster.SelectByPrimaryKey(model.RoleId);
                 objRoleMasterOld = objRoleMaster.ShallowCopy();
             }

             objRoleMaster.RoleId = model.RoleId;
             objRoleMaster.RoleDescription = model.RoleDescription;
             objRoleMaster.CreatedOn = model.CreatedOn;
             objRoleMaster.CreatedBy = model.CreatedBy;
             objRoleMaster.ModifiedOn = model.ModifiedOn;
             objRoleMaster.ModifiedBy = model.ModifiedBy;

             if (operation == CrudOperation.Add)
             {
                id = objRoleMaster.Insert();
             }
             else
             {
                objRoleMaster.Update();
             }
         }
     }
}
