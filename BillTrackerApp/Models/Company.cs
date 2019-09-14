using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BillTrackerApp.Models
{
    public class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyID { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string AccountNumber { get; set; }

        [MaxLength(30)]
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
        public Address CompanyAddress { get; set; }
        //public int AddressID { get; set; }
    }
}
