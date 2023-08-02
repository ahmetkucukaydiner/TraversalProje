using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class GuideManager : IGuideService
    {
        private IGuideDal _guideDal;

        public GuideManager(IGuideDal guideDal)
        {
            _guideDal = guideDal;
        }

        public void TAdd(Guide entity)
        {
            _guideDal.Add(entity);
        }

        public void TDelete(Guide entity)
        {
            _guideDal.Delete(entity);
        }

        public void TUpdate(Guide entity)
        {
            _guideDal.Update(entity);
        }

        public List<Guide> TGetList()
        {
            return _guideDal.GetList();
        }

        public Guide TGetByID(int id)
        {
            return _guideDal.Get(x => x.Id == id);
        }
    }
}
