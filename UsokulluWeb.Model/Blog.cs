using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsokulluWeb.Model
{
    public class Blog : Base  
    {
        public Blog()
        {
            this.Comment = new HashSet<BlogComment>();
        }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }

        //navigation properties
        [ForeignKey("CategoryId")]
        public virtual BlogCategory Category { get; set; }
        [ForeignKey("UserId")]
        public virtual ICollection<BlogComment> Comment { get; set; }
        //icollection sınıfından bir nesne  yarattığımızda comment daima
        //boş gelecek o yüzden constructor'da bunun yorumlarını yeni bir listeyle dolduruyoruz
    }
}
