using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.Abstract
{
    public interface IContactUsDal : IGenericDal<ContactUs>
    {
        List<ContactUs> GetListContactUsByTrue();
        List<ContactUs> GetListContactUsByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
