using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;
using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToTrueByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = true;
            context.SaveChanges();
        }

        public void ChangeToFalseByGuide(int id)
        {
            var values = context.Guides.Find(id);
            values.Status = false;
            context.SaveChanges();
        }
    }
}
