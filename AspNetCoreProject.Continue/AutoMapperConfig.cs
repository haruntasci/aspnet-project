using AspNetCoreProject.Continue.Entities;
using AspNetCoreProject.Continue.Models;
using AutoMapper;

namespace AspNetCoreProject.Continue
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<User, CreateUserModel>().ReverseMap();
            CreateMap<User, EditUserModel>().ReverseMap();
        }
    }
}
