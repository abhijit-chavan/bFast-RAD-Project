using System;
using System.Collections.Generic;
using CourseEnquiry1;
using CourseEnquiry1API.BusinessObject;
using CourseEnquiry1API;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the CourseEnrollment table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class CourseEnrollmentExample
{
    private CourseEnrollmentExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCourseEnrollmentCol.Sort(CourseEnrollment.ByCourseName);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCourseEnrollmentCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCourseEnrollmentCol;
        // grid.DataBind();

        // Example 4:  loop through all the CourseEnrollment(s)
        foreach (CourseEnrollment objCourseEnrollment in objCourseEnrollmentCol)
        {
            int enrollmentId = objCourseEnrollment.EnrollmentId;
            int courseName = objCourseEnrollment.CourseName;
            int studentName = objCourseEnrollment.StudentName;
            string comments = objCourseEnrollment.Comments;

            // get the Course related to CourseName.
            Course objCourseRelatedToCourseName = objCourseEnrollment.CourseNameNavigation; 

            // get the Student related to StudentName.
            Student objStudentRelatedToStudentName = objCourseEnrollment.StudentNameNavigation; 
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by EnrollmentId in ascending order
        string sortBy = "EnrollmentId"; // ascending order
        //string sortBy = "EnrollmentId desc"; // descending order

        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int enrollmentIdSample = 12;

        // select a record by primary key(s)

        CourseEnrollment objCourseEnrollment = CourseEnrollment.SelectByPrimaryKey(enrollmentIdSample);

        if (objCourseEnrollment != null)
        {
            // if record is found, a record is returned
            int enrollmentId = objCourseEnrollment.EnrollmentId;
            int courseName = objCourseEnrollment.CourseName;
            int studentName = objCourseEnrollment.StudentName;
            string comments = objCourseEnrollment.Comments;

            // get the Course related to CourseName.
            Course objCourseRelatedToCourseName = objCourseEnrollment.CourseNameNavigation; 

            // get the Student related to StudentName.
            Student objStudentRelatedToStudentName = objCourseEnrollment.StudentNameNavigation; 
        }
    }

    /// <summary>
    /// Shows how to Select all records by Course, related to column CourseName
    /// </summary>
    private void SelectCourseEnrollmentCollectionByCourseName()
    {
        int courseNameSample = 12;

        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectCourseEnrollmentCollectionByCourseName(courseNameSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCourseEnrollmentCol.Sort(CourseEnrollment.ByCourseName);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCourseEnrollmentCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCourseEnrollmentCol;
        // grid.DataBind();

        // Example 4:  loop through all the CourseEnrollment(s)
        foreach (CourseEnrollment objCourseEnrollment in objCourseEnrollmentCol)
        {
            int enrollmentId = objCourseEnrollment.EnrollmentId;
            int courseName = objCourseEnrollment.CourseName;
            int studentName = objCourseEnrollment.StudentName;
            string comments = objCourseEnrollment.Comments;

            // get the Course related to CourseName.
            Course objCourseRelatedToCourseName = objCourseEnrollment.CourseNameNavigation; 

            // get the Student related to StudentName.
            Student objStudentRelatedToStudentName = objCourseEnrollment.StudentNameNavigation; 
        }
    }

    /// <summary>
    /// Shows how to Select all records by Student, related to column StudentName
    /// </summary>
    private void SelectCourseEnrollmentCollectionByStudentName()
    {
        int studentNameSample = 12;

        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectCourseEnrollmentCollectionByStudentName(studentNameSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCourseEnrollmentCol.Sort(CourseEnrollment.ByCourseName);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCourseEnrollmentCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCourseEnrollmentCol;
        // grid.DataBind();

        // Example 4:  loop through all the CourseEnrollment(s)
        foreach (CourseEnrollment objCourseEnrollment in objCourseEnrollmentCol)
        {
            int enrollmentId = objCourseEnrollment.EnrollmentId;
            int courseName = objCourseEnrollment.CourseName;
            int studentName = objCourseEnrollment.StudentName;
            string comments = objCourseEnrollment.Comments;

            // get the Course related to CourseName.
            Course objCourseRelatedToCourseName = objCourseEnrollment.CourseNameNavigation; 

            // get the Student related to StudentName.
            Student objStudentRelatedToStudentName = objCourseEnrollment.StudentNameNavigation; 
        }
    }

    /// <summary>
    /// Shows how to Select all records by Course, related to column CourseName sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectCourseEnrollmentCollectionByCourseNameWithSortExpression()
    {
        int courseNameSample = 12;
        string sortBy = "EnrollmentId"; // ascending order
        //string sortBy = "EnrollmentId desc"; // descending order

        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectCourseEnrollmentCollectionByCourseName(courseNameSample, sortBy);
    }

    /// <summary>
    /// Shows how to Select all records by Student, related to column StudentName sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectCourseEnrollmentCollectionByStudentNameWithSortExpression()
    {
        int studentNameSample = 12;
        string sortBy = "EnrollmentId"; // ascending order
        //string sortBy = "EnrollmentId desc"; // descending order

        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectCourseEnrollmentCollectionByStudentName(studentNameSample, sortBy);
    }

    /// <summary>
    /// The example below shows how to Select the EnrollmentId and Comments columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectCourseEnrollmentDropDownListData()
    {
        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectCourseEnrollmentDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "EnrollmentId";
        // ddl1.DataTextField = "Comments";
        // ddl1.DataSource = objCourseEnrollmentCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (CourseEnrollment objCourseEnrollment in objCourseEnrollmentCol)
        // {
        //     ddl2.Items.Add(new ListItem(objCourseEnrollment.Comments, objCourseEnrollment.EnrollmentId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (CourseEnrollment objCourseEnrollment in objCourseEnrollmentCol)
        // {
        //     cbx1.Items.Add(new ListItem(objCourseEnrollment.Comments, objCourseEnrollment.EnrollmentId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new CourseEnrollment
        CourseEnrollment objCourseEnrollment = new CourseEnrollment();

        // assign values you want inserted
        objCourseEnrollment.CourseName = 12;
        objCourseEnrollment.StudentName = 12;
        objCourseEnrollment.Comments = "abc";

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objCourseEnrollment.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new CourseEnrollment
        CourseEnrollment objCourseEnrollment = new CourseEnrollment();

        // assign the existing primary key(s)
        // of the record you want updated
        objCourseEnrollment.EnrollmentId = 12;

        // assign values you want updated
        objCourseEnrollment.CourseName = 12;
        objCourseEnrollment.StudentName = 12;
        objCourseEnrollment.Comments = "abc";

        // finally, update an existing record
        objCourseEnrollment.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        CourseEnrollment.Delete(12);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the CourseEnrollment table
        int totalRecordCount = CourseEnrollment.GetRecordCount();
    }

    /// <summary>
    /// Shows how to get the total number of records by CourseName
    /// </summary>
    private void GetRecordCountByCourseName()
    {
        // get the total number of records in the CourseEnrollment table by CourseName
        // 12 here is just a sample CourseName change the value as you see fit
        int totalRecordCount = CourseEnrollment.GetRecordCountByCourseName(12);
    }

    /// <summary>
    /// Shows how to get the total number of records by StudentName
    /// </summary>
    private void GetRecordCountByStudentName()
    {
        // get the total number of records in the CourseEnrollment table by StudentName
        // 12 here is just a sample StudentName change the value as you see fit
        int totalRecordCount = CourseEnrollment.GetRecordCountByStudentName(12);
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
        int? enrollmentId = null;
        int? courseName = null;
        int? studentName = null;
        string comments = null;

        int totalRecordCount = CourseEnrollment.GetRecordCountDynamicWhere(enrollmentId, courseName, studentName, comments);
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
        string sortBy = "EnrollmentId";
        //string sortBy = "EnrollmentId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objCourseEnrollmentCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the CourseEnrollment(s).  The example above will only loop for 10 items.
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
    private void SelectSkipAndTakeByCourseName()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "EnrollmentId";
        //string sortBy = "EnrollmentId desc";

        // 1. select a specific number of sorted records with a CourseName = 12
        // starting from the index you specify
        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectSkipAndTakeByCourseName(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 12);

        // to use objCourseEnrollmentCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the CourseEnrollment(s).  The example above will only loop for 10 items.
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
    private void SelectSkipAndTakeByStudentName()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "EnrollmentId";
        //string sortBy = "EnrollmentId desc";

        // 1. select a specific number of sorted records with a StudentName = 12
        // starting from the index you specify
        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectSkipAndTakeByStudentName(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 12);

        // to use objCourseEnrollmentCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the CourseEnrollment(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "EnrollmentId";
        //string sortBy = "EnrollmentId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? enrollmentId = null;
        int? courseName = null;
        int? studentName = null;
        string comments = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectSkipAndTakeDynamicWhere(enrollmentId, courseName, studentName, comments, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objCourseEnrollmentCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the CourseEnrollment(s).  The example above will only loop for 10 items.
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
        int? enrollmentId = null;
        int? courseName = null;
        int? studentName = null;
        string comments = null;

        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectAllDynamicWhere(enrollmentId, courseName, studentName, comments);
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
        int? enrollmentId = null;
        int? courseName = null;
        int? studentName = null;
        string comments = null;

        string sortBy = "EnrollmentId"; // ascending order
        //string sortBy = "EnrollmentId desc"; // descending order

        List<CourseEnrollment> objCourseEnrollmentCol = CourseEnrollment.SelectAllDynamicWhere(enrollmentId, courseName, studentName, comments, sortBy);
    }
}
