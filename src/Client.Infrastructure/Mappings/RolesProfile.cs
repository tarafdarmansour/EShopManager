using AutoMapper;
using EshopManager.Application.Requests.Identity;
using EshopManager.Application.Responses.Identity;

namespace EshopManager.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}