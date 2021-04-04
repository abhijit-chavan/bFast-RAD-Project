using System;
using CourseEnquiry1API.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseEnquiry1API.BusinessObject.Base
{
     /// <summary>
     /// Base class for WorkflowStepsMaster.  Do not make changes to this class,
     /// instead, put additional code in the WorkflowStepsMaster class
     /// </summary>
     public class WorkflowStepsMasterBase : CourseEnquiry1API.Models.WorkflowStepsMasterModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public WorkflowStepsMasterBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static WorkflowStepsMaster SelectByPrimaryKey(int stepId)
         {
             return WorkflowStepsMasterDataLayer.SelectByPrimaryKey(stepId);
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowStepsMaster table
         /// </summary>
         public static int GetRecordCount()
         {
             return WorkflowStepsMasterDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowStepsMaster table by WorKflowId
         /// </summary>
         public static int GetRecordCountByWorKflowId(int worKflowId)
         {
             return WorkflowStepsMasterDataLayer.GetRecordCountByWorKflowId(worKflowId);
         }

         /// <summary>
         /// Gets the total number of records in the WorkflowStepsMaster table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? stepId, int? worKflowId, string approvalLevel, string description, string autoApprove, int? waitTime, string createdBy, DateTime? createdOn, string updatedBy, DateTime? updatedOn)
         {
             return WorkflowStepsMasterDataLayer.GetRecordCountDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn);
         }

         /// <summary>
         /// Selects records as a collection (List) of WorkflowStepsMaster sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<WorkflowStepsMaster> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression, bool isIncludeRelatedProperties = true)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return WorkflowStepsMasterDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows, isIncludeRelatedProperties);
         }

         /// <summary>
         /// Selects records by WorKflowId as a collection (List) of WorkflowStepsMaster sorted by the sortByExpression starting from the startRowIndex
         /// </summary>
         public static List<WorkflowStepsMaster> SelectSkipAndTakeByWorKflowId(int rows, int startRowIndex, string sortByExpression, int worKflowId)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return WorkflowStepsMasterDataLayer.SelectSkipAndTakeByWorKflowId(sortByExpression, startRowIndex, rows, worKflowId);
         }

         /// <summary>
         /// Selects records as a collection (List) of WorkflowStepsMaster sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<WorkflowStepsMaster> SelectSkipAndTakeDynamicWhere(int? stepId, int? worKflowId, string approvalLevel, string description, string autoApprove, int? waitTime, string createdBy, DateTime? createdOn, string updatedBy, DateTime? updatedOn, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return WorkflowStepsMasterDataLayer.SelectSkipAndTakeDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of WorkflowStepsMaster
         /// </summary>
         public static List<WorkflowStepsMaster> SelectAll()
         {
             return WorkflowStepsMasterDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of WorkflowStepsMaster sorted by the sort expression
         /// </summary>
         public static List<WorkflowStepsMaster> SelectAll(string sortByExpression)
         {
             List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMasterDataLayer.SelectAll();
             return SortByExpression(objWorkflowStepsMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of WorkflowStepsMaster.
         /// </summary>
         public static List<WorkflowStepsMaster> SelectAllDynamicWhere(int? stepId, int? worKflowId, string approvalLevel, string description, string autoApprove, int? waitTime, string createdBy, DateTime? createdOn, string updatedBy, DateTime? updatedOn)
         {
             return WorkflowStepsMasterDataLayer.SelectAllDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of WorkflowStepsMaster sorted by the sort expression.
         /// </summary>
         public static List<WorkflowStepsMaster> SelectAllDynamicWhere(int? stepId, int? worKflowId, string approvalLevel, string description, string autoApprove, int? waitTime, string createdBy, DateTime? createdOn, string updatedBy, DateTime? updatedOn, string sortByExpression)
         {
             List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMasterDataLayer.SelectAllDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn);
             return SortByExpression(objWorkflowStepsMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects all WorkflowStepsMaster by WorkflowMaster, related to column WorKflowId
         /// </summary>
         public static List<WorkflowStepsMaster> SelectWorkflowStepsMasterCollectionByWorKflowId(int workflowId)
         {
             return WorkflowStepsMasterDataLayer.SelectWorkflowStepsMasterCollectionByWorKflowId(workflowId);
         }

         /// <summary>
         /// Selects all WorkflowStepsMaster by WorkflowMaster, related to column WorKflowId, sorted by the sort expression
         /// </summary>
         public static List<WorkflowStepsMaster> SelectWorkflowStepsMasterCollectionByWorKflowId(int workflowId, string sortByExpression)
         {
             List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMasterDataLayer.SelectWorkflowStepsMasterCollectionByWorKflowId(workflowId);
             return SortByExpression(objWorkflowStepsMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects StepId and ApprovalLevel columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<WorkflowStepsMaster> SelectWorkflowStepsMasterDropDownListData()
         {
             return WorkflowStepsMasterDataLayer.SelectWorkflowStepsMasterDropDownListData();
         }

         /// <summary>
         /// Sorts the List<WorkflowStepsMaster >by sort expression
         /// </summary>
         public static List<WorkflowStepsMaster> SortByExpression(List<WorkflowStepsMaster> objWorkflowStepsMasterCol, string sortExpression)
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
                 case "StepId":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByStepId);
                     break;
                 case "WorKflowId":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByWorKflowId);
                     break;
                 case "ApprovalLevel":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByApprovalLevel);
                     break;
                 case "Description":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByDescription);
                     break;
                 case "AutoApprove":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByAutoApprove);
                     break;
                 case "WaitTime":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByWaitTime);
                     break;
                 case "CreatedBy":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByCreatedBy);
                     break;
                 case "CreatedOn":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByCreatedOn);
                     break;
                 case "UpdatedBy":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByUpdatedBy);
                     break;
                 case "UpdatedOn":
                     objWorkflowStepsMasterCol.Sort(CourseEnquiry1API.BusinessObject.WorkflowStepsMaster.ByUpdatedOn);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objWorkflowStepsMasterCol.Reverse();

             return objWorkflowStepsMasterCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             WorkflowStepsMaster objWorkflowStepsMaster = (WorkflowStepsMaster)this;
             return WorkflowStepsMasterDataLayer.Insert(objWorkflowStepsMaster);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             WorkflowStepsMaster objWorkflowStepsMaster = (WorkflowStepsMaster)this;
             WorkflowStepsMasterDataLayer.Update(objWorkflowStepsMaster);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int stepId)
         {
             WorkflowStepsMasterDataLayer.Delete(stepId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "StepId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares StepId used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByStepId = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             return x.StepId.CompareTo(y.StepId);
         };

         /// <summary>
         /// Compares WorKflowId used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByWorKflowId = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             return Nullable.Compare(x.WorKflowId, y.WorKflowId);
         };

         /// <summary>
         /// Compares ApprovalLevel used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByApprovalLevel = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             string value1 = x.ApprovalLevel ?? String.Empty;
             string value2 = y.ApprovalLevel ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares Description used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByDescription = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             string value1 = x.Description ?? String.Empty;
             string value2 = y.Description ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares AutoApprove used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByAutoApprove = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             string value1 = x.AutoApprove ?? String.Empty;
             string value2 = y.AutoApprove ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares WaitTime used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByWaitTime = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             return Nullable.Compare(x.WaitTime, y.WaitTime);
         };

         /// <summary>
         /// Compares CreatedBy used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByCreatedBy = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             string value1 = x.CreatedBy ?? String.Empty;
             string value2 = y.CreatedBy ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares CreatedOn used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByCreatedOn = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             return x.CreatedOn.CompareTo(y.CreatedOn);
         };

         /// <summary>
         /// Compares UpdatedBy used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByUpdatedBy = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             string value1 = x.UpdatedBy ?? String.Empty;
             string value2 = y.UpdatedBy ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares UpdatedOn used for sorting
         /// </summary>
         public static Comparison<WorkflowStepsMaster> ByUpdatedOn = delegate(WorkflowStepsMaster x, WorkflowStepsMaster y)
         {
             return x.UpdatedOn.CompareTo(y.UpdatedOn);
         };

     }
}
