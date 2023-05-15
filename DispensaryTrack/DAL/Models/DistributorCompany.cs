//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class DistributorCompany
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string DistName { get; set; }
        [Required, StringLength(100)]
        public string CompName { get; set; }
        [Required, StringLength(11)]
        public string Phone { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(200)]
        public string Address { get; set; }
        [Required]
        public string Status { get; set; }

        public virtual ICollection<StockMedicine> StockMedicines { get; set; }

        public DistributorCompany()
        {
            StockMedicines = new List<StockMedicine>();
        }
    }
}