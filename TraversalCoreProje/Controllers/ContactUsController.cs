using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;
using Traversal.DTOLayer.DTOs.ContactDTOs;
using Traversal.Entities.Concrete;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactUsController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDto sendMessageDto)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs
                {
                    MessageBody = sendMessageDto.MessageBody,
                    Email = sendMessageDto.Email,
                    MessageStatus = true,
                    Name = sendMessageDto.Name,
                    Subject = sendMessageDto.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index", "Default");
            }
            return View(sendMessageDto);
        }
    }
}
