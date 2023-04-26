//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DispensaryTrack.Models
{
    public class Employee
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; }
        [Required, StringLength(11)]
        public string Phone { get; set; }
        [Required, StringLength(25)]
        public string Password { get; set; }
        [Required]
        public DateTime JoinDate { get; set; }
        [Required]
        public string EmpType { get; set; }
        [Required, StringLength(200)]
        public string Address { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public double Salary { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        //public virtual ICollection<Medicine> Medicines { get; set; }

        public Employee()
        {
            Orders = new List<Order>();
            //Medicines = new List<Medicine>();
        }
    }
}