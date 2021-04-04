using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnquiryAPI.Models.Base
{
     /// <summary>
     /// Base class for EnquiryModel.  Do not make changes to this class,
     /// instead, put additional code in the EnquiryModel class 
     /// </summary>
     public class EnquiryModelBase
     {
         /// <summary> 
         /// Gets or Sets EnquiryId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Enquiry Id")]
         public int EnquiryId { get; set; } 

         /// <summary> 
         /// Gets or Sets CourseId 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Display(Name = "Course Id")]
         public int CourseId { get; set; } 

         /// <summary> 
         /// Gets or Sets StudentName 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Student Name")]
         public string StudentName { get; set; } 

         /// <summary> 
         /// Gets or Sets ContactNo 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Range(typeof(Int64), "-9223372036854775808", "9223372036854775807", ErrorMessage = "{0} must be an integer!")]
         [Display(Name = "Contact No")]
         public Int64 ContactNo { get; set; } 

         /// <summary> 
         /// Gets or Sets Comments 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Comments")]
         public string Comments { get; set; } 

     }
}
