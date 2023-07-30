using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Repository;
using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.Concrete
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
    }
}
