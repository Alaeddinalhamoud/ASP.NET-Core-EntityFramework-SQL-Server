using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
         [DisplayName("Course Name")]
         [Required(ErrorMessage = "Course Name is Required.")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Credits is Required.")]
        public string Credits { get; set; }

    }
}
