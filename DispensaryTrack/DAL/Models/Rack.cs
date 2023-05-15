//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Rack
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Status { get; set; }
        public virtual ICollection<StockMedicine> StockMedicines { get; set; }
        public Rack()
        {
            StockMedicines = new List<StockMedicine>();
        }
    }
}