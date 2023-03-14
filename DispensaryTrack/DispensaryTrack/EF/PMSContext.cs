using DispensaryTrack.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DispensaryTrack.EF
{
    public class PMSContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DistributorCompany> Distributors { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set;}
        public DbSet<Rack> Racks { get; set; }

    }
}