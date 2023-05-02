using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PurchaseMedicineDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int DistributorId { get; set; }

    }
}
