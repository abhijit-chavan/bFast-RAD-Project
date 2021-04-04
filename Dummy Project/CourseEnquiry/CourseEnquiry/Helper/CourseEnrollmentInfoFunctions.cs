using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace CourseEnquiry
{
     public class CourseEnrollmentInfoFunctions
     {
         private CourseEnrollmentInfoFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(CourseEnrollmentInfo model, CrudOperation operation, bool isForListInline = false)
         {
             CourseEnrollmentInfo objCourseEnrollmentInfo;
             CourseEnrollmentInfo objCourseEnrollmentInfoOld = new CourseEnrollmentInfo();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objCourseEnrollmentInfo = new CourseEnrollmentInfo();
             else
             {
                 objCourseEnrollmentInfo = CourseEnrollmentInfo.SelectByPrimaryKey(model.EnrollmentId);
                 objCourseEnrollmentInfoOld = objCourseEnrollmentInfo.ShallowCopy();
             }

             objCourseEnrollmentInfo.EnrollmentId = model.EnrollmentId;
             objCourseEnrollmentInfo.CourseId = model.CourseId;
             objCourseEnrollmentInfo.StudentId = model.StudentId;
             objCourseEnrollmentInfo.Comments = model.Comments;

             if (operation == CrudOperation.Add)
             {
                id = objCourseEnrollmentInfo.Insert();
             }
             else
             {
                objCourseEnrollmentInfo.Update();
             }
         }
     }
}
