using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland_project.ViewModel
{
    public class spMyDetailViewModel
    {

        [Required(ErrorMessage ="Please enter your firstname")]
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
        public string phone { get; set; }


        [Required(ErrorMessage = "Please enter your street name")]
        public string street { get; set; }

        [Required(ErrorMessage = "Please enter your house number")]
        [Range(1, int.MaxValue, ErrorMessage = "Invaild house number")]
        public int house { get; set; }

        [Required(ErrorMessage = "Please enter your postalcode")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Invalid postalcode")]
        public string postal { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string city { get; set; }
    }
}
