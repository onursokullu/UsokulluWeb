using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class BloodGroups : Base
    {
        public int PatientId { get; set; }
        public string GroupName { get; set; }

        //navigation properties
        [ForeignKey("PatientId")]
        public virtual Patients Patient { get; set; }

    }
}
