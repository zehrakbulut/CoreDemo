using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        void IGenericDal<T>.Delete(T t)
        {
            using var c = new Context();
            c.Remove(t);
            c.SaveChanges();
        }

        T IGenericDal<T>.GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        List<T> IGenericDal<T>.GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        void IGenericDal<T>.Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        void IGenericDal<T>.Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
