using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsokulluWeb.Model;

namespace UsokulluWeb.Bll
{
    public class BlogCommentRepository : BaseRepository<BlogComment>
    {
        public List<BlogComment> GetByBlogId(int Id)
        {
            return context.Set<BlogComment>().Where(x => x.BlogId == Id).ToList();
        }
    }
}
