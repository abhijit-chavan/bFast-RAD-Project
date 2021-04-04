using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseEnquiry1API.Models.Base
{
     /// <summary>
     /// Base class for StudentModel.  Do not make changes to this class,
     /// instead, put additional code in the StudentModel class 
     /// </summary>
     public class StudentModelBase
     {
         /// <summary> 
         /// Gets or Sets StudenId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Studen Id")]
         public int StudenId { get; set; } 

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
         /// Gets or Sets ContactNumber 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be an integer!")]
         [Display(Name = "Contact Number")]
         public int ContactNumber { get; set; } 

         /// <summary> 
         /// Gets or Sets Password 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Password")]
         public string Password { get; set; } 

     }
}
