using EshopManager.Application.Features.Documents.Commands.AddEdit;
using EshopManager.Application.Features.Documents.Queries.GetAll;
using EshopManager.Application.Requests.Documents;
using EshopManager.Shared.Wrapper;
using System.Threading.Tasks;
using EshopManager.Application.Features.Documents.Queries.GetById;

namespace EshopManager.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}