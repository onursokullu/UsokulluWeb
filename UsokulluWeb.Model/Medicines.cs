using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Medicines : Base
    {
        public Medicines()
        {
            this.Prescriptions = new HashSet<Prescription>();
        }
        [Required]
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        public int PrescriptionId { get; set; }
        [Required]
        public string Description { get; set; }

        //navigation properties
        [ForeignKey("PrescriptionId")]
        public virtual ICollection<Prescription> Prescriptions { get; set; }

    }
}
