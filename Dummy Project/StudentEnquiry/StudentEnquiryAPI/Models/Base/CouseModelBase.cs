using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnquiryAPI.Models.Base
{
     /// <summary>
     /// Base class for CouseModel.  Do not make changes to this class,
     /// instead, put additional code in the CouseModel class 
     /// </summary>
     public class CouseModelBase
     {
         /// <summary> 
         /// Gets or Sets Couseid 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "Couseid")]
         public int Couseid { get; set; } 

         /// <summary> 
         /// Gets or Sets CouseName 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [StringLength(50, ErrorMessage = "{0} must be a maximum of {1} characters long!")]
         [Display(Name = "Couse Name")]
         public string CouseName { get; set; } 

         /// <summary> 
         /// Gets or Sets CourseStartDate 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "Course Start Date")]
         public DateTime CourseStartDate { get; set; } 

         /// <summary> 
         /// Gets or Sets CourseEndDate 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [RegularExpression(@"^(((((0[13578])|([13578])|(1[02]))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(3[01])))|((([469])|(11))[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9])|(30)))|((02|2)[\-\/\s]?((0[1-9])|([1-9])|([1-2][0-9]))))[\-\/\s]?\d{4})(\s(((0[1-9])|([1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$", ErrorMessage = "{0} must be a valid date!")]
         [DisplayFormat(DataFormatString = "{0:M/d/yyyy}", ApplyFormatInEditMode = true)]
         [Display(Name = "Course End Date")]
         public DateTime CourseEndDate { get; set; } 

         /// <summary> 
         /// Gets or Sets CouseFees 
         /// </summary> 
         [Required(ErrorMessage = "{0} is required!")]
         [Range(typeof(Int64), "-9223372036854775808", "9223372036854775807", ErrorMessage = "{0} must be an integer!")]
         [Display(Name = "Couse Fees")]
         public Int64 CouseFees { get; set; } 

     }
}
