using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseEnquiryAPI.Models.Base
{
     /// <summary>
     /// Base class for CourseEnrollmentInfoModel.  Do not make changes to this class,
     /// instead, put additional code in the CourseEnrollmentInfoModel class 
     /// </summary>
     public class CourseEnrollmentInfoModelBase
     {
         /// <summary> 
         /// Gets or Sets EnrollmentId 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Display(Name = "Enrollment Id")]
         public int EnrollmentId { get; set; } 

         /// <summary> 
         /// Gets or Sets CourseId 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Display(Name = "Course Id")]
         public int CourseId { get; set; } 

         /// <summary> 
         /// Gets or Sets StudentId 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Display(Name = "Student Id")]
         public int StudentId { get; set; } 

         /// <summary> 
         /// Gets or Sets Comments 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Comments")]
         public string Comments { get; set; } 

     }
}
