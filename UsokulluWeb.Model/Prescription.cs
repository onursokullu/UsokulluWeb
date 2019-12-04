using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Prescription : Base
    {
        public int PatientId { get; set; }
        public string Content { get; set; }
    }
}
