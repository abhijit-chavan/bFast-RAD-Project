using System;
using System.Collections.Generic;
using fifth_tempDB;
using fifth_tempDBAPI.BusinessObject;
using fifth_tempDBAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the WorkflowMaster table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class WorkflowMasterExample
{
    private WorkflowMasterExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objWorkflowMasterCol.Sort(WorkflowMaster.ByWorkflowName);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objWorkflowMasterCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objWorkflowMasterCol;
        // grid.DataBind();

        // Example 4:  loop through all the WorkflowMaster(s)
        foreach (WorkflowMaster objWorkflowMaster in objWorkflowMasterCol)
        {
            int workflowId = objWorkflowMaster.WorkflowId;
            string workflowName = objWorkflowMaster.WorkflowName;
            int? levelOfApprovals = objWorkflowMaster.LevelOfApprovals;
            string createdBy = objWorkflowMaster.CreatedBy;
            DateTime createdOn = objWorkflowMaster.CreatedOn;
            string updatedby = objWorkflowMaster.Updatedby;
            DateTime updatedon = objWorkflowMaster.Updatedon;
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by WorkflowId in ascending order
        string sortBy = "WorkflowId"; // ascending order
        //string sortBy = "WorkflowId desc"; // descending order

        List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int workflowIdSample = 1;

        // select a record by primary key(s)

        WorkflowMaster objWorkflowMaster = WorkflowMaster.SelectByPrimaryKey(workflowIdSample);

        if (objWorkflowMaster != null)
        {
            // if record is found, a record is returned
            int workflowId = objWorkflowMaster.WorkflowId;
            string workflowName = objWorkflowMaster.WorkflowName;
            int? levelOfApprovals = objWorkflowMaster.LevelOfApprovals;
            string createdBy = objWorkflowMaster.CreatedBy;
            DateTime createdOn = objWorkflowMaster.CreatedOn;
            string updatedby = objWorkflowMaster.Updatedby;
            DateTime updatedon = objWorkflowMaster.Updatedon;
        }
    }

    /// <summary>
    /// The example below shows how to Select the WorkflowId and WorkflowName columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectWorkflowMasterDropDownListData()
    {
        List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectWorkflowMasterDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "WorkflowId";
        // ddl1.DataTextField = "WorkflowName";
        // ddl1.DataSource = objWorkflowMasterCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (WorkflowMaster objWorkflowMaster in objWorkflowMasterCol)
        // {
        //     ddl2.Items.Add(new ListItem(objWorkflowMaster.WorkflowName, objWorkflowMaster.WorkflowId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (WorkflowMaster objWorkflowMaster in objWorkflowMasterCol)
        // {
        //     cbx1.Items.Add(new ListItem(objWorkflowMaster.WorkflowName, objWorkflowMaster.WorkflowId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new WorkflowMaster
        WorkflowMaster objWorkflowMaster = new WorkflowMaster();

        // assign values you want inserted
        objWorkflowMaster.WorkflowName = "Issue Tracking";
        objWorkflowMaster.LevelOfApprovals = 2;
        objWorkflowMaster.CreatedBy = "abhijit";
        objWorkflowMaster.CreatedOn = DateTime.Now;
        objWorkflowMaster.Updatedby = "abc";
        objWorkflowMaster.Updatedon = DateTime.Now;

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objWorkflowMaster.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new WorkflowMaster
        WorkflowMaster objWorkflowMaster = new WorkflowMaster();

        // assign the existing primary key(s)
        // of the record you want updated
        objWorkflowMaster.WorkflowId = 1;

        // assign values you want updated
        objWorkflowMaster.WorkflowName = "Issue Tracking";
        objWorkflowMaster.LevelOfApprovals = 2;
        objWorkflowMaster.CreatedBy = "abhijit";
        objWorkflowMaster.CreatedOn = DateTime.Now;
        objWorkflowMaster.Updatedby = "abc";
        objWorkflowMaster.Updatedon = DateTime.Now;

        // finally, update an existing record
        objWorkflowMaster.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        WorkflowMaster.Delete(4);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the WorkflowMaster table
        int totalRecordCount = WorkflowMaster.GetRecordCount();
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
        int? workflowId = null;
        string workflowName = null;
        int? levelOfApprovals = null;
        string createdBy = null;
        DateTime? createdOn = null;
        string updatedby = null;
        DateTime? updatedon = null;

        int totalRecordCount = WorkflowMaster.GetRecordCountDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon);
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
        string sortBy = "WorkflowId";
        //string sortBy = "WorkflowId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objWorkflowMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the WorkflowMaster(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "WorkflowId";
        //string sortBy = "WorkflowId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? workflowId = null;
        string workflowName = null;
        int? levelOfApprovals = null;
        string createdBy = null;
        DateTime? createdOn = null;
        string updatedby = null;
        DateTime? updatedon = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectSkipAndTakeDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objWorkflowMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the WorkflowMaster(s).  The example above will only loop for 10 items.
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
        int? workflowId = null;
        string workflowName = null;
        int? levelOfApprovals = null;
        string createdBy = null;
        DateTime? createdOn = null;
        string updatedby = null;
        DateTime? updatedon = null;

        List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectAllDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon);
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
        int? workflowId = null;
        string workflowName = null;
        int? levelOfApprovals = null;
        string createdBy = null;
        DateTime? createdOn = null;
        string updatedby = null;
        DateTime? updatedon = null;

        string sortBy = "WorkflowId"; // ascending order
        //string sortBy = "WorkflowId desc"; // descending order

        List<WorkflowMaster> objWorkflowMasterCol = WorkflowMaster.SelectAllDynamicWhere(workflowId, workflowName, levelOfApprovals, createdBy, createdOn, updatedby, updatedon, sortBy);
    }
}
