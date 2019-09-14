﻿// <auto-generated />
using System;
using BillTrackerApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BillTrackerApp.Migrations
{
    [DbContext(typeof(BillTrackerContext))]
    partial class BillTrackerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BillTrackerApp.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(200);

                    b.Property<int>("CompanyID");

                    b.Property<string>("Country")
                        .HasMaxLength(50);

                    b.Property<string>("State")
                        .HasMaxLength(50);

                    b.Property<string>("StreetAddress1")
                        .HasMaxLength(500);

                    b.Property<string>("StreetAddress2")
                        .HasMaxLength(500);

                    b.HasKey("AddressID");

                    b.HasIndex("CompanyID")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BillTrackerApp.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<string>("Phone")
                        .HasMaxLength(30);

                    b.Property<DateTime>("StartDate");

                    b.HasKey("CompanyID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("BillTrackerApp.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountDue");

                    b.Property<decimal>("AmountPaid");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime>("BillingPeriod");

                    b.Property<int>("CompanyID");

                    b.Property<string>("ConfirmationNumber")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DatePaid");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("Note");

                    b.HasKey("InvoiceID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("BillTrackerApp.Models.Address", b =>
                {
                    b.HasOne("BillTrackerApp.Models.Company", "Company")
                        .WithOne("CompanyAddress")
                        .HasForeignKey("BillTrackerApp.Models.Address", "CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BillTrackerApp.Models.Invoice", b =>
                {
                    b.HasOne("BillTrackerApp.Models.Company", "Company")
                        .WithMany("Invoices")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
