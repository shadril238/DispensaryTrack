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
    public class MedicineDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GenericName { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
    }
}
