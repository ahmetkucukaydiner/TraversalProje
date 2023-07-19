using System.Linq.Expressions;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;

namespace Traversal.DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Add(T entity)
        {
            using var c = new Context();
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
            using var c = new Context();
            c.Update(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var c = new Context();
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetList(Expression<Func<T, bool>> filter = null)
        {
            using var c = new Context();
            return filter == null
                ? c.Set<T>().ToList()
                : c.Set<T>().Where(filter).ToList();
        }

        public T Get(Expression<Func<T, bool>> filter = null)
        {
            using var c = new Context();
            return c.Set<T>().SingleOrDefault(filter);
        }
    }
}
