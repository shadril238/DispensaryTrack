using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CustomerDTO
    {
        [Required]
        public int Cid { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public double Balance { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
