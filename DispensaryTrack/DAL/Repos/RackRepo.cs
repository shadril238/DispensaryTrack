using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class RackRepo : Repo, IRepo<Rack, int, bool>
    {
        public bool Delete(int id)
        {
            var rack = Get(id);
            db.Racks.Remove(rack);
            return db.SaveChanges() > 0;
        }

        public List<Rack> Get()
        {
            return db.Racks.ToList();
        }

        public Rack Get(int id)
        {
            return db.Racks.Find(id);
        }

        public bool Insert(Rack obj)
        {
            db.Racks.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Rack obj)
        {
            var exrack = Get(obj.Id);
            db.Entry(exrack).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
