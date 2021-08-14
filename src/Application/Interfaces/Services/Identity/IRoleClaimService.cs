﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EshopManager.Application.Interfaces.Common;
using EshopManager.Application.Requests.Identity;
using EshopManager.Application.Responses.Identity;
using EshopManager.Shared.Wrapper;

namespace EshopManager.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}