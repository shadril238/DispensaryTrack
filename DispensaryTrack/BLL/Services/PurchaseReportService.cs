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
        public static List<PerDayTotalPurchaseDTO> GetPerDayTotalPurchase()
        {
            var bills = DataAccessFactory.PurchaseMedicineData().Get();
            var data = bills.GroupBy(b => b.Date.Date).Select(group => new PerDayTotalPurchaseDTO
            {
                Date = group.Key,
                TotalPurchase = group.Sum(b => b.TotalPrice)
            }).ToList();

            return data;
        }
    }
}
