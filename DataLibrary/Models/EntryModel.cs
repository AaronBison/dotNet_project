using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class EntryModel
    {
        public int EntryId { get; set; }
        public string Name { get; set; }
        public int PassId { get; set; }
        public string Date { get; set; }
        public string InsertedBy { get; set; }
        public string BarCode { get; set; }
        public int HallId { get; set; }
    }
}
