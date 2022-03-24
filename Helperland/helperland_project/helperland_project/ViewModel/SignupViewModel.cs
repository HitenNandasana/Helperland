using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
    
namespace helperland_project.ViewModel
{
    
    public class SignupViewModel
    {
        [Required(ErrorMessage = "Please enter your firstname")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter your lastname")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your phonenumber")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile number")]
        [MaxLength(10)]
        public string Phonenumber { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        [RegularExpression(@"^.*(?=.{6,14})(?=.*[a-zA-Z])(?=.*\d)(?=.*[@!#$%&?]).*$", ErrorMessage = "Password must be between 6 and 14 characters and contain one uppercase letter, one lowercase letter, one digit and one special character.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your confirm password")]
        [Compare("Password",ErrorMessage ="password and confirm password do not match")]
        public string Confirmpassword { get; set; }

        public class MustBeTrueAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return value is bool && (bool)value;
            }
        }
        [MustBeTrue(ErrorMessage = "Please accept privacy policy")]
        public bool PrivacyPolicy { get; set; }

    }
}
