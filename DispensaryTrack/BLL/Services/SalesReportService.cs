using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SalesReportService
    {
        //Returns Date and Total Sale
        public static List<PerDayTotalSaleDTO> GetPerDayTotalSales()
        {
            var bills = DataAccessFactory.BillData().Get();
            var data = bills.GroupBy(b => b.BillDate.Date).Select(group => new PerDayTotalSaleDTO
            {
                Date = group.Key,
                TotalSales = group.Sum(b => b.PaidAmt)
            }).ToList() ;

            return data;
        }
        //Retuens Daliy Total Sale
        public static double GetPerDayTotalSale()
        {
            var bills = DataAccessFactory.BillData().Get();
            var data = bills
                .Where(b => b.BillDate.Day.Equals(DateTime.Now.Day) && b.BillDate.Month.Equals(DateTime.Now.Month) && b.BillDate.Year.Equals(DateTime.Now.Year))
                .GroupBy(b => b.BillDate.Month).Select(group => new
                {
                    TotalSales = group.Sum(b => b.PaidAmt)
                }).ToList();

            return Convert.ToDouble(data);
        }

        //Returns Monthly Total Sale
        public static double GetPerMonthTotalSale()
        {
            var bills = DataAccessFactory.BillData().Get();
            var data = bills
                .Where(b => b.BillDate.Month.Equals(DateTime.Now.Month) && b.BillDate.Year.Equals(DateTime.Now.Year))
                .GroupBy(b => b.BillDate.Month).Select(group => new
                {
                    TotalSales = group.Sum(b => b.PaidAmt)
                }).ToList();

            return Convert.ToDouble(data);
        }
    }
}
