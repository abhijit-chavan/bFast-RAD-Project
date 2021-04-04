using System;
using System.Collections.Generic;
using StudentEnquiry;
using StudentEnquiryAPI.BusinessObject;
using StudentEnquiryAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the Couse table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class CouseExample
{
    private CouseExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<Couse> objCouseCol = Couse.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCouseCol.Sort(Couse.ByCouseName);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCouseCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCouseCol;
        // grid.DataBind();

        // Example 4:  loop through all the Couse(s)
        foreach (Couse objCouse in objCouseCol)
        {
            int couseid = objCouse.Couseid;
            string couseName = objCouse.CouseName;
            DateTime courseStartDate = objCouse.CourseStartDate;
            DateTime courseEndDate = objCouse.CourseEndDate;
            Int64 couseFees = objCouse.CouseFees;
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by Couseid in ascending order
        string sortBy = "Couseid"; // ascending order
        //string sortBy = "Couseid desc"; // descending order

        List<Couse> objCouseCol = Couse.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int couseidSample = 12;

        // select a record by primary key(s)

        Couse objCouse = Couse.SelectByPrimaryKey(couseidSample);

        if (objCouse != null)
        {
            // if record is found, a record is returned
            int couseid = objCouse.Couseid;
            string couseName = objCouse.CouseName;
            DateTime courseStartDate = objCouse.CourseStartDate;
            DateTime courseEndDate = objCouse.CourseEndDate;
            Int64 couseFees = objCouse.CouseFees;
        }
    }

    /// <summary>
    /// The example below shows how to Select the Couseid and CouseName columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectCouseDropDownListData()
    {
        List<Couse> objCouseCol = Couse.SelectCouseDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "Couseid";
        // ddl1.DataTextField = "CouseName";
        // ddl1.DataSource = objCouseCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (Couse objCouse in objCouseCol)
        // {
        //     ddl2.Items.Add(new ListItem(objCouse.CouseName, objCouse.Couseid.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (Couse objCouse in objCouseCol)
        // {
        //     cbx1.Items.Add(new ListItem(objCouse.CouseName, objCouse.Couseid.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new Couse
        Couse objCouse = new Couse();

        // assign values you want inserted
        objCouse.CouseName = "abc";
        objCouse.CourseStartDate = DateTime.Now;
        objCouse.CourseEndDate = DateTime.Now;
        objCouse.CouseFees = 12;

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objCouse.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new Couse
        Couse objCouse = new Couse();

        // assign the existing primary key(s)
        // of the record you want updated
        objCouse.Couseid = 12;

        // assign values you want updated
        objCouse.CouseName = "abc";
        objCouse.CourseStartDate = DateTime.Now;
        objCouse.CourseEndDate = DateTime.Now;
        objCouse.CouseFees = 12;

        // finally, update an existing record
        objCouse.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        Couse.Delete(12);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the Couse table
        int totalRecordCount = Couse.GetRecordCount();
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
        int? couseid = null;
        string couseName = null;
        DateTime? courseStartDate = null;
        DateTime? courseEndDate = null;
        Int64? couseFees = null;

        int totalRecordCount = Couse.GetRecordCountDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees);
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
        string sortBy = "Couseid";
        //string sortBy = "Couseid desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<Couse> objCouseCol = Couse.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objCouseCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the Couse(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "Couseid";
        //string sortBy = "Couseid desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? couseid = null;
        string couseName = null;
        DateTime? courseStartDate = null;
        DateTime? courseEndDate = null;
        Int64? couseFees = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<Couse> objCouseCol = Couse.SelectSkipAndTakeDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objCouseCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the Couse(s).  The example above will only loop for 10 items.
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
        int? couseid = null;
        string couseName = null;
        DateTime? courseStartDate = null;
        DateTime? courseEndDate = null;
        Int64? couseFees = null;

        List<Couse> objCouseCol = Couse.SelectAllDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees);
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
        int? couseid = null;
        string couseName = null;
        DateTime? courseStartDate = null;
        DateTime? courseEndDate = null;
        Int64? couseFees = null;

        string sortBy = "Couseid"; // ascending order
        //string sortBy = "Couseid desc"; // descending order

        List<Couse> objCouseCol = Couse.SelectAllDynamicWhere(couseid, couseName, courseStartDate, courseEndDate, couseFees, sortBy);
    }
}
