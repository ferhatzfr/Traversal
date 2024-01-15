using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using DTOLayer.DTOs.DestinationDTOs;
using DTOLayer.DTOs.MailDTOs;
using EntityLayer.Concreate;

namespace Traversal.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<AnnouncementAddDtos, Announcement>().ReverseMap();

            CreateMap<AppUserDtos, AppUser>().ReverseMap();

            CreateMap<AppUserLoginDtos, AppUser>().ReverseMap();

            CreateMap<DestinationDtos, Destination>().ReverseMap();

        }
    }
}
