using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        private ISubAboutDal _subAboutDal;

        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }

        public void TAdd(SubAbout entity)
        {
            _subAboutDal.Add(entity);
        }

        public void TDelete(SubAbout entity)
        {
            _subAboutDal.Delete(entity);
        }

        public void TUpdate(SubAbout entity)
        {
            _subAboutDal.Update(entity);
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public SubAbout TGetByID(int id)
        {
            return _subAboutDal.Get(x => x.Id == id);
        }
    }
}
