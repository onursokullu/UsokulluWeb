using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Patients : Base
    {
        public Patients()
        {
            this.Prescription = new HashSet<Prescription>();
            this.Treatment = new HashSet<Treatments>();
            this.Appointment = new HashSet<Appointments>();
        }
        [Required]
        public int TcNo { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Address { get; set; }
        public int BloodGroupId { get; set; }
        public int PrescriptionId { get; set; }
        public int TreatmentId { get; set; }
        public int AppointmentId { get; set; }
        [Required]
        public string Gender { get; set; }

        //navigation properties
        [ForeignKey("BloodGroupId")]
        public virtual BloodGroups BloodGroup { get; set; }
       // [ForeignKey("PrescriptionId")]
        public virtual ICollection<Prescription> Prescription { get; set; }
        [ForeignKey("TreatmentId")]
        public virtual ICollection<Treatments> Treatment { get; set; }
        [ForeignKey("AppointmentId")]
        public virtual ICollection<Appointments> Appointment { get; set; }


    }
}
