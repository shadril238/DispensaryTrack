//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Bill
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public double PaidAmt { get; set; }
        [Required]
        public DateTime BillDate { get; set; }
        [Required, ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Required, ForeignKey("Order")]
        public int OrderId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
    }
}