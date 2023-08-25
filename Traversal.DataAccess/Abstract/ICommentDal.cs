using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        List<Comment> GetListCommentWithDestination();
        List<Comment> GetListCommentWithDestinationAndUser(int id);
    }
}
