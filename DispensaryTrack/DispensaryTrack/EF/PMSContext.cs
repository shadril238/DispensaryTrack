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
    }
}