using helperland_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace helperland_project.ViewModel
{
    public class AdminViewModel
    {
        public List<User> users { get; set; }
        public List<AdminServiceRequestViewModel> adminServiceRequests { get; set; }

        [Required(ErrorMessage ="Please select date")]
        public string c_ser_date { get; set; }

        [Required(ErrorMessage = "Please select time")]
        public string c_ser_time { get; set; }

        [Required(ErrorMessage = "Please enter your street number")]
        public string c_street { get; set; }

        [Required(ErrorMessage = "Please enter your house number")]
        public string c_hno { get; set; }

        [Required(ErrorMessage = "Please enter your postalcode")]
        public string c_postal { get; set; }

        [Required(ErrorMessage = "Please enter your city")]
        public string c_city { get; set; }

        public int hidden_ser_id { get; set; }
        public int hidden_u_id { get; set; }
    }
}
