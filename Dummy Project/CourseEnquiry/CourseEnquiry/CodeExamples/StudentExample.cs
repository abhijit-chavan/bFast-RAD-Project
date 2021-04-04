using System;
using System.Collections.Generic;
using CourseEnquiry;
using CourseEnquiryAPI.BusinessObject;
using CourseEnquiryAPI;
// using System.Windows.Forms;    // Note: remove comment when using with windows forms

/// <summary>
/// These are data-centric code examples for the Student table.
/// You can cut and paste the respective codes into your application
/// by changing the sample values assigned from these examples.
/// NOTE: This class contains private methods because they're
/// not meant to be called by an outside client.  Each method contains
/// code for the respective example being shown
/// </summary>
public sealed class StudentExample
{
    private StudentExample()
    {
    }

    /// <summary>
    /// Shows how to Select all records.  It also shows how to sort, bind, and loop through records.
    /// </summary>
    private void SelectAll()
    {
        // select all records
        List<Student> objStudentCol = Student.SelectAll();

        // Example 1:  you can optionally sort the collection in ascending order by your chosen field 
        objStudentCol.Sort(Student.ByStudentName);

        // Example 2:  to sort in descending order, add this line to the Sort code in Example 1 
        objStudentCol.Reverse();

        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // GridView grid = new GridView();
        // grid.DataSource = objStudentCol;
        // grid.DataBind();

        // Example 4:  loop through all the Student(s)
        foreach (Student objStudent in objStudentCol)
        {
            int studentId = objStudent.StudentId;
            string studentName = objStudent.StudentName;
            string emailId = objStudent.EmailId;
            Int64 contactNo = objStudent.ContactNo;
            string studentPassword = objStudent.StudentPassword;
        }
    }

    /// <summary>
    /// Shows how to Select all records sorted by column name in either ascending or descending order.
    /// </summary>
    private void SelectAllWithSortExpression()
    {
        // select all records sorted by StudentId in ascending order
        string sortBy = "StudentId"; // ascending order
        //string sortBy = "StudentId desc"; // descending order

        List<Student> objStudentCol = Student.SelectAll(sortBy);
    }

    /// <summary>
    /// Shows how to Select a record by Primary Key.  It also shows how to retrieve Lazily-loaded related Objects.  Related Objects are assigned for each Foreign Key.
    /// </summary>
    private void SelectByPrimaryKey()
    {
        int studentIdSample = 12;

        // select a record by primary key(s)

        Student objStudent = Student.SelectByPrimaryKey(studentIdSample);

        if (objStudent != null)
        {
            // if record is found, a record is returned
            int studentId = objStudent.StudentId;
            string studentName = objStudent.StudentName;
            string emailId = objStudent.EmailId;
            Int64 contactNo = objStudent.ContactNo;
            string studentPassword = objStudent.StudentPassword;
        }
    }

    /// <summary>
    /// The example below shows how to Select the StudentId and StudentName columns for use with a with a Drop Down List, Combo Box, Checked Box List, List View, List Box, etc
    /// </summary>
    private void SelectStudentDropDownListData()
    {
        List<Student> objStudentCol = Student.SelectStudentDropDownListData();

        // Example 1:  directly bind to a drop down list - for ASP.NET Web Forms
        // DropDownList ddl1 = new DropDownList();
        // ddl1.DataValueField = "StudentId";
        // ddl1.DataTextField = "StudentName";
        // ddl1.DataSource = objStudentCol;
        // ddl1.DataBind();

        // Example 2:  add each item through a loop - for ASP.NET Web Forms
        // DropDownList ddl2 = new DropDownList();

        // foreach (Student objStudent in objStudentCol)
        // {
        //     ddl2.Items.Add(new ListItem(objStudent.StudentName, objStudent.StudentId.ToString()));
        // }

        // Example 3:  bind to a combo box.  for Windows Forms (WinForms)
        // ComboBox cbx1 = new ComboBox();

        // foreach (Student objStudent in objStudentCol)
        // {
        //     cbx1.Items.Add(new ListItem(objStudent.StudentName, objStudent.StudentId.ToString()));
        // }
    }

