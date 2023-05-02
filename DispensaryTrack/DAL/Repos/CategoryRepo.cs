using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CategoryRepo : Repo, IRepo<Category, int, bool>
    {
        public bool Delete(int id)
        {
            var cate = Get(id);
            db.Categories.Remove(cate);
            return db.SaveChanges() > 0;
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public bool Insert(Category obj)
        {
            db.Categories.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Category obj)
        {
            var excate = Get(obj.Id);
            db.Entry(excate).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
