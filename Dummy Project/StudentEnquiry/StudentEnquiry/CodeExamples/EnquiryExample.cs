using System;
using System.Collections.Generic;
using StudentEnquiry;
using StudentEnquiryAPI.BusinessObject;
using StudentEnquiryAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the Enquiry table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class EnquiryExample
{
    private EnquiryExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<Enquiry> objEnquiryCol = Enquiry.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objEnquiryCol.Sort(Enquiry.ByCourseId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objEnquiryCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objEnquiryCol;
        // grid.DataBind();

        // Example 4:  loop through all the Enquiry(s)
        foreach (Enquiry objEnquiry in objEnquiryCol)
        {
            int enquiryId = objEnquiry.EnquiryId;
            int courseId = objEnquiry.CourseId;
            string studentName = objEnquiry.StudentName;
            Int64 contactNo = objEnquiry.ContactNo;
            string comments = objEnquiry.Comments;

            // get the Enquiry related to EnquiryId.
            Enquiry objEnquiryRelatedToEnquiryId = Enquiry.SelectByPrimaryKey(enquiryId); 

            // get the Couse related to CourseId.
            Couse objCouseRelatedToCourseId = objEnquiry.CourseIdNavigation; 
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by EnquiryId in ascending order
        string sortBy = "EnquiryId"; // ascending order
        //string sortBy = "EnquiryId desc"; // descending order

        List<Enquiry> objEnquiryCol = Enquiry.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int enquiryIdSample = 12;

        // select a record by primary key(s)

        Enquiry objEnquiry = Enquiry.SelectByPrimaryKey(enquiryIdSample);

        if (objEnquiry != null)
        {
            // if record is found, a record is returned
            int enquiryId = objEnquiry.EnquiryId;
            int courseId = objEnquiry.CourseId;
            string studentName = objEnquiry.StudentName;
            Int64 contactNo = objEnquiry.ContactNo;
            string comments = objEnquiry.Comments;

            // get the Enquiry related to EnquiryId.
            Enquiry objEnquiryRelatedToEnquiryId = Enquiry.SelectByPrimaryKey(enquiryId); 

            // get the Couse related to CourseId.
            Couse objCouseRelatedToCourseId = objEnquiry.CourseIdNavigation; 
        }
    }

    /// <summary>
    /// Shows how to Select all records by Enquiry, related to column EnquiryId
    /// </summary>
    private void SelectEnquiryCollectionByEnquiryId()
    {
        int enquiryIdSample = 12;

        List<Enquiry> objEnquiryCol = Enquiry.SelectEnquiryCollectionByEnquiryId(enquiryIdSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objEnquiryCol.Sort(Enquiry.ByCourseId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objEnquiryCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objEnquiryCol;
        // grid.DataBind();

        // Example 4:  loop through all the Enquiry(s)
        foreach (Enquiry objEnquiry in objEnquiryCol)
        {
            int enquiryId = objEnquiry.EnquiryId;
            int courseId = objEnquiry.CourseId;
            string studentName = objEnquiry.StudentName;
            Int64 contactNo = objEnquiry.ContactNo;
            string comments = objEnquiry.Comments;

            // get the Enquiry related to EnquiryId.
            Enquiry objEnquiryRelatedToEnquiryId = Enquiry.SelectByPrimaryKey(enquiryId); 

            // get the Couse related to CourseId.
            Couse objCouseRelatedToCourseId = objEnquiry.CourseIdNavigation; 
        }
    }

    /// <summary>
    /// Shows how to Select all records by Couse, related to column CourseId
    /// </summary>
    private void SelectEnquiryCollectionByCourseId()
    {
        int courseIdSample = 12;

        List<Enquiry> objEnquiryCol = Enquiry.SelectEnquiryCollectionByCourseId(courseIdSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objEnquiryCol.Sort(Enquiry.ByCourseId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objEnquiryCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objEnquiryCol;
        // grid.DataBind();

        // Example 4:  loop through all the Enquiry(s)
        foreach (Enquiry objEnquiry in objEnquiryCol)
        {
            int enquiryId = objEnquiry.EnquiryId;
            int courseId = objEnquiry.CourseId;
            string studentName = objEnquiry.StudentName;
            Int64 contactNo = objEnquiry.ContactNo;
            string comments = objEnquiry.Comments;

            // get the Enquiry related to EnquiryId.
            Enquiry objEnquiryRelatedToEnquiryId = Enquiry.SelectByPrimaryKey(enquiryId); 

            // get the Couse related to CourseId.
            Couse objCouseRelatedToCourseId = objEnquiry.CourseIdNavigation; 
        }
    }

    /// <summary>
    /// Shows how to Select all records by Enquiry, related to column EnquiryId sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectEnquiryCollectionByEnquiryIdWithSortExpression()
    {
        int enquiryIdSample = 12;
        string sortBy = "EnquiryId"; // ascending order
        //string sortBy = "EnquiryId desc"; // descending order

        List<Enquiry> objEnquiryCol = Enquiry.SelectEnquiryCollectionByEnquiryId(enquiryIdSample, sortBy);
    }

    /// <summary>
    /// Shows how to Select all records by Couse, related to column CourseId sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectEnquiryCollectionByCourseIdWithSortExpression()
    {
        int courseIdSample = 12;
        string sortBy = "EnquiryId"; // ascending order
        //string sortBy = "EnquiryId desc"; // descending order

        List<Enquiry> objEnquiryCol = Enquiry.SelectEnquiryCollectionByCourseId(courseIdSample, sortBy);
    }

    /// <summary>
    /// The example below shows how to Select the EnquiryId and StudentName columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectEnquiryDropDownListData()
    {
        List<Enquiry> objEnquiryCol = Enquiry.SelectEnquiryDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "EnquiryId";
        // ddl1.DataTextField = "StudentName";
        // ddl1.DataSource = objEnquiryCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (Enquiry objEnquiry in objEnquiryCol)
        // {
        //     ddl2.Items.Add(new ListItem(objEnquiry.StudentName, objEnquiry.EnquiryId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (Enquiry objEnquiry in objEnquiryCol)
        // {
        //     cbx1.Items.Add(new ListItem(objEnquiry.StudentName, objEnquiry.EnquiryId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new Enquiry
        Enquiry objEnquiry = new Enquiry();

        // assign values you want inserted
        objEnquiry.CourseId = 12;
        objEnquiry.StudentName = "abc";
        objEnquiry.ContactNo = 12;
        objEnquiry.Comments = "abc";

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objEnquiry.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new Enquiry
        Enquiry objEnquiry = new Enquiry();

        // assign the existing primary key(s)
        // of the record you want updated
        objEnquiry.EnquiryId = 12;

        // assign values you want updated
        objEnquiry.CourseId = 12;
        objEnquiry.StudentName = "abc";
        objEnquiry.ContactNo = 12;
        objEnquiry.Comments = "abc";

        // finally, update an existing record
        objEnquiry.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        Enquiry.Delete(12);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the Enquiry table
        int totalRecordCount = Enquiry.GetRecordCount();
    }

    /// <summary>
    /// Shows how to get the total number of records by EnquiryId
    /// </summary>
    private void GetRecordCountByEnquiryId()
    {
        // get the total number of records in the Enquiry table by EnquiryId
        // 12 here is just a sample EnquiryId change the value as you see fit
        int totalRecordCount = Enquiry.GetRecordCountByEnquiryId(12);
    }

    /// <summary>
    /// Shows how to get the total number of records by CourseId
    /// </summary>
    private void GetRecordCountByCourseId()
    {
        // get the total number of records in the Enquiry table by CourseId
        // 12 here is just a sample CourseId change the value as you see fit
        int totalRecordCount = Enquiry.GetRecordCountByCourseId(12);
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
        int? enquiryId = null;
        int? courseId = null;
        string studentName = null;
        Int64? contactNo = null;
        string comments = null;

        int totalRecordCount = Enquiry.GetRecordCountDynamicWhere(enquiryId, courseId, studentName, contactNo, comments);
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
        string sortBy = "EnquiryId";
        //string sortBy = "EnquiryId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<Enquiry> objEnquiryCol = Enquiry.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objEnquiryCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the Enquiry(s).  The example above will only loop for 10 items.
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
    private void SelectSkipAndTakeByEnquiryId()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "EnquiryId";
        //string sortBy = "EnquiryId desc";

        // 1. select a specific number of sorted records with a EnquiryId = 12
        // starting from the index you specify
        List<Enquiry> objEnquiryCol = Enquiry.SelectSkipAndTakeByEnquiryId(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 12);

        // to use objEnquiryCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the Enquiry(s).  The example above will only loop for 10 items.
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
    private void SelectSkipAndTakeByCourseId()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "EnquiryId";
        //string sortBy = "EnquiryId desc";

        // 1. select a specific number of sorted records with a CourseId = 12
        // starting from the index you specify
        List<Enquiry> objEnquiryCol = Enquiry.SelectSkipAndTakeByCourseId(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 12);

        // to use objEnquiryCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the Enquiry(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "EnquiryId";
        //string sortBy = "EnquiryId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? enquiryId = null;
        int? courseId = null;
        string studentName = null;
        Int64? contactNo = null;
        string comments = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<Enquiry> objEnquiryCol = Enquiry.SelectSkipAndTakeDynamicWhere(enquiryId, courseId, studentName, contactNo, comments, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objEnquiryCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the Enquiry(s).  The example above will only loop for 10 items.
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
        int? enquiryId = null;
        int? courseId = null;
        string studentName = null;
        Int64? contactNo = null;
        string comments = null;

        List<Enquiry> objEnquiryCol = Enquiry.SelectAllDynamicWhere(enquiryId, courseId, studentName, contactNo, comments);
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
        int? enquiryId = null;
        int? courseId = null;
        string studentName = null;
        Int64? contactNo = null;
        string comments = null;

        string sortBy = "EnquiryId"; // ascending order
        //string sortBy = "EnquiryId desc"; // descending order

        List<Enquiry> objEnquiryCol = Enquiry.SelectAllDynamicWhere(enquiryId, courseId, studentName, contactNo, comments, sortBy);
    }
}
