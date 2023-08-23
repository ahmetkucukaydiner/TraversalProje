namespace Traversal.DataAccess.Abstract
{
    public interface IGenericUowDal<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void MultiUpdate(List<T> t);
        T GetByID(int id);
    }
}
