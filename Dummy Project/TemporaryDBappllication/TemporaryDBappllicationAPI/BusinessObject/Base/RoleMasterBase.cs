using System;
using TemporaryDBappllicationAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TemporaryDBappllicationAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for RoleMaster.  Do not make changes to this class,
     /// instead, put additional code in the RoleMaster class
     /// </summary>
     public class RoleMasterBase : TemporaryDBappllicationAPI.Models.RoleMasterModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public RoleMasterBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static RoleMaster SelectByPrimaryKey(int roleId)
         {
             return RoleMasterDataLayer.SelectByPrimaryKey(roleId);
         }

         /// <summary>
         /// Gets the total number of records in the RoleMaster table
         /// </summary>
         public static int GetRecordCount()
         {
             return RoleMasterDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the RoleMaster table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? roleId, string roleDescription, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy)
         {
             return RoleMasterDataLayer.GetRecordCountDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy);
         }

         /// <summary>
         /// Selects records as a collection (List) of RoleMaster sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<RoleMaster> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return RoleMasterDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of RoleMaster sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<RoleMaster> SelectSkipAndTakeDynamicWhere(int? roleId, string roleDescription, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return RoleMasterDataLayer.SelectSkipAndTakeDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of RoleMaster
         /// </summary>
         public static List<RoleMaster> SelectAll()
         {
             return RoleMasterDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of RoleMaster sorted by the sort expression
         /// </summary>
         public static List<RoleMaster> SelectAll(string sortByExpression)
         {
             List<RoleMaster> objRoleMasterCol = RoleMasterDataLayer.SelectAll();
             return SortByExpression(objRoleMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of RoleMaster.
         /// </summary>
         public static List<RoleMaster> SelectAllDynamicWhere(int? roleId, string roleDescription, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy)
         {
             return RoleMasterDataLayer.SelectAllDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of RoleMaster sorted by the sort expression.
         /// </summary>
         public static List<RoleMaster> SelectAllDynamicWhere(int? roleId, string roleDescription, DateTime? createdOn, string createdBy, DateTime? modifiedOn, string modifiedBy, string sortByExpression)
         {
             List<RoleMaster> objRoleMasterCol = RoleMasterDataLayer.SelectAllDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy);
             return SortByExpression(objRoleMasterCol, sortByExpression);
         }

         /// <summary>
         /// Selects RoleId and CreatedBy columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<RoleMaster> SelectRoleMasterDropDownListData()
         {
             return RoleMasterDataLayer.SelectRoleMasterDropDownListData();
         }

         /// <summary>
         /// Sorts the List<RoleMaster >by sort expression
         /// </summary>
         public static List<RoleMaster> SortByExpression(List<RoleMaster> objRoleMasterCol, string sortExpression)
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
                 case "RoleId":
                     objRoleMasterCol.Sort(TemporaryDBappllicationAPI.BusinessObject.RoleMaster.ByRoleId);
                     break;
                 case "RoleDescription":
                     objRoleMasterCol.Sort(TemporaryDBappllicationAPI.BusinessObject.RoleMaster.ByRoleDescription);
                     break;
                 case "CreatedOn":
                     objRoleMasterCol.Sort(TemporaryDBappllicationAPI.BusinessObject.RoleMaster.ByCreatedOn);
                     break;
                 case "CreatedBy":
                     objRoleMasterCol.Sort(TemporaryDBappllicationAPI.BusinessObject.RoleMaster.ByCreatedBy);
                     break;
                 case "ModifiedOn":
                     objRoleMasterCol.Sort(TemporaryDBappllicationAPI.BusinessObject.RoleMaster.ByModifiedOn);
                     break;
                 case "ModifiedBy":
                     objRoleMasterCol.Sort(TemporaryDBappllicationAPI.BusinessObject.RoleMaster.ByModifiedBy);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objRoleMasterCol.Reverse();

             return objRoleMasterCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             RoleMaster objRoleMaster = (RoleMaster)this;
             return RoleMasterDataLayer.Insert(objRoleMaster);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             RoleMaster objRoleMaster = (RoleMaster)this;
             RoleMasterDataLayer.Update(objRoleMaster);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int roleId)
         {
             RoleMasterDataLayer.Delete(roleId);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "RoleId";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares RoleId used for sorting
         /// </summary>
         public static Comparison<RoleMaster> ByRoleId = delegate(RoleMaster x, RoleMaster y)
         {
             return x.RoleId.CompareTo(y.RoleId);
         };

         /// <summary>
         /// Compares RoleDescription used for sorting
         /// </summary>
         public static Comparison<RoleMaster> ByRoleDescription = delegate(RoleMaster x, RoleMaster y)
         {
             string value1 = x.RoleDescription ?? String.Empty;
             string value2 = y.RoleDescription ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares CreatedOn used for sorting
         /// </summary>
         public static Comparison<RoleMaster> ByCreatedOn = delegate(RoleMaster x, RoleMaster y)
         {
             return x.CreatedOn.CompareTo(y.CreatedOn);
         };

         /// <summary>
         /// Compares CreatedBy used for sorting
         /// </summary>
         public static Comparison<RoleMaster> ByCreatedBy = delegate(RoleMaster x, RoleMaster y)
         {
             string value1 = x.CreatedBy ?? String.Empty;
             string value2 = y.CreatedBy ?? String.Empty;
             return value1.CompareTo(value2);
         };

         /// <summary>
         /// Compares ModifiedOn used for sorting
         /// </summary>
         public static Comparison<RoleMaster> ByModifiedOn = delegate(RoleMaster x, RoleMaster y)
         {
             return Nullable.Compare(x.ModifiedOn, y.ModifiedOn);
         };

         /// <summary>
         /// Compares ModifiedBy used for sorting
         /// </summary>
         public static Comparison<RoleMaster> ByModifiedBy = delegate(RoleMaster x, RoleMaster y)
         {
             string value1 = x.ModifiedBy ?? String.Empty;
             string value2 = y.ModifiedBy ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
