using System;
using StudentEnquiryAPI.DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentEnquiryAPI.BusinessObject.Base
{
     /// <summary>
     /// Base class for LoginTable.  Do not make changes to this class,
     /// instead, put additional code in the LoginTable class
     /// </summary>
     public class LoginTableBase : StudentEnquiryAPI.Models.LoginTableModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public LoginTableBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static LoginTable SelectByPrimaryKey(int adminid)
         {
             return LoginTableDataLayer.SelectByPrimaryKey(adminid);
         }

         /// <summary>
         /// Gets the total number of records in the LoginTable table
         /// </summary>
         public static int GetRecordCount()
         {
             return LoginTableDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the LoginTable table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? adminid, string password)
         {
             return LoginTableDataLayer.GetRecordCountDynamicWhere(adminid, password);
         }

         /// <summary>
         /// Selects records as a collection (List) of LoginTable sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<LoginTable> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return LoginTableDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of LoginTable sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<LoginTable> SelectSkipAndTakeDynamicWhere(int? adminid, string password, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return LoginTableDataLayer.SelectSkipAndTakeDynamicWhere(adminid, password, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of LoginTable
         /// </summary>
         public static List<LoginTable> SelectAll()
         {
             return LoginTableDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of LoginTable sorted by the sort expression
         /// </summary>
         public static List<LoginTable> SelectAll(string sortByExpression)
         {
             List<LoginTable> objLoginTableCol = LoginTableDataLayer.SelectAll();
             return SortByExpression(objLoginTableCol, sortByExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of LoginTable.
         /// </summary>
         public static List<LoginTable> SelectAllDynamicWhere(int? adminid, string password)
         {
             return LoginTableDataLayer.SelectAllDynamicWhere(adminid, password);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of LoginTable sorted by the sort expression.
         /// </summary>
         public static List<LoginTable> SelectAllDynamicWhere(int? adminid, string password, string sortByExpression)
         {
             List<LoginTable> objLoginTableCol = LoginTableDataLayer.SelectAllDynamicWhere(adminid, password);
             return SortByExpression(objLoginTableCol, sortByExpression);
         }

         /// <summary>
         /// Selects Adminid and Password columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<LoginTable> SelectLoginTableDropDownListData()
         {
             return LoginTableDataLayer.SelectLoginTableDropDownListData();
         }

         /// <summary>
         /// Sorts the List<LoginTable >by sort expression
         /// </summary>
         public static List<LoginTable> SortByExpression(List<LoginTable> objLoginTableCol, string sortExpression)
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
                 case "Adminid":
                     objLoginTableCol.Sort(StudentEnquiryAPI.BusinessObject.LoginTable.ByAdminid);
                     break;
                 case "Password":
                     objLoginTableCol.Sort(StudentEnquiryAPI.BusinessObject.LoginTable.ByPassword);
                     break;
                 default:
                     break;
             }

             if (isSortDescending)
                 objLoginTableCol.Reverse();

             return objLoginTableCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
             LoginTable objLoginTable = (LoginTable)this;
             return LoginTableDataLayer.Insert(objLoginTable);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             LoginTable objLoginTable = (LoginTable)this;
             LoginTableDataLayer.Update(objLoginTable);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int adminid)
         {
             LoginTableDataLayer.Delete(adminid);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "Adminid";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         /// <summary>
         /// Compares Adminid used for sorting
         /// </summary>
         public static Comparison<LoginTable> ByAdminid = delegate(LoginTable x, LoginTable y)
         {
             return x.Adminid.CompareTo(y.Adminid);
         };

         /// <summary>
         /// Compares Password used for sorting
         /// </summary>
         public static Comparison<LoginTable> ByPassword = delegate(LoginTable x, LoginTable y)
         {
             string value1 = x.Password ?? String.Empty;
             string value2 = y.Password ?? String.Empty;
             return value1.CompareTo(value2);
         };

     }
}
