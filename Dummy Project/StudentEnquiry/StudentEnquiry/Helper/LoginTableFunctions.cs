using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace StudentEnquiry
{
     public class LoginTableFunctions
     {
         private LoginTableFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(LoginTable model, CrudOperation operation, bool isForListInline = false)
         {
             LoginTable objLoginTable;
             LoginTable objLoginTableOld = new LoginTable();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objLoginTable = new LoginTable();
             else
             {
                 objLoginTable = LoginTable.SelectByPrimaryKey(model.Adminid);
                 objLoginTableOld = objLoginTable.ShallowCopy();
             }

             objLoginTable.Adminid = model.Adminid;
             objLoginTable.Password = model.Password;

             if (operation == CrudOperation.Add)
             {
                id = objLoginTable.Insert();
             }
             else
             {
                objLoginTable.Update();
             }
         }
     }
}
