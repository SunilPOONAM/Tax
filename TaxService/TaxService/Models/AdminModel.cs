using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaxService.Models
{
    public class AdminModel
    {

        public long UserID { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }


        [Required]
        public string Password { get; set; }

        public long RoleId { get; set; }

        public string Role { get; set; }


        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }



        public AdminModel() { }

        public AdminModel(User user)
        {
            UserID = user.UserID;
           
            Username = user.Username;
           
        }

        public User GetNewUser()
        {
            return new User
            {
                Username = Username,
                Password=Password,
                RoleId=2
            };
        }

       

       



    }

    public class ChangePasswordModel
    {
        public long UserID { get; set; }

        public string Password { get; set; }

        [DataType(DataType.Password)]        
        [Compare("Password", ErrorMessage = "Invalid old password")]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }


        [DataType(DataType.Password)]
        [Required]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        [Display(Name = "Confirm New Password")]
        public string ConfirmPassword { get; set; }

        public ChangePasswordModel() { }
        public ChangePasswordModel(User user)
        {
            UserID = user.UserID;
            Password = user.Password;
        }

       

    }
}