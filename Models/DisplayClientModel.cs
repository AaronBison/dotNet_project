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
        [StringLength(40, ErrorMessage = "Name is too long.")]
        [MinLength(5, ErrorMessage = "Name is too short.")]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public string CreatedDate { get; set; }

        [Required]
        [StringLength(13, ErrorMessage = "CNP is too long.")]
        [MinLength(13, ErrorMessage = "CNP is too short.")]
        public string CNP { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "Address is too long.")]
        [MinLength(3, ErrorMessage = "Address is too short.")]
        public string Address { get; set; }
        public string BarCode { get; set; }
        public string Notes { get; set; }
    }
}
