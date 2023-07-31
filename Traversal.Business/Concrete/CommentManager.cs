using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public void TDelete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public void TUpdate(Comment entity)
        {
            _commentDal.Update(entity);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.Get(x => x.Id == id);
        }

        public List<Comment> TGetDestinationById(int id)
        {
            return _commentDal.GetList(x => x.DestinationId == id);
        }
    }
}
