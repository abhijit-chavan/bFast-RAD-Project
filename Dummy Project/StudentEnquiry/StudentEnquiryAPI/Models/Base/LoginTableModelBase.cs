using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnquiryAPI.Models.Base
{
     /// <summary>
     /// Base class for LoginTableModel.  Do not make changes to this class,
     /// instead, put additional code in the LoginTableModel class 
     /// </summary>
     public class LoginTableModelBase
     {
         /// <summary> 
         /// Gets or Sets Adminid 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Adminid")]
         public int Adminid { get; set; } 

         /// <summary> 
         /// Gets or Sets Password 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Password")]
         public string Password { get; set; } 

     }
}
