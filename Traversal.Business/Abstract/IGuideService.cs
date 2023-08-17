using Traversal.Entities.Concrete;

namespace Traversal.Business.Abstract
{
    public interface IGuideService : IGenericService<Guide>
    {
        void TChangeToTrueByGuide(int id);
        void TChangeToFalseByGuide(int id);
    }
}
