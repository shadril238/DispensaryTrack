using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class StockMedicineRepo : Repo, IRepo<StockMedicine, int, bool>
    {
        public bool Delete(int id)
        {
            var stock = Get(id);
            db.StockMedicines.Remove(stock);
            return db.SaveChanges() > 0;
        }

        public List<StockMedicine> Get()
        {
            return db.StockMedicines.ToList();
        }

        public StockMedicine Get(int id)
        {
            return db.StockMedicines.Find(id);
        }

        public bool Insert(StockMedicine obj)
        {
            db.StockMedicines.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(StockMedicine obj)
        {
            var exstock = Get(obj.Id);
            db.Entry(exstock).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
