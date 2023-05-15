//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Medicine
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string GenericName { get; set; }
        [Required]
        public string Status { get; set; }
        [Required, ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<StockMedicine> StockMedicines { get; set; }
        public Medicine()
        {
            StockMedicines = new List<StockMedicine>();
        }
    }
}