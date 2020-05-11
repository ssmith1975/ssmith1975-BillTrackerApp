using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BillTrackerApp.API.Models
{
    public class Invoice
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InvoiceID { get; set; }
        public DateTime BillingPeriod { get; set; }


        public DateTime DueDate { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public DateTime DatePaid { get; set; }
        public decimal AmountDue { get; set; }
        [MaxLength(100)]
        public string ConfirmationNumber { get; set; }
        public string Note { get; set; }

        public Company Company { get; set; }
        public int CompanyID { get; set; }
        
    }
}
