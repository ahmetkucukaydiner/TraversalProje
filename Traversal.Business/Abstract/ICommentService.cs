using Traversal.Entities.Concrete;

namespace Traversal.Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
        List<Comment> GetListCommentWithDestination();
    }
}
