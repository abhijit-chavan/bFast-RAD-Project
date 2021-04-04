using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseEnquiryAPI.Models.Base
{
     /// <summary>
     /// Base class for AdminModel.  Do not make changes to this class,
     /// instead, put additional code in the AdminModel class 
     /// </summary>
     public class AdminModelBase
     {
         /// <summary> 
         /// Gets or Sets AdminId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Admin Id")]
         public int AdminId { get; set; } 

         /// <summary> 
         /// Gets or Sets AdminName 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Admin Name")]
         public string AdminName { get; set; } 

         /// <summary> 
         /// Gets or Sets AdminPassword 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Admin Password")]
         public string AdminPassword { get; set; } 

     }
}
