using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;

namespace Traversal.DataAccess.Repository
{
    public class GenericUowRepository<T> : IGenericUowDal<T> where T : class
    {
        private readonly Context _context;

        public GenericUowRepository(Context context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
