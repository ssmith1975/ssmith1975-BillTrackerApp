using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BillTrackerApp.Models;

namespace BillTrackerApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(BillTrackerContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (context.Invoices.Any())
            {
                return;   // DB has been seeded
            }

            var addresses = new Address[]
            {
                new Address {
                    StreetAddress1 = "555 Some Street",
                    City = "Some Place",
                    State = "MO",
                    Country = "US"
                },
                new Address {
                    StreetAddress1 = "777 Some Other Street",
                    City = "Some Other Place",
                    State = "MO",
                    Country = "US"
                }
            };

            var companies = new Company[]
            {
                new Company {
                    AccountNumber = "12345",
                    Name ="ABC", Phone="18001234567",
                    StartDate = Convert.ToDateTime("1/1/2019"),
                    CompanyAddress = addresses[0]
                },
                new Company {
                    AccountNumber = "12346",
                    Name ="DEF",
                    Phone ="18001234568",
                    StartDate = Convert.ToDateTime("1/2/2019") ,
                    CompanyAddress = addresses[1]
                },

            };

            var invoices = new Invoice[]
            {
                new Invoice
                {
                    Company = companies[0],
                    BillingPeriod = Convert.ToDateTime("1/1/2019"),
                    AmountDue = 25.00m,
                    Balance = 0.00m,
                    DueDate = Convert.ToDateTime("1/31/2019"),
                    AmountPaid = 25.00m,
                    DatePaid =  Convert.ToDateTime("1/15/2019"),
                    ConfirmationNumber = "11111",
                    Note = "Paid for the month"
                }

            };

            foreach (Invoice i in invoices)
            {
                context.Invoices.Add(i);
            }
            context.SaveChanges();

  
        }
    }
}
