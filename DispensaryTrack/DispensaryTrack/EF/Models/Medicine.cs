using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DispensaryTrack.EF.Models
{
    public class Medicine
    {
        [Required,Key]
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [Required,StringLength(100)]
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
        [Required, ForeignKey("Category")]
        public int CategoryId { get; set; }
        [Required, ForeignKey("DistributorCompany")]
        public int DistId { get; set; }
        [Required, ForeignKey("Rack")]
        public int RackId { get; set; }
        //[Required, ForeignKey("Employee")]
        //public int EmpId { get; set; }

        public virtual Rack Rack { get; set; }
        //public virtual Employee Employee { get; set; }
        public virtual DistributorCompany DistributorCompany { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public Medicine()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}