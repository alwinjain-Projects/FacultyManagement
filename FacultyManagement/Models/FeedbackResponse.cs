using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FacultyManagement.Models
{
    public class FeedbackResponse
    {

        [Required(ErrorMessage = "Please enter faculty id")]
        [Key]
        public int fId { get; set; }

        [Required(ErrorMessage = "Please enter faculty name")]
        public String cOrF { get; set; }

        [Required(ErrorMessage = "Please enter faculty name")]
        public String cOrFName { get; set; }

        [Required(ErrorMessage = "Please enter faculty last name")]
        public String fName { get; set; }

        [Required(ErrorMessage = "Please enter faculty last name")]
        public String lName { get; set; }

        [Required(ErrorMessage = "Please enter faculty last name")]
        public String phone { get; set; }


        [Required(ErrorMessage = "Please enter faculty last name")]
        public String gmail { get; set; }


        [Required(ErrorMessage = "Please enter faculty last name")]
        public String feedback { get; set; }

        [Required(ErrorMessage = "Please enter faculty last name")]
        public String Message { get; set; }
    }
}
