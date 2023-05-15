//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class OrderDetail
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required, ForeignKey("Order")]
        public int OrderId { get; set; }
        [Required, ForeignKey("StockMedicine")]
        public int StockId { get; set; }

        public virtual Order Order { get; set; }
        public virtual StockMedicine StockMedicine { get; set; }

    }
}