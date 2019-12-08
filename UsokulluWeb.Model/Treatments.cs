using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Treatments :Base
    {
        public int UserId { get; set; }
        public int PatientId { get; set; }
        [Required]
        public int ToothNumber { get; set; }
        [Required]
        public string TreatmentDescription { get; set; }

    }
}
