using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class InfoClientsPassModel
    {
        public int ClientsPassesId { get; set; }
        public int ClientId { get; set; }
        public int PassId { get; set; }
        public string BuyDate { get; set; }
        public string BarCode { get; set; }
        public int EntriesCount { get; set; }
        public int IsActive { get; set; }
        public int HallId { get; set; }
        public string PassName { get; set; }
        public int DaysUntilExpires { get; set; }
        public int EntriesUntilExpires { get; set; }
        public string HourFrom { get; set; }
        public string HourUntil { get; set; }
        public int UsablePerDay { get; set; }
        public int DaysLeft { get; set; }
        public int EntiresLeft => EntriesUntilExpires - EntriesCount;
    }
}
