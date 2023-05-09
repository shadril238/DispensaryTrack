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
        public int Id { get; set; }

        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}