using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fourth_tempDBAPI.Models.Base
{
     /// <summary>
     /// Base class for WorkflowMasterModel.  Do not make changes to this class,
     /// instead, put additional code in the WorkflowMasterModel class 
     /// </summary>
     public class WorkflowMasterModelBase
     {
         /// <summary> 
         /// Gets or Sets WorkflowId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Workflow Id")]
         public int WorkflowId { get; set; } 

         /// <summary> 
         /// Gets or Sets WorkflowName 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Workflow Name")]
         public string WorkflowName { get; set; } 

         /// <summary> 
         /// Gets or Sets LevelOfApprovals 
         /// </summary> 
         [Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be an integer!")]
         [Display(Name = "Level Of Approvals")]
         public int? LevelOfApprovals { get; set; } 

         [NotMapped]
         [RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
         [Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
         [Display(Name = "Level Of Approvals")]
         public string LevelOfApprovalsHidden { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedBy 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Created By")]
         public string CreatedBy { get; set; } 

         /// <summary> 
         /// Gets or Sets CreatedOn 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "Created On")]
         public DateTime CreatedOn { get; set; } 

         /// <summary> 
         /// Gets or Sets Updatedby 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Updatedby")]
         public string Updatedby { get; set; } 

         /// <summary> 
         /// Gets or Sets Updatedon 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "Updatedon")]
         public DateTime Updatedon { get; set; } 

     }
}
