using CourseEnquiryAPI.Domain;
using CourseEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace CourseEnquiry
{
     public class StudentFunctions
     {
         private StudentFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(Student model, CrudOperation operation, bool isForListInline = false)
         {
             Student objStudent;
             Student objStudentOld = new Student();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objStudent = new Student();
             else
             {
                 objStudent = Student.SelectByPrimaryKey(model.StudentId);
                 objStudentOld = objStudent.ShallowCopy();
             }

             objStudent.StudentId = model.StudentId;
             objStudent.StudentName = model.StudentName;
             objStudent.EmailId = model.EmailId;
             objStudent.ContactNo = model.ContactNo;
             objStudent.StudentPassword = model.StudentPassword;

             if (operation == CrudOperation.Add)
             {
                id = objStudent.Insert();
             }
             else
             {
                objStudent.Update();
             }
         }
     }
}
