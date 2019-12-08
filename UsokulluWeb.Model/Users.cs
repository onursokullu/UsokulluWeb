using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Users:Base
    {
        [DataType(DataType.EmailAddress)]
        public string UserEmail { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
    }
}
