using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland_project.ViewModel
{
    public class LoginViewModel
    {
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        /*[Required]
        [Compare("Password", ErrorMessage = "password and confirm password do not match")]
        public string ConfirmPassword { get; set; }*/

    }
}
