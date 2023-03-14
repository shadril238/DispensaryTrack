using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DispensaryTrack.EF.Models
{
    public class PurchaseMedicine
    {
        [Required,Key]
        public int Id { get; set; }
        [Required]
        public double TotalPrice{ get; set;}
        [Required]
        public DateTime Date { get; set; }
        [Required, ForeignKey("DistributorCompany")]
        public int DistributorId { get; set; }

        public virtual ICollection<Medicine> Medicines { get; set; }
        public virtual DistributorCompany DistributorCompany { get; set; }
        public PurchaseMedicine() 
        {
            Medicines = new List<Medicine>();
        }

    }
}