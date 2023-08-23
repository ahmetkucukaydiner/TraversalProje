namespace Traversal.Business.Abstract.AbstractUow
{
    public interface IGenericUowService<T>
    {
        void TAdd(T t);
        void TUpdate(T t);
        void TMultiUpdate(List<T> t);
        T GetByID(int id);
    }
}
