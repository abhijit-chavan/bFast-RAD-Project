using System;
using System.Collections.Generic;
using fifth_tempDB;
using fifth_tempDBAPI.BusinessObject;
using fifth_tempDBAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the RoleMaster table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class RoleMasterExample
{
    private RoleMasterExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<RoleMaster> objRoleMasterCol = RoleMaster.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objRoleMasterCol.Sort(RoleMaster.ByRoleDescription);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objRoleMasterCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objRoleMasterCol;
        // grid.DataBind();

        // Example 4:  loop through all the RoleMaster(s)
        foreach (RoleMaster objRoleMaster in objRoleMasterCol)
        {
            int roleId = objRoleMaster.RoleId;
            string roleDescription = objRoleMaster.RoleDescription;
            DateTime createdOn = objRoleMaster.CreatedOn;
            string createdBy = objRoleMaster.CreatedBy;
            DateTime? modifiedOn = objRoleMaster.ModifiedOn;
            string modifiedBy = objRoleMaster.ModifiedBy;
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by RoleId in ascending order
        string sortBy = "RoleId"; // ascending order
        //string sortBy = "RoleId desc"; // descending order

        List<RoleMaster> objRoleMasterCol = RoleMaster.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int roleIdSample = 1;

        // select a record by primary key(s)

        RoleMaster objRoleMaster = RoleMaster.SelectByPrimaryKey(roleIdSample);

        if (objRoleMaster != null)
        {
            // if record is found, a record is returned
            int roleId = objRoleMaster.RoleId;
            string roleDescription = objRoleMaster.RoleDescription;
            DateTime createdOn = objRoleMaster.CreatedOn;
            string createdBy = objRoleMaster.CreatedBy;
            DateTime? modifiedOn = objRoleMaster.ModifiedOn;
            string modifiedBy = objRoleMaster.ModifiedBy;
        }
    }

    /// <summary>
    /// The example below shows how to Select the RoleId and CreatedBy columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectRoleMasterDropDownListData()
    {
        List<RoleMaster> objRoleMasterCol = RoleMaster.SelectRoleMasterDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "RoleId";
        // ddl1.DataTextField = "CreatedBy";
        // ddl1.DataSource = objRoleMasterCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (RoleMaster objRoleMaster in objRoleMasterCol)
        // {
        //     ddl2.Items.Add(new ListItem(objRoleMaster.CreatedBy, objRoleMaster.RoleId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (RoleMaster objRoleMaster in objRoleMasterCol)
        // {
        //     cbx1.Items.Add(new ListItem(objRoleMaster.CreatedBy, objRoleMaster.RoleId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new RoleMaster
        RoleMaster objRoleMaster = new RoleMaster();

        // assign values you want inserted
        objRoleMaster.RoleDescription = "Administrator";
        objRoleMaster.CreatedOn = DateTime.Now;
        objRoleMaster.CreatedBy = "System";
        objRoleMaster.ModifiedOn = DateTime.Now;
        objRoleMaster.ModifiedBy = "abc";

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objRoleMaster.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new RoleMaster
        RoleMaster objRoleMaster = new RoleMaster();

        // assign the existing primary key(s)
        // of the record you want updated
        objRoleMaster.RoleId = 1;

        // assign values you want updated
        objRoleMaster.RoleDescription = "Administrator";
        objRoleMaster.CreatedOn = DateTime.Now;
        objRoleMaster.CreatedBy = "System";
        objRoleMaster.ModifiedOn = DateTime.Now;
        objRoleMaster.ModifiedBy = "abc";

        // finally, update an existing record
        objRoleMaster.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        RoleMaster.Delete(7);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the RoleMaster table
        int totalRecordCount = RoleMaster.GetRecordCount();
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
        int? roleId = null;
        string roleDescription = null;
        DateTime? createdOn = null;
        string createdBy = null;
        DateTime? modifiedOn = null;
        string modifiedBy = null;

        int totalRecordCount = RoleMaster.GetRecordCountDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy);
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
        string sortBy = "RoleId";
        //string sortBy = "RoleId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<RoleMaster> objRoleMasterCol = RoleMaster.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objRoleMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the RoleMaster(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "RoleId";
        //string sortBy = "RoleId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? roleId = null;
        string roleDescription = null;
        DateTime? createdOn = null;
        string createdBy = null;
        DateTime? modifiedOn = null;
        string modifiedBy = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<RoleMaster> objRoleMasterCol = RoleMaster.SelectSkipAndTakeDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objRoleMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the RoleMaster(s).  The example above will only loop for 10 items.
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
        int? roleId = null;
        string roleDescription = null;
        DateTime? createdOn = null;
        string createdBy = null;
        DateTime? modifiedOn = null;
        string modifiedBy = null;

        List<RoleMaster> objRoleMasterCol = RoleMaster.SelectAllDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy);
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
        int? roleId = null;
        string roleDescription = null;
        DateTime? createdOn = null;
        string createdBy = null;
        DateTime? modifiedOn = null;
        string modifiedBy = null;

        string sortBy = "RoleId"; // ascending order
        //string sortBy = "RoleId desc"; // descending order

        List<RoleMaster> objRoleMasterCol = RoleMaster.SelectAllDynamicWhere(roleId, roleDescription, createdOn, createdBy, modifiedOn, modifiedBy, sortBy);
    }
}
