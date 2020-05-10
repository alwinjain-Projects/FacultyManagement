using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FacultyManagement.Models
{
    public class CourseResponse
    {
        [Required(ErrorMessage = "Please enter course id")]
        public int cId { get; set; }

        [Required(ErrorMessage = "Please enter course name")]

        public String cName { get; set; }

        [Required(ErrorMessage = "Please enter course credit")]
        public double cCredit { get; set; }

    }
}
