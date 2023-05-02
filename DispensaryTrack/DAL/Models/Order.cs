//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Order
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public double TotalAmt { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Status { get; set; }
        [Required, ForeignKey("Employee")]
        public string EmpMail { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetail>();
            Bills = new List<Bill>();
        }
    }
}