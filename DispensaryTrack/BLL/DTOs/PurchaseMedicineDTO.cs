//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PurchaseMedicineDTO : MedicineDTO
    {
        public int PurId { get; set; }
    
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public int DistributorId { get; set; }

    }
}
