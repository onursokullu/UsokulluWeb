using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class BloodGroups
    {
        public BloodGroups()
        {
            this.Patient = new HashSet<Patients>();
        }
        public int Id { get; set; }
        public string GroupName { get; set; }

        //navigation properties
        [ForeignKey("PatientId")]
        public virtual ICollection<Patients> Patient { get; set; }

    }
}
