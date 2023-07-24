using System.Linq.Expressions;
using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class FeatureManager : IFeatureService
    {
        private IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature entity)
        {
            _featureDal.Add(entity);
        }

        public void TDelete(Feature entity)
        {
            _featureDal.Delete(entity);
        }

        public void TUpdate(Feature entity)
        {
            _featureDal.Update(entity);
        }

        public List<Feature> TGetList(Expression<Func<Feature, bool>> filter = null)
        {
            return _featureDal.GetList();
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.Get(x => x.Id == id);
        }
    }
}
