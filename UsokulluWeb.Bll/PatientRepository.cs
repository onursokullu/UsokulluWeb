using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsokulluWeb.Model;

namespace UsokulluWeb.Bll
{
    public class PatientRepository : BaseRepository<Patients>
    {
        public bool SoftDelete(int id)
        {
            var data = context.Patients.Find(id);
            data.IsDelete = true;
            return base.Update(data);
        }
    }
}
