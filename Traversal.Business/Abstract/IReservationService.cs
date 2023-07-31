using Traversal.Entities.Concrete;

namespace Traversal.Business.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListApprovalReservation(int id);
    }
}
