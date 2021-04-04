using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseEnquiry1API.Models.Base
{
     /// <summary>
     /// Base class for CourseModel.  Do not make changes to this class,
     /// instead, put additional code in the CourseModel class 
     /// </summary>
     public class CourseModelBase
     {
         /// <summary> 
         /// Gets or Sets CourseId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Course Id")]
         public int CourseId { get; set; } 

         /// <summary> 
         /// Gets or Sets CourseName 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Course Name")]
         public string CourseName { get; set; } 

         /// <summary> 
         /// Gets or Sets StartDate 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "Start Date")]
         public DateTime StartDate { get; set; } 

         /// <summary> 
         /// Gets or Sets EndDate 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "End Date")]
         public DateTime EndDate { get; set; } 

         /// <summary> 
         /// Gets or Sets Fees 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"[-+]?[0-9]*\.?[0-9]?[0-9]", ErrorMessage = "{0} must be a valid decimal!")]
         [Display(Name = "Fees")]
         public decimal Fees { get; set; } 

     }
}
