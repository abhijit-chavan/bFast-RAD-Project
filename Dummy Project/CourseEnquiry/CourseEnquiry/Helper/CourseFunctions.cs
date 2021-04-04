using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace CourseEnquiry
{
     public class CourseFunctions
     {
         private CourseFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(Course model, CrudOperation operation, bool isForListInline = false)
         {
             Course objCourse;
             Course objCourseOld = new Course();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objCourse = new Course();
             else
             {
                 objCourse = Course.SelectByPrimaryKey(model.CourseId);
                 objCourseOld = objCourse.ShallowCopy();
             }

             objCourse.CourseId = model.CourseId;
             objCourse.CourseName = model.CourseName;
             objCourse.StartDate = model.StartDate;
             objCourse.EndDate = model.EndDate;
             objCourse.Fees = model.Fees;

             if (operation == CrudOperation.Add)
             {
                id = objCourse.Insert();
             }
             else
             {
                objCourse.Update();
             }
         }
     }
}
