//shadril238
using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    //Inheritance [Parent : StockMedicineService, Child : AlertService]
    public class AlertService : StockMedicineService
    {
        //Expired StockMedicine Alert
        public static List<StockMedicineDTO> ExpireMedicineAlert()
        {
            //linq joining
            var stockmedicine = Get();
            var data = stockmedicine
                .Where(sm => sm.ExpireDate.AddDays(-5) >= DateTime.Now && sm.Status.Equals("Active")).ToList();
            return data.ToList();
        }
        //Stock Alert
        public static List<StockMedicineDTO> StockMedicineAlert()
        {
            var medicine = Get();
            var data = medicine
                .Where(m => m.TotalStock < 100).ToList();
            return data.ToList();
        }
    }
}
