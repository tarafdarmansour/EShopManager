﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EshopManager.Application.Features.DocumentTypes.Commands.AddEdit;
using EshopManager.Application.Features.DocumentTypes.Queries.GetAll;
using EshopManager.Shared.Wrapper;

namespace EshopManager.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}