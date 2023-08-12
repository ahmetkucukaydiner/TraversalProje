using Microsoft.EntityFrameworkCore;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;
using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListCommentWithDestination()
        {
            using(var c = new Context())
            {
                return c.Comments.Include(x=>x.Destination).ToList();
            }
        }
    }
}
