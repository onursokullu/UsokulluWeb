using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsokulluWeb.Model;

namespace UsokulluWeb.Bll
{
    public class AppointmentRepository : BaseRepository<Appointments>
    {
        public List<Appointments> GetPatientAppointments(int PatientsId)
        {
            return context.Appointment.Where(x=>x.PatientId==PatientsId).ToList();
        }
    }
}
