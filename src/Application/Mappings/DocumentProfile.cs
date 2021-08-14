using AutoMapper;
using EshopManager.Application.Features.Documents.Commands.AddEdit;
using EshopManager.Application.Features.Documents.Queries.GetById;
using EshopManager.Domain.Entities.Misc;

namespace EshopManager.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}