using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int CategoriId { get; set; }
        public int CommentId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        //nav properties
        [ForeignKey("CategoriId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<BlogComment> Comment { get; set; }
        //    public Blog()
        //    {
        //        this.Comment = new HashSet<BlogComment>();
        //    }
        //    public int CategoryId { get; set; }
        
        //    public int BlogId { get; set; }
        //    [Required]
       

        //    //navigation properties
        //    [ForeignKey("CategoryId")]
        //    public virtual Category Category { get; set; }
        //    [ForeignKey("BlogId")]
        //    public virtual ICollection<BlogComment> Comment { get; set; }
        //icollection sınıfından bir nesne  yarattığımızda comment daima
        //boş gelecek o yüzden constructor'da bunun yorumlarını yeni bir listeyle dolduruyoruz
    }
}
