using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class BlogComment : Base
    {
        public int BlogId { get; set; }
        public string NameSur { get; set; }
        public string ComTitle { get; set; }
        public string ComContent { get; set; }

        //navigation properties
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }
    }
}
