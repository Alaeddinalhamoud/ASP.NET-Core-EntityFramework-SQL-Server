using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_EF.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        [DisplayName("GenderName")]
        [Required(ErrorMessage = "Gender Name is Required.")]
         public string GenderName { get; set; }

    }
}
