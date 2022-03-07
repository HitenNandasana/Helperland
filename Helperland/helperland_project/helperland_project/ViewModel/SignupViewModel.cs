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
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
/*        [Remote(action: "UserSignup", controller: "Home")]
*/        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile number")]
        public string Phonenumber { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password",ErrorMessage ="password and confirm password do not match")]
        public string Confirmpassword { get; set; }

        public class MustBeTrueAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                return value is bool && (bool)value;
            }
        }
        [MustBeTrue(ErrorMessage = "Please accept Privacy Policy")]
        public bool PrivacyPolicy { get; set; }

    }
}
