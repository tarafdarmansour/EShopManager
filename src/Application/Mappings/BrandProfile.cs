using AutoMapper;
using EshopManager.Application.Features.Brands.Commands.AddEdit;
using EshopManager.Application.Features.Brands.Queries.GetAll;
using EshopManager.Application.Features.Brands.Queries.GetById;
using EshopManager.Domain.Entities.Catalog;

namespace EshopManager.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}