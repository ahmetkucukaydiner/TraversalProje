using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Traversal.Entities.Concrete;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    public class PasswordChangeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public PasswordChangeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
        {
            var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Email);
            string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var passwordResetTokenLink = Url.Action("ResetPassword", "PasswordChange",new
            {
               userID = user.Id,
               token = passwordResetToken
            }, HttpContext.Request.Scheme);

            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "projelerleyazilim@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", forgetPasswordViewModel.Email);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = passwordResetTokenLink;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Şifre Değişiklik Talebi";

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("projelerleyazilim@gmail.com", "mrfutgtosroysvub");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string userID, string token)
        {
            TempData["userID"] = userID;
            TempData["token"] = token;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            var userID = TempData["userID"];
            var token = TempData["token"];

            if(userID == null || token == null) 
            {
                //hata mesajı
            }
            var user = await _userManager.FindByIdAsync(userID.ToString());
            var result = await _userManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password);

            if(result.Succeeded) 
            {
                return RedirectToAction("SignIn", "Login");
            }

            return View();
        }
    }
}
