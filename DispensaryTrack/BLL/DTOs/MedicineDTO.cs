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
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string GenericName { get; set; }
        [Required]
        public float BuyPrice { get; set; }
        [Required]
        public float SalePrice { get; set; }
        [Required]
        public int TotalStock { get; set; }
        [Required]
        public DateTime ExpireDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int PurchaseId { get; set; }
        [Required]
        public int RackId { get; set; }
    }
}
