using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusBookingApp.Models
{
    public class BusContext : DbContext
    {
        public BusContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<BusDetail> BusDetails { get; set; }

        public DbSet<BusStopDetail> BusStopDetails { get; set; }

        public DbSet<BookingDetail> BookingDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer()
                {
                    CustId = 1,
                    FirstName = "Madhumitha",
                    LastName = "Srinivasan",
                    Age = 25,
                    Gender = "Female",
                    Address1 = "West masi street",
                    Address2 = "Madurai junction",
                    city = "Madurai",
                    Pincode = 600001,
                    email = "rpadmavathiin@gmail.com",
                    phone = "900000000",
                    UserName = "madhu",
                    Password = "1234"

                }
                );
        }
    }
}
