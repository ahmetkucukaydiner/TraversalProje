using Traversal.Entities.Concrete;

namespace Traversal.Business.Abstract
{
    public interface IDestinationService : IGenericService<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);
    }
}
