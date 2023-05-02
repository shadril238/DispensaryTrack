using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Customer
    {
        [Required, Key]
        public int Cid { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(11)]
        public string Phone { get; set; }
        public double Balance { get; set; }
        [Required]
        public string Gender { get; set; }
        public string Status { get; set; }
        [Required, StringLength(200)]
        public string Address { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }

        public Customer()
        {
            this.Balance = 0;
            Bills = new List<Bill>();
        }
    }
}