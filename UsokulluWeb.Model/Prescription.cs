using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Prescription : Base
    {
        public int PatientId { get; set; }
        [Required]
        public string Content { get; set; }
    }
}
