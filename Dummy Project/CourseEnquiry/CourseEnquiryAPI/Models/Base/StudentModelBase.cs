using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseEnquiryAPI.Models.Base
{
     /// <summary>
     /// Base class for StudentModel.  Do not make changes to this class,
     /// instead, put additional code in the StudentModel class 
     /// </summary>
     public class StudentModelBase
     {
         /// <summary> 
         /// Gets or Sets StudentId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Student Id")]
         public int StudentId { get; set; } 

         /// <summary> 
         /// Gets or Sets StudentName 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Student Name")]
         public string StudentName { get; set; } 

         /// <summary> 
         /// Gets or Sets EmailId 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Email Id")]
         public string EmailId { get; set; } 

         /// <summary> 
         /// Gets or Sets ContactNo 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Range(typeof(Int64), "-9223372036854775808", "9223372036854775807", ErrorMessage = "{0} must be an integer!")]
         [Display(Name = "Contact No")]
         public Int64 ContactNo { get; set; } 

         /// <summary> 
         /// Gets or Sets StudentPassword 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Student Password")]
         public string StudentPassword { get; set; } 

     }
}
