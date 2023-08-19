﻿using AutoMapper;
using Traversal.DTOLayer.DTOs.AnnouncementDTOs;
using Traversal.DTOLayer.DTOs.AppUserDTOs;
using Traversal.Entities.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>();
            CreateMap<Announcement, AnnouncementAddDto>();

            CreateMap<AppUserRegisterDto, AppUser>();
            CreateMap<AppUser, AppUserRegisterDto>();

            CreateMap<AppUserLoginDto, AppUser>();
            CreateMap<AppUser, AppUserLoginDto>();
        }
    }
}
