using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace CourseEnquiry1
{
     public class CourseEnrollmentFunctions
     {
         private CourseEnrollmentFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(CourseEnrollment model, CrudOperation operation, bool isForListInline = false)
         {
             CourseEnrollment objCourseEnrollment;
             CourseEnrollment objCourseEnrollmentOld = new CourseEnrollment();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objCourseEnrollment = new CourseEnrollment();
             else
             {
                 objCourseEnrollment = CourseEnrollment.SelectByPrimaryKey(model.EnrollmentId);
                 objCourseEnrollmentOld = objCourseEnrollment.ShallowCopy();
             }

             objCourseEnrollment.EnrollmentId = model.EnrollmentId;
             objCourseEnrollment.CourseName = model.CourseName;
             objCourseEnrollment.StudentName = model.StudentName;
             objCourseEnrollment.Comments = model.Comments;

             if (operation == CrudOperation.Add)
             {
                id = objCourseEnrollment.Insert();
             }
             else
             {
                objCourseEnrollment.Update();
             }
         }
     }
}
