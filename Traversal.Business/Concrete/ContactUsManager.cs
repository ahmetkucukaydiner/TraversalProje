using Traversal.Business.Abstract;
using Traversal.DataAccess.Abstract;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        private IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs entity)
        {
            _contactUsDal.Add(entity);
        }

        public void TDelete(ContactUs entity)
        {
            _contactUsDal.Delete(entity);
        }

        public void TUpdate(ContactUs entity)
        {
            _contactUsDal.Update(entity);
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public ContactUs TGetByID(int id)
        {
            return _contactUsDal.Get(x => x.Id == id);
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }
    }
}
