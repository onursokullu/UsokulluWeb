using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Patients : Base
    {
        public int TcNo { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public int BloodGroupId { get; set; }
        public int PrescriptionId { get; set; }
        public string Gender { get; set; }
        

    }
}
