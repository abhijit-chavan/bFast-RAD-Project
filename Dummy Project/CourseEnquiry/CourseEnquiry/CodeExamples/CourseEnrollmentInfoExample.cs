using System;
using System.Collections.Generic;
using CourseEnquiry;
using CourseEnquiryAPI.BusinessObject;
using CourseEnquiryAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the CourseEnrollmentInfo table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class CourseEnrollmentInfoExample
{
    private CourseEnrollmentInfoExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCourseEnrollmentInfoCol.Sort(CourseEnrollmentInfo.ByCourseId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCourseEnrollmentInfoCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCourseEnrollmentInfoCol;
        // grid.DataBind();

        // Example 4:  loop through all the CourseEnrollmentInfo(s)
        foreach (CourseEnrollmentInfo objCourseEnrollmentInfo in objCourseEnrollmentInfoCol)
        {
            int enrollmentId = objCourseEnrollmentInfo.EnrollmentId;
            int courseId = objCourseEnrollmentInfo.CourseId;
            int studentId = objCourseEnrollmentInfo.StudentId;
            string comments = objCourseEnrollmentInfo.Comments;

            // get the CourseEnrollmentInfo related to EnrollmentId.
            CourseEnrollmentInfo objCourseEnrollmentInfoRelatedToEnrollmentId = CourseEnrollmentInfo.SelectByPrimaryKey(enrollmentId); 

            // get the Course related to CourseId.
            Course objCourseRelatedToCourseId = Course.SelectByPrimaryKey(courseId); 

            // get the Student related to StudentId.
            Student objStudentRelatedToStudentId = Student.SelectByPrimaryKey(studentId); 
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

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int enrollmentIdSample = 12;

        // select a record by primary key(s)

        CourseEnrollmentInfo objCourseEnrollmentInfo = CourseEnrollmentInfo.SelectByPrimaryKey(enrollmentIdSample);

        if (objCourseEnrollmentInfo != null)
        {
            // if record is found, a record is returned
            int enrollmentId = objCourseEnrollmentInfo.EnrollmentId;
            int courseId = objCourseEnrollmentInfo.CourseId;
            int studentId = objCourseEnrollmentInfo.StudentId;
            string comments = objCourseEnrollmentInfo.Comments;

            // get the CourseEnrollmentInfo related to EnrollmentId.
            CourseEnrollmentInfo objCourseEnrollmentInfoRelatedToEnrollmentId = CourseEnrollmentInfo.SelectByPrimaryKey(enrollmentId); 

            // get the Course related to CourseId.
            Course objCourseRelatedToCourseId = Course.SelectByPrimaryKey(courseId); 

            // get the Student related to StudentId.
            Student objStudentRelatedToStudentId = Student.SelectByPrimaryKey(studentId); 
        }
    }

    /// <summary>
    /// Shows how to Select all records by CourseEnrollmentInfo, related to column EnrollmentId
    /// </summary>
    private void SelectCourseEnrollmentInfoCollectionByEnrollmentId()
    {
        int enrollmentIdSample = 12;

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectCourseEnrollmentInfoCollectionByEnrollmentId(enrollmentIdSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCourseEnrollmentInfoCol.Sort(CourseEnrollmentInfo.ByCourseId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCourseEnrollmentInfoCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCourseEnrollmentInfoCol;
        // grid.DataBind();

        // Example 4:  loop through all the CourseEnrollmentInfo(s)
        foreach (CourseEnrollmentInfo objCourseEnrollmentInfo in objCourseEnrollmentInfoCol)
        {
            int enrollmentId = objCourseEnrollmentInfo.EnrollmentId;
            int courseId = objCourseEnrollmentInfo.CourseId;
            int studentId = objCourseEnrollmentInfo.StudentId;
            string comments = objCourseEnrollmentInfo.Comments;

            // get the CourseEnrollmentInfo related to EnrollmentId.
            CourseEnrollmentInfo objCourseEnrollmentInfoRelatedToEnrollmentId = CourseEnrollmentInfo.SelectByPrimaryKey(enrollmentId); 

            // get the Course related to CourseId.
            Course objCourseRelatedToCourseId = Course.SelectByPrimaryKey(courseId); 

            // get the Student related to StudentId.
            Student objStudentRelatedToStudentId = Student.SelectByPrimaryKey(studentId); 
        }
    }

    /// <summary>
    /// Shows how to Select all records by Course, related to column CourseId
    /// </summary>
    private void SelectCourseEnrollmentInfoCollectionByCourseId()
    {
        int courseIdSample = 12;

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectCourseEnrollmentInfoCollectionByCourseId(courseIdSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCourseEnrollmentInfoCol.Sort(CourseEnrollmentInfo.ByCourseId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCourseEnrollmentInfoCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCourseEnrollmentInfoCol;
        // grid.DataBind();

        // Example 4:  loop through all the CourseEnrollmentInfo(s)
        foreach (CourseEnrollmentInfo objCourseEnrollmentInfo in objCourseEnrollmentInfoCol)
        {
            int enrollmentId = objCourseEnrollmentInfo.EnrollmentId;
            int courseId = objCourseEnrollmentInfo.CourseId;
            int studentId = objCourseEnrollmentInfo.StudentId;
            string comments = objCourseEnrollmentInfo.Comments;

            // get the CourseEnrollmentInfo related to EnrollmentId.
            CourseEnrollmentInfo objCourseEnrollmentInfoRelatedToEnrollmentId = CourseEnrollmentInfo.SelectByPrimaryKey(enrollmentId); 

            // get the Course related to CourseId.
            Course objCourseRelatedToCourseId = Course.SelectByPrimaryKey(courseId); 

            // get the Student related to StudentId.
            Student objStudentRelatedToStudentId = Student.SelectByPrimaryKey(studentId); 
        }
    }

    /// <summary>
    /// Shows how to Select all records by Student, related to column StudentId
    /// </summary>
    private void SelectCourseEnrollmentInfoCollectionByStudentId()
    {
        int studentIdSample = 12;

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectCourseEnrollmentInfoCollectionByStudentId(studentIdSample);

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objCourseEnrollmentInfoCol.Sort(CourseEnrollmentInfo.ByCourseId);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objCourseEnrollmentInfoCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objCourseEnrollmentInfoCol;
        // grid.DataBind();

        // Example 4:  loop through all the CourseEnrollmentInfo(s)
        foreach (CourseEnrollmentInfo objCourseEnrollmentInfo in objCourseEnrollmentInfoCol)
        {
            int enrollmentId = objCourseEnrollmentInfo.EnrollmentId;
            int courseId = objCourseEnrollmentInfo.CourseId;
            int studentId = objCourseEnrollmentInfo.StudentId;
            string comments = objCourseEnrollmentInfo.Comments;

            // get the CourseEnrollmentInfo related to EnrollmentId.
            CourseEnrollmentInfo objCourseEnrollmentInfoRelatedToEnrollmentId = CourseEnrollmentInfo.SelectByPrimaryKey(enrollmentId); 

            // get the Course related to CourseId.
            Course objCourseRelatedToCourseId = Course.SelectByPrimaryKey(courseId); 

            // get the Student related to StudentId.
            Student objStudentRelatedToStudentId = Student.SelectByPrimaryKey(studentId); 
        }
    }

    /// <summary>
    /// Shows how to Select all records by CourseEnrollmentInfo, related to column EnrollmentId sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectCourseEnrollmentInfoCollectionByEnrollmentIdWithSortExpression()
    {
        int enrollmentIdSample = 12;
        string sortBy = "EnrollmentId"; // ascending order
        //string sortBy = "EnrollmentId desc"; // descending order

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectCourseEnrollmentInfoCollectionByEnrollmentId(enrollmentIdSample, sortBy);
    }

    /// <summary>
    /// Shows how to Select all records by Course, related to column CourseId sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectCourseEnrollmentInfoCollectionByCourseIdWithSortExpression()
    {
        int courseIdSample = 12;
        string sortBy = "EnrollmentId"; // ascending order
        //string sortBy = "EnrollmentId desc"; // descending order

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectCourseEnrollmentInfoCollectionByCourseId(courseIdSample, sortBy);
    }

    /// <summary>
    /// Shows how to Select all records by Student, related to column StudentId sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectCourseEnrollmentInfoCollectionByStudentIdWithSortExpression()
    {
        int studentIdSample = 12;
        string sortBy = "EnrollmentId"; // ascending order
        //string sortBy = "EnrollmentId desc"; // descending order

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectCourseEnrollmentInfoCollectionByStudentId(studentIdSample, sortBy);
    }

    /// <summary>
    /// The example below shows how to Select the EnrollmentId and Comments columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectCourseEnrollmentInfoDropDownListData()
    {
        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectCourseEnrollmentInfoDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "EnrollmentId";
        // ddl1.DataTextField = "Comments";
        // ddl1.DataSource = objCourseEnrollmentInfoCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (CourseEnrollmentInfo objCourseEnrollmentInfo in objCourseEnrollmentInfoCol)
        // {
        //     ddl2.Items.Add(new ListItem(objCourseEnrollmentInfo.Comments, objCourseEnrollmentInfo.EnrollmentId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (CourseEnrollmentInfo objCourseEnrollmentInfo in objCourseEnrollmentInfoCol)
        // {
        //     cbx1.Items.Add(new ListItem(objCourseEnrollmentInfo.Comments, objCourseEnrollmentInfo.EnrollmentId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new CourseEnrollmentInfo
        CourseEnrollmentInfo objCourseEnrollmentInfo = new CourseEnrollmentInfo();

        // assign values you want inserted
        objCourseEnrollmentInfo.EnrollmentId = 12;
        objCourseEnrollmentInfo.CourseId = 12;
        objCourseEnrollmentInfo.StudentId = 12;
        objCourseEnrollmentInfo.Comments = "abc";

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objCourseEnrollmentInfo.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new CourseEnrollmentInfo
        CourseEnrollmentInfo objCourseEnrollmentInfo = new CourseEnrollmentInfo();

        // assign the existing primary key(s)
        // of the record you want updated
        objCourseEnrollmentInfo.EnrollmentId = 12;

        // assign values you want updated
        objCourseEnrollmentInfo.CourseId = 12;
        objCourseEnrollmentInfo.StudentId = 12;
        objCourseEnrollmentInfo.Comments = "abc";

        // finally, update an existing record
        objCourseEnrollmentInfo.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        CourseEnrollmentInfo.Delete(12);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the CourseEnrollmentInfo table
        int totalRecordCount = CourseEnrollmentInfo.GetRecordCount();
    }

    /// <summary>
    /// Shows how to get the total number of records by EnrollmentId
    /// </summary>
    private void GetRecordCountByEnrollmentId()
    {
        // get the total number of records in the CourseEnrollmentInfo table by EnrollmentId
        // 12 here is just a sample EnrollmentId change the value as you see fit
        int totalRecordCount = CourseEnrollmentInfo.GetRecordCountByEnrollmentId(12);
    }

    /// <summary>
    /// Shows how to get the total number of records by CourseId
    /// </summary>
    private void GetRecordCountByCourseId()
    {
        // get the total number of records in the CourseEnrollmentInfo table by CourseId
        // 12 here is just a sample CourseId change the value as you see fit
        int totalRecordCount = CourseEnrollmentInfo.GetRecordCountByCourseId(12);
    }

    /// <summary>
    /// Shows how to get the total number of records by StudentId
    /// </summary>
    private void GetRecordCountByStudentId()
    {
        // get the total number of records in the CourseEnrollmentInfo table by StudentId
        // 12 here is just a sample StudentId change the value as you see fit
        int totalRecordCount = CourseEnrollmentInfo.GetRecordCountByStudentId(12);
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
        int? courseId = null;
        int? studentId = null;
        string comments = null;

        int totalRecordCount = CourseEnrollmentInfo.GetRecordCountDynamicWhere(enrollmentId, courseId, studentId, comments);
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
        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objCourseEnrollmentInfoCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the CourseEnrollmentInfo(s).  The example above will only loop for 10 items.
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
    private void SelectSkipAndTakeByEnrollmentId()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "EnrollmentId";
        //string sortBy = "EnrollmentId desc";

        // 1. select a specific number of sorted records with a EnrollmentId = 12
        // starting from the index you specify
        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectSkipAndTakeByEnrollmentId(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 12);

        // to use objCourseEnrollmentInfoCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the CourseEnrollmentInfo(s).  The example above will only loop for 10 items.
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
        string sortBy = "EnrollmentId";
        //string sortBy = "EnrollmentId desc";

        // 1. select a specific number of sorted records with a CourseId = 12
        // starting from the index you specify
        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectSkipAndTakeByCourseId(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 12);

        // to use objCourseEnrollmentInfoCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the CourseEnrollmentInfo(s).  The example above will only loop for 10 items.
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
    private void SelectSkipAndTakeByStudentId()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "EnrollmentId";
        //string sortBy = "EnrollmentId desc";

        // 1. select a specific number of sorted records with a StudentId = 12
        // starting from the index you specify
        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectSkipAndTakeByStudentId(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy, 12);

        // to use objCourseEnrollmentInfoCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the CourseEnrollmentInfo(s).  The example above will only loop for 10 items.
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
        int? courseId = null;
        int? studentId = null;
        string comments = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectSkipAndTakeDynamicWhere(enrollmentId, courseId, studentId, comments, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objCourseEnrollmentInfoCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the CourseEnrollmentInfo(s).  The example above will only loop for 10 items.
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
        int? courseId = null;
        int? studentId = null;
        string comments = null;

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectAllDynamicWhere(enrollmentId, courseId, studentId, comments);
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
        int? courseId = null;
        int? studentId = null;
        string comments = null;

        string sortBy = "EnrollmentId"; // ascending order
        //string sortBy = "EnrollmentId desc"; // descending order

        List<CourseEnrollmentInfo> objCourseEnrollmentInfoCol = CourseEnrollmentInfo.SelectAllDynamicWhere(enrollmentId, courseId, studentId, comments, sortBy);
    }
}
