using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseEnquiry1API.Models.Base
{
     /// <summary>
     /// Base class for CourseEnrollmentModel.  Do not make changes to this class,
     /// instead, put additional code in the CourseEnrollmentModel class 
     /// </summary>
     public class CourseEnrollmentModelBase
     {
         /// <summary> 
         /// Gets or Sets EnrollmentId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Enrollment Id")]
         public int EnrollmentId { get; set; } 

         /// <summary> 
         /// Gets or Sets CourseName 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Display(Name = "Course Name")]
         public int CourseName { get; set; } 

         /// <summary> 
         /// Gets or Sets StudentName 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Display(Name = "Student Name")]
         public int StudentName { get; set; } 

         /// <summary> 
         /// Gets or Sets Comments 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Comments")]
         public string Comments { get; set; } 

     }
}
