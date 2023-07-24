using System.Linq.Expressions;

namespace Traversal.Business.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        List<T> TGetList(Expression<Func<T, bool>> filter = null);
        T TGetByID(int id);
    }
}
