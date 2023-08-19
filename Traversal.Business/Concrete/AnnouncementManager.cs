using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TAdd(Announcement entity)
        {
            _announcementDal.Add(entity);
        }

        public void TDelete(Announcement entity)
        {
            _announcementDal.Delete(entity);
        }

        public void TUpdate(Announcement entity)
        {
            _announcementDal.Update(entity);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDal.GetList();
        }

        public Announcement TGetByID(int id)
        {
            return _announcementDal.Get(x => x.Id == id);
        }
    }
}
