using CourseEnquiry1API.Domain;
using CourseEnquiry1API.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace CourseEnquiry1
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
                 objStudent = Student.SelectByPrimaryKey(model.StudenId);
                 objStudentOld = objStudent.ShallowCopy();
             }

             objStudent.StudenId = model.StudenId;
             objStudent.StudentName = model.StudentName;
             objStudent.EmailId = model.EmailId;
             objStudent.ContactNumber = model.ContactNumber;
             objStudent.Password = model.Password;

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
