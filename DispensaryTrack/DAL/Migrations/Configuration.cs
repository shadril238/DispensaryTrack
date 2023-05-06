namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.DispensaryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.DispensaryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            //shadril238
            //Employees Table
            /*
            Random rand = new Random();
            for(int i = 0; i < 12; i++)
            {
                context.Employees.AddOrUpdate(new Models.Employee
                {
                    Email = Guid.NewGuid().ToString().Substring(0, 3),
                    Name = Guid.NewGuid().ToString().Substring(1,5),
                    Phone = "0175"+rand.Next(5734765, 9999999).ToString(),
                    Password = Guid.NewGuid().ToString().Substring(i, 4),
                    JoinDate= DateTime.Now,
                    EmpType= "Salesman",
                    Address= Guid.NewGuid().ToString().Substring(0,5),
                    Status="Full-time",
                    Salary= rand.Next(15000, 45001)
                });
            }
            */

            //Customers Table
            /*
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                context.Customers.AddOrUpdate(new Models.Customer
                {
                    Name = "Customer-" + i,
                    Email= "customer"+i+"@xyz.com",
                    Phone= "0175" + rand.Next(5734765, 9999999).ToString(),
                    Gender="Male",
                    Status="General",
                    Address=Guid.NewGuid().ToString().Substring(0,5)
                });
            }
            */
        }
    }
}
