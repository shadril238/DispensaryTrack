//shadril238
using DAL.Interfaces;
using DispensaryTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeRepo : Repo, IRepo<Employee, int, bool>
    {
        public bool Delete(int id)
        {
            var emp = Get(id);
            db.Employees.Remove(emp);
            return db.SaveChanges() > 0;
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public bool Insert(Employee obj)
        {
            db.Employees.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Employee obj)
        {
            var exemp=Get(obj.Id);
            db.Entry(exemp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
