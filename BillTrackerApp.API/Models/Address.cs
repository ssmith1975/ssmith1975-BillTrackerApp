using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillTrackerApp.API.Models
{
    public class Address
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressID { get; set; }
        // public int CompanyID { get; set; }
        [MaxLength(500)]
        public string StreetAddress1 { get; set; }
        [MaxLength(500)]
        public string StreetAddress2 { get; set; }
        [MaxLength(200)]
        public string City { get; set; }
        [MaxLength(50)]
        public string State { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        [MaxLength(15)]
        public string Zip { get; set; }
        public Company Company { get; set; }
    
        public int CompanyID { get; set; }

    }

}