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
    internal class OrderDetailRepo : Repo, IRepo<OrderDetail, int, bool>
    {
        public bool Delete(int id)
        {
            var orderdetail = Get(id);
            db.OrderDetails.Remove(orderdetail);    
            return db.SaveChanges() > 0;
        }

        public List<OrderDetail> Get()
        {
            return db.OrderDetails.ToList();
        }

        public OrderDetail Get(int id)
        {
            return db.OrderDetails.Find(id);
        }

        public bool Insert(OrderDetail obj)
        {
            db.OrderDetails.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(OrderDetail obj)
        {
            var exorderdetails = Get(obj.Id);
            db.Entry(exorderdetails).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
