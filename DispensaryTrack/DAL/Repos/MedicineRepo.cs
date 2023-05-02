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
    internal class MedicineRepo : Repo, IRepo<Medicine, int, bool>
    {
        public bool Delete(int id)
        {
            var med = Get(id);
            db.Medicines.Remove(med);
            return db.SaveChanges() > 0;
        }

        public List<Medicine> Get()
        {
            return db.Medicines.ToList();
        }

        public Medicine Get(int id)
        {
            return db.Medicines.Find(id);
        }

        public bool Insert(Medicine obj)
        {
            db.Medicines.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Medicine obj)
        {
            var exmed = Get(obj.Id);
            db.Entry(exmed).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
