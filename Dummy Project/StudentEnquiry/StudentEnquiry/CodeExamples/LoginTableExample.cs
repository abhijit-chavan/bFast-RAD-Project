using System;
using System.Collections.Generic;
using StudentEnquiry;
using StudentEnquiryAPI.BusinessObject;
using StudentEnquiryAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the LoginTable table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class LoginTableExample
{
    private LoginTableExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<LoginTable> objLoginTableCol = LoginTable.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objLoginTableCol.Sort(LoginTable.ByPassword);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objLoginTableCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objLoginTableCol;
        // grid.DataBind();

        // Example 4:  loop through all the LoginTable(s)
        foreach (LoginTable objLoginTable in objLoginTableCol)
        {
            int adminid = objLoginTable.Adminid;
            string password = objLoginTable.Password;
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by Adminid in ascending order
        string sortBy = "Adminid"; // ascending order
        //string sortBy = "Adminid desc"; // descending order

        List<LoginTable> objLoginTableCol = LoginTable.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int adminidSample = 12;

        // select a record by primary key(s)

        LoginTable objLoginTable = LoginTable.SelectByPrimaryKey(adminidSample);

        if (objLoginTable != null)
        {
            // if record is found, a record is returned
            int adminid = objLoginTable.Adminid;
            string password = objLoginTable.Password;
        }
    }

    /// <summary>
    /// The example below shows how to Select the Adminid and Password columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectLoginTableDropDownListData()
    {
        List<LoginTable> objLoginTableCol = LoginTable.SelectLoginTableDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "Adminid";
        // ddl1.DataTextField = "Password";
        // ddl1.DataSource = objLoginTableCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (LoginTable objLoginTable in objLoginTableCol)
        // {
        //     ddl2.Items.Add(new ListItem(objLoginTable.Password, objLoginTable.Adminid.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (LoginTable objLoginTable in objLoginTableCol)
        // {
        //     cbx1.Items.Add(new ListItem(objLoginTable.Password, objLoginTable.Adminid.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new LoginTable
        LoginTable objLoginTable = new LoginTable();

        // assign values you want inserted
        objLoginTable.Password = "abc";

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objLoginTable.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new LoginTable
        LoginTable objLoginTable = new LoginTable();

        // assign the existing primary key(s)
        // of the record you want updated
        objLoginTable.Adminid = 12;

        // assign values you want updated
        objLoginTable.Password = "abc";

        // finally, update an existing record
        objLoginTable.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        LoginTable.Delete(12);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the LoginTable table
        int totalRecordCount = LoginTable.GetRecordCount();
    }

    /// <summary>
    /// Shows how to get the total number of records based on Search Parameters.
    /// </summary>
    private void GetRecordCountDynamicWhere()
    {
        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? adminid = null;
        string password = null;

        int totalRecordCount = LoginTable.GetRecordCountDynamicWhere(adminid, password);
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index.  The total number of records are also retrieved when using the SelectSkipAndTake() method.
    /// For example, if there are 200 records take only 10 records (numberOfRecordsToRetrieve), starting from the first index (startRetrievalFromRecordIndex = 0)
    /// The example below uses some variables, here are their definitions:
    /// totalRecordCount - total number of records if you were to retrieve everything
    /// startRetrievalFromRecordIndex - the index to start taking records from. Zero (0) E.g. If you want to skip the first 20 records, then assign 19 here.
    /// numberOfRecordsToRetrieve - take n records starting from the startRetrievalFromRecordIndex
    /// sortBy - to sort in Ascending order by Field Name, just assign just the Field Name, do not pass 'asc'
    /// sortBy - to sort in Descending order by Field Name, use the Field Name, a space and the word 'desc'
    /// </summary>
    private void SelectSkipAndTake()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "Adminid";
        //string sortBy = "Adminid desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<LoginTable> objLoginTableCol = LoginTable.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objLoginTableCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the LoginTable(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "Adminid";
        //string sortBy = "Adminid desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? adminid = null;
        string password = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<LoginTable> objLoginTableCol = LoginTable.SelectSkipAndTakeDynamicWhere(adminid, password, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objLoginTableCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the LoginTable(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get all records based on Search Parameters.
    /// </summary>
    private void SelectAllDynamicWhere()
    {
        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? adminid = null;
        string password = null;

        List<LoginTable> objLoginTableCol = LoginTable.SelectAllDynamicWhere(adminid, password);
    }

    /// <summary>
    /// Shows how to get all records based on Search Parameters sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllDynamicWhereWithSortExpression()
    {
        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? adminid = null;
        string password = null;

        string sortBy = "Adminid"; // ascending order
        //string sortBy = "Adminid desc"; // descending order

        List<LoginTable> objLoginTableCol = LoginTable.SelectAllDynamicWhere(adminid, password, sortBy);
    }
}
