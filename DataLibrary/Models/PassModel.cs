using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class PassModel
    {
        public int PassId { get; set; }
        public string PassName { get; set; }
        public double Price { get; set; }
        public int DaysUntilExpires { get; set; }
        public int EntriesUntilExpires { get; set; }
        public bool is_deleted { get; set; }
        public int HallId { get; set; }
        public string HourFrom { get; set; }
        public string HourUntil { get; set; }
        public int UsablePerDay { get; set; }
    }
}
