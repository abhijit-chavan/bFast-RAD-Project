using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fourth_tempDBAPI.Models.Base
{
     /// <summary>
     /// Base class for RoleMasterModel.  Do not make changes to this class,
     /// instead, put additional code in the RoleMasterModel class 
     /// </summary>
     public class RoleMasterModelBase
     {
         /// <summary> 
         /// Gets or Sets RoleId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Role Id")]
         public int RoleId { get; set; } 

         /// <summary> 
         /// Gets or Sets RoleDescription 
         /// </summary> 
         [StringLength(25, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Role Description")]
         public string RoleDescription { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedOn 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "Created On")]
         public DateTime CreatedOn { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedBy 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Created By")]
         public string CreatedBy { get; set; } 

         /// <summary> 
         /// Gets or Sets ModifiedOn 
         /// </summary> 
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "Modified On")]
         public DateTime? ModifiedOn { get; set; } 

         /// <summary> 
         /// Gets or Sets ModifiedBy 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Modified By")]
         public string ModifiedBy { get; set; } 

     }
}
