using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class BlogCategory : Base
    {
      
        public int BlogId { get; set; }
        public string Name { get; set; }

        //navigation properties
        [ForeignKey("BlogId")]
        public virtual Blog blog { get; set; }

    }
}
