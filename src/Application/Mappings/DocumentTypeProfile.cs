using AutoMapper;
using EshopManager.Application.Features.DocumentTypes.Commands.AddEdit;
using EshopManager.Application.Features.DocumentTypes.Queries.GetAll;
using EshopManager.Application.Features.DocumentTypes.Queries.GetById;
using EshopManager.Domain.Entities.Misc;

namespace EshopManager.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}