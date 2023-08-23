using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;
using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfAccountDal : GenericUowRepository<Account>, IAccountDal
    {
        public EfAccountDal(Context context) : base(context)
        {

        }
    }
}
