using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet_project.Models
{
    public class DisplayClientModel
    {
        // Data annotations for front-end side data validation
        [Required]
        [StringLength(20, ErrorMessage = "First Name is too long.")]
        [MinLength(5, ErrorMessage = "First Name is too short.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Last Name is too long.")]
        [MinLength(5, ErrorMessage = "Last Name is too short.")]
        public string LastName { get; set; } 
    }
}
