using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace CourseEnquiry
{
     public class AdminFunctions
     {
         private AdminFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(Admin model, CrudOperation operation, bool isForListInline = false)
         {
             Admin objAdmin;
             Admin objAdminOld = new Admin();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objAdmin = new Admin();
             else
             {
                 objAdmin = Admin.SelectByPrimaryKey(model.AdminId);
                 objAdminOld = objAdmin.ShallowCopy();
             }

             objAdmin.AdminId = model.AdminId;
             objAdmin.AdminName = model.AdminName;
             objAdmin.AdminPassword = model.AdminPassword;

             if (operation == CrudOperation.Add)
             {
                id = objAdmin.Insert();
             }
             else
             {
                objAdmin.Update();
             }
         }
     }
}
