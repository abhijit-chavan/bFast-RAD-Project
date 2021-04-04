using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseEnquiry1API.Models.Base
{
     /// <summary>
     /// Base class for WorkflowStepsMasterModel.  Do not make changes to this class,
     /// instead, put additional code in the WorkflowStepsMasterModel class 
     /// </summary>
     public class WorkflowStepsMasterModelBase
     {
         /// <summary> 
         /// Gets or Sets StepId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Step Id")]
         public int StepId { get; set; } 

         /// <summary> 
         /// Gets or Sets WorKflowId 
         /// </summary> 
         [Display(Name = "Wor Kflow Id")]
         public int? WorKflowId { get; set; } 

         /// <summary> 
         /// Gets or Sets ApprovalLevel 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Approval Level")]
         public string ApprovalLevel { get; set; } 

         /// <summary> 
         /// Gets or Sets Description 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Description")]
         public string Description { get; set; } 

         /// <summary> 
         /// Gets or Sets AutoApprove 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Auto Approve")]
         public string AutoApprove { get; set; } 

         /// <summary> 
         /// Gets or Sets WaitTime 
         /// </summary> 
         [Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be an integer!")]
         [Display(Name = "Wait Time")]
         public int? WaitTime { get; set; } 

         [NotMapped]
         [RegularExpression("([0-9]+)", ErrorMessage = "{0} must be a number!")]
         [Range(typeof(Int32), "-2147483648", "2147483647", ErrorMessage = "{0} must be between {1} and {2}!")]
         [Display(Name = "Wait Time")]
         public string WaitTimeHidden { get; set; } 

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
         /// Gets or Sets UpdatedBy 
         /// </summary> 
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Updated By")]
         public string UpdatedBy { get; set; } 

         /// <summary> 
         /// Gets or Sets UpdatedOn 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "Updated On")]
         public DateTime UpdatedOn { get; set; } 

     }
}
