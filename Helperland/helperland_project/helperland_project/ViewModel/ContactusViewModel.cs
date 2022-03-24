using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland_project.ViewModel
{
    public class ContactusViewModel
    {
        [Required(ErrorMessage ="Please enter your firstname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your lastname")]
        public string LastName { get; set; }
        
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format")]
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }
        
        public string Subject { get; set; }
        
        [Required(ErrorMessage = "Please enter your phonenumber")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile number")]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        
        [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; }

    }
}
