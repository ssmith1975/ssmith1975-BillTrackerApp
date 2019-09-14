using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BillTrackerApp.Models;
using  Microsoft.EntityFrameworkCore;

namespace BillTrackerApp.Data
{
    public class BillTrackerContext:DbContext
    {
        public BillTrackerContext(DbContextOptions<BillTrackerContext> options):base(options)
        {}
        public DbSet<Company> Companies { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<Invoice>().ToTable("Invoice");

        }

    }
}
