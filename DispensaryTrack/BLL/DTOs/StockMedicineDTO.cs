using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StockMedicineDTO
    {
        public int Id { get; set; }
        public string MedicineName { get; set; }
        public string MedicineGenericName { get; set; }
        public string RackName { get; set; }
        public float BuyPrice { get; set; }
        public float SalePrice { get; set; }
        public int TotalStock { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Status { get; set; }
        public int PurchaseId { get; set; }
        public int RackId { get; set; }
        public int DistributorId { get; set; }
        public int MedicineId { get; set; }
    }
}
