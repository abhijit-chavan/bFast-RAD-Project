using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fourth_tempDBAPI.Models.Base
{
     /// <summary>
     /// Base class for UserRolesModel.  Do not make changes to this class,
     /// instead, put additional code in the UserRolesModel class 
     /// </summary>
     public class UserRolesModelBase
     {
         /// <summary> 
         /// Gets or Sets UserRoleId 
         /// </summary> 
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         [Display(Name = "User Role Id")]
         public int UserRoleId { get; set; } 

         /// <summary> 
         /// Gets or Sets UserId 
         /// </summary> 
         [Display(Name = "User Id")]
         public int? UserId { get; set; } 

         /// <summary> 
         /// Gets or Sets RoleId 
         /// </summary> 
         [Display(Name = "Role Id")]
         public int? RoleId { get; set; } 

         /// <summary> 
         /// Gets or Sets Status 
         /// </summary> 
         [Display(Name = "Status")]
         public bool Status { get; set; } 

     }
}
