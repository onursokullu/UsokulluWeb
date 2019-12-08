using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    class Medicines : Base
    {
        [Required]
        public string MedicineName { get; set; }
        public string Dosage { get; set; }
        [Required]
        public string Description { get; set; }
      
    }
}
