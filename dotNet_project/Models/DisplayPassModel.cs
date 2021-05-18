using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotNet_project.Models
{
    public class DisplayPassModel
    {
        // Data annotations for front-end side data validation
        [Required]
        [StringLength(40, ErrorMessage = "Name is too long.")]
        [MinLength(5, ErrorMessage = "Name is too short.")]
        public string PassName { get; set; }

        [Required]
        public int Price { get; set; }
        public int DaysUntilExpires { get; set; }
        public int EntriesUntilExpires { get; set; }
        public bool is_deleted { get; set; }

        [Required]
        public int HallId { get; set; }
        public string HourFrom { get; set; }
        public string HourUntil { get; set; }
        public int UsablePerDay { get; set; }
    }
}
