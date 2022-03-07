using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland_project.ViewModel
{
    public class ContactusViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required]
        public string Email { get; set; }
        
        public string Subject { get; set; }
        
        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile number")]
        public string PhoneNumber { get; set; }
        
        [Required]
        public string Message { get; set; }

    }
}
