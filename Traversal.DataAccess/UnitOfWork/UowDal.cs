using Traversal.DataAccess.Concrete;

namespace Traversal.DataAccess.UnitOfWork
{
    public class UowDal : IUowDal
    {
        private readonly Context _context;

        public UowDal(Context context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
