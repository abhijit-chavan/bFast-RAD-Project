using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace StudentEnquiry
{
     public class CouseFunctions
     {
         private CouseFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(Couse model, CrudOperation operation, bool isForListInline = false)
         {
             Couse objCouse;
             Couse objCouseOld = new Couse();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objCouse = new Couse();
             else
             {
                 objCouse = Couse.SelectByPrimaryKey(model.Couseid);
                 objCouseOld = objCouse.ShallowCopy();
             }

             objCouse.Couseid = model.Couseid;
             objCouse.CouseName = model.CouseName;
             objCouse.CourseStartDate = model.CourseStartDate;
             objCouse.CourseEndDate = model.CourseEndDate;
             objCouse.CouseFees = model.CouseFees;

             if (operation == CrudOperation.Add)
             {
                id = objCouse.Insert();
             }
             else
             {
                objCouse.Update();
             }
         }
     }
}
