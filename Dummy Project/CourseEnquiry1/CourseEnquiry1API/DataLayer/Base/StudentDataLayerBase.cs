using CourseEnquiry1API.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CourseEnquiry1API.DataLayer.Base
{
     /// <summary>
     /// Base class for StudentDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the StudentDataLayer class
     /// </summary>
     internal class StudentDataLayerBase
     {
         // constructor
         internal StudentDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         internal static Student SelectByPrimaryKey(int studenId)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.Student.Where(s => s.StudenId == studenId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the Student table
         /// </summary>
         internal static int GetRecordCount()
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.Student.Count();
         }

         /// <summary>
         /// Gets the total number of records in the Student table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? studenId, string studentName, string emailId, int? contactNumber, string password)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             int studenIdValue = int.MinValue;
             int contactNumberValue = int.MinValue;

             if (studenId != null)
                studenIdValue = studenId.Value;

             if (contactNumber != null)
                contactNumberValue = contactNumber.Value;

             return context.Student
                 .Where(s =>
                           (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                           (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                           (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects Student records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<Student> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "StudentName desc":
                             return context.Student.OrderByDescending(s => s.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "EmailId desc":
                             return context.Student.OrderByDescending(s => s.EmailId).Skip(startRowIndex).Take(rows).ToList();
                         case "ContactNumber desc":
                             return context.Student.OrderByDescending(s => s.ContactNumber).Skip(startRowIndex).Take(rows).ToList();
                         case "Password desc":
                             return context.Student.OrderByDescending(s => s.Password).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Student.OrderByDescending(s => s.StudenId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
             else
             {
                     switch (sortByExpression)
                     {
                         case "StudentName":
                             return context.Student.OrderBy(s => s.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "EmailId":
                             return context.Student.OrderBy(s => s.EmailId).Skip(startRowIndex).Take(rows).ToList();
                         case "ContactNumber":
                             return context.Student.OrderBy(s => s.ContactNumber).Skip(startRowIndex).Take(rows).ToList();
                         case "Password":
                             return context.Student.OrderBy(s => s.Password).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Student.OrderBy(s => s.StudenId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects Student records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<Student> SelectSkipAndTakeDynamicWhere(int? studenId, string studentName, string emailId, int? contactNumber, string password, string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             int studenIdValue = int.MinValue;
             int contactNumberValue = int.MinValue;

             if (studenId != null)
                studenIdValue = studenId.Value;

             if (contactNumber != null)
                contactNumberValue = contactNumber.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "StudentName desc":
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderByDescending(s => s.StudentName).Skip(startRowIndex).Take(rows).ToList();

                     case "EmailId desc":
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderByDescending(s => s.EmailId).Skip(startRowIndex).Take(rows).ToList();

                     case "ContactNumber desc":
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderByDescending(s => s.ContactNumber).Skip(startRowIndex).Take(rows).ToList();

                     case "Password desc":
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderByDescending(s => s.Password).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderByDescending(s => s.StudenId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "StudentName":
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderBy(s => s.StudentName).Skip(startRowIndex).Take(rows).ToList();

                     case "EmailId":
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderBy(s => s.EmailId).Skip(startRowIndex).Take(rows).ToList();

                     case "ContactNumber":
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderBy(s => s.ContactNumber).Skip(startRowIndex).Take(rows).ToList();

                     case "Password":
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderBy(s => s.Password).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Student
                             .Where(s =>
                                       (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                                   ).OrderBy(s => s.StudenId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all Student
         /// </summary>
         internal static List<Student> SelectAll()
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return context.Student.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Student.
         /// </summary>
         internal static List<Student> SelectAllDynamicWhere(int? studenId, string studentName, string emailId, int? contactNumber, string password)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();

             int studenIdValue = int.MinValue;
             int contactNumberValue = int.MinValue;

             if (studenId != null)
                studenIdValue = studenId.Value;

             if (contactNumber != null)
                contactNumberValue = contactNumber.Value;

             return context.Student
                 .Where(s =>
                           (studenId != null ? s.StudenId == studenIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                           (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                           (contactNumber != null ? s.ContactNumber == contactNumberValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(password) ? s.Password.Contains(password) : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects StudenId and StudentName columns for use with a DropDownList web control
         /// </summary>
         internal static List<Student> SelectStudentDropDownListData()
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             return (from s in context.Student
                     select new Student { StudenId = s.StudenId, StudentName = s.StudentName }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(Student objStudent)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             Student entStudent = new Student();

             entStudent.StudentName = objStudent.StudentName;
             entStudent.EmailId = objStudent.EmailId;
             entStudent.ContactNumber = objStudent.ContactNumber;
             entStudent.Password = objStudent.Password;

             context.Student.Add(entStudent);
             context.SaveChanges();

             return entStudent.StudenId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(Student objStudent)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             Student entStudent = context.Student.Where(s => s.StudenId == objStudent.StudenId).FirstOrDefault();

             if (entStudent != null)
             {
                 entStudent.StudentName = objStudent.StudentName;
                 entStudent.EmailId = objStudent.EmailId;
                 entStudent.ContactNumber = objStudent.ContactNumber;
                 entStudent.Password = objStudent.Password;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int studenId)
         {
             CourseEnquiryContext context = new CourseEnquiryContext();
             var objStudent = context.Student.Where(s => s.StudenId == studenId).FirstOrDefault();

             if (objStudent != null)
             {
                 context.Student.Remove(objStudent);
                 context.SaveChanges();
             }
         }
     }
}
