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
    internal class BillRepo : Repo, IRepo<Bill, int, bool>
    {
        public bool Delete(int id)
        {
            var bill = Get(id);
            db.Bills.Remove(bill);
            return db.SaveChanges() > 0;
        }

        public List<Bill> Get()
        {
            return db.Bills.ToList();
        }

        public Bill Get(int id)
        {
            return db.Bills.Find(id);
        }

        public bool Insert(Bill obj)
        {
            db.Bills.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Bill obj)
        {
            var exbill = Get(obj.Id);
            db.Entry(exbill).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
