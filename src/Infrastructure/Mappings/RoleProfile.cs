using AutoMapper;
using EshopManager.Infrastructure.Models.Identity;
using EshopManager.Application.Responses.Identity;

namespace EshopManager.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}