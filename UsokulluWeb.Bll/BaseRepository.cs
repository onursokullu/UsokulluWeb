using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UsokulluWeb.Dal.Entity;

namespace UsokulluWeb.Bll
{
    public class BaseRepository<T> where T : class, new()
    {
        protected readonly UsokulluContext context = new UsokulluContext();
        public bool Add(T data)
        {   //ctrl+k+s kısayoluyla try catch ekleyebiliyorsun
            try
            {
                context.Set<T>().Add(data);

                return context.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool Delete(int id)
        {
            try
            {
                T deletedData = context.Set<T>().Find(id);
                context.Set<T>().Remove(deletedData);
                return context.SaveChanges() > 0 ? true : false;

            }
            catch (Exception)
            {

                return true;
            }
        }
        public bool SoftDelete(T data)
        {
            try
            {
                //olmadı
                context.Entry<T>(data).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges() > 0 ? true : false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<T> GetAll()
        {

            //using (context=new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {

            //using (context = new Context())
            {
                return context.Set<T>().Find(id);
            }
        }

        public bool Update(T data)
        {
            //using (context = new Context())
            {
                context.Entry<T>(data).State = EntityState.Modified;
                int result = context.SaveChanges();
                //ternary if
                return result > 0 ? true : false;
            }
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            //using (context=new Context())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }
    }
}
