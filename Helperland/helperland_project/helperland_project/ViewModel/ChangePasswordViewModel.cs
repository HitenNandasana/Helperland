﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland_project.ViewModel
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage ="Please enter your password")]
        [RegularExpression(@"^.*(?=.{6,14})(?=.*[a-zA-Z])(?=.*\d)(?=.*[@!#$%&?]).*$", ErrorMessage = "Password must be between 6 and 14 characters and contain one uppercase letter, one lowercase letter, one digit and one special character.")]
        public string cPassword { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("cPassword", ErrorMessage = "Password and confirm password do not match")]
        public string confirmPass { get; set; }

    }
}
