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
        public static List<PerDayTotalSaleDTO> GetPerDayTotalSale()
        {
            var bills = DataAccessFactory.BillData().Get();
            var data = bills.GroupBy(b => b.BillDate.Date).Select(group => new PerDayTotalSaleDTO
            {
                Date = group.Key,
                TotalSales = group.Sum(b => b.PaidAmt)
            }).ToList() ;

            return data;
        }
    }
}
