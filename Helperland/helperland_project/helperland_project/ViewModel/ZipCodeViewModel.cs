using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland_project.ViewModel
{
    public class ZipCodeViewModel
    {
        [Required(ErrorMessage = "Please enter your postalcode")]
        
        [StringLength(6, MinimumLength = 6, ErrorMessage = "Invalid pincode")]
        public string zipcode { get; set; }
    }
}
