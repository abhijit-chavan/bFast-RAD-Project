using System;
using System.Collections.Generic;
using fifth_tempDB;
using fifth_tempDBAPI.BusinessObject;
using fifth_tempDBAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the UserMaster table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class UserMasterExample
{
    private UserMasterExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<UserMaster> objUserMasterCol = UserMaster.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objUserMasterCol.Sort(UserMaster.ByUserName);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objUserMasterCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objUserMasterCol;
        // grid.DataBind();

        // Example 4:  loop through all the UserMaster(s)
        foreach (UserMaster objUserMaster in objUserMasterCol)
        {
            int userId = objUserMaster.UserId;
            string userName = objUserMaster.UserName;
            string password = objUserMaster.Password;
            string email = objUserMaster.Email;
            DateTime createdOn = objUserMaster.CreatedOn;
            string createdBy = objUserMaster.CreatedBy;
            DateTime? modifiedOn = objUserMaster.ModifiedOn;
            string modifiedBy = objUserMaster.ModifiedBy;
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by UserId in ascending order
        string sortBy = "UserId"; // ascending order
        //string sortBy = "UserId desc"; // descending order

        List<UserMaster> objUserMasterCol = UserMaster.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int userIdSample = 1;

        // select a record by primary key(s)

        UserMaster objUserMaster = UserMaster.SelectByPrimaryKey(userIdSample);

        if (objUserMaster != null)
        {
            // if record is found, a record is returned
            int userId = objUserMaster.UserId;
            string userName = objUserMaster.UserName;
            string password = objUserMaster.Password;
            string email = objUserMaster.Email;
            DateTime createdOn = objUserMaster.CreatedOn;
            string createdBy = objUserMaster.CreatedBy;
            DateTime? modifiedOn = objUserMaster.ModifiedOn;
            string modifiedBy = objUserMaster.ModifiedBy;
        }
    }

    /// <summary>
    /// The example below shows how to Select the UserId and CreatedBy columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectUserMasterDropDownListData()
    {
        List<UserMaster> objUserMasterCol = UserMaster.SelectUserMasterDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "UserId";
        // ddl1.DataTextField = "CreatedBy";
        // ddl1.DataSource = objUserMasterCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (UserMaster objUserMaster in objUserMasterCol)
        // {
        //     ddl2.Items.Add(new ListItem(objUserMaster.CreatedBy, objUserMaster.UserId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (UserMaster objUserMaster in objUserMasterCol)
        // {
        //     cbx1.Items.Add(new ListItem(objUserMaster.CreatedBy, objUserMaster.UserId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new UserMaster
        UserMaster objUserMaster = new UserMaster();

        // assign values you want inserted
        objUserMaster.UserName = "Sristi Annu";
        objUserMaster.Password = "1234";
        objUserMaster.Email = "sristia@birlasoft.com";
        objUserMaster.CreatedOn = DateTime.Now;
        objUserMaster.CreatedBy = "System";
        objUserMaster.ModifiedOn = DateTime.Now;
        objUserMaster.ModifiedBy = "abc";

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objUserMaster.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new UserMaster
        UserMaster objUserMaster = new UserMaster();

        // assign the existing primary key(s)
        // of the record you want updated
        objUserMaster.UserId = 1;

        // assign values you want updated
        objUserMaster.UserName = "Sristi Annu";
        objUserMaster.Password = "1234";
        objUserMaster.Email = "sristia@birlasoft.com";
        objUserMaster.CreatedOn = DateTime.Now;
        objUserMaster.CreatedBy = "System";
        objUserMaster.ModifiedOn = DateTime.Now;
        objUserMaster.ModifiedBy = "abc";

        // finally, update an existing record
        objUserMaster.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        UserMaster.Delete(4);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the UserMaster table
        int totalRecordCount = UserMaster.GetRecordCount();
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
        int? userId = null;
        string userName = null;
        string password = null;
        string email = null;
        DateTime? createdOn = null;
        string createdBy = null;
        DateTime? modifiedOn = null;
        string modifiedBy = null;

        int totalRecordCount = UserMaster.GetRecordCountDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy);
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
        string sortBy = "UserId";
        //string sortBy = "UserId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<UserMaster> objUserMasterCol = UserMaster.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objUserMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the UserMaster(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "UserId";
        //string sortBy = "UserId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? userId = null;
        string userName = null;
        string password = null;
        string email = null;
        DateTime? createdOn = null;
        string createdBy = null;
        DateTime? modifiedOn = null;
        string modifiedBy = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<UserMaster> objUserMasterCol = UserMaster.SelectSkipAndTakeDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objUserMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the UserMaster(s).  The example above will only loop for 10 items.
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
        int? userId = null;
        string userName = null;
        string password = null;
        string email = null;
        DateTime? createdOn = null;
        string createdBy = null;
        DateTime? modifiedOn = null;
        string modifiedBy = null;

        List<UserMaster> objUserMasterCol = UserMaster.SelectAllDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy);
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
        int? userId = null;
        string userName = null;
        string password = null;
        string email = null;
        DateTime? createdOn = null;
        string createdBy = null;
        DateTime? modifiedOn = null;
        string modifiedBy = null;

        string sortBy = "UserId"; // ascending order
        //string sortBy = "UserId desc"; // descending order

        List<UserMaster> objUserMasterCol = UserMaster.SelectAllDynamicWhere(userId, userName, password, email, createdOn, createdBy, modifiedOn, modifiedBy, sortBy);
    }
}
