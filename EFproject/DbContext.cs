
using EFproject;
using Microsoft.EntityFrameworkCore;

namespace DbContext
    {
    
        public class ECommerceDbContext : Microsoft.EntityFrameworkCore.DbContext
        {
            public DbSet<Car> Cars { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Sale> Sales { get; set; }

           
            protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-1BO408E\\SQLEXPRESS; Database=ECommerceDb; Integrated Security = True; ");
            }

                
         }
  }