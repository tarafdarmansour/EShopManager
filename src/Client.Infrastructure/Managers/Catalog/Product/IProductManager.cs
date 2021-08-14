﻿using EshopManager.Application.Features.Products.Commands.AddEdit;
using EshopManager.Application.Features.Products.Queries.GetAllPaged;
using EshopManager.Application.Requests.Catalog;
using EshopManager.Shared.Wrapper;
using System.Threading.Tasks;

namespace EshopManager.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}