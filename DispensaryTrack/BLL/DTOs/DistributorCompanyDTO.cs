//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DistributorCompanyDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string DistName { get; set; }
        [Required]
        public string CompName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
