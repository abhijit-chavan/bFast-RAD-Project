using System;
using System.Collections.Generic;
using StudentEnquiry;
using StudentEnquiryAPI.BusinessObject;
using StudentEnquiryAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the UserRoles table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class UserRolesExample
{
    private UserRolesExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<UserRoles> objUserRolesCol = UserRoles.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objUserRolesCol.Sort(UserRoles.ByUserId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objUserRolesCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objUserRolesCol;
        // grid.DataBind();

        // Example 4:  loop through all the UserRoles(s)
        foreach (UserRoles objUserRoles in objUserRolesCol)
        {
            int userRoleId = objUserRoles.UserRoleId;
            int? userId = objUserRoles.UserId;
            int? roleId = objUserRoles.RoleId;
            bool? status = objUserRoles.Status;

            // get the UserMaster related to UserId.
            if (objUserRoles.UserId != null)
            {
                UserMaster objUserMasterRelatedToUserId = UserMaster.SelectByPrimaryKey(userId.Value); 
            }

            // get the RoleMaster related to RoleId.
            if (objUserRoles.RoleId != null)
            {
                RoleMaster objRoleMasterRelatedToRoleId = RoleMaster.SelectByPrimaryKey(roleId.Value); 
            }
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by UserRoleId in ascending order
        string sortBy = "UserRoleId"; // ascending order
        //string sortBy = "UserRoleId desc"; // descending order

        List<UserRoles> objUserRolesCol = UserRoles.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int userRoleIdSample = 1;

        // select a record by primary key(s)

        UserRoles objUserRoles = UserRoles.SelectByPrimaryKey(userRoleIdSample);

        if (objUserRoles != null)
        {
            // if record is found, a record is returned
            int userRoleId = objUserRoles.UserRoleId;
            int? userId = objUserRoles.UserId;
            int? roleId = objUserRoles.RoleId;
            bool? status = objUserRoles.Status;

            // get the UserMaster related to UserId.
            if (objUserRoles.UserId != null)
            {
                UserMaster objUserMasterRelatedToUserId = UserMaster.SelectByPrimaryKey(userId.Value); 
            }

            // get the RoleMaster related to RoleId.
            if (objUserRoles.RoleId != null)
            {
                RoleMaster objRoleMasterRelatedToRoleId = RoleMaster.SelectByPrimaryKey(roleId.Value); 
            }
        }
    }

    /// <summary>
    /// Shows how to Select all records by UserMaster, related to column UserId
    /// </summary>
    private void SelectUserRolesCollectionByUserId()
    {
        int userIdSample = 2;

        List<UserRoles> objUserRolesCol = UserRoles.SelectUserRolesCollectionByUserId(userIdSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objUserRolesCol.Sort(UserRoles.ByUserId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objUserRolesCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objUserRolesCol;
        // grid.DataBind();

        // Example 4:  loop through all the UserRoles(s)
        foreach (UserRoles objUserRoles in objUserRolesCol)
        {
            int userRoleId = objUserRoles.UserRoleId;
            int? userId = objUserRoles.UserId;
            int? roleId = objUserRoles.RoleId;
            bool? status = objUserRoles.Status;

            // get the UserMaster related to UserId.
            if (objUserRoles.UserId != null)
            {
                UserMaster objUserMasterRelatedToUserId = UserMaster.SelectByPrimaryKey(userId.Value); 
            }

            // get the RoleMaster related to RoleId.
            if (objUserRoles.RoleId != null)
            {
                RoleMaster objRoleMasterRelatedToRoleId = RoleMaster.SelectByPrimaryKey(roleId.Value); 
            }
        }
    }

    /// <summary>
    /// Shows how to Select all records by RoleMaster, related to column RoleId
    /// </summary>
    private void SelectUserRolesCollectionByRoleId()
    {
        int roleIdSample = 1;

        List<UserRoles> objUserRolesCol = UserRoles.SelectUserRolesCollectionByRoleId(roleIdSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objUserRolesCol.Sort(UserRoles.ByUserId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objUserRolesCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objUserRolesCol;
        // grid.DataBind();

        // Example 4:  loop through all the UserRoles(s)
        foreach (UserRoles objUserRoles in objUserRolesCol)
        {
            int userRoleId = objUserRoles.UserRoleId;
            int? userId = objUserRoles.UserId;
            int? roleId = objUserRoles.RoleId;
            bool? status = objUserRoles.Status;

            // get the UserMaster related to UserId.
            if (objUserRoles.UserId != null)
            {
                UserMaster objUserMasterRelatedToUserId = UserMaster.SelectByPrimaryKey(userId.Value); 
            }

            // get the RoleMaster related to RoleId.
            if (objUserRoles.RoleId != null)
            {
                RoleMaster objRoleMasterRelatedToRoleId = RoleMaster.SelectByPrimaryKey(roleId.Value); 
            }
        }
    }

    /// <summary>
    /// Shows how to Select all records by UserMaster, related to column UserId sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectUserRolesCollectionByUserIdWithSortExpression()
    {
        int userIdSample = 2;
        string sortBy = "UserRoleId"; // ascending order
        //string sortBy = "UserRoleId desc"; // descending order

        List<UserRoles> objUserRolesCol = UserRoles.SelectUserRolesCollectionByUserId(userIdSample, sortBy);
    }

    /// <summary>
    /// Shows how to Select all records by RoleMaster, related to column RoleId sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectUserRolesCollectionByRoleIdWithSortExpression()
    {
        int roleIdSample = 1;
        string sortBy = "UserRoleId"; // ascending order
        //string sortBy = "UserRoleId desc"; // descending order

        List<UserRoles> objUserRolesCol = UserRoles.SelectUserRolesCollectionByRoleId(roleIdSample, sortBy);
    }

    /// <summary>
    /// The example below shows how to Select the UserRoleId and Status columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectUserRolesDropDownListData()
    {
        List<UserRoles> objUserRolesCol = UserRoles.SelectUserRolesDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "UserRoleId";
        // ddl1.DataTextField = "Status";
        // ddl1.DataSource = objUserRolesCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (UserRoles objUserRoles in objUserRolesCol)
        // {
        //     ddl2.Items.Add(new ListItem(objUserRoles.Status.ToString(), objUserRoles.UserRoleId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (UserRoles objUserRoles in objUserRolesCol)
        // {
        //     cbx1.Items.Add(new ListItem(objUserRoles.Status.ToString(), objUserRoles.UserRoleId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new UserRoles
        UserRoles objUserRoles = new UserRoles();

        // assign values you want inserted
        objUserRoles.UserId = 2;
        objUserRoles.RoleId = 1;
        objUserRoles.Status = false;

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objUserRoles.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new UserRoles
        UserRoles objUserRoles = new UserRoles();

        // assign the existing primary key(s)
        // of the record you want updated
        objUserRoles.UserRoleId = 1;

        // assign values you want updated
        objUserRoles.UserId = 2;
        objUserRoles.RoleId = 1;
        objUserRoles.Status = false;

        // finally, update an existing record
        objUserRoles.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        UserRoles.Delete(4);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the UserRoles table
        int totalRecordCount = UserRoles.GetRecordCount();
    }

    /// <summary>
    /// Shows how to get the total number of records by UserId
    /// </summary>
    private void GetRecordCountByUserId()
    {
        // get the total number of records in the UserRoles table by UserId
        // 2 here is just a sample UserId change the value as you see fit
        int totalRecordCount = UserRoles.GetRecordCountByUserId(2);
    }

    /// <summary>
    /// Shows how to get the total number of records by RoleId
    /// </summary>
    private void GetRecordCountByRoleId()
    {
        // get the total number of records in the UserRoles table by RoleId
        // 1 here is just a sample RoleId change the value as you see fit
        int totalRecordCount = UserRoles.GetRecordCountByRoleId(1);
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
        int? userRoleId = null;
        int? userId = null;
        int? roleId = null;
        bool? status = null;

        int totalRecordCount = UserRoles.GetRecordCountDynamicWhere(userRoleId, userId, roleId, status);
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
        string sortBy = "UserRoleId";
        //string sortBy = "UserRoleId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<UserRoles> objUserRolesCol = UserRoles.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objUserRolesCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the UserRoles(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index by the related Field Name.  The total number of records are also retrieved when using the SelectSkipAndTake() method.
    /// For example, if there are 200 records, take only 10 records (numberOfRecordsToRetrieve), starting from the first index (startRetrievalFromRecordIndex = 0)
    /// The example below uses some variables, here are their definitions:
    /// totalRecordCount - total number of records if you were to retrieve everything
    /// startRetrievalFromRecordIndex - the index to start taking records from. Zero (0) E.g. If you want to skip the first 20 records, then assign 19 here.
    /// numberOfRecordsToRetrieve - take n records starting from the startRetrievalFromRecordIndex
    /// sortBy - to sort in Ascending order by Field Name, just assign just the Field Name, do not pass 'asc'
    /// sortBy - to sort in Descending order by Field Name, use the Field Name, a space and the word 'desc'
    /// </summary>
    private void SelectSkipAndTakeByUserId()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "UserRoleId";
        //string sortBy = "UserRoleId desc";

        // 1. select a specific number of sorted records with a UserId = 2
        // starting from the index you specify
        List<UserRoles> objUserRolesCol = UserRoles.SelectSkipAndTakeByUserId(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 2);

        // to use objUserRolesCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the UserRoles(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index by the related Field Name.  The total number of records are also retrieved when using the SelectSkipAndTake() method.
    /// For example, if there are 200 records, take only 10 records (numberOfRecordsToRetrieve), starting from the first index (startRetrievalFromRecordIndex = 0)
    /// The example below uses some variables, here are their definitions:
    /// totalRecordCount - total number of records if you were to retrieve everything
    /// startRetrievalFromRecordIndex - the index to start taking records from. Zero (0) E.g. If you want to skip the first 20 records, then assign 19 here.
    /// numberOfRecordsToRetrieve - take n records starting from the startRetrievalFromRecordIndex
    /// sortBy - to sort in Ascending order by Field Name, just assign just the Field Name, do not pass 'asc'
    /// sortBy - to sort in Descending order by Field Name, use the Field Name, a space and the word 'desc'
    /// </summary>
    private void SelectSkipAndTakeByRoleId()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "UserRoleId";
        //string sortBy = "UserRoleId desc";

        // 1. select a specific number of sorted records with a RoleId = 1
        // starting from the index you specify
        List<UserRoles> objUserRolesCol = UserRoles.SelectSkipAndTakeByRoleId(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 1);

        // to use objUserRolesCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the UserRoles(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "UserRoleId";
        //string sortBy = "UserRoleId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? userRoleId = null;
        int? userId = null;
        int? roleId = null;
        bool? status = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<UserRoles> objUserRolesCol = UserRoles.SelectSkipAndTakeDynamicWhere(userRoleId, userId, roleId, status, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objUserRolesCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the UserRoles(s).  The example above will only loop for 10 items.
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
        int? userRoleId = null;
        int? userId = null;
        int? roleId = null;
        bool? status = null;

        List<UserRoles> objUserRolesCol = UserRoles.SelectAllDynamicWhere(userRoleId, userId, roleId, status);
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
        int? userRoleId = null;
        int? userId = null;
        int? roleId = null;
        bool? status = null;

        string sortBy = "UserRoleId"; // ascending order
        //string sortBy = "UserRoleId desc"; // descending order

        List<UserRoles> objUserRolesCol = UserRoles.SelectAllDynamicWhere(userRoleId, userId, roleId, status, sortBy);
    }
}
