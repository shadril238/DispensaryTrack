//shadril238
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class OrderRepo : Repo, IRepo<Order, int, bool>
    {
        public bool Delete(int id)
        {
            var order = Get(id);
            db.Orders.Remove(order);
            return db.SaveChanges() > 0;
        }

        public List<Order> Get()
        {
            return db.Orders.ToList();
        }

        public Order Get(int id)
        {
            return db.Orders.Find(id);
        }

        public bool Insert(Order obj)
        {
            db.Orders.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Order obj)
        {
            var exorder = Get(obj.Id);
            db.Entry(exorder).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
