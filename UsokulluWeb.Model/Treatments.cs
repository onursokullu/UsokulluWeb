using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Treatments :Base
    {
        public Treatments()
        {
            this.Patient = new HashSet<Patients>();
        }
        public int PatientId { get; set; }
        [Required]
        public int ToothNumber { get; set; }
        [Required]
        public string TreatmentDescription { get; set; }

        //navigation properties
        [ForeignKey("PatientId")]
        public virtual ICollection<Patients> Patient { get; set; }
        
    }
}
