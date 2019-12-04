using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class PrescriptionMedicines : Base
    { 
        public int MedicineId { get; set; }
        public int PrescriptionId { get; set; }
        public int Quantity { get; set; }
    }
}
