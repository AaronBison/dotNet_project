using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class ClientsPassesModel
    {
        public int ClientsPassesId { get; set; }
        public int ClientId { get; set; }
        public int PassId { get; set; }
        public string BuyDate { get; set; }
        public string BarCode { get; set; }
        public int EntriesCount { get; set; }
        public int BuyPrice { get; set; }
        public int IsActive { get; set; }
        public string FirstUsageDate { get; set; }
        public int HallId { get; set; }
    }
}
