using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3EVB481;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent Mapping
            //modelBuilder.HasDefaultSchema("admin");
            modelBuilder.Entity<Employee>().ToTable("Employees");

            modelBuilder.Entity<Employee>().Property(p => p.ID).HasColumnName("EmployeeID");
            modelBuilder.Entity<Employee>().Property(p => p.FirstName).HasColumnName("FirstName");
            modelBuilder.Entity<Employee>().Property(p => p.LastName).HasColumnName("LastName");
        }
    }
}
