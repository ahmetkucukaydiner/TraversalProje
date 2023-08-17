using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.Abstract
{
    public interface IGuideDal : IGenericDal<Guide>
    {
        void ChangeToTrueByGuide(int id);
        void ChangeToFalseByGuide(int id);
    }
}
