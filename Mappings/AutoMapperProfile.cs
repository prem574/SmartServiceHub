using AutoMapper;
using SmartServiceHub.DTOs;
using SmartServiceHub.Model;

namespace SmartServiceHub.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {

            CreateMap<UserRegisterDto, User>();
            CreateMap<User, UserResponseDto>();
                }
    }
}
