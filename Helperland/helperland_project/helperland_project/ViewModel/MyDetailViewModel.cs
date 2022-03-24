using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland_project.ViewModel
{
    public class MyDetailViewModel
    {
        [Required(ErrorMessage ="Please enter your street name")]
        public string street { get; set; }

        [Required(ErrorMessage = "Please enter your house number")]
        [Range(1, int.MaxValue, ErrorMessage = "Invaild house number")]
        public int hno { get; set; }

        [Required(ErrorMessage = "Please enter your phonenumber")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile number")]
        [MaxLength(10)]
        public string phone { get; set; }

        [Required(ErrorMessage = "Please enter your pincode")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Invalid pincode")]
        public string pincode { get; set; }

        [Required(ErrorMessage = "Please enter your city name")]
        public string city { get; set; }
    }
}
