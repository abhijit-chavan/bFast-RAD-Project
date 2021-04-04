using System;
using StudentEnquiryAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentEnquiryAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for WorkflowMaster.  Do not make changes to this class,
     /// instead, put additional code in the WorkflowMaster class
     /// </summary>
     public class WorkflowMasterBase : StudentEnquiryAPI.Models.WorkflowMasterModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public WorkflowMasterBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static WorkflowMaster SelectByPrimaryKey(int workflowId)
         {
             return WorkflowMasterDataLayer.SelectByPrimaryKey(workflowId);
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowMaster table
         /// </summary>
         public static int GetRecordCount()
         {
             return WorkflowMasterDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowMaster table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? workflowId, string workflowName, int? levelOfApprovals, string createdBy, DateTime? createdOn, string updatedby, DateTime? updatedon)
         {
             return WorkflowMasterDataLayer.GetRecordCountDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon);
         }

         /// <summary>
         /// Selects records as a collection (List) of WorkflowMaster sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<WorkflowMaster> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return WorkflowMasterDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of WorkflowMaster sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<WorkflowMaster> SelectSkipAndTakeDynamicWhere(int? workflowId, string workflowName, int? levelOfApprovals, string createdBy, DateTime? createdOn, string updatedby, DateTime? updatedon, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return WorkflowMasterDataLayer.SelectSkipAndTakeDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of WorkflowMaster
         /// </summary>
         public static List<WorkflowMaster> SelectAll()
         {
             return WorkflowMasterDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of WorkflowMaster sorted by the sort expression
         /// </summary>
         public static List<WorkflowMaster> SelectAll(string sortByExpression)
         {
             List<WorkflowMaster> objWorkflowMasterCol = WorkflowMasterDataLayer.SelectAll();
             return SortByExpression(objWorkflowMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of WorkflowMaster.
         /// </summary>
         public static List<WorkflowMaster> SelectAllDynamicWhere(int? workflowId, string workflowName, int? levelOfApprovals, string createdBy, DateTime? createdOn, string updatedby, DateTime? updatedon)
         {
             return WorkflowMasterDataLayer.SelectAllDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of WorkflowMaster sorted by the sort expression.
         /// </summary>
         public static List<WorkflowMaster> SelectAllDynamicWhere(int? workflowId, string workflowName, int? levelOfApprovals, string createdBy, DateTime? createdOn, string updatedby, DateTime? updatedon, string sortByExpression)
         {
             List<WorkflowMaster> objWorkflowMasterCol = WorkflowMasterDataLayer.SelectAllDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon);
             return SortByExpression(objWorkflowMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects WorkflowId and WorkflowName columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<WorkflowMaster> SelectWorkflowMasterDropDownListData()
         {
             return WorkflowMasterDataLayer.SelectWorkflowMasterDropDownListData();
         }

         /// <summary>
         /// Sorts the List<WorkflowMaster >by sort expression
         /// </summary>
         public static List<WorkflowMaster> SortByExpression(List<WorkflowMaster> objWorkflowMasterCol, string sortExpression)
         {
             bool isSortDescending = sortExpression.ToLower().Contains(" desc");

             if (isSortDescending)
             {
                 sortExpression = sortExpression.Replace(" DESC", "");
                 sortExpression = sortExpression.Replace(" desc", "");
             }
             else
             {
                 sortExpression = sortExpression.Replace(" ASC", "");
                 sortExpression = sortExpression.Replace(" asc", "");
             }

             switch (sortExpression)
             {
                 case "WorkflowId":
                     objWorkflowMasterCol.Sort(StudentEnquiryAPI.BusinessObject.WorkflowMaster.ByWorkflowId);
                     break;
                 case "WorkflowName":
                     objWorkflowMasterCol.Sort(StudentEnquiryAPI.BusinessObject.WorkflowMaster.ByWorkflowName);
                     break;
                 case "LevelOfApprovals":
                     objWorkflowMasterCol.Sort(StudentEnquiryAPI.BusinessObject.WorkflowMaster.ByLevelOfApprovals);
                     break;
                 case "CreatedBy":
                     objWorkflowMasterCol.Sort(StudentEnquiryAPI.BusinessObject.WorkflowMaster.ByCreatedBy);
                     break;
                 case "CreatedOn":
                     objWorkflowMasterCol.Sort(StudentEnquiryAPI.BusinessObject.WorkflowMaster.ByCreatedOn);
                     break;
                 case "Updatedby":
                     objWorkflowMasterCol.Sort(StudentEnquiryAPI.BusinessObject.WorkflowMaster.ByUpdatedby);
                     break;
                 case "Updatedon":
                     objWorkflowMasterCol.Sort(StudentEnquiryAPI.BusinessObject.WorkflowMaster.ByUpdatedon);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objWorkflowMasterCol.Reverse();

             return objWorkflowMasterCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             WorkflowMaster objWorkflowMaster = (WorkflowMaster)this;
             return WorkflowMasterDataLayer.Insert(objWorkflowMaster);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             WorkflowMaster objWorkflowMaster = (WorkflowMaster)this;
             WorkflowMasterDataLayer.Update(objWorkflowMaster);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int workflowId)
         {
             WorkflowMasterDataLayer.Delete(workflowId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "WorkflowId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares WorkflowId used for sorting
         /// </summary>
         public static Comparison<WorkflowMaster> ByWorkflowId = delegate(WorkflowMaster x, WorkflowMaster y)
         {
             return x.WorkflowId.CompareTo(y.WorkflowId);
         };

         /// <summary>
         /// Compares WorkflowName used for sorting
         /// </summary>
         public static Comparison<WorkflowMaster> ByWorkflowName = delegate(WorkflowMaster x, WorkflowMaster y)
         {
             string value1 = x.WorkflowName ?? String.Empty;
             string value2 = y.WorkflowName ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares LevelOfApprovals used for sorting
         /// </summary>
         public static Comparison<WorkflowMaster> ByLevelOfApprovals = delegate(WorkflowMaster x, WorkflowMaster y)
         {
             return Nullable.Compare(x.LevelOfApprovals, y.LevelOfApprovals);
         };

         /// <summary>
         /// Compares CreatedBy used for sorting
         /// </summary>
         public static Comparison<WorkflowMaster> ByCreatedBy = delegate(WorkflowMaster x, WorkflowMaster y)
         {
             string value1 = x.CreatedBy ?? String.Empty;
             string value2 = y.CreatedBy ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares CreatedOn used for sorting
         /// </summary>
         public static Comparison<WorkflowMaster> ByCreatedOn = delegate(WorkflowMaster x, WorkflowMaster y)
         {
             return x.CreatedOn.CompareTo(y.CreatedOn);
         };

         /// <summary>
         /// Compares Updatedby used for sorting
         /// </summary>
         public static Comparison<WorkflowMaster> ByUpdatedby = delegate(WorkflowMaster x, WorkflowMaster y)
         {
             string value1 = x.Updatedby ?? String.Empty;
             string value2 = y.Updatedby ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares Updatedon used for sorting
         /// </summary>
         public static Comparison<WorkflowMaster> ByUpdatedon = delegate(WorkflowMaster x, WorkflowMaster y)
         {
             return x.Updatedon.CompareTo(y.Updatedon);
         };

     }
}
