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
        //Bill
        public static IRepo<Bill, int, bool> BillData()
        {
            return new BillRepo();
        }
        //Category
        public static IRepo<Category, int, bool> CategoryData()
        {
            return new CategoryRepo();
        }
        //Customer
        public static IRepo<Customer, int, bool> CustomerData()
        {
            return new CustomerRepo();
        }
        //Employee
        public static IRepo<Employee, int, bool> EmployeeData()
        {
            return new EmployeeRepo();
        }
        //Medicine
        public static IRepo<Medicine, int , bool> MedicineData()
        {
            return new MedicineRepo();
        }
        //Order
        public static IRepo<Order, int , bool> OrderData()
        {
            return new OrderRepo();
        }
        //OrderDetail
        public static IRepo<OrderDetail, int, bool> OrderDetailData()
        {
            return new OrderDetailRepo();
        }
        //Rack
        public static IRepo<Rack, int, bool> RackData()
        {
            return new RackRepo();
        }


    }
}
