using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ClientModel
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool is_deleted { get; set; }
        public string Photo { get; set; }
        public string CreatedDate { get; set; }
        public string CNP { get; set; }
        public string Address { get; set; }
        public string BarCode { get; set; }
        public string Notes { get; set; }
    }
}
