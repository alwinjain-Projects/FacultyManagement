using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FacultyManagement.Models
{
    public class FacultyResponse
    {
        [Required(ErrorMessage = "Please enter faculty id")]
        [Key]
        public int fId { get; set; }

        [Required(ErrorMessage = "Please enter faculty name")]
        public String fName { get; set; }

        [Required(ErrorMessage = "Please enter faculty last name")]
        public String fLastName { get; set; }


    }
}
