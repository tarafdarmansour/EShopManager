using AutoMapper;
using EshopManager.Infrastructure.Models.Audit;
using EshopManager.Application.Responses.Audit;

namespace EshopManager.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}