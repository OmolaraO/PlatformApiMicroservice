using AutoMapper;
using PlatformSevice.Dtos;
using PlatformSevice.Models;

namespace PlatformSevice.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target
            CreateMap<Platform, PlatformReadDto>().ReverseMap();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
