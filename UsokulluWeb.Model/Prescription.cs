using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Prescription : Base
    {
        public Prescription()
        {
            this.Medicines = new HashSet<Medicines>();
        }
        public int PatientId { get; set; }
        public int MedicineId { get; set; }
        [Required]
        public string Content { get; set; }

        //navigation properties
        [ForeignKey("PatientId")]
		public virtual Patients Patient {get; set;}
        [ForeignKey("MedicineId")]
        public virtual ICollection<Medicines> Medicines{ get; set; }

    }
}
