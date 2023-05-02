using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DAL.Models
{
    public class Category
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(200)]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
        public Category()
        {
            Medicines = new List<Medicine>();
        }
    }
}