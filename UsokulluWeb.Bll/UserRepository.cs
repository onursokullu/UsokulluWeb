using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsokulluWeb.Model;

namespace UsokulluWeb.Bll
{
    public class UserRepository : BaseRepository<Users>
    {
        public Users Login(string email, string password)
        {
            return context.Set<Users>().Where(x => x.UserEmail == email && x.Password ==password).FirstOrDefault();
        }
    }
}
