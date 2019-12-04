using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Treatments :Base
    {
        public int UserId { get; set; }
        public int PatientId { get; set; }
        public int ToothNumber { get; set; }
        public string TreatmentDescription { get; set; }

    }
}
