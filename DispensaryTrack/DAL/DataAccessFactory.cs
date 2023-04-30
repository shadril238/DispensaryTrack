//shadril238
using DAL.Interfaces;
using DAL.Repos;
using DispensaryTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Bill, int, bool> BillData()
        {
            return new BillRepo();
        }
        public static IRepo<Category, int, bool> CategoryData()
        {
            return new CategoryRepo();
        }
        public static IRepo<Customer, int, bool> CustomerData()
        {
            return new CustomerRepo();
        }
        public static IRepo<Employee, int, bool> EmployeeData()
        {
            return new EmployeeRepo();
        }
        public static IRepo<Medicine, int , bool> MedicineData()
        {
            return new MedicineRepo();
        }
        public static IRepo<Order, int , bool> OrderData()
        {
            return new OrderRepo();
        }
        public static IRepo<OrderDetail, int, bool> OrderDetailData()
        {
            return new OrderDetailRepo();
        }


    }
}
