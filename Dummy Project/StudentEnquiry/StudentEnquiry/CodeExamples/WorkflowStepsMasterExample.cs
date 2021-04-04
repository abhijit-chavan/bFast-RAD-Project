using System;
using System.Collections.Generic;
using StudentEnquiry;
using StudentEnquiryAPI.BusinessObject;
using StudentEnquiryAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the WorkflowStepsMaster table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class WorkflowStepsMasterExample
{
    private WorkflowStepsMasterExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objWorkflowStepsMasterCol.Sort(WorkflowStepsMaster.ByWorKflowId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objWorkflowStepsMasterCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objWorkflowStepsMasterCol;
        // grid.DataBind();

        // Example 4:  loop through all the WorkflowStepsMaster(s)
        foreach (WorkflowStepsMaster objWorkflowStepsMaster in objWorkflowStepsMasterCol)
        {
            int stepId = objWorkflowStepsMaster.StepId;
            int? worKflowId = objWorkflowStepsMaster.WorKflowId;
            string approvalLevel = objWorkflowStepsMaster.ApprovalLevel;
            string description = objWorkflowStepsMaster.Description;
            string autoApprove = objWorkflowStepsMaster.AutoApprove;
            int? waitTime = objWorkflowStepsMaster.WaitTime;
            string createdBy = objWorkflowStepsMaster.CreatedBy;
            DateTime createdOn = objWorkflowStepsMaster.CreatedOn;
            string updatedBy = objWorkflowStepsMaster.UpdatedBy;
            DateTime updatedOn = objWorkflowStepsMaster.UpdatedOn;

            // get the WorkflowMaster related to WorKflowId.
            if (objWorkflowStepsMaster.WorKflowId != null)
            {
                WorkflowMaster objWorkflowMasterRelatedToWorKflowId = objWorkflowStepsMaster.WorKflowIdNavigation; 
            }
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by StepId in ascending order
        string sortBy = "StepId"; // ascending order
        //string sortBy = "StepId desc"; // descending order

        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int stepIdSample = 12;

        // select a record by primary key(s)

        WorkflowStepsMaster objWorkflowStepsMaster = WorkflowStepsMaster.SelectByPrimaryKey(stepIdSample);

        if (objWorkflowStepsMaster != null)
        {
            // if record is found, a record is returned
            int stepId = objWorkflowStepsMaster.StepId;
            int? worKflowId = objWorkflowStepsMaster.WorKflowId;
            string approvalLevel = objWorkflowStepsMaster.ApprovalLevel;
            string description = objWorkflowStepsMaster.Description;
            string autoApprove = objWorkflowStepsMaster.AutoApprove;
            int? waitTime = objWorkflowStepsMaster.WaitTime;
            string createdBy = objWorkflowStepsMaster.CreatedBy;
            DateTime createdOn = objWorkflowStepsMaster.CreatedOn;
            string updatedBy = objWorkflowStepsMaster.UpdatedBy;
            DateTime updatedOn = objWorkflowStepsMaster.UpdatedOn;

            // get the WorkflowMaster related to WorKflowId.
            if (objWorkflowStepsMaster.WorKflowId != null)
            {
                WorkflowMaster objWorkflowMasterRelatedToWorKflowId = objWorkflowStepsMaster.WorKflowIdNavigation; 
            }
        }
    }

    /// <summary>
    /// Shows how to Select all records by WorkflowMaster, related to column WorKflowId
    /// </summary>
    private void SelectWorkflowStepsMasterCollectionByWorKflowId()
    {
        int worKflowIdSample = 12;

        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectWorkflowStepsMasterCollectionByWorKflowId(worKflowIdSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objWorkflowStepsMasterCol.Sort(WorkflowStepsMaster.ByWorKflowId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objWorkflowStepsMasterCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objWorkflowStepsMasterCol;
        // grid.DataBind();

        // Example 4:  loop through all the WorkflowStepsMaster(s)
        foreach (WorkflowStepsMaster objWorkflowStepsMaster in objWorkflowStepsMasterCol)
        {
            int stepId = objWorkflowStepsMaster.StepId;
            int? worKflowId = objWorkflowStepsMaster.WorKflowId;
            string approvalLevel = objWorkflowStepsMaster.ApprovalLevel;
            string description = objWorkflowStepsMaster.Description;
            string autoApprove = objWorkflowStepsMaster.AutoApprove;
            int? waitTime = objWorkflowStepsMaster.WaitTime;
            string createdBy = objWorkflowStepsMaster.CreatedBy;
            DateTime createdOn = objWorkflowStepsMaster.CreatedOn;
            string updatedBy = objWorkflowStepsMaster.UpdatedBy;
            DateTime updatedOn = objWorkflowStepsMaster.UpdatedOn;

            // get the WorkflowMaster related to WorKflowId.
            if (objWorkflowStepsMaster.WorKflowId != null)
            {
                WorkflowMaster objWorkflowMasterRelatedToWorKflowId = objWorkflowStepsMaster.WorKflowIdNavigation; 
            }
        }
    }

    /// <summary>
    /// Shows how to Select all records by WorkflowMaster, related to column WorKflowId sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectWorkflowStepsMasterCollectionByWorKflowIdWithSortExpression()
    {
        int worKflowIdSample = 12;
        string sortBy = "StepId"; // ascending order
        //string sortBy = "StepId desc"; // descending order

        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectWorkflowStepsMasterCollectionByWorKflowId(worKflowIdSample, sortBy);
    }

    /// <summary>
    /// The example below shows how to Select the StepId and ApprovalLevel columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectWorkflowStepsMasterDropDownListData()
    {
        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectWorkflowStepsMasterDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "StepId";
        // ddl1.DataTextField = "ApprovalLevel";
        // ddl1.DataSource = objWorkflowStepsMasterCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (WorkflowStepsMaster objWorkflowStepsMaster in objWorkflowStepsMasterCol)
        // {
        //     ddl2.Items.Add(new ListItem(objWorkflowStepsMaster.ApprovalLevel, objWorkflowStepsMaster.StepId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (WorkflowStepsMaster objWorkflowStepsMaster in objWorkflowStepsMasterCol)
        // {
        //     cbx1.Items.Add(new ListItem(objWorkflowStepsMaster.ApprovalLevel, objWorkflowStepsMaster.StepId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new WorkflowStepsMaster
        WorkflowStepsMaster objWorkflowStepsMaster = new WorkflowStepsMaster();

        // assign values you want inserted
        objWorkflowStepsMaster.WorKflowId = 12;
        objWorkflowStepsMaster.ApprovalLevel = "abc";
        objWorkflowStepsMaster.Description = "abc";
        objWorkflowStepsMaster.AutoApprove = "abc";
        objWorkflowStepsMaster.WaitTime = 12;
        objWorkflowStepsMaster.CreatedBy = "abc";
        objWorkflowStepsMaster.CreatedOn = DateTime.Now;
        objWorkflowStepsMaster.UpdatedBy = "abc";
        objWorkflowStepsMaster.UpdatedOn = DateTime.Now;

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objWorkflowStepsMaster.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new WorkflowStepsMaster
        WorkflowStepsMaster objWorkflowStepsMaster = new WorkflowStepsMaster();

        // assign the existing primary key(s)
        // of the record you want updated
        objWorkflowStepsMaster.StepId = 12;

        // assign values you want updated
        objWorkflowStepsMaster.WorKflowId = 12;
        objWorkflowStepsMaster.ApprovalLevel = "abc";
        objWorkflowStepsMaster.Description = "abc";
        objWorkflowStepsMaster.AutoApprove = "abc";
        objWorkflowStepsMaster.WaitTime = 12;
        objWorkflowStepsMaster.CreatedBy = "abc";
        objWorkflowStepsMaster.CreatedOn = DateTime.Now;
        objWorkflowStepsMaster.UpdatedBy = "abc";
        objWorkflowStepsMaster.UpdatedOn = DateTime.Now;

        // finally, update an existing record
        objWorkflowStepsMaster.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        WorkflowStepsMaster.Delete(12);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the WorkflowStepsMaster table
        int totalRecordCount = WorkflowStepsMaster.GetRecordCount();
    }

    /// <summary>
    /// Shows how to get the total number of records by WorKflowId
    /// </summary>
    private void GetRecordCountByWorKflowId()
    {
        // get the total number of records in the WorkflowStepsMaster table by WorKflowId
        // 12 here is just a sample WorKflowId change the value as you see fit
        int totalRecordCount = WorkflowStepsMaster.GetRecordCountByWorKflowId(12);
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
        int? stepId = null;
        int? worKflowId = null;
        string approvalLevel = null;
        string description = null;
        string autoApprove = null;
        int? waitTime = null;
        string createdBy = null;
        DateTime? createdOn = null;
        string updatedBy = null;
        DateTime? updatedOn = null;

        int totalRecordCount = WorkflowStepsMaster.GetRecordCountDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn);
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
        string sortBy = "StepId";
        //string sortBy = "StepId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objWorkflowStepsMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the WorkflowStepsMaster(s).  The example above will only loop for 10 items.
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
    private void SelectSkipAndTakeByWorKflowId()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "StepId";
        //string sortBy = "StepId desc";

        // 1. select a specific number of sorted records with a WorKflowId = 12
        // starting from the index you specify
        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectSkipAndTakeByWorKflowId(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 12);

        // to use objWorkflowStepsMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the WorkflowStepsMaster(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "StepId";
        //string sortBy = "StepId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? stepId = null;
        int? worKflowId = null;
        string approvalLevel = null;
        string description = null;
        string autoApprove = null;
        int? waitTime = null;
        string createdBy = null;
        DateTime? createdOn = null;
        string updatedBy = null;
        DateTime? updatedOn = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectSkipAndTakeDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objWorkflowStepsMasterCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the WorkflowStepsMaster(s).  The example above will only loop for 10 items.
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
        int? stepId = null;
        int? worKflowId = null;
        string approvalLevel = null;
        string description = null;
        string autoApprove = null;
        int? waitTime = null;
        string createdBy = null;
        DateTime? createdOn = null;
        string updatedBy = null;
        DateTime? updatedOn = null;

        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectAllDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn);
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
        int? stepId = null;
        int? worKflowId = null;
        string approvalLevel = null;
        string description = null;
        string autoApprove = null;
        int? waitTime = null;
        string createdBy = null;
        DateTime? createdOn = null;
        string updatedBy = null;
        DateTime? updatedOn = null;

        string sortBy = "StepId"; // ascending order
        //string sortBy = "StepId desc"; // descending order

        List<WorkflowStepsMaster> objWorkflowStepsMasterCol = WorkflowStepsMaster.SelectAllDynamicWhere(stepId, worKflowId, approvalLevel, description, autoApprove, waitTime, createdBy, createdOn, updatedBy, updatedOn, sortBy);
    }
}
