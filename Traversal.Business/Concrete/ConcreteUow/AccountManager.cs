using Traversal.Business.Abstract.AbstractUow;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.UnitOfWork;
using Traversal.Entities.Concrete;

namespace Traversal.Business.Concrete.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUowDal _uowDal;

        public AccountManager(IAccountDal accountDal, IUowDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public void TAdd(Account t)
        {
            _accountDal.Add(t);
            _uowDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public Account GetByID(int id)
        {
            return _accountDal.GetByID(id);
        }
    }
}
