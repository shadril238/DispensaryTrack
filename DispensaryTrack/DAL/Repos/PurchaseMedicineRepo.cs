using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PurchaseMedicineRepo : Repo, IRepo<PurchaseMedicine, int, bool>
    {
        public bool Delete(int id)
        {
            var purchasemedicine = Get(id);
            db.PurchaseMedicines.Remove(purchasemedicine);
            return db.SaveChanges() > 0;
        }

        public List<PurchaseMedicine> Get()
        {
            return db.PurchaseMedicines.ToList();
        }

        public PurchaseMedicine Get(int id)
        {
            return db.PurchaseMedicines.Find(id);
        }

        public bool Insert(PurchaseMedicine obj)
        {
            db.PurchaseMedicines.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(PurchaseMedicine obj)
        {
            var exPurchaseMedicine = Get(obj.Id);
            db.Entry(exPurchaseMedicine).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