    /// <summary>
    /// Shows how to Insert or Create a New Record
    /// </summary>
    private void Insert()
    {
        // first instantiate a new Student
        Student objStudent = new Student();

        // assign values you want inserted
        objStudent.StudentName = "abc";
        objStudent.EmailId = "abc";
        objStudent.ContactNo = 12;
        objStudent.StudentPassword = "abc";

        // finally, insert a new record
        // the insert method returns the newly created primary key
        int newlyCreatedPrimaryKey = objStudent.Insert();
    }

    /// <summary>
    /// Shows how to Update an existing record by Primary Key
    /// </summary>
    private void Update()
    {
        // first instantiate a new Student
        Student objStudent = new Student();

        // assign the existing primary key(s)
        // of the record you want updated
        objStudent.StudentId = 12;

        // assign values you want updated
        objStudent.StudentName = "abc";
        objStudent.EmailId = "abc";
        objStudent.ContactNo = 12;
        objStudent.StudentPassword = "abc";

        // finally, update an existing record
        objStudent.Update();
    }

    /// <summary>
    /// Shows how to Delete an existing record by Primary Key
    /// </summary>
    private void Delete()
    {
        // delete a record by primary key
        Student.Delete(12);
    }

    /// <summary>
    /// Shows how to get the total number of records
    /// </summary>
    private void GetRecordCount()
    {
        // get the total number of records in the Student table
        int totalRecordCount = Student.GetRecordCount();
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
        int? studentId = null;
        string studentName = null;
        string emailId = null;
        Int64? contactNo = null;
        string studentPassword = null;

        int totalRecordCount = Student.GetRecordCountDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword);
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
        string sortBy = "StudentId";
        //string sortBy = "StudentId desc";

        // 1. select a specific number of sorted records starting from the index you specify
        List<Student> objStudentCol = Student.SelectSkipAndTake(numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objStudentCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 2:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 3:  loop through all the Student(s).  The example above will only loop for 10 items.
    }

    /// <summary>
    /// Shows how to get a specific number of sorted records, starting from an index, based on Search Parameters.  The number of records are also retrieved.
    /// </summary>
    private void SelectSkipAndTakeDynamicWhere()
    {
        int startRetrievalFromRecordIndex = 0;
        int numberOfRecordsToRetrieve = 10;
        string sortBy = "StudentId";
        //string sortBy = "StudentId desc";

        // search parameters, everything is nullable, only items being searched for should be filled
        // note: fields with String type uses a LIKE search, everything else uses an exact match
        // also, every field you're searching for uses the AND operator
        // e.g. int? productID = 1; string productName = "ch";
        // will translate to: SELECT....WHERE productID = 1 AND productName LIKE '%ch%'
        int? studentId = null;
        string studentName = null;
        string emailId = null;
        Int64? contactNo = null;
        string studentPassword = null;

        // 1. select a specific number of sorted records starting from the index you specify based on Search Parameters
        List<Student> objStudentCol = Student.SelectSkipAndTakeDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword, numberOfRecordsToRetrieve, startRetrievalFromRecordIndex, sortBy);

        // to use objStudentCol please see the SelectAll() method examples
        // No need for Examples 1 and 2 because the Collection here is already sorted
        // Example 3:  directly bind to a GridView - for ASP.NET Web Forms
        // Example 4:  loop through all the Student(s).  The example above will only loop for 10 items.
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
        int? studentId = null;
        string studentName = null;
        string emailId = null;
        Int64? contactNo = null;
        string studentPassword = null;

        List<Student> objStudentCol = Student.SelectAllDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword);
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
        int? studentId = null;
        string studentName = null;
        string emailId = null;
        Int64? contactNo = null;
        string studentPassword = null;

        string sortBy = "StudentId"; // ascending order
        //string sortBy = "StudentId desc"; // descending order

        List<Student> objStudentCol = Student.SelectAllDynamicWhere(studentId, studentName, emailId, contactNo, studentPassword, sortBy);
    }
}
