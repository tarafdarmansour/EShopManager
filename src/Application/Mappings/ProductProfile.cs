using AutoMapper;
using EshopManager.Application.Features.Products.Commands.AddEdit;
using EshopManager.Domain.Entities.Catalog;

namespace EshopManager.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}