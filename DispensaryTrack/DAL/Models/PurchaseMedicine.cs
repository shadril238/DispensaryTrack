//shadril238 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class PurchaseMedicine
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required, ForeignKey("StockMedicine")]
        public int StockMedicineId { get; set; }
        public virtual StockMedicine StockMedicine { get; set; }
    }
}