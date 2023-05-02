using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class DistributorCompanyRepo : Repo, IRepo<DistributorCompany, int, bool>
    {
        public bool Delete(int id)
        {
            var distributorCompany = Get(id);
            db.Distributors.Remove(distributorCompany);
            return db.SaveChanges() > 0;
        }

        public List<DistributorCompany> Get()
        {
            return db.Distributors.ToList();
        }

        public DistributorCompany Get(int id)
        {
            return db.Distributors.Find(id);
        }

        public bool Insert(DistributorCompany obj)
        {
            db.Distributors.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(DistributorCompany obj)
        {
            var exDistributorCompany = Get(obj.Id);
            db.Entry(exDistributorCompany).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
