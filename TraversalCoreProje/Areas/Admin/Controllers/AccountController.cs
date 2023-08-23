using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract.AbstractUow;
using Traversal.Entities.Concrete;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AccountViewModel accountViewModel)
        {
            var valueSender = _accountService.GetByID(accountViewModel.SenderID);
            var valueReceiver = _accountService.GetByID(accountViewModel.ReceiverID);

            valueSender.Balance -= accountViewModel.Amount;
            valueReceiver.Balance += accountViewModel.Amount;

            List<Account> modifiedAccounts = new()
            {
                valueSender,
                valueReceiver
            };

            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }
}
