using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CustomerRepo : Repo, IRepo<Customer, int, bool>
    {
        public bool Delete(int id)
        {
            var customer = Get(id);
            db.Customers.Remove(customer);
            return db.SaveChanges() > 0;
        }

        public List<Customer> Get()
        {
            return db.Customers.ToList();
        }

        public Customer Get(int id)
        {
            return db.Customers.Find(id);
        }

        public bool Insert(Customer obj)
        {
            db.Customers.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Customer obj)
        {
            var excustomer = Get(obj.Cid);
            db.Entry(excustomer).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
