using System;
using System.Collections.Generic;
using CourseEnquiry1;
using CourseEnquiry1API.BusinessObject;
using CourseEnquiry1API;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the Course table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class CourseExample
{
    private CourseExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<Course> objCourseCol = Course.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCourseCol.Sort(Course.ByCourseName);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCourseCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCourseCol;
        // grid.DataBind();

        // Example 4:  loop through all the Course(s)
        foreach (Course objCourse in objCourseCol)
        {
            int courseId = objCourse.CourseId;
            string courseName = objCourse.CourseName;
            DateTime startDate = objCourse.StartDate;
            DateTime endDate = objCourse.EndDate;
            decimal fees = objCourse.Fees;
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by CourseId in ascending order
        string sortBy = "CourseId"; // ascending order
        //string sortBy = "CourseId desc"; // descending order

        List<Course> objCourseCol = Course.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int courseIdSample = 12;

        // select a record by primary key(s)

        Course objCourse = Course.SelectByPrimaryKey(courseIdSample);

        if (objCourse != null)
        {
            // if record is found, a record is returned
            int courseId = objCourse.CourseId;
            string courseName = objCourse.CourseName;
            DateTime startDate = objCourse.StartDate;
            DateTime endDate = objCourse.EndDate;
            decimal fees = objCourse.Fees;
        }
    }

    /// <summary>
    /// The example below shows how to Select the CourseId and CourseName columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectCourseDropDownListData()
    {
        List<Course> objCourseCol = Course.SelectCourseDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "CourseId";
        // ddl1.DataTextField = "CourseName";
        // ddl1.DataSource = objCourseCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (Course objCourse in objCourseCol)
        // {
        //     ddl2.Items.Add(new ListItem(objCourse.CourseName, objCourse.CourseId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (Course objCourse in objCourseCol)
        // {
        //     cbx1.Items.Add(new ListItem(objCourse.CourseName, objCourse.CourseId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new Course
        Course objCourse = new Course();

        // assign values you want inserted
        objCourse.CourseName = "abc";
        objCourse.StartDate = DateTime.Now;
        objCourse.EndDate = DateTime.Now;
        objCourse.Fees = 52.4m;

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objCourse.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new Course
        Course objCourse = new Course();

        // assign the existing primary key(s)
        // of the record you want updated
        objCourse.CourseId = 12;

        // assign values you want updated
        objCourse.CourseName = "abc";
        objCourse.StartDate = DateTime.Now;
        objCourse.EndDate = DateTime.Now;
        objCourse.Fees = 52.4m;

        // finally, update an existing record
        objCourse.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        Course.Delete(12);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the Course table
        int totalRecordCount = Course.GetRecordCount();
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
        int? courseId = null;
        string courseName = null;
        DateTime? startDate = null;
        DateTime? endDate = null;
        decimal? fees = null;

        int totalRecordCount = Course.GetRecordCountDynamicWhere(courseId, courseName, startDate, endDate, fees);
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
        string sortBy = "CourseId";
        //string sortBy = "CourseId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<Course> objCourseCol = Course.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objCourseCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the Course(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "CourseId";
        //string sortBy = "CourseId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? courseId = null;
        string courseName = null;
        DateTime? startDate = null;
        DateTime? endDate = null;
        decimal? fees = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<Course> objCourseCol = Course.SelectSkipAndTakeDynamicWhere(courseId, courseName, startDate, endDate, fees, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objCourseCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the Course(s).  The example above will only loop for 10 items.
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
        int? courseId = null;
        string courseName = null;
        DateTime? startDate = null;
        DateTime? endDate = null;
        decimal? fees = null;

        List<Course> objCourseCol = Course.SelectAllDynamicWhere(courseId, courseName, startDate, endDate, fees);
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
        int? courseId = null;
        string courseName = null;
        DateTime? startDate = null;
        DateTime? endDate = null;
        decimal? fees = null;

        string sortBy = "CourseId"; // ascending order
        //string sortBy = "CourseId desc"; // descending order

        List<Course> objCourseCol = Course.SelectAllDynamicWhere(courseId, courseName, startDate, endDate, fees, sortBy);
    }
}
