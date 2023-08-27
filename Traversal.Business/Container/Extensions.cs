﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Traversal.Business.Abstract;
using Traversal.Business.Abstract.AbstractUow;
using Traversal.Business.Concrete;
using Traversal.Business.Concrete.ConcreteUow;
using Traversal.Business.ValidationRules.AnnouncementValidationRules;
using Traversal.Business.ValidationRules.ContactUsValidationRules;
using Traversal.DataAccess.Abstract;
using Traversal.DataAccess.EntityFramework;
using Traversal.DataAccess.UnitOfWork;
using Traversal.DTOLayer.DTOs.AnnouncementDTOs;
using Traversal.DTOLayer.DTOs.ContactDTOs;

namespace Traversal.Business.Container
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsDal, EfContactUsDal>();
            services.AddScoped<IContactUsService, ContactUsManager>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IUowDal, UowDal>();
        }

        public static void CustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementValidator>();
            services.AddTransient<IValidator<SendMessageDto>, SendContactUsValidator>();
        }
    }
}
