using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class StockMedicine
    {
        [Key]
        public int Id { get; set; }
        [Required, ForeignKey("Medicine")]
        public int MedicineId { get; set; }
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
        
        //[Required, ForeignKey("PurchaseMedicine")]
        //public int PurchaseId { get; set; }
        [Required, ForeignKey("Rack")]
        public int RackId { get; set; }
        [Required, ForeignKey("DistributorCompany")]
        public int DistributorId { get; set; }

        public virtual Rack Rack { get; set; }
        //public virtual PurchaseMedicine PurchaseMedicine { get; set; }
        public virtual DistributorCompany DistributorCompany { get; set; }
        public virtual Medicine Medicine { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        
        public StockMedicine()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}
