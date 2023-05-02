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
    internal class EmployeeRepo : Repo, IRepo<Employee, string, bool>, IAuth<bool>
    {
        public bool Authenticate(string email, string password)
        {
            var data = db.Employees.FirstOrDefault(e=>e.Email.Equals(email) && e.Password.Equals(password));
            return data != null;
        }

        public bool Delete(string email)
        {
            var emp = Get(email);
            db.Employees.Remove(emp);
            return db.SaveChanges() > 0;
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(string email)
        {
            return db.Employees.Find(email);
        }

        public bool Insert(Employee obj)
        {
            db.Employees.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Employee obj)
        {
            var exemp=Get(obj.Email);
            db.Entry(exemp).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
