using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class BlogComment : Base
    {
        public int BlogId { get; set; }
        [Required]
        public string NameSur { get; set; }
        [Required]
        public string ComTitle { get; set; }
        [Required]
        public string ComContent { get; set; }

        //navigation properties
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }
    }
}
