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
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public virtual ICollection<Medicine> Medicines { get; set; }
        public PurchaseMedicine()
        {
            Medicines = new List<Medicine>();
        }
    }
}