using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MedicineDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GenericName { get; set; }
        public float BuyPrice { get; set; }
        public float SalePrice { get; set; }
        public int TotalStock { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
        public int PurchaseId { get; set; }
        public int RackId { get; set; }
        public int DistributorId { get; set; }
    }
}