//shadril238
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BillDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public double PaidAmt { get; set; }
        [Required]
        public DateTime BillDate { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int OrderId { get; set; }
    }
}
