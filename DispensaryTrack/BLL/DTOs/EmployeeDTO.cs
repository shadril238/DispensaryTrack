//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class EmployeeDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public DateTime JoinDate { get; set; }
        [Required]
        public string EmpType { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public double Salary { get; set; }
    }
}
