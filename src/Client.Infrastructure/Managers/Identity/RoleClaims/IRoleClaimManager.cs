using System.Collections.Generic;
using System.Threading.Tasks;
using EshopManager.Application.Requests.Identity;
using EshopManager.Application.Responses.Identity;
using EshopManager.Shared.Wrapper;

namespace EshopManager.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}