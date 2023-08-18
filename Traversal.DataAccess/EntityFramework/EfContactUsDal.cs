using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.Concrete;
using Traversal.DataAccess.Repository;
using Traversal.Entities.Concrete;

namespace Traversal.DataAccess.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
            }
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using (var context = new Context())
            {
                var values = context.ContactUses.Where(x => x.MessageStatus == false).ToList();
                return values;
            }
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }
    }
}
