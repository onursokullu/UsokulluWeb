using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Appointments : Base
    {
        public int PatientId { get; set; }
        [Required]
        public DateTime AppointmentDate { get; set; }

        //navigation properties
        [ForeignKey("PatientId")]
        public virtual HashSet<Patients> Patient { get; set; }
    }
}
