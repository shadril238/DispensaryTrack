using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PurchaseReportService
    {
        //Returns Date and Total Purchase
        public static List<PerDayTotalPurchaseDTO> GetPerDayTotalPurchases()
        {
            var purchase = DataAccessFactory.PurchaseMedicineData().Get();
            var data = purchase
                .Where(p => p.Date.Day.Equals(DateTime.Now.Day) && p.Date.Month.Equals(DateTime.Now.Month) && p.Date.Year.Equals(DateTime.Now.Year))
                .GroupBy(p => p.Date.Date)
                .Select(group => new PerDayTotalPurchaseDTO
                {
                    Date = group.Key,
                    TotalPurchase = group.Sum(p => p.TotalPrice)
                }).ToList();

            return data;
        }
        //Returns Daily Total Purchase
        public static double GetPerDayTotalPurchase()
        {
            var purchase = DataAccessFactory.PurchaseMedicineData().Get();
            var data = purchase
                .Where(p => p.Date.Month.Equals(DateTime.Now.Month) && p.Date.Year.Equals(DateTime.Now.Year))
                .GroupBy(p => p.Date.Month)
                .Select(group => new
                {
                    TotalPurchase = group.Sum(p => p.TotalPrice)
                }).ToList();

            return Convert.ToDouble(data);
        }

        //Returns Monthly Total Purchase
        public static double GetPerMonthTotalPurchase()
        {
            var purchase = DataAccessFactory.PurchaseMedicineData().Get();
            var data = purchase
                .Where(p => p.Date.Month.Equals(DateTime.Now.Month) && p.Date.Year.Equals(DateTime.Now.Year))
                .GroupBy(p => p.Date.Month)
                .Select(group => new
                {
                    TotalPurchase = group.Sum(p => p.TotalPrice)
                }).ToList();

            return Convert.ToDouble(data);
        }
    }
}
