using CourseEnquiryAPI.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CourseEnquiryAPI.DataLayer.Base
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
         internal static Student SelectByPrimaryKey(int studentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Student.Where(s => s.StudentId == studentId).FirstOrDefault();
         }

         /// <summary>
         /// Gets the total number of records in the Student table
         /// </summary>
         internal static int GetRecordCount()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Student.Count();
         }

         /// <summary>
         /// Gets the total number of records in the Student table based on search parameters
         /// </summary>
         internal static int GetRecordCountDynamicWhere(int? studentId, string studentName, string emailId, Int64? contactNo, string studentPassword)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int studentIdValue = int.MinValue;
             Int64 contactNoValue = Int64.MinValue;

             if (studentId != null)
                studentIdValue = studentId.Value;

             if (contactNo != null)
                contactNoValue = contactNo.Value;

             return context.Student
                 .Where(s =>
                           (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                           (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                           (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                       ).Count();
         }

         /// <summary>
         /// Selects Student records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         internal static List<Student> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             if (sortByExpression.Contains(" desc"))
             {
                     switch (sortByExpression)
                     {
                         case "StudentName desc":
                             return context.Student.OrderByDescending(s => s.StudentName).Skip(startRowIndex).Take(rows).ToList();
                         case "EmailId desc":
                             return context.Student.OrderByDescending(s => s.EmailId).Skip(startRowIndex).Take(rows).ToList();
                         case "ContactNo desc":
                             return context.Student.OrderByDescending(s => s.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentPassword desc":
                             return context.Student.OrderByDescending(s => s.StudentPassword).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Student.OrderByDescending(s => s.StudentId).Skip(startRowIndex).Take(rows).ToList();
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
                         case "ContactNo":
                             return context.Student.OrderBy(s => s.ContactNo).Skip(startRowIndex).Take(rows).ToList();
                         case "StudentPassword":
                             return context.Student.OrderBy(s => s.StudentPassword).Skip(startRowIndex).Take(rows).ToList();
                         default:
                             return context.Student.OrderBy(s => s.StudentId).Skip(startRowIndex).Take(rows).ToList();
                     }
             }
         }

         /// <summary>
         /// Selects Student records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         internal static List<Student> SelectSkipAndTakeDynamicWhere(int? studentId, string studentName, string emailId, Int64? contactNo, string studentPassword, string sortByExpression, int startRowIndex, int rows)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int studentIdValue = int.MinValue;
             Int64 contactNoValue = Int64.MinValue;

             if (studentId != null)
                studentIdValue = studentId.Value;

             if (contactNo != null)
                contactNoValue = contactNo.Value;

             if (sortByExpression.Contains(" desc"))
             {
                 switch (sortByExpression)
                 {
                     case "StudentName desc":
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderByDescending(s => s.StudentName).Skip(startRowIndex).Take(rows).ToList();

                     case "EmailId desc":
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderByDescending(s => s.EmailId).Skip(startRowIndex).Take(rows).ToList();

                     case "ContactNo desc":
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderByDescending(s => s.ContactNo).Skip(startRowIndex).Take(rows).ToList();

                     case "StudentPassword desc":
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderByDescending(s => s.StudentPassword).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderByDescending(s => s.StudentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
             else
             {
                 switch (sortByExpression)
                 {
                     case "StudentName":
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderBy(s => s.StudentName).Skip(startRowIndex).Take(rows).ToList();

                     case "EmailId":
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderBy(s => s.EmailId).Skip(startRowIndex).Take(rows).ToList();

                     case "ContactNo":
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderBy(s => s.ContactNo).Skip(startRowIndex).Take(rows).ToList();

                     case "StudentPassword":
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderBy(s => s.StudentPassword).Skip(startRowIndex).Take(rows).ToList();

                     default:
                         return context.Student
                             .Where(s =>
                                       (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                                       (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                                       (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                                       (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                                   ).OrderBy(s => s.StudentId).Skip(startRowIndex).Take(rows).ToList();
                 }
             }
         }

         /// <summary>
         /// Selects all Student
         /// </summary>
         internal static List<Student> SelectAll()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return context.Student.ToList();
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of Student.
         /// </summary>
         internal static List<Student> SelectAllDynamicWhere(int? studentId, string studentName, string emailId, Int64? contactNo, string studentPassword)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();

             int studentIdValue = int.MinValue;
             Int64 contactNoValue = Int64.MinValue;

             if (studentId != null)
                studentIdValue = studentId.Value;

             if (contactNo != null)
                contactNoValue = contactNo.Value;

             return context.Student
                 .Where(s =>
                           (studentId != null ? s.StudentId == studentIdValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(studentName) ? s.StudentName.Contains(studentName) : 1 == 1) &&
                           (!String.IsNullOrEmpty(emailId) ? s.EmailId.Contains(emailId) : 1 == 1) &&
                           (contactNo != null ? s.ContactNo == contactNoValue : 1 == 1) &&
                           (!String.IsNullOrEmpty(studentPassword) ? s.StudentPassword.Contains(studentPassword) : 1 == 1) 
                       ).ToList();
         }
         /// <summary>
         /// Selects StudentId and StudentName columns for use with a DropDownList web control
         /// </summary>
         internal static List<Student> SelectStudentDropDownListData()
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             return (from s in context.Student
                     select new Student { StudentId = s.StudentId, StudentName = s.StudentName }).ToList();
         }
         /// <summary>
         /// Inserts a record
         /// </summary>
         internal static int Insert(Student objStudent)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             Student entStudent = new Student();

             entStudent.StudentName = objStudent.StudentName;
             entStudent.EmailId = objStudent.EmailId;
             entStudent.ContactNo = objStudent.ContactNo;
             entStudent.StudentPassword = objStudent.StudentPassword;

             context.Student.Add(entStudent);
             context.SaveChanges();

             return entStudent.StudentId;
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         internal static void Update(Student objStudent)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             Student entStudent = context.Student.Where(s => s.StudentId == objStudent.StudentId).FirstOrDefault();

             if (entStudent != null)
             {
                 entStudent.StudentName = objStudent.StudentName;
                 entStudent.EmailId = objStudent.EmailId;
                 entStudent.ContactNo = objStudent.ContactNo;
                 entStudent.StudentPassword = objStudent.StudentPassword;

                 context.SaveChanges();
             }
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         internal static void Delete(int studentId)
         {
             CourseEnquiryDBContext context = new CourseEnquiryDBContext();
             var objStudent = context.Student.Where(s => s.StudentId == studentId).FirstOrDefault();

             if (objStudent != null)
             {
                 context.Student.Remove(objStudent);
                 context.SaveChanges();
             }
         }
     }
}
