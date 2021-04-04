using StudentEnquiryAPI.Domain;
using StudentEnquiryAPI.BusinessObject;
using Application_Components.EmailNotification;
using System;

namespace StudentEnquiry
{
     public class EnquiryFunctions
     {
         private EnquiryFunctions()
         {
         }


         /// <summary>
         /// Used when adding or updating a record.
         /// </summary>
         internal static void AddOrEdit(Enquiry model, CrudOperation operation, bool isForListInline = false)
         {
             Enquiry objEnquiry;
             Enquiry objEnquiryOld = new Enquiry();
             decimal id = 0;

             if (operation == CrudOperation.Add)
                objEnquiry = new Enquiry();
             else
             {
                 objEnquiry = Enquiry.SelectByPrimaryKey(model.EnquiryId);
                 objEnquiryOld = objEnquiry.ShallowCopy();
             }

             objEnquiry.EnquiryId = model.EnquiryId;
             objEnquiry.CourseId = model.CourseId;
             objEnquiry.StudentName = model.StudentName;
             objEnquiry.ContactNo = model.ContactNo;
             objEnquiry.Comments = model.Comments;

             if (operation == CrudOperation.Add)
             {
                id = objEnquiry.Insert();
             }
             else
             {
                objEnquiry.Update();
             }
         }
     }
}
