using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderApp.Models
{
    public class StoreContext : DbContext
    {
        readonly string connectionString = @"Data source=MADHUMITHA\SQLEXPRESS;Integrated security=true;Initial Catalog=pizza";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<PizzaCrust> pizzaCrusts { get; set; }
        public DbSet<PizzaSize> pizzaSizes { get; set; }
        public DbSet<topping> toppings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 1,
                UserName = "ABCD",
                Password = "1234",
               Address = "SengKang 543308"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                UserId = 2,
                UserName = "ABCD1",
                Password = "12345",
                 Address = "SengKang 543309"
            });
        }
    }
}
